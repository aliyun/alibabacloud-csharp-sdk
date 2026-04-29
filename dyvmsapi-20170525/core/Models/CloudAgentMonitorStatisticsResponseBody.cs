// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class CloudAgentMonitorStatisticsResponseBody : TeaModel {
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
        public CloudAgentMonitorStatisticsResponseBodyData Data { get; set; }
        public class CloudAgentMonitorStatisticsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>座席统计项数组</para>
            /// </summary>
            [NameInMap("AgentStatistics")]
            [Validation(Required=false)]
            public List<CloudAgentMonitorStatisticsResponseBodyDataAgentStatistics> AgentStatistics { get; set; }
            public class CloudAgentMonitorStatisticsResponseBodyDataAgentStatistics : TeaModel {
                /// <summary>
                /// <para>座席工号</para>
                /// 
                /// <b>Example:</b>
                /// <para>1111</para>
                /// </summary>
                [NameInMap("Cno")]
                [Validation(Required=false)]
                public string Cno { get; set; }

                /// <summary>
                /// <para>status: 代表座席状态，状态每个值对应的含义: stateIdle: 置闲; statePause: 置忙; stateCalling: 呼叫中; stateInuse: 通话中; stateWrapup: 整理, loginTime: 代表座席登录时间, startTime: 代表开始通话的时间</para>
                /// 
                /// <b>Example:</b>
                /// <para>{\&quot;state\&quot;:\&quot;stateIdle\&quot;,\&quot;startTime\&quot;:\&quot;1491462675\&quot;}</para>
                /// </summary>
                [NameInMap("CurrentState")]
                [Validation(Required=false)]
                public string CurrentState { get; set; }

                /// <summary>
                /// <para>外呼组编号</para>
                /// 
                /// <b>Example:</b>
                /// <para>WH123</para>
                /// </summary>
                [NameInMap("Gno")]
                [Validation(Required=false)]
                public string Gno { get; set; }

                /// <summary>
                /// <para>外呼组名称</para>
                /// 
                /// <b>Example:</b>
                /// <para>gpname</para>
                /// </summary>
                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                /// <summary>
                /// <para>总空闲次数</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("Idle_count")]
                [Validation(Required=false)]
                public string IdleCount { get; set; }

                /// <summary>
                /// <para>总空闲时长</para>
                /// 
                /// <b>Example:</b>
                /// <para>54344</para>
                /// </summary>
                [NameInMap("Idle_time")]
                [Validation(Required=false)]
                public string IdleTime { get; set; }

                /// <summary>
                /// <para>最大空闲时长</para>
                /// 
                /// <b>Example:</b>
                /// <para>52375</para>
                /// </summary>
                [NameInMap("Max_idle_time")]
                [Validation(Required=false)]
                public string MaxIdleTime { get; set; }

                /// <summary>
                /// <para>外呼通话最大时长</para>
                /// 
                /// <b>Example:</b>
                /// <para>41</para>
                /// </summary>
                [NameInMap("Max_ob_bridge_time")]
                [Validation(Required=false)]
                public string MaxObBridgeTime { get; set; }

                /// <summary>
                /// <para>外呼呼叫最大时长</para>
                /// 
                /// <b>Example:</b>
                /// <para>31</para>
                /// </summary>
                [NameInMap("Max_ob_calling_time")]
                [Validation(Required=false)]
                public string MaxObCallingTime { get; set; }

                /// <summary>
                /// <para>外呼整理最大时长</para>
                /// 
                /// <b>Example:</b>
                /// <para>30</para>
                /// </summary>
                [NameInMap("Max_ob_wrapup_time")]
                [Validation(Required=false)]
                public string MaxObWrapupTime { get; set; }

                /// <summary>
                /// <para>最小空闲时长</para>
                /// 
                /// <b>Example:</b>
                /// <para>9</para>
                /// </summary>
                [NameInMap("Min_idle_time")]
                [Validation(Required=false)]
                public string MinIdleTime { get; set; }

                /// <summary>
                /// <para>外呼通话最小时长</para>
                /// 
                /// <b>Example:</b>
                /// <para>29</para>
                /// </summary>
                [NameInMap("Min_ob_bridge_time")]
                [Validation(Required=false)]
                public string MinObBridgeTime { get; set; }

                /// <summary>
                /// <para>外呼呼叫最小时长</para>
                /// 
                /// <b>Example:</b>
                /// <para>8</para>
                /// </summary>
                [NameInMap("Min_ob_calling_time")]
                [Validation(Required=false)]
                public string MinObCallingTime { get; set; }

                /// <summary>
                /// <para>外呼整理最小时长</para>
                /// 
                /// <b>Example:</b>
                /// <para>30</para>
                /// </summary>
                [NameInMap("Min_ob_wrapup_time")]
                [Validation(Required=false)]
                public string MinObWrapupTime { get; set; }

                /// <summary>
                /// <para>总外呼通话次数</para>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("Ob_bridge_count")]
                [Validation(Required=false)]
                public string ObBridgeCount { get; set; }

                /// <summary>
                /// <para>外呼通话时长</para>
                /// 
                /// <b>Example:</b>
                /// <para>144</para>
                /// </summary>
                [NameInMap("Ob_bridge_time")]
                [Validation(Required=false)]
                public string ObBridgeTime { get; set; }

                /// <summary>
                /// <para>总外呼呼叫次数</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("Ob_calling_count")]
                [Validation(Required=false)]
                public string ObCallingCount { get; set; }

                /// <summary>
                /// <para>外呼呼叫时长</para>
                /// 
                /// <b>Example:</b>
                /// <para>67</para>
                /// </summary>
                [NameInMap("Ob_calling_time")]
                [Validation(Required=false)]
                public string ObCallingTime { get; set; }

                /// <summary>
                /// <para>总外呼整理次数</para>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("Ob_wrapup_count")]
                [Validation(Required=false)]
                public string ObWrapupCount { get; set; }

                /// <summary>
                /// <para>外呼整理时长</para>
                /// 
                /// <b>Example:</b>
                /// <para>120</para>
                /// </summary>
                [NameInMap("Ob_wrapup_time")]
                [Validation(Required=false)]
                public string ObWrapupTime { get; set; }

                /// <summary>
                /// <para>预览外呼座席接听数</para>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("Preview_ob_agent_answered_count")]
                [Validation(Required=false)]
                public string PreviewObAgentAnsweredCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("Preview_ob_both_answered_count")]
                [Validation(Required=false)]
                public string PreviewObBothAnsweredCount { get; set; }

                /// <summary>
                /// <para>双方接听最大通话时长</para>
                /// 
                /// <b>Example:</b>
                /// <para>41</para>
                /// </summary>
                [NameInMap("Preview_ob_max_bridge_time")]
                [Validation(Required=false)]
                public string PreviewObMaxBridgeTime { get; set; }

                /// <summary>
                /// <para>双方接听最小通话时长</para>
                /// 
                /// <b>Example:</b>
                /// <para>29</para>
                /// </summary>
                [NameInMap("Preview_ob_min_bridge_time")]
                [Validation(Required=false)]
                public string PreviewObMinBridgeTime { get; set; }

                /// <summary>
                /// <para>双方接听总通话时长</para>
                /// 
                /// <b>Example:</b>
                /// <para>144</para>
                /// </summary>
                [NameInMap("Preview_ob_total_bridge_time")]
                [Validation(Required=false)]
                public string PreviewObTotalBridgeTime { get; set; }

                /// <summary>
                /// <para>预览外呼数</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("Preview_ob_total_count")]
                [Validation(Required=false)]
                public string PreviewObTotalCount { get; set; }

                /// <summary>
                /// <para>预览外呼有效通话次数</para>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("Preview_ob_valid_calls")]
                [Validation(Required=false)]
                public string PreviewObValidCalls { get; set; }

                /// <summary>
                /// <para>预览外呼有效通话总时长</para>
                /// 
                /// <b>Example:</b>
                /// <para>144</para>
                /// </summary>
                [NameInMap("Preview_ob_valid_total_bridge_time")]
                [Validation(Required=false)]
                public string PreviewObValidTotalBridgeTime { get; set; }

                /// <summary>
                /// <para>队列名</para>
                /// 
                /// <b>Example:</b>
                /// <para>示例值</para>
                /// </summary>
                [NameInMap("QueueName")]
                [Validation(Required=false)]
                public string QueueName { get; set; }

            }

            /// <summary>
            /// <para>日期，格式为：yyyy-MM-dd</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-04-06</para>
            /// </summary>
            [NameInMap("Date")]
            [Validation(Required=false)]
            public string Date { get; set; }

            /// <summary>
            /// <para>总计</para>
            /// 
            /// <b>Example:</b>
            /// <para>26</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public string Total { get; set; }

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
        /// <para>9FF70B74-1B3C-44C1-ACDF-8DF962988F0E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
