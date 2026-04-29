// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class CloudQueryTaskResponseBody : TeaModel {
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public CloudQueryTaskResponseBodyData Data { get; set; }
        public class CloudQueryTaskResponseBodyData : TeaModel {
            [NameInMap("TaskProperties")]
            [Validation(Required=false)]
            public List<CloudQueryTaskResponseBodyDataTaskProperties> TaskProperties { get; set; }
            public class CloudQueryTaskResponseBodyDataTaskProperties : TeaModel {
                /// <summary>
                /// <para>外呼组号</para>
                /// 
                /// <b>Example:</b>
                /// <para>WH124</para>
                /// </summary>
                [NameInMap("AgentGroup")]
                [Validation(Required=false)]
                public string AgentGroup { get; set; }

                /// <summary>
                /// <para>座席超时时间，单位秒</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("AgentTimeout")]
                [Validation(Required=false)]
                public long? AgentTimeout { get; set; }

                /// <summary>
                /// <para>初始化预计客户接通率</para>
                /// 
                /// <b>Example:</b>
                /// <para>50</para>
                /// </summary>
                [NameInMap("AnswerRate")]
                [Validation(Required=false)]
                public long? AnswerRate { get; set; }

                /// <summary>
                /// <para>自动完成，0.关闭 1.开启</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("AutoComplete")]
                [Validation(Required=false)]
                public long? AutoComplete { get; set; }

                /// <summary>
                /// <para>定时开始，0.关闭 1.开启</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("AutoStart")]
                [Validation(Required=false)]
                public long? AutoStart { get; set; }

                /// <summary>
                /// <para>定时开始日期，格式：yyyy-MM-dd，如：2017-02-11</para>
                /// 
                /// <b>Example:</b>
                /// <para>2017-02-11</para>
                /// </summary>
                [NameInMap("AutoStartDay")]
                [Validation(Required=false)]
                public string AutoStartDay { get; set; }

                /// <summary>
                /// <para>定时开始时间，格式：HH:mm:ss，如：08:00:00</para>
                /// 
                /// <b>Example:</b>
                /// <para>08:00:00</para>
                /// </summary>
                [NameInMap("AutoStartTime")]
                [Validation(Required=false)]
                public string AutoStartTime { get; set; }

                /// <summary>
                /// <para>定时完成，0.关闭 1.开启</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("AutoStop")]
                [Validation(Required=false)]
                public long? AutoStop { get; set; }

                /// <summary>
                /// <para>定时完成日期，格式：yyyy-MM-dd，如：2017-02-11</para>
                /// 
                /// <b>Example:</b>
                /// <para>2017-02-11</para>
                /// </summary>
                [NameInMap("AutoStopDay")]
                [Validation(Required=false)]
                public string AutoStopDay { get; set; }

                /// <summary>
                /// <para>定时完成时间，格式：HH:mm:ss，如：17:00:00</para>
                /// 
                /// <b>Example:</b>
                /// <para>17:00:00</para>
                /// </summary>
                [NameInMap("AutoStopTime")]
                [Validation(Required=false)]
                public string AutoStopTime { get; set; }

                /// <summary>
                /// <para>呼叫方式，0.连续呼叫 1.间隔呼叫</para>
                /// 
                /// <b>Example:</b>
                /// <para>50</para>
                /// </summary>
                [NameInMap("AutoTaskType")]
                [Validation(Required=false)]
                public long? AutoTaskType { get; set; }

                /// <summary>
                /// <para>间隔呼叫时间段，呼叫的时间段配置。参数格式：时间条件编号。支持多个，多个使用英文&quot;,&quot;逗号隔开，如：9,22</para>
                /// 
                /// <b>Example:</b>
                /// <para>9,22</para>
                /// </summary>
                [NameInMap("AutoTriggerTimeStrategy")]
                [Validation(Required=false)]
                public string AutoTriggerTimeStrategy { get; set; }

                /// <summary>
                /// <para>指定座席方式，1.座席工号列表 2.外呼组</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("CallGroupType")]
                [Validation(Required=false)]
                public long? CallGroupType { get; set; }

                /// <summary>
                /// <para>座席当日接听数限制，JsonArray格式[{&quot;cnos&quot;:[&quot;2000&quot;,&quot;2001&quot;],&quot;limit&quot;:&quot;5&quot;}]</para>
                /// 
                /// <b>Example:</b>
                /// <para>[{&quot;cnos&quot;:[&quot;2000&quot;,&quot;2001&quot;],&quot;limit&quot;:&quot;5&quot;}]</para>
                /// </summary>
                [NameInMap("CallLimitStrategy")]
                [Validation(Required=false)]
                public string CallLimitStrategy { get; set; }

                /// <summary>
                /// <para>呼叫顺序，数据结构为Json格式<c>{&quot;strategy&quot;:[{&quot;sort&quot;:1,&quot;type&quot;:&quot;retryCall&quot;, &quot;desc&quot;:0},{&quot;sort&quot;:2,&quot;type&quot;:&quot;firstCall&quot;,&quot;orderType&quot;:0}]}</c>，格式说明：sort是重试号码和未呼叫号码的呼叫顺序 ，type：retryCall重试号码、firstCall未呼叫号码，当type=retryCall，desc：0.优先呼叫待重呼轮次数值较小的号码，即轮次靠前（如第1轮、第2轮）的号码先被呼叫 1.优先呼叫待重呼轮次数值较大的号码，即轮次靠后（如第5轮、第4轮）的号码先被呼叫，当type=firstCall时，orderType：随机呼叫，0顺序(优先级) 1随机 2顺序(导入时间)</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;strategy&quot;:[{&quot;sort&quot;:1,&quot;type&quot;:&quot;retryCall&quot;, &quot;desc&quot;:0},{&quot;sort&quot;:2,&quot;type&quot;:&quot;firstCall&quot;,&quot;orderType&quot;:0}]}</para>
                /// </summary>
                [NameInMap("CallPriorityStrategy")]
                [Validation(Required=false)]
                public string CallPriorityStrategy { get; set; }

                /// <summary>
                /// <para>呼叫流转模式， 1.直连座席 2.AI转人工 直连座席模式：客户接听后直接分配座席，无空闲座席可溢出语音导航（需配置语音导航），保障高优先级客户直连体验 AI转人工：客户接入后，优先进入语音导航中配置的智能体机器人，按交互结果决定是否转接座席，提升自动化覆盖率，降低人工成本</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("CallRouteStrategy")]
                [Validation(Required=false)]
                public long? CallRouteStrategy { get; set; }

                /// <summary>
                /// <para>座席分配规则，1.随机 2.顺序 3.座席未进线最大时（从上一次呼叫结束到当前的总时长） 4.座席状态[空闲]最长时长（座席最近一次切换为空闲状态的持续时长）</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("CallStrategy")]
                [Validation(Required=false)]
                public long? CallStrategy { get; set; }

                /// <summary>
                /// <para>座席通道变量</para>
                /// 
                /// <b>Example:</b>
                /// <para>[{&quot;key1&quot;:&quot;value1&quot;},{&quot;key2&quot;:&quot;value2&quot;}]</para>
                /// </summary>
                [NameInMap("CallVariables")]
                [Validation(Required=false)]
                public string CallVariables { get; set; }

                /// <summary>
                /// <para>外显规则，Json格式，外显号码选择规则：默认区号，是否匹配省会等；如：{&quot;defaultAreaCode&quot;:&quot;010&quot;, &quot;isMatchCapital&quot;:&quot;1&quot;}</para>
                /// 
                /// <b>Example:</b>
                /// <para>示例值</para>
                /// </summary>
                [NameInMap("ClidProperty")]
                [Validation(Required=false)]
                public string ClidProperty { get; set; }

                /// <summary>
                /// <para>座席工号列表</para>
                /// 
                /// <b>Example:</b>
                /// <para>1111,2222</para>
                /// </summary>
                [NameInMap("Cnos")]
                [Validation(Required=false)]
                public string Cnos { get; set; }

                /// <summary>
                /// <para>最大并发限制</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("Concurrency")]
                [Validation(Required=false)]
                public long? Concurrency { get; set; }

                /// <summary>
                /// <para>任务创建时间 ，格式为： yyyy-MM-dd HH:mm:ss</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-10-12 18:03:14</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>客户侧外显规则，1.随机 2.按区号</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("CustomerClidType")]
                [Validation(Required=false)]
                public long? CustomerClidType { get; set; }

                /// <summary>
                /// <para>外显号码比例配置内容</para>
                /// 
                /// <b>Example:</b>
                /// <para>[{&quot;number&quot;:&quot;123,345&quot;,&quot;weight&quot;:&quot;5&quot;},{&quot;number&quot;:&quot;567,789&quot;,&quot;weight&quot;:&quot;5&quot;}]</para>
                /// </summary>
                [NameInMap("CustomerClidWeight")]
                [Validation(Required=false)]
                public string CustomerClidWeight { get; set; }

                /// <summary>
                /// <para>外显号码比例配置开关，0.关闭 1.开启</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CustomerClidWeightFlag")]
                [Validation(Required=false)]
                public long? CustomerClidWeightFlag { get; set; }

                /// <summary>
                /// <para>客户侧外显号码列表</para>
                /// 
                /// <b>Example:</b>
                /// <para>02138276106</para>
                /// </summary>
                [NameInMap("CustomerClids")]
                [Validation(Required=false)]
                public string CustomerClids { get; set; }

                /// <summary>
                /// <para>客户侧外显号码类型，1.外显固话 2.外显手机号  4.外显号码池 5.外显导航</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("CustomerClidsCategory")]
                [Validation(Required=false)]
                public long? CustomerClidsCategory { get; set; }

                /// <summary>
                /// <para>客户侧等待音</para>
                /// 
                /// <b>Example:</b>
                /// <para>no</para>
                /// </summary>
                [NameInMap("CustomerMoh")]
                [Validation(Required=false)]
                public string CustomerMoh { get; set; }

                /// <summary>
                /// <para>客户超时时间，单位秒</para>
                /// 
                /// <b>Example:</b>
                /// <para>17</para>
                /// </summary>
                [NameInMap("CustomerTimeout")]
                [Validation(Required=false)]
                public long? CustomerTimeout { get; set; }

                /// <summary>
                /// <para>客户侧提示音</para>
                /// 
                /// <b>Example:</b>
                /// <para>示例值示例值</para>
                /// </summary>
                [NameInMap("CustomerVoice")]
                [Validation(Required=false)]
                public string CustomerVoice { get; set; }

                /// <summary>
                /// <para>任务描述</para>
                /// 
                /// <b>Example:</b>
                /// <para>desc</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>呼叫中心Id</para>
                /// 
                /// <b>Example:</b>
                /// <para>7000002</para>
                /// </summary>
                [NameInMap("EnterpriseId")]
                [Validation(Required=false)]
                public string EnterpriseId { get; set; }

                /// <summary>
                /// <para>定时完成时强制结束任务，开启配置后，当任务到定时完成时间时无论任务中的号码是否已经呼完，均将任务状态设置为结束。适用于对数据有呼叫时间限制的场景。注：任务在结束状态时无法再次启动。 0：否，1：是</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ForceEndFlag")]
                [Validation(Required=false)]
                public long? ForceEndFlag { get; set; }

                /// <summary>
                /// <para>外呼任务Id</para>
                /// 
                /// <b>Example:</b>
                /// <para>59</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>暂停后重新预热，0.关闭，1开启</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("IsRewarm")]
                [Validation(Required=false)]
                public long? IsRewarm { get; set; }

                /// <summary>
                /// <para>语音导航Id，预测外呼使用场景：直连座席模式下如果客户接听后未在特定时间内（默认2秒）找到可用座席，通话将溢出到语音导航继续排队找座席。同时支持在呼转座席，座席未接听时也溢出到语音导航，需要开启企业配置生效。AI转人工模式下，呼叫先转到语音导航 自动外呼使用场景：客户接听后，转到的语音导航</para>
                /// 
                /// <b>Example:</b>
                /// <para>133</para>
                /// </summary>
                [NameInMap("IvrId")]
                [Validation(Required=false)]
                public long? IvrId { get; set; }

                /// <summary>
                /// <para>座席最大等待时间，单位秒</para>
                /// 
                /// <b>Example:</b>
                /// <para>34</para>
                /// </summary>
                [NameInMap("MaxWaitTime")]
                [Validation(Required=false)]
                public long? MaxWaitTime { get; set; }

                /// <summary>
                /// <para>最小可用座席数</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("MinAvailableAgentCount")]
                [Validation(Required=false)]
                public long? MinAvailableAgentCount { get; set; }

                /// <summary>
                /// <para>任务名称</para>
                /// 
                /// <b>Example:</b>
                /// <para>name1</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>超过呼叫限制的座席</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("OverCallLimitCnos")]
                [Validation(Required=false)]
                public string OverCallLimitCnos { get; set; }

                /// <summary>
                /// <para>任务结束时间</para>
                /// 
                /// <b>Example:</b>
                /// <para>示例值示例值</para>
                /// </summary>
                [NameInMap("OverTime")]
                [Validation(Required=false)]
                public string OverTime { get; set; }

                /// <summary>
                /// <para>任务暂停时长(针对自动启动时间段) 单位分钟</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("PauseDuration")]
                [Validation(Required=false)]
                public long? PauseDuration { get; set; }

                /// <summary>
                /// <para>任务暂停时间点</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-04-20 11:00:00</para>
                /// </summary>
                [NameInMap("PauseTime")]
                [Validation(Required=false)]
                public string PauseTime { get; set; }

                /// <summary>
                /// <para>超呼率</para>
                /// 
                /// <b>Example:</b>
                /// <para>60</para>
                /// </summary>
                [NameInMap("PredictAdjust")]
                [Validation(Required=false)]
                public long? PredictAdjust { get; set; }

                /// <summary>
                /// <para>骚扰率，支持小数，精确到小数点两位</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.0</para>
                /// </summary>
                [NameInMap("Quotiety")]
                [Validation(Required=false)]
                public double? Quotiety { get; set; }

                /// <summary>
                /// <para>重试策略， 「基础模式」 数据结构为Json格式<c>{&quot;retry&quot;:2,&quot;strategy&quot;:[{&quot;round&quot;:1,&quot;time&quot;:&quot;1-1-1&quot;},{&quot;round&quot;:2,&quot;time&quot;:&quot;2-2-2&quot;}]}</c> 格式说明：retry是重试次数，round是第几次重试，time是第几次重试间隔的时间：1-1-1，第一个1是天，第二个1是小时，第三个1是分钟 「高级模式」 高级模式需要开启「号码状态识别」服务后。目前只支持「自动外呼」任务模式。 数据结构为JsonArray格式 <c>[{&quot;condition&quot;:{&quot;sipCause&quot;:[710,719]},&quot;retry&quot;:1,&quot;sort&quot;:1,&quot;strategy&quot;:[{&quot;round&quot;:1,&quot;time&quot;:&quot;0-0-10&quot;}]},{&quot;condition&quot;:{&quot;sipCause&quot;:[800]},&quot;retry&quot;:1,&quot;sort&quot;:2,&quot;strategy&quot;:[{&quot;round&quot;:2,&quot;time&quot;:&quot;0-0-10&quot;}]}]</c> 格式说明：condition是重试条件，sort是重试条件的顺序，其余字段与基础模式一致</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;retry&quot;:2,&quot;strategy&quot;:[{&quot;round&quot;:1,&quot;time&quot;:&quot;1-1-1&quot;},{&quot;round&quot;:2,&quot;time&quot;:&quot;2-2-2&quot;}]}</para>
                /// </summary>
                [NameInMap("RetryStrategy")]
                [Validation(Required=false)]
                public string RetryStrategy { get; set; }

                /// <summary>
                /// <para>重试仅当天生效，0.关闭 1.开启，删除待重试的数据和待呼叫的数据 2.开启，删除待重试的数据 3.开启，删除待呼叫的数据</para>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("RetryStrategyOnlyToday")]
                [Validation(Required=false)]
                public long? RetryStrategyOnlyToday { get; set; }

                /// <summary>
                /// <para>重试策略时间类型，1.基于首次呼叫时间 2.基于上次呼叫时间</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("RetryStrategyTimeType")]
                [Validation(Required=false)]
                public long? RetryStrategyTimeType { get; set; }

                /// <summary>
                /// <para>任务开始时间</para>
                /// 
                /// <b>Example:</b>
                /// <para>09:00</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// <para>任务状态，0.初始 1.运行中 2.暂停 3.结束</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public long? Status { get; set; }

                /// <summary>
                /// <para>任务状态描述</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;&quot;</para>
                /// </summary>
                [NameInMap("StatusDescription")]
                [Validation(Required=false)]
                public string StatusDescription { get; set; }

                /// <summary>
                /// <para>任务状态变更类型，0.系统变更 1.人为变更</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("StatusTriggerType")]
                [Validation(Required=false)]
                public long? StatusTriggerType { get; set; }

                /// <summary>
                /// <para>禁止呼叫时间限制，在特定的时间段内禁止呼叫。参数格式：时间条件编号。支持多个，多个使用英文&quot;,&quot;逗号隔开，如：9,22。</para>
                /// 
                /// <b>Example:</b>
                /// <para>9,22</para>
                /// </summary>
                [NameInMap("TimeStrategy")]
                [Validation(Required=false)]
                public string TimeStrategy { get; set; }

                /// <summary>
                /// <para>任务类型，1.预测外呼任务 2.自动外呼任务</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public long? Type { get; set; }

                /// <summary>
                /// <para>任务自定义字段</para>
                /// 
                /// <b>Example:</b>
                /// <para>[{&quot;key1&quot;:&quot;value1&quot;},{&quot;key2&quot;:&quot;value2&quot;}]</para>
                /// </summary>
                [NameInMap("UserFields")]
                [Validation(Required=false)]
                public string UserFields { get; set; }

                /// <summary>
                /// <para>任务预热时间，单位秒</para>
                /// 
                /// <b>Example:</b>
                /// <para>9</para>
                /// </summary>
                [NameInMap("WarmUpDuration")]
                [Validation(Required=false)]
                public long? WarmUpDuration { get; set; }

                /// <summary>
                /// <para>座席整理时间，单位秒</para>
                /// 
                /// <b>Example:</b>
                /// <para>13</para>
                /// </summary>
                [NameInMap("Wrapup")]
                [Validation(Required=false)]
                public long? Wrapup { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>D9CB3933-9FE3-4870-BA8E-2BEE91B69D23</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
