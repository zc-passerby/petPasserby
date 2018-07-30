﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using QQLite.Framework.SDK;

namespace petPasserby
{
    /// <summary>
    /// 配置文件参数枚举
    /// </summary>
    public enum enumConfigList
    {
        // 命令语列表
        CommandDic_openPokemonFunc,
        CommandDic_closePokemonFunc,
        CommandDic_queryPokemonInfo,
        // 回复语列表
        LanguageDic_openPokemonFuncSuccess,
        LanguageDic_openPokemonFuncFailure,
        LanguageDic_closePokemonFuncSuccess,
        LanguageDic_closePokemonFuncFailure,
        LanguageDic_queryPokemonInfoSuccess,
        LanguageDic_queryPokemonInfoFailure,
    };
    /// <summary>
    /// 命令配置详情
    /// </summary>
    public class CommandDetail
    {
        /// <summary>
        /// 命令（多个命令以|分隔，如：开|开1|开2）
        /// </summary>
        public string Command { get; set; }
        /// <summary>
        /// 会话(好友1 临时会话2 群4 讨论组8)[四位二进制]
        /// </summary>
        public int DoIM { get; set; }
        /// <summary>
        /// 权限(好友、群成员1 群管理员2 群主4 软件管理员8 负责人QQ32)[六位二进制]
        /// </summary>
        public int Role { get; set; }
    }

    /// <summary>
    /// 命令配置字典
    /// </summary>
    public class CommandDictionary
    {
        /// <summary>
        /// 开启宝可梦功能
        /// </summary>
        public CommandDetail openPokemonFunc { get; set; }
        /// <summary>
        /// 关闭宝可梦功能
        /// </summary>
        public CommandDetail closePokemonFunc { get; set; }
        /// <summary>
        /// 查询宝可梦信息
        /// </summary>
        public CommandDetail queryPokemonInfo { get; set; }
    }

    public class LanguageDictionary
    {
        /// <summary>
        /// 开启宝可梦功能成功回复语
        /// </summary>
        public string openPokemonFuncSuccess { get; set; }
        /// <summary>
        /// 开启宝可梦功能失败回复语
        /// </summary>
        public string openPokemonFuncFailure { get; set; }
        /// <summary>
        /// 关闭宝可梦功能成功回复语
        /// </summary>
        public string closePokemonFuncSuccess { get; set; }
        /// <summary>
        /// 关闭宝可梦功能失败回复语
        /// </summary>
        public string closePokemonFuncFailure { get; set; }
        /// <summary>
        /// 查询宝可梦信息成功回复语
        /// </summary>
        public string queryPokemonInfoSuccess { get; set; }
        /// <summary>
        /// 查询宝可梦信息失败回复语
        /// </summary>
        public string queryPokemonInfoFailure { get; set; }
    }

    /// <summary>
    /// 插件配置类
    /// </summary>
    public class petPasserbyConfig : PluginConfig
    {
        public CommandDictionary CommandDic { get; set; }
        public LanguageDictionary LanguageDic { get; set; }
    }
}
