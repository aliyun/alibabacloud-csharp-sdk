// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class CloudCreateTaskRequest : TeaModel {
        /// <summary>
        /// <para>外呼组号；callGroupType=2时必填。注：一个外呼组可以绑定到多个任务，但只能同时运行一个任务中</para>
        /// 
        /// <b>Example:</b>
        /// <para>33</para>
        /// </summary>
        [NameInMap("AgentGroup")]
        [Validation(Required=false)]
        public string AgentGroup { get; set; }

        /// <summary>
        /// <para>座席超时时间；单位秒数，默认10秒，取值范围5 ~ 60</para>
        /// 
        /// <b>Example:</b>
        /// <para>52</para>
        /// </summary>
        [NameInMap("AgentTimeout")]
        [Validation(Required=false)]
        public long? AgentTimeout { get; set; }

        /// <summary>
        /// <para>初始化预计客户接通率；默认50，取值范围1～100，预热阶段的呼叫，按照此接通率计算呼叫频率</para>
        /// 
        /// <b>Example:</b>
        /// <para>59</para>
        /// </summary>
        [NameInMap("AnswerRate")]
        [Validation(Required=false)]
        public long? AnswerRate { get; set; }

        /// <summary>
        /// <para>0.关闭 1.开启，默认开启。开启：任务中的号码呼叫完后，任务自动完成，状态设置为结束，关闭：任务中的号码呼叫完后，任务自动暂停，状态设置为暂停注：任务在结束状态时无法再次启动。</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("AutoComplete")]
        [Validation(Required=false)]
        public long? AutoComplete { get; set; }

        /// <summary>
        /// <para>0.关闭 1.自动删除。任务数超出最大任务数限制时，是否自动删除已完成的最早创建的任务，值为1代表自动删除。注：autoDelete不是任务属性，只在接口调用时生效</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("AutoDelete")]
        [Validation(Required=false)]
        public long? AutoDelete { get; set; }

        /// <summary>
        /// <para>定时开始；0.关闭 1.开启，默认关闭。值为1时autoStartDay和autoStartTime参数才生效，并且至少设置其中的一个</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("AutoStart")]
        [Validation(Required=false)]
        public long? AutoStart { get; set; }

        /// <summary>
        /// <para>定时开始日期；autoStart=1时生效。参数不传入时默认在当天的autoStartTime定时启动。格式：yyyy-MM-dd，如：2017-01-01</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-01-01</para>
        /// </summary>
        [NameInMap("AutoStartDay")]
        [Validation(Required=false)]
        public string AutoStartDay { get; set; }

        /// <summary>
        /// <para>定时开始时间；autoStart=1时生效。参数不传入时默认在autoStartDay的00:00:00定时启动。格式：HH:mm:ss，如：08:00:00</para>
        /// 
        /// <b>Example:</b>
        /// <para>08:00:00</para>
        /// </summary>
        [NameInMap("AutoStartTime")]
        [Validation(Required=false)]
        public string AutoStartTime { get; set; }

        /// <summary>
        /// <para>定时完成；0.关闭 1.开启，默认关闭。值为1时autoStopDay和autoStopTime参数才生效，并且至少设置其中的一个</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("AutoStop")]
        [Validation(Required=false)]
        public long? AutoStop { get; set; }

        /// <summary>
        /// <para>定时完成日期；autoStop=1时生效。参数不传入时默认在当天的autoStopTime定时完成。格式：yyyy-MM-dd，如：2017-01-01</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-01-01</para>
        /// </summary>
        [NameInMap("AutoStopDay")]
        [Validation(Required=false)]
        public string AutoStopDay { get; set; }

        /// <summary>
        /// <para>定时完成时间；autoStop=1时生效。参数不传入时默认在autoStopDay的23:59:59定时完成。格式：HH:mm:ss，如：17:00:00</para>
        /// 
        /// <b>Example:</b>
        /// <para>17:00:00</para>
        /// </summary>
        [NameInMap("AutoStopTime")]
        [Validation(Required=false)]
        public string AutoStopTime { get; set; }

        /// <summary>
        /// <para>0.连续呼叫 1.间隔呼叫，默认连续呼叫。配合定时开始（autoStart）和定时结束（autoStop）参数使用，如任务需要在每天的特定时间段内呼叫则开启间隔呼叫方式</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("AutoTaskType")]
        [Validation(Required=false)]
        public long? AutoTaskType { get; set; }

        /// <summary>
        /// <para>间隔呼叫时间段；autoTaskType=1时必填。呼叫的时间段配置。参数格式：时间条件编号。支持多个，多个使用英文&quot;,&quot;逗号隔开，如：9,22。注：时间条件列表可通过查询时间条件设置列表接口获取</para>
        /// 
        /// <b>Example:</b>
        /// <para>9,22</para>
        /// </summary>
        [NameInMap("AutoTriggerTimeStrategy")]
        [Validation(Required=false)]
        public string AutoTriggerTimeStrategy { get; set; }

        /// <summary>
        /// <para>指定座席方式；1.座席工号列表 2.外呼组，默认座席工号列表注：任务创建后不支持修改</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CallGroupType")]
        [Validation(Required=false)]
        public long? CallGroupType { get; set; }

        /// <summary>
        /// <para>座席当日接听的通话个数上限，使用方式详见下方说明；JsonArray格式 [{&quot;cnos&quot;:[&quot;2000&quot;,&quot;2001&quot;],&quot;limit&quot;:&quot;5&quot;}注：使用座席当日接听数限制功能需开启企业配置，功能开启并且配置上限后系统才开始统计当日接听数</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;cnos&quot;:[&quot;2000&quot;,&quot;2001&quot;],&quot;limit&quot;:&quot;5&quot;}]</para>
        /// </summary>
        [NameInMap("CallLimitStrategy")]
        [Validation(Required=false)]
        public string CallLimitStrategy { get; set; }

        /// <summary>
        /// <para>数据结构为Json格式<c>{&quot;strategy&quot;:[{&quot;sort&quot;:1,&quot;type&quot;:&quot;retryCall&quot;, &quot;desc&quot;:0},{&quot;sort&quot;:2,&quot;type&quot;:&quot;firstCall&quot;,&quot;orderType&quot;:0}]}</c>格式说明：sort是重试号码和未呼叫号码的呼叫顺序 type：retryCall重试号码、firstCall未呼叫号码当type=retryCall，desc：0.优先呼叫待重呼轮次数值较小的号码，即轮次靠前（如第1轮、第2轮）的号码先被呼叫 1.优先呼叫待重呼轮次数值较大的号码，即轮次靠后（如第5轮、第4轮）的号码先被呼叫当type=firstCall时，orderType：随机呼叫，0顺序(优先级) 1随机 2顺序(导入时间)</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("CallPriorityStrategy")]
        [Validation(Required=false)]
        public string CallPriorityStrategy { get; set; }

        /// <summary>
        /// <para>1.直连座席 2.AI转人工 直连座席模式：客户接听后直接分配座席，无空闲座席可溢出语音导航（需配置语音导航），保障高优先级客户直连体验 AI转人工：客户接入后，优先进入语音导航中配置的智能体机器人，按交互结果决定是否转接座席，提升自动化覆盖率，降低人工成本</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CallRouteStrategy")]
        [Validation(Required=false)]
        public long? CallRouteStrategy { get; set; }

        /// <summary>
        /// <para>座席分配规则；1.随机 2.顺序 3.座席未进线最大时（从上一次呼叫结束到当前的总时长） 4.座席状态[空闲]最长时长（座席最近一次切换为空闲状态的持续时长），默认随机</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CallStrategy")]
        [Validation(Required=false)]
        public string CallStrategy { get; set; }

        /// <summary>
        /// <para>座席通道变量。JsonArray格式；最大支持5个变量。默认空值， 示例：[{&quot;name&quot;:&quot;abcdefg&quot;,&quot;value&quot;:&quot;${cdr_enterprise_id}&quot;}] 注：单个字段值的长度不能超过1000个字符。变量会以SIP_HEADER的形式设置到座席侧通道</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;name&quot;:&quot;abcdefg&quot;,&quot;value&quot;:&quot;${cdr_enterprise_id}&quot;}]</para>
        /// </summary>
        [NameInMap("CallVariables")]
        [Validation(Required=false)]
        public string CallVariables { get; set; }

        /// <summary>
        /// <para>外显规则；customerClidType=2时生效。Json格式，外显号码选择规则：默认区号，是否匹配省会等；如：{&quot;defaultAreaCode&quot;:&quot;010&quot;, &quot;isMatchCapital&quot;:&quot;1&quot;}。不建议使用</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;defaultAreaCode&quot;:&quot;010&quot;, &quot;isMatchCapital&quot;:&quot;1&quot;}</para>
        /// </summary>
        [NameInMap("ClidProperty")]
        [Validation(Required=false)]
        public string ClidProperty { get; set; }

        /// <summary>
        /// <para>座席工号列表；callGroupType=1时必填。支持多个座席工号，多个之间使用英文逗号\&quot;,\&quot;分隔注：一个座席只能在一个运行中的任务中</para>
        /// 
        /// <b>Example:</b>
        /// <para>1111,2222</para>
        /// </summary>
        [NameInMap("Cnos")]
        [Validation(Required=false)]
        public string Cnos { get; set; }

        /// <summary>
        /// <para>任务维度限制最大并发数，实际并发不会超过最大并发限制。type=1时，配置成0表示不限制，座席数量少于10时建议配置该参数</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Concurrency")]
        [Validation(Required=false)]
        public long? Concurrency { get; set; }

        /// <summary>
        /// <para>客户侧外显规则；customerClidsCategory=1或2时生效。1.随机 2.按区号，默认随机。不建议使用</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CustomerClidType")]
        [Validation(Required=false)]
        public long? CustomerClidType { get; set; }

        /// <summary>
        /// <para>外显号码比例配置内容；customerClidsCategory=1且customerClidWeightFlag=1时生效。JsonArray格式 [{&quot;number&quot;:&quot;123,345&quot;,&quot;weight&quot;:&quot;5&quot;}, {&quot;number&quot;:&quot;567,789&quot;,&quot;weight&quot;:&quot;5&quot;}]，不建议使用</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;number&quot;:&quot;123,345&quot;,&quot;weight&quot;:&quot;5&quot;}, {&quot;number&quot;:&quot;567,789&quot;,&quot;weight&quot;:&quot;5&quot;}]</para>
        /// </summary>
        [NameInMap("CustomerClidWeight")]
        [Validation(Required=false)]
        public string CustomerClidWeight { get; set; }

        /// <summary>
        /// <para>外显号码比例配置开关；customerClidsCategory=1时生效。0.关闭 1.开启，默认关闭。不建议使用</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("CustomerClidWeightFlag")]
        [Validation(Required=false)]
        public long? CustomerClidWeightFlag { get; set; }

        /// <summary>
        /// <para>客户侧外显号码列表；customerClidsCategory=1或2时必填。支持多个，多个直接使用英文逗号\&quot;,\&quot;分隔。不建议使用</para>
        /// 
        /// <b>Example:</b>
        /// <para>7744331,7744332</para>
        /// </summary>
        [NameInMap("CustomerClids")]
        [Validation(Required=false)]
        public string CustomerClids { get; set; }

        /// <summary>
        /// <para>客户侧外显号码类型；1.外显固话 2.外显手机号 4.外显号码池 5.外显导航注：推荐使用外显导航，可以灵活调整和控制外显策略。其他类型将逐步下线</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CustomerClidsCategory")]
        [Validation(Required=false)]
        public long? CustomerClidsCategory { get; set; }

        /// <summary>
        /// <para>客户侧外显号码池名称或外显导航标识；customerClidsCategory=4或5时必填。customerClidsCategory=4时customerClidsGroup传号码池名称。customerClidsCategory=5时customerClidsGroup传外显导航标识</para>
        /// 
        /// <b>Example:</b>
        /// <para>示例值示例值</para>
        /// </summary>
        [NameInMap("CustomerClidsGroup")]
        [Validation(Required=false)]
        public string CustomerClidsGroup { get; set; }

        /// <summary>
        /// <para>客户侧等待音；客户接听后呼叫座席，等待座席接听时播放的语音，默认为空白音。支持公共语音和企业语音，值为语音文件的path，如:60000011533526918819</para>
        /// 
        /// <b>Example:</b>
        /// <para>60000011533526918819</para>
        /// </summary>
        [NameInMap("CustomerMoh")]
        [Validation(Required=false)]
        public string CustomerMoh { get; set; }

        /// <summary>
        /// <para>客户超时时间；单位秒数，默认30秒，取值范围5 ~ 60</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("CustomerTimeout")]
        [Validation(Required=false)]
        public long? CustomerTimeout { get; set; }

        /// <summary>
        /// <para>客户侧提示音；客户接听后呼转座席前播放的语音，提示音播放完成后再找座席，默认无提示音。支持公共语音和企业语音，值为语音文件的path，如:60000011533526918819</para>
        /// 
        /// <b>Example:</b>
        /// <para>60000011533526918819</para>
        /// </summary>
        [NameInMap("CustomerVoice")]
        [Validation(Required=false)]
        public string CustomerVoice { get; set; }

        /// <summary>
        /// <para>任务描述；需进行UTF-8格式的URLEncode编码，长度小于200字</para>
        /// 
        /// <b>Example:</b>
        /// <para>Task Description</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>呼叫中心 id</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>36</para>
        /// </summary>
        [NameInMap("EnterpriseId")]
        [Validation(Required=false)]
        public long? EnterpriseId { get; set; }

        /// <summary>
        /// <para>定时完成时强制结束任务；autoStop=1时生效。0.关闭 1.开启，默认关闭。开启配置后，当任务到定时完成时间时无论任务中的号码是否已经呼完，均将任务状态设置为结束。适用于对数据有呼叫时间限制的场景。注：任务在结束状态时无法再次启动。</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ForceEndFlag")]
        [Validation(Required=false)]
        public long? ForceEndFlag { get; set; }

        /// <summary>
        /// <para>暂停后重新预热；0.关闭，1开启，默认开启，任务暂停后是否需要重新预热</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("IsRewarm")]
        [Validation(Required=false)]
        public long? IsRewarm { get; set; }

        /// <summary>
        /// <para>语音导航Id；参数ivrId和ivrName二选一，同时传入时ivrId生效，在创建自动外呼任务时ivrId或ivrName必选其一。预测外呼使用场景：如果客户接听后未在特定时间内（默认2秒）找到可用座席，通话将溢出到语音导航继续排队找座席。同时支持在呼转座席，座席未接听时也溢出到语音导航，需要开启企业配置生效自动外呼使用场景：客户接听后，转到的语音导航</para>
        /// 
        /// <b>Example:</b>
        /// <para>42</para>
        /// </summary>
        [NameInMap("IvrId")]
        [Validation(Required=false)]
        public long? IvrId { get; set; }

        /// <summary>
        /// <para>语音导航名称；参数ivrId和ivrName二选一，同时传入时ivrId生效，在创建自动外呼任务时ivrId或ivrName必选其一。</para>
        /// 
        /// <b>Example:</b>
        /// <para>IvrName1</para>
        /// </summary>
        [NameInMap("IvrName")]
        [Validation(Required=false)]
        public string IvrName { get; set; }

        /// <summary>
        /// <para>座席最长等待时间；默认40秒，最小10，最大600，允许座席空闲的最大时间。任务执行过程中，如果座席平均空闲时间大于maxWaitTime，每次呼叫个数会增加</para>
        /// 
        /// <b>Example:</b>
        /// <para>40</para>
        /// </summary>
        [NameInMap("MaxWaitTime")]
        [Validation(Required=false)]
        public long? MaxWaitTime { get; set; }

        /// <summary>
        /// <para>最小可用座席数；默认为10，取值范围1 ~ 10。任务内可用座席数小于当前值时，任务自动暂停，避免骚扰</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MinAvailableAgentCount")]
        [Validation(Required=false)]
        public long? MinAvailableAgentCount { get; set; }

        /// <summary>
        /// <para>任务名称；需进行UTF-8格式的URLEncode编码，长度小于50字</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>taskName</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>超呼率；默认值为100，取值范围50～400</para>
        /// 
        /// <b>Example:</b>
        /// <para>55</para>
        /// </summary>
        [NameInMap("PredictAdjust")]
        [Validation(Required=false)]
        public long? PredictAdjust { get; set; }

        /// <summary>
        /// <para>骚扰率；默认值为1，取值范围为大于0，小于等于20，支持小数，精确到小数点两位。值越小呼叫的号码越少，值越大呼叫的号码越多，座席利用率越高</para>
        /// 
        /// <b>Example:</b>
        /// <para>17.62</para>
        /// </summary>
        [NameInMap("Quotiety")]
        [Validation(Required=false)]
        public double? Quotiety { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>重试策略；「基础模式」数据结构为Json格式<c>{&quot;retry&quot;:2,&quot;strategy&quot;:[{&quot;round&quot;:1,&quot;time&quot;:&quot;1-1-1&quot;},{&quot;round&quot;:2,&quot;time&quot;:&quot;2-2-2&quot;}]}</c>格式说明：retry是重试次数，round是第几次重试，time是第几次重试间隔的时间：1-1-1，第一个1是天，第二个1是小时，第三个1是分钟「高级模式」高级模式需要开启「号码状态识别」服务数据结构为JsonArray格式 <c>[{&quot;condition&quot;:{&quot;sipCause&quot;:[710,719]},&quot;retry&quot;:1,&quot;sort&quot;:1,&quot;strategy&quot;:[{&quot;round&quot;:1,&quot;time&quot;:&quot;0-0-10&quot;}]},{&quot;condition&quot;:{&quot;sipCause&quot;:[800]},&quot;retry&quot;:1,&quot;sort&quot;:2,&quot;strategy&quot;:[{&quot;round&quot;:2,&quot;time&quot;:&quot;0-0-10&quot;}]}]</c>格式说明：condition是重试条件，sort是重试条件的顺序，其余字段与基础模式一致 注：基础模式和高级模式的区分根据传入的参数格式自动识别。基于首次呼叫时间重试时，每轮的重试时间必须大于上一轮的时间</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;retry&quot;:2,&quot;strategy&quot;:[{&quot;round&quot;:1,&quot;time&quot;:&quot;1-1-1&quot;},{&quot;round&quot;:2,&quot;time&quot;:&quot;2-2-2&quot;}]}</para>
        /// </summary>
        [NameInMap("RetryStrategy")]
        [Validation(Required=false)]
        public string RetryStrategy { get; set; }

        /// <summary>
        /// <para>任务仅当天生效；0.关闭 1.开启，删除待重试的数据和待呼叫的数据 2.开启，删除待重试的数据 3.开启，删除待呼叫的数据，默认关闭</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("RetryStrategyOnlyToday")]
        [Validation(Required=false)]
        public long? RetryStrategyOnlyToday { get; set; }

        /// <summary>
        /// <para>重试策略时间类型；配置重试策略时生效。 1.基于首次呼叫时间 2.基于上次呼叫时间，默认基于首次呼叫时间</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RetryStrategyTimeType")]
        [Validation(Required=false)]
        public long? RetryStrategyTimeType { get; set; }

        /// <summary>
        /// <para>任务模板名称；通过任务模板可以实现对任务参数的统一管理以及简化接口传参，多个任务可以使用同一个模板管理参数，接口只需要传入任务间有差异的参数。参数生效规则：接口传入的参数优先。示例说明：如果接口传了参数autoStart=1和参数templateName=testTemplate，接口传入的参数autoStart生效。如果接口未传入autoStart参数或者传入的autoStart参数是空值，那么模版中的参数生效。注：任务模板可通过任务模板接口进行管理</para>
        /// 
        /// <b>Example:</b>
        /// <para>TemplateName</para>
        /// </summary>
        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

        /// <summary>
        /// <para>禁呼时间；在特定的时间段内禁止呼叫。参数格式：时间条件编号。支持多个，多个使用英文&quot;,&quot;逗号隔开，如：9,22。注：时间条件列表可通过查询时间条件设置列表接口获取</para>
        /// 
        /// <b>Example:</b>
        /// <para>9,22</para>
        /// </summary>
        [NameInMap("TimeStrategy")]
        [Validation(Required=false)]
        public string TimeStrategy { get; set; }

        /// <summary>
        /// <para>1.预测外呼任务 2.自动外呼任务。外呼任务创建后任务类型不支持修改</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public long? Type { get; set; }

        /// <summary>
        /// <para>任务自定义字段。JsonArray格式；数组的每个元素只支持传递一组键值对，传递多组只取第一组，如 {&quot;key&quot;, &quot;value&quot;}。 默认空值，示例：[{&quot;name&quot;:&quot;1234&quot;},{&quot;name1&quot;:&quot;12345&quot;}] 注：单个字段值的长度不能超过1000个字符</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;name&quot;:&quot;1234&quot;},{&quot;name1&quot;:&quot;12345&quot;}]</para>
        /// </summary>
        [NameInMap("UserFields")]
        [Validation(Required=false)]
        public string UserFields { get; set; }

        /// <summary>
        /// <para>任务预热时间；默认300秒, 取值范围60 ～ 600</para>
        /// 
        /// <b>Example:</b>
        /// <para>93</para>
        /// </summary>
        [NameInMap("WarmUpDuration")]
        [Validation(Required=false)]
        public long? WarmUpDuration { get; set; }

        /// <summary>
        /// <para>座席整理时间；默认30秒，取值范围1～10800，整理时间会影响每次呼叫的个数，值越大，呼叫号码个数会减小</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("Wrapup")]
        [Validation(Required=false)]
        public long? Wrapup { get; set; }

    }

}
