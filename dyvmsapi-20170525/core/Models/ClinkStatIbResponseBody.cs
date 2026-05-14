// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class ClinkStatIbResponseBody : TeaModel {
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
        public ClinkStatIbResponseBodyData Data { get; set; }
        public class ClinkStatIbResponseBodyData : TeaModel {
            /// <summary>
            /// <para>请求 id</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("ClinkRequestId")]
            [Validation(Required=false)]
            public string ClinkRequestId { get; set; }

            /// <summary>
            /// <para>报表数据（注：时长字段单位均为秒）</para>
            /// </summary>
            [NameInMap("StatIb")]
            [Validation(Required=false)]
            public List<ClinkStatIbResponseBodyDataStatIb> StatIb { get; set; }
            public class ClinkStatIbResponseBodyDataStatIb : TeaModel {
                /// <summary>
                /// <para>接听电话座席数</para>
                /// 
                /// <b>Example:</b>
                /// <para>96</para>
                /// </summary>
                [NameInMap("AnsweredAgentCount")]
                [Validation(Required=false)]
                public long? AnsweredAgentCount { get; set; }

                /// <summary>
                /// <para>人均接听量</para>
                /// 
                /// <b>Example:</b>
                /// <para>6</para>
                /// </summary>
                [NameInMap("AvgAnsweredAgentCount")]
                [Validation(Required=false)]
                public long? AvgAnsweredAgentCount { get; set; }

                /// <summary>
                /// <para>日期（统计方式2为同步日期；统计方式3为分时信息，例 0-1时）</para>
                /// 
                /// <b>Example:</b>
                /// <para>20240203</para>
                /// </summary>
                [NameInMap("Date")]
                [Validation(Required=false)]
                public string Date { get; set; }

                /// <summary>
                /// <para>热线号码</para>
                /// 
                /// <b>Example:</b>
                /// <para>Hotline</para>
                /// </summary>
                [NameInMap("Hotline")]
                [Validation(Required=false)]
                public string Hotline { get; set; }

                /// <summary>
                /// <para>热线别名</para>
                /// 
                /// <b>Example:</b>
                /// <para>HotlineName</para>
                /// </summary>
                [NameInMap("HotlineName")]
                [Validation(Required=false)]
                public string HotlineName { get; set; }

                /// <summary>
                /// <para>呼叫座席来电总数</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("IbAgentCount")]
                [Validation(Required=false)]
                public long? IbAgentCount { get; set; }

                /// <summary>
                /// <para>人工接听数</para>
                /// 
                /// <b>Example:</b>
                /// <para>56</para>
                /// </summary>
                [NameInMap("IbAnsweredCount")]
                [Validation(Required=false)]
                public long? IbAnsweredCount { get; set; }

                /// <summary>
                /// <para>人工接听排队总时长</para>
                /// 
                /// <b>Example:</b>
                /// <para>90</para>
                /// </summary>
                [NameInMap("IbAnsweredQueueDuration")]
                [Validation(Required=false)]
                public long? IbAnsweredQueueDuration { get; set; }

                /// <summary>
                /// <para>呼入人工接听率</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.28</para>
                /// </summary>
                [NameInMap("IbAnsweredRate")]
                [Validation(Required=false)]
                public double? IbAnsweredRate { get; set; }

                /// <summary>
                /// <para>人工接听平均排队时长</para>
                /// 
                /// <b>Example:</b>
                /// <para>93</para>
                /// </summary>
                [NameInMap("IbAvgAnsweredQueueDuration")]
                [Validation(Required=false)]
                public long? IbAvgAnsweredQueueDuration { get; set; }

                /// <summary>
                /// <para>呼入平均通话时长</para>
                /// 
                /// <b>Example:</b>
                /// <para>19</para>
                /// </summary>
                [NameInMap("IbAvgBridgeDuration")]
                [Validation(Required=false)]
                public long? IbAvgBridgeDuration { get; set; }

                /// <summary>
                /// <para>呼入平均时长</para>
                /// 
                /// <b>Example:</b>
                /// <para>98</para>
                /// </summary>
                [NameInMap("IbAvgDuration")]
                [Validation(Required=false)]
                public long? IbAvgDuration { get; set; }

                /// <summary>
                /// <para>进入队列平均排队时长</para>
                /// 
                /// <b>Example:</b>
                /// <para>40</para>
                /// </summary>
                [NameInMap("IbAvgQueueDuration")]
                [Validation(Required=false)]
                public long? IbAvgQueueDuration { get; set; }

                /// <summary>
                /// <para>机器人应答数</para>
                /// 
                /// <b>Example:</b>
                /// <para>36</para>
                /// </summary>
                [NameInMap("IbBotAnsweredCount")]
                [Validation(Required=false)]
                public long? IbBotAnsweredCount { get; set; }

                /// <summary>
                /// <para>机器人未应答数</para>
                /// 
                /// <b>Example:</b>
                /// <para>79</para>
                /// </summary>
                [NameInMap("IbBotUnansweredCount")]
                [Validation(Required=false)]
                public long? IbBotUnansweredCount { get; set; }

                /// <summary>
                /// <para>呼入通话总时长（客户侧）</para>
                /// 
                /// <b>Example:</b>
                /// <para>28</para>
                /// </summary>
                [NameInMap("IbBridgeDuration")]
                [Validation(Required=false)]
                public long? IbBridgeDuration { get; set; }

                /// <summary>
                /// <para>直转座席数</para>
                /// 
                /// <b>Example:</b>
                /// <para>61</para>
                /// </summary>
                [NameInMap("IbDirectAgentCount")]
                [Validation(Required=false)]
                public long? IbDirectAgentCount { get; set; }

                /// <summary>
                /// <para>直转队列数</para>
                /// 
                /// <b>Example:</b>
                /// <para>18</para>
                /// </summary>
                [NameInMap("IbDirectQueueCount")]
                [Validation(Required=false)]
                public long? IbDirectQueueCount { get; set; }

                /// <summary>
                /// <para>直转电话/IP话机数</para>
                /// 
                /// <b>Example:</b>
                /// <para>81</para>
                /// </summary>
                [NameInMap("IbDirectTelCount")]
                [Validation(Required=false)]
                public long? IbDirectTelCount { get; set; }

                /// <summary>
                /// <para>进入IVR人工接听数</para>
                /// 
                /// <b>Example:</b>
                /// <para>17</para>
                /// </summary>
                [NameInMap("IbIvrAnsweredCount")]
                [Validation(Required=false)]
                public long? IbIvrAnsweredCount { get; set; }

                /// <summary>
                /// <para>进入IVR数</para>
                /// 
                /// <b>Example:</b>
                /// <para>45</para>
                /// </summary>
                [NameInMap("IbIvrCount")]
                [Validation(Required=false)]
                public long? IbIvrCount { get; set; }

                /// <summary>
                /// <para>进入IVR未转队列数</para>
                /// 
                /// <b>Example:</b>
                /// <para>73</para>
                /// </summary>
                [NameInMap("IbIvrNoQueueCount")]
                [Validation(Required=false)]
                public long? IbIvrNoQueueCount { get; set; }

                /// <summary>
                /// <para>进入IVR转队列数</para>
                /// 
                /// <b>Example:</b>
                /// <para>94</para>
                /// </summary>
                [NameInMap("IbIvrQueueCount")]
                [Validation(Required=false)]
                public long? IbIvrQueueCount { get; set; }

                /// <summary>
                /// <para>进入IVR客户速挂</para>
                /// 
                /// <b>Example:</b>
                /// <para>18</para>
                /// </summary>
                [NameInMap("IbIvrQuickUnlinkCount")]
                [Validation(Required=false)]
                public long? IbIvrQuickUnlinkCount { get; set; }

                /// <summary>
                /// <para>进入IVR系统应答数</para>
                /// 
                /// <b>Example:</b>
                /// <para>12</para>
                /// </summary>
                [NameInMap("IbIvrSystemAnsweredCount")]
                [Validation(Required=false)]
                public long? IbIvrSystemAnsweredCount { get; set; }

                /// <summary>
                /// <para>进入IVR人工未接听数</para>
                /// 
                /// <b>Example:</b>
                /// <para>70</para>
                /// </summary>
                [NameInMap("IbIvrUnAnsweredCount")]
                [Validation(Required=false)]
                public long? IbIvrUnAnsweredCount { get; set; }

                /// <summary>
                /// <para>未进入IVR数</para>
                /// 
                /// <b>Example:</b>
                /// <para>12</para>
                /// </summary>
                [NameInMap("IbNoIvrCount")]
                [Validation(Required=false)]
                public long? IbNoIvrCount { get; set; }

                /// <summary>
                /// <para>进入队列来电通数</para>
                /// 
                /// <b>Example:</b>
                /// <para>91</para>
                /// </summary>
                [NameInMap("IbQueueCount")]
                [Validation(Required=false)]
                public long? IbQueueCount { get; set; }

                /// <summary>
                /// <para>进入队列排队总时长</para>
                /// 
                /// <b>Example:</b>
                /// <para>79</para>
                /// </summary>
                [NameInMap("IbQueueDuration")]
                [Validation(Required=false)]
                public long? IbQueueDuration { get; set; }

                /// <summary>
                /// <para>黑名单来电数</para>
                /// 
                /// <b>Example:</b>
                /// <para>90</para>
                /// </summary>
                [NameInMap("IbRestrictCount")]
                [Validation(Required=false)]
                public long? IbRestrictCount { get; set; }

                /// <summary>
                /// <para>X秒接听数</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("IbRingingRangeCount")]
                [Validation(Required=false)]
                public long? IbRingingRangeCount { get; set; }

                /// <summary>
                /// <para>X秒接听率</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.43</para>
                /// </summary>
                [NameInMap("IbRingingRangeRate")]
                [Validation(Required=false)]
                public double? IbRingingRangeRate { get; set; }

                /// <summary>
                /// <para>系统应答数</para>
                /// 
                /// <b>Example:</b>
                /// <para>25</para>
                /// </summary>
                [NameInMap("IbSystemAnsweredCount")]
                [Validation(Required=false)]
                public long? IbSystemAnsweredCount { get; set; }

                /// <summary>
                /// <para>系统未应答数</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("IbSystemUnAnsweredCount")]
                [Validation(Required=false)]
                public long? IbSystemUnAnsweredCount { get; set; }

                /// <summary>
                /// <para>来电总通数</para>
                /// 
                /// <b>Example:</b>
                /// <para>40</para>
                /// </summary>
                [NameInMap("IbTotalCount")]
                [Validation(Required=false)]
                public long? IbTotalCount { get; set; }

                /// <summary>
                /// <para>人工未接听数</para>
                /// 
                /// <b>Example:</b>
                /// <para>70</para>
                /// </summary>
                [NameInMap("IbUnansweredCount")]
                [Validation(Required=false)]
                public long? IbUnansweredCount { get; set; }

                /// <summary>
                /// <para>VIP呼入数</para>
                /// 
                /// <b>Example:</b>
                /// <para>77</para>
                /// </summary>
                [NameInMap("IbVipCount")]
                [Validation(Required=false)]
                public long? IbVipCount { get; set; }

                /// <summary>
                /// <para>网上400呼入数</para>
                /// 
                /// <b>Example:</b>
                /// <para>53</para>
                /// </summary>
                [NameInMap("IbWebCount")]
                [Validation(Required=false)]
                public long? IbWebCount { get; set; }

                /// <summary>
                /// <para>呼入总时长</para>
                /// 
                /// <b>Example:</b>
                /// <para>69</para>
                /// </summary>
                [NameInMap("IbtotalDuration")]
                [Validation(Required=false)]
                public long? IbtotalDuration { get; set; }

                /// <summary>
                /// <para>进入IVR直转电话/IP话机人工接听数</para>
                /// 
                /// <b>Example:</b>
                /// <para>95</para>
                /// </summary>
                [NameInMap("IvrDirectTelAnsweredCount")]
                [Validation(Required=false)]
                public long? IvrDirectTelAnsweredCount { get; set; }

                /// <summary>
                /// <para>进入IVR直转电话/IP话机数</para>
                /// 
                /// <b>Example:</b>
                /// <para>88</para>
                /// </summary>
                [NameInMap("IvrDirectTelCount")]
                [Validation(Required=false)]
                public long? IvrDirectTelCount { get; set; }

                /// <summary>
                /// <para>进入IVR直转电话/IP话机系统应答数</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("IvrDirectTelSysAnsweredCount")]
                [Validation(Required=false)]
                public long? IvrDirectTelSysAnsweredCount { get; set; }

                /// <summary>
                /// <para>进入IVR直转电话/IP话机人工未接听数</para>
                /// 
                /// <b>Example:</b>
                /// <para>75</para>
                /// </summary>
                [NameInMap("IvrDirectTelUnansweredCount")]
                [Validation(Required=false)]
                public long? IvrDirectTelUnansweredCount { get; set; }

                /// <summary>
                /// <para>客户速挂数</para>
                /// 
                /// <b>Example:</b>
                /// <para>67</para>
                /// </summary>
                [NameInMap("QuickUnlinkCount")]
                [Validation(Required=false)]
                public long? QuickUnlinkCount { get; set; }

                /// <summary>
                /// <para>热线重复来电数</para>
                /// 
                /// <b>Example:</b>
                /// <para>14</para>
                /// </summary>
                [NameInMap("RepeatHotlineCount")]
                [Validation(Required=false)]
                public long? RepeatHotlineCount { get; set; }

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
        /// <para>A90E4451-FED7-49D2-87C8-00700A8C4D0D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
