// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class CloudGetTaskResponseBody : TeaModel {
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
        public CloudGetTaskResponseBodyData Data { get; set; }
        public class CloudGetTaskResponseBodyData : TeaModel {
            /// <summary>
            /// <para>任务配置信息</para>
            /// </summary>
            [NameInMap("TaskProperty")]
            [Validation(Required=false)]
            public CloudGetTaskResponseBodyDataTaskProperty TaskProperty { get; set; }
            public class CloudGetTaskResponseBodyDataTaskProperty : TeaModel {
                /// <summary>
                /// <para>adjustStep</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("AdjustStep")]
                [Validation(Required=false)]
                public string AdjustStep { get; set; }

                /// <summary>
                /// <para>座席超时时间，单位秒</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("AgentTimeout")]
                [Validation(Required=false)]
                public string AgentTimeout { get; set; }

                /// <summary>
                /// <para>已废弃。座席利用率</para>
                /// 
                /// <b>Example:</b>
                /// <para>deprecated</para>
                /// </summary>
                [NameInMap("AgentUtilization")]
                [Validation(Required=false)]
                public string AgentUtilization { get; set; }

                /// <summary>
                /// <para>初始化预计客户接通率</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("AnswerRate")]
                [Validation(Required=false)]
                public string AnswerRate { get; set; }

                /// <summary>
                /// <para>自动完成，0.关闭 1.开启</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("AutoComplete")]
                [Validation(Required=false)]
                public string AutoComplete { get; set; }

                /// <summary>
                /// <para>定时开始，0.关闭 1.开启</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("AutoStart")]
                [Validation(Required=false)]
                public string AutoStart { get; set; }

                /// <summary>
                /// <para>定时开始日期，格式：yyyy-MM-dd，如：2017-02-11</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-02-11</para>
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
                public string AutoStop { get; set; }

                /// <summary>
                /// <para>定时完成日期，格式：yyyy-MM-dd，如：2017-02-11</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-02-11</para>
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
                /// <para>0</para>
                /// </summary>
                [NameInMap("AutoTaskType")]
                [Validation(Required=false)]
                public string AutoTaskType { get; set; }

                /// <summary>
                /// <para>间隔呼叫时间段，呼叫的时间段配置。参数格式：时间条件编号。支持多个，多个使用英文&quot;,&quot;逗号隔开，如：9,22。</para>
                /// 
                /// <b>Example:</b>
                /// <para>9,22</para>
                /// </summary>
                [NameInMap("AutoTriggerTimeStrategy")]
                [Validation(Required=false)]
                public string AutoTriggerTimeStrategy { get; set; }

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
                /// <para>座席分配规则，1.随机 2.顺序 3.座席未进线最大时（从上一次呼叫结束到当前的总时长） 4.座席状态[空闲]最长时长（座席最近一次切换为空闲状态的持续时长）</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("CallStrategy")]
                [Validation(Required=false)]
                public string CallStrategy { get; set; }

                /// <summary>
                /// <para>座席通道变量，JsonArray格式[{&quot;key1&quot;:&quot;value1&quot;},{&quot;key2&quot;:&quot;value2&quot;}]</para>
                /// 
                /// <b>Example:</b>
                /// <para>[{&quot;key1&quot;:&quot;value1&quot;},{&quot;key2&quot;:&quot;value2&quot;}]</para>
                /// </summary>
                [NameInMap("CallVariables")]
                [Validation(Required=false)]
                public string CallVariables { get; set; }

                /// <summary>
                /// <para>已废弃。给企业推送任务状态的URL地址</para>
                /// 
                /// <b>Example:</b>
                /// <para>deprecated</para>
                /// </summary>
                [NameInMap("CallbackUrl")]
                [Validation(Required=false)]
                public string CallbackUrl { get; set; }

                /// <summary>
                /// <para>已废弃。热线号码组</para>
                /// 
                /// <b>Example:</b>
                /// <para>deprecated</para>
                /// </summary>
                [NameInMap("ClidGroup")]
                [Validation(Required=false)]
                public string ClidGroup { get; set; }

                /// <summary>
                /// <para>外显规则，Json格式，外显号码选择规则：默认区号，是否匹配省会等；如：{&quot;defaultAreaCode&quot;:&quot;010&quot;, &quot;isMatchCapital&quot;:&quot;1&quot;}</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;defaultAreaCode&quot;:&quot;010&quot;, &quot;isMatchCapital&quot;:&quot;1&quot;}</para>
                /// </summary>
                [NameInMap("ClidProperty")]
                [Validation(Required=false)]
                public string ClidProperty { get; set; }

                /// <summary>
                /// <para>座席工号列表</para>
                /// 
                /// <b>Example:</b>
                /// <para>111,222</para>
                /// </summary>
                [NameInMap("Cnos")]
                [Validation(Required=false)]
                public string Cnos { get; set; }

                /// <summary>
                /// <para>最大并发限制</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Concurrency")]
                [Validation(Required=false)]
                public string Concurrency { get; set; }

                /// <summary>
                /// <para>任务创建时间 ，格式为： yyyy-MM-dd HH:mm:ss</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-05-10 14:07:22</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>已废弃。推送重试次数 最大5次</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("CurlRetryTimes")]
                [Validation(Required=false)]
                public string CurlRetryTimes { get; set; }

                /// <summary>
                /// <para>客户侧外显规则，1.随机 2.按区号</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("CustomerClidType")]
                [Validation(Required=false)]
                public string CustomerClidType { get; set; }

                /// <summary>
                /// <para>外显号码比例配置内容，JsonArray格式[{&quot;number&quot;:&quot;123,345&quot;,&quot;weight&quot;:&quot;5&quot;},{&quot;number&quot;:&quot;567,789&quot;,&quot;weight&quot;:&quot;5&quot;}]</para>
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
                public string CustomerClidWeightFlag { get; set; }

                /// <summary>
                /// <para>客户侧外显号码列表</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;&quot;</para>
                /// </summary>
                [NameInMap("CustomerClids")]
                [Validation(Required=false)]
                public string CustomerClids { get; set; }

                /// <summary>
                /// <para>客户侧外显号码类型，1.外显固话 2.外显手机号 4.外显号码池 5.外显导航</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("CustomerClidsCategory")]
                [Validation(Required=false)]
                public string CustomerClidsCategory { get; set; }

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
                /// <para>30</para>
                /// </summary>
                [NameInMap("CustomerTimeout")]
                [Validation(Required=false)]
                public string CustomerTimeout { get; set; }

                /// <summary>
                /// <para>客户侧提示音</para>
                /// 
                /// <b>Example:</b>
                /// <para>示例值</para>
                /// </summary>
                [NameInMap("CustomerVoice")]
                [Validation(Required=false)]
                public string CustomerVoice { get; set; }

                /// <summary>
                /// <para>任务描述</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>企业编号</para>
                /// 
                /// <b>Example:</b>
                /// <para>7000002</para>
                /// </summary>
                [NameInMap("EnterpriseId")]
                [Validation(Required=false)]
                public string EnterpriseId { get; set; }

                /// <summary>
                /// <para>定时完成时强制结束任务。开启配置后，当任务到定时完成时间时无论任务中的号码是否已经呼完，均将任务状态设置为结束。适用于对数据有呼叫时间限制的场景。注：任务在结束状态时无法再次启动。</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ForceEndFlag")]
                [Validation(Required=false)]
                public string ForceEndFlag { get; set; }

                /// <summary>
                /// <para>外呼任务Id</para>
                /// 
                /// <b>Example:</b>
                /// <para>11059</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>随机呼叫，0.关闭 1.开启</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("IsRandom")]
                [Validation(Required=false)]
                public string IsRandom { get; set; }

                /// <summary>
                /// <para>暂停后重新预热，0.关闭，1开启</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("IsRewarm")]
                [Validation(Required=false)]
                public string IsRewarm { get; set; }

                /// <summary>
                /// <para>语音导航Id</para>
                /// 
                /// <b>Example:</b>
                /// <para>33</para>
                /// </summary>
                [NameInMap("IvrId")]
                [Validation(Required=false)]
                public string IvrId { get; set; }

                /// <summary>
                /// <para>座席最大等待时间，单位秒</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("MaxWaitTime")]
                [Validation(Required=false)]
                public string MaxWaitTime { get; set; }

                /// <summary>
                /// <para>最小可用座席数</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("MinAvailableAgentCount")]
                [Validation(Required=false)]
                public string MinAvailableAgentCount { get; set; }

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
                /// <b>Example:</b>
                /// <para>&quot;&quot;</para>
                /// </summary>
                [NameInMap("OverCallLimitCnos")]
                [Validation(Required=false)]
                public string OverCallLimitCnos { get; set; }

                /// <summary>
                /// <para>任务结束时间</para>
                /// 
                /// <b>Example:</b>
                /// <para>示例值示例值示例值</para>
                /// </summary>
                [NameInMap("OverTime")]
                [Validation(Required=false)]
                public string OverTime { get; set; }

                /// <summary>
                /// <para>任务暂停时长(针对自动启动时间段) 单位分钟</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("PauseDuration")]
                [Validation(Required=false)]
                public string PauseDuration { get; set; }

                /// <summary>
                /// <para>任务暂停时间点</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-04-14 16:51:11</para>
                /// </summary>
                [NameInMap("PauseTime")]
                [Validation(Required=false)]
                public string PauseTime { get; set; }

                /// <summary>
                /// <para>超呼率</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("PredictAdjust")]
                [Validation(Required=false)]
                public string PredictAdjust { get; set; }

                /// <summary>
                /// <para>骚扰率，支持小数，精确到小数点两位</para>
                /// 
                /// <b>Example:</b>
                /// <para>3.0</para>
                /// </summary>
                [NameInMap("Quotiety")]
                [Validation(Required=false)]
                public string Quotiety { get; set; }

                /// <summary>
                /// <para>重试策略，「基础模式」数据结构为Json格式<c>{&quot;retry&quot;:2,&quot;strategy&quot;:[{&quot;round&quot;:1,&quot;time&quot;:&quot;1-1-1&quot;},{&quot;round&quot;:2,&quot;time&quot;:&quot;2-2-2&quot;}]}</c>格式说明：retry是重试次数，round是第几次重试，time是第几次重试间隔的时间：1-1-1，第一个1是天，第二个1是小时，第三个1是分钟「高级模式」高级模式需要开启「号码状态识别」服务后。目前只支持「自动外呼」任务模式。数据结构为JsonArray格式 <c>[{&quot;condition&quot;:{&quot;sipCause&quot;:[710,719]},&quot;retry&quot;:1,&quot;sort&quot;:1,&quot;strategy&quot;:[{&quot;round&quot;:1,&quot;time&quot;:&quot;0-0-10&quot;}]},{&quot;condition&quot;:{&quot;sipCause&quot;:[800]},&quot;retry&quot;:1,&quot;sort&quot;:2,&quot;strategy&quot;:[{&quot;round&quot;:2,&quot;time&quot;:&quot;0-0-10&quot;}]}]</c>格式说明：condition是重试条件，sort是重试条件的顺序，其余字段与基础模式一致</para>
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
                /// <para>0</para>
                /// </summary>
                [NameInMap("RetryStrategyOnlyToday")]
                [Validation(Required=false)]
                public string RetryStrategyOnlyToday { get; set; }

                /// <summary>
                /// <para>已废弃</para>
                /// 
                /// <b>Example:</b>
                /// <para>deprecated</para>
                /// </summary>
                [NameInMap("StandbyCnos")]
                [Validation(Required=false)]
                public string StandbyCnos { get; set; }

                /// <summary>
                /// <para>任务开始时间</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-05-10 14:11:15</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// <para>任务状态，0.初始 1.运行中 2.暂停 3.结束</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>任务状态描述</para>
                /// 
                /// <b>Example:</b>
                /// <para>示例值示例值</para>
                /// </summary>
                [NameInMap("StatusDescription")]
                [Validation(Required=false)]
                public string StatusDescription { get; set; }

                /// <summary>
                /// <para>已废弃。任务级呼叫属性 json格式{&quot;key1&quot;:&quot;value1&quot;,&quot;key2&quot;:&quot;value2&quot;}，仅做呼叫控制用，不放通道变量</para>
                /// 
                /// <b>Example:</b>
                /// <para>deprecated</para>
                /// </summary>
                [NameInMap("TaskFields")]
                [Validation(Required=false)]
                public string TaskFields { get; set; }

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
                public string Type { get; set; }

                /// <summary>
                /// <para>任务自定义字段，JsonArray格式[{&quot;key1&quot;:&quot;value1&quot;},{&quot;key2&quot;:&quot;value2&quot;}]</para>
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
                /// <para>300</para>
                /// </summary>
                [NameInMap("WarmUpDuration")]
                [Validation(Required=false)]
                public string WarmUpDuration { get; set; }

                /// <summary>
                /// <para>座席整理时间，单位秒</para>
                /// 
                /// <b>Example:</b>
                /// <para>30</para>
                /// </summary>
                [NameInMap("Wrapup")]
                [Validation(Required=false)]
                public string Wrapup { get; set; }

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
        /// <para>7BF47617-7851-48F7-A3A1-2021342A78E2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
