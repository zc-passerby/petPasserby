# 设计思路
## 目录

- [口袋精灵](#口袋精灵)
  - [管理员开关](#管理员开关)  
  - [获取精灵](#获取精灵)
  - [查询精灵资料](#查询精灵资料)
    - 查询自己精灵资料
    - 查询别人精灵资料
  - [](#)

### 口袋精灵
    口袋精灵（群聊版）（注：包含QQ号的指令都支持直接艾特【例如：赠送宠物@落宇飞尘】）
#### 管理员开关
    发送：开启/关闭口袋精灵【例如：关闭口袋精灵】（默认开启）
#### 获取精灵
    发送：进入精灵世界 属性 [昵称]
    属性：金、木、水、火、土
    默认昵称：精灵宝宝
#### 查询精灵资料
##### 查询自己精灵资料
    发送：我的精灵
##### 查询别人精灵资料
    发送：精灵侦查 QQ号 【例如：宠物侦查 766887280】
#### 赠送精灵
    发送：赠送精灵 QQ号 【例如：赠送精灵 766887280】

超级宠物（注：包含QQ号的指令都支持直接艾特【例如：赠送宠物@天空科技】）

管理开关超级宠物-------发送：开启/关闭超级宠物【例如：关闭超级宠物】（默认开启）  

随机砸蛋获得宠物----------------发送：砸蛋  
查询自己宠物资料----------------发送：我的宠物  
把宠物赠送给别人----------------发送：赠送宠物 QQ号　　【例如：赠送宠物 653064237】  
把宠物放生-------------------------发送：放生宠物  

查询别人宠物资料----------------发送：宠物侦查 QQ号　　【例如：宠物侦查 653064237】  
攻击别人的宠物------------------发送：宠物攻击 QQ号　　【例如：宠物攻击 653064237】  

修改宠物的昵称------------------发送：宠物改名 昵称　　【例如：宠物改名 豆豆】（需消耗-改名卡）  
修改宠物的性别------------------发送：宠物变性（需消耗-变性药水）  
复活死亡的宠物------------------发送：宠物复活（需消耗-九转还魂丹）  

宠物求婚------------------------发送：宠物求婚 QQ号　　【例如：宠物求婚 653064237】（需消耗-永恒钻戒）  
同意求婚------------------------发送：同意求婚 QQ号　　【例如：同意求婚 653064237】  
宠物离婚------------------------发送：宠物离婚  

查询宠物副本--------------------发送：宠物副本  
进入副本刷怪--------------------发送：进入副本 副本名称【例如：进入副本 神陨星域】  

升级宠物------------------------发送：宠物升级  
宠物进化------------------------发送：宠物进化  
注：宠物等级达到60级后就能进化，进化后的攻击和防御都会翻倍，所以等级越高，基础的攻击防御值就越高，120级是最佳进化等级！(进化后等级变成1级，身上的神器和秘技会自动脱落到背包内)  
宠物觉醒------------------------发送：宠物觉醒（超究极体满级后才能觉醒天赋）  
制作天赋符----------------------发送：制作天赋符（将已经觉醒的天赋制作成天赋符，使用者可觉醒对应天赋）  
提炼仙丹------------------------发送：提炼仙丹（觉醒天赋【绝影丹心】后可提炼仙丹,随机生成某种仙丹,需消耗20万经验和积分，50精力）  
使用仙丹------------------------发送：使用仙丹 仙丹名 QQ号【例如：使用仙丹 镇魂丹 653064237】  

查看本群宠物战力排行------------发送：宠物战力排行  
查所有群宠物战力排行------------发送：宠物神榜  
神榜强者领取奖励----------------发送：领取神榜奖励  

查看出售宠物--------------------发送：宠物市场（可买到心仪的宠物）  
查看神器商城--------------------发送：神器商城（可买到前50级神器）  
查看宠物商城--------------------发送：宠物商城（可买到道具和材料）  

购买宠物------------------------发送：购买宠物 宠物名称 宠物级别【例如：购买宠物 青龙 传说】  
购买神器------------------------发送：购买神器 神器名称【例如：购买神器 荒芜神鼎】  
购买物品------------------------发送：购买 物品名 数量 【例如：购买 变性药水 1】  

查看自己的背包------------------发送：我的背包  
清空自己的背包------------------发送：清空背包  

某物品详细说明------------------发送：宠物说明 物品名称【例如：宠物说明 九转还魂丹】  
查询某些信息--------------------发送：宠物种类/属性/神器/秘技/仙丹/天赋【例如：宠物神器】  

使用物品------------------------发送：使用 物品名 数量 【例如：使用 红药水 1】  
出售物品------------------------发送：出售 物品名 数量 【例如：出售 红药水 10】  
丢弃物品------------------------发送：丢弃 物品名 数量 【例如：丢弃 红药水 10】  
转让物品------------------------发送：转让物品 QQ号 物品名 数量【例如：转让物品 563403286 变性药水 1】  

打造神器------------------------发送：打造神器 神器名称【例如：打造神器 九天玄琴】（需要神器图纸、材料、积分）  
锻造神器------------------------发送：锻造神器 神器名称【例如：锻造神器 九天玄琴】（镶嵌对应神器精魄锻造无级别神器）  
佩戴神器------------------------发送：佩戴神器 神器名称【例如：佩戴神器 九天玄琴】（对等级有要求）  
卸下神器------------------------发送：卸下神器  
参悟秘技------------------------发送：参悟秘技 秘技名称【例如：参悟秘技 五雷震天诀】（对等级和智力有要求）  
宠物活动------------------------发送：修炼/双修/打工/闭关/学习/玩耍/洗髓/探险【例如：修炼】  

=======================================================  

活动说明：  
修炼：获得经验  
双修：获得经验翻倍（需结婚才行）  
打工：获得积分  
闭关：恢复血量  
学习：增加智力  
玩耍：增加心情  
洗髓：降低智力转化为攻击或者防御（随机值）  
探险：随机事件（可获得秘技、神器图纸、材料、道具等）  

=======================================================  

砸蛋说明：每人每日可砸蛋3次，2次砸蛋间隔1小时！  
精力说明：宠物执行某些操作时会消耗一定的精力，每分钟会自动恢复1点精力！  
等级说明：满级120！升级会随机增加基础属性值【智力、生命、攻击、防御】，等级达到60级后可进化，进化后（攻击、防御）值翻倍，经验归0，等级重置为1级  
进化阶段：幼年期=》成长期=》成熟期=》完全体=》究极体=》超究极体  
天赋说明：超究极体满级后可尝试觉醒天赋，觉醒天赋的宠物会获得额外的天赋能力  
关于战力：宠物战力 = 攻击 \* 3 + (智力+防御) * 2 + (生命*心情) + 武器加成 + 秘技加成  
宠物级别：普通<精品<稀有<神级<传说<史诗（级别越高升级时所提升的基础属性值越多，史诗级别需联系客服定制）  
属性作用：属性克制在PK时会额外提升50%的战力【金-木-水-火-土-金】【风-雷-冰-风】【光-暗-光】  

=======================================================  

天赋归类（超究极体满级后可觉醒随机天赋）  

【绝影丹心】觉醒此天赋的宠物可提炼出各种各样的仙丹  
【妙手摘星】觉醒此天赋的宠物成功击杀对方宠物时有40%的概率偷到对方背包内某随机物品  
【神隐遁术】觉醒此天赋的宠物被比自己战力高宠物的攻击时，有一半的概率逃脱  
【不死之体】觉醒此天赋的宠物永远不会死亡  
【天火御甲】觉醒此天赋的宠物战斗时会提高30%的防御力，免疫所有负面效果，任何负面效果仙丹对此天赋无效  
【狂暴怒火】觉醒此天赋的宠物战斗时会额外提升30%的攻击力  
【蝶逆轮回】觉醒此天赋的宠物满血状态下与比自己战力高的宠物战斗时有30%概率触发此天赋，自身剩余一滴血，秒杀敌方  
【七星化海】觉醒此天赋的宠物战斗结束后会额外增加10%-30%的经验  
【鸿运当头】觉醒此天赋的宠物探险时100%有所收货  

天赋觉醒要求：等级120级，超究极体　　指令：宠物觉醒（扣除100万经验，100W积分，100精力）  
制作天赋符：制作天赋符（本身有的天赋可以制作成天赋符送给他人，制作之后天赋消失得到天赋符需要扣除50万积分，50万经验，50精力）  
宠物只能觉醒一种天赋，若天赋已存在继续觉醒则自动替换当前天赋！！！  
使用天赋符每次需要扣除10万积分，10万经验，50精力  

=======================================================  

仙丹归类（觉醒天赋【绝影丹心】后可提炼仙丹）  

镇魂丹：对宠物使用后，会镇压宠物灵魂，使其进入假死状态，4小时内无法操作宠物  
惊魂丹：对宠物使用后，使其灵魂受到惊吓，2小时内无法操作宠物  
破厄丹：对宠物使用后，能解除各种限制和异常，使宠物恢复正常状态  
死亡丹：对宠物使用后，使其立即死亡，心情变成1颗星，血量变成0  
神力丹：对宠物使用后，增加500点攻击力  
金刚丹：对宠物使用后，增加500点防御力  
万寿丹：对宠物使用后，增加1万点生命上限  
聚灵丹：对宠物使用后，增加10万经验  
忘尘丹：对宠物使用后，使其遗忘秘技  
清虚丹：对宠物使用后，生命上限减少1万  
破武丹：对宠物使用后，减少500攻击力  
破防丹：对宠物使用后，减少500防御力  

=======================================================  

宠物飞升------------------------发送：宠物飞升（消耗100点精力、200万经验、200万积分）  
注：飞升之后等级最高可以升级到220级，战力转化为仙力（1仙力=1000战力）  

宠物神仙劫（飞升以上任务）------发送：宠物神仙劫（可查看当前神仙劫可挑战神仙）  

幻境寻宝（飞升以上任务）--------发送：幻境寻宝  

查看可以领取宠物剧情任务--------发送：宠物剧情任务  
查看自己的任务进度--------------发送：我的剧情任务  
取消当前的剧情任务--------------发送：取消剧情任务