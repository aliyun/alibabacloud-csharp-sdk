// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class CloudOutboundPreviewObReportResponseBody : TeaModel {
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
        public CloudOutboundPreviewObReportResponseBodyData Data { get; set; }
        public class CloudOutboundPreviewObReportResponseBodyData : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<CloudOutboundPreviewObReportResponseBodyDataList> List { get; set; }
            public class CloudOutboundPreviewObReportResponseBodyDataList : TeaModel {
                /// <summary>
                /// <para>座席接听数</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("AgentAnsweredCount")]
                [Validation(Required=false)]
                public string AgentAnsweredCount { get; set; }

                /// <summary>
                /// <para>座席姓名</para>
                /// 
                /// <b>Example:</b>
                /// <para>name3</para>
                /// </summary>
                [NameInMap("AgentName")]
                [Validation(Required=false)]
                public string AgentName { get; set; }

                /// <summary>
                /// <para>座席接听率</para>
                /// 
                /// <b>Example:</b>
                /// <para>100%</para>
                /// </summary>
                [NameInMap("AgentRate")]
                [Validation(Required=false)]
                public string AgentRate { get; set; }

                /// <summary>
                /// <para>平均通话时长</para>
                /// 
                /// <b>Example:</b>
                /// <para>00:00:12</para>
                /// </summary>
                [NameInMap("AvgBridgeTime")]
                [Validation(Required=false)]
                public string AvgBridgeTime { get; set; }

                /// <summary>
                /// <para>AXB双方接听数</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("AxbBothAnsweredCount")]
                [Validation(Required=false)]
                public string AxbBothAnsweredCount { get; set; }

                /// <summary>
                /// <para>AXB双方接听率 = AXB双方接听数 / AXB外呼总数</para>
                /// 
                /// <b>Example:</b>
                /// <para>0%</para>
                /// </summary>
                [NameInMap("AxbBothAnsweredRate")]
                [Validation(Required=false)]
                public string AxbBothAnsweredRate { get; set; }

                /// <summary>
                /// <para>AXB外呼双方接听分钟数</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("AxbBothAnsweredTime")]
                [Validation(Required=false)]
                public string AxbBothAnsweredTime { get; set; }

                /// <summary>
                /// <para>AXB外呼总数</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("AxbObTotalCount")]
                [Validation(Required=false)]
                public string AxbObTotalCount { get; set; }

                /// <summary>
                /// <para>双方接听数</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("BothAnsweredCount")]
                [Validation(Required=false)]
                public string BothAnsweredCount { get; set; }

                /// <summary>
                /// <para>双方接听时长</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("BothAnsweredTime")]
                [Validation(Required=false)]
                public string BothAnsweredTime { get; set; }

                /// <summary>
                /// <para>呼叫接通率</para>
                /// 
                /// <b>Example:</b>
                /// <para>100%</para>
                /// </summary>
                [NameInMap("CallBridgedRate")]
                [Validation(Required=false)]
                public string CallBridgedRate { get; set; }

                /// <summary>
                /// <para>发起呼叫次数</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("CallTotalCount")]
                [Validation(Required=false)]
                public string CallTotalCount { get; set; }

                /// <summary>
                /// <para>座席工号</para>
                /// 
                /// <b>Example:</b>
                /// <para>3008</para>
                /// </summary>
                [NameInMap("Cno")]
                [Validation(Required=false)]
                public string Cno { get; set; }

                /// <summary>
                /// <para>客户接听数</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("CustomerAnsweredCount")]
                [Validation(Required=false)]
                public string CustomerAnsweredCount { get; set; }

                /// <summary>
                /// <para>客户接听率</para>
                /// 
                /// <b>Example:</b>
                /// <para>100%</para>
                /// </summary>
                [NameInMap("CustomerRate")]
                [Validation(Required=false)]
                public string CustomerRate { get; set; }

                /// <summary>
                /// <para>统计周期</para>
                /// 
                /// <b>Example:</b>
                /// <para>示例值</para>
                /// </summary>
                [NameInMap("DateTimeRange")]
                [Validation(Required=false)]
                public string DateTimeRange { get; set; }

                /// <summary>
                /// <para>企业Id</para>
                /// 
                /// <b>Example:</b>
                /// <para>6000001</para>
                /// </summary>
                [NameInMap("EnterpriseId")]
                [Validation(Required=false)]
                public string EnterpriseId { get; set; }

                /// <summary>
                /// <para>拦截次数</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("InterceptionCount")]
                [Validation(Required=false)]
                public string InterceptionCount { get; set; }

                /// <summary>
                /// <para>拦截率</para>
                /// 
                /// <b>Example:</b>
                /// <para>0%</para>
                /// </summary>
                [NameInMap("InterceptionRate")]
                [Validation(Required=false)]
                public string InterceptionRate { get; set; }

                /// <summary>
                /// <para>固话双方接听数</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("LandlineBothAnsweredCount")]
                [Validation(Required=false)]
                public string LandlineBothAnsweredCount { get; set; }

                /// <summary>
                /// <para>固话双方接听率 = 固话双方接听数 / 固话外呼总数</para>
                /// 
                /// <b>Example:</b>
                /// <para>100%</para>
                /// </summary>
                [NameInMap("LandlineBothAnsweredRate")]
                [Validation(Required=false)]
                public string LandlineBothAnsweredRate { get; set; }

                /// <summary>
                /// <para>固话双方接听分钟数</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("LandlineBothAnsweredTime")]
                [Validation(Required=false)]
                public string LandlineBothAnsweredTime { get; set; }

                /// <summary>
                /// <para>固话外呼总数</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("LandlineObTotalCount")]
                [Validation(Required=false)]
                public string LandlineObTotalCount { get; set; }

                /// <summary>
                /// <para>最长通话时长</para>
                /// 
                /// <b>Example:</b>
                /// <para>00:00:14</para>
                /// </summary>
                [NameInMap("MaxBridgeTime")]
                [Validation(Required=false)]
                public string MaxBridgeTime { get; set; }

                /// <summary>
                /// <para>最短通话时长</para>
                /// 
                /// <b>Example:</b>
                /// <para>00:00:11</para>
                /// </summary>
                [NameInMap("MinBridgeTime")]
                [Validation(Required=false)]
                public string MinBridgeTime { get; set; }

                /// <summary>
                /// <para>总通话时长</para>
                /// 
                /// <b>Example:</b>
                /// <para>00:00:38</para>
                /// </summary>
                [NameInMap("TotalBridgeTime")]
                [Validation(Required=false)]
                public string TotalBridgeTime { get; set; }

                /// <summary>
                /// <para>外呼总数</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("TotalCount")]
                [Validation(Required=false)]
                public string TotalCount { get; set; }

                /// <summary>
                /// <para>通话占比</para>
                /// 
                /// <b>Example:</b>
                /// <para>0%</para>
                /// </summary>
                [NameInMap("VadRate")]
                [Validation(Required=false)]
                public string VadRate { get; set; }

                /// <summary>
                /// <para>有效通话平均通话时长</para>
                /// 
                /// <b>Example:</b>
                /// <para>00:00:12</para>
                /// </summary>
                [NameInMap("ValidAvgBridgeTime")]
                [Validation(Required=false)]
                public string ValidAvgBridgeTime { get; set; }

                /// <summary>
                /// <para>有效通话次数</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("ValidCalls")]
                [Validation(Required=false)]
                public string ValidCalls { get; set; }

                /// <summary>
                /// <para>有效通话总通话时长</para>
                /// 
                /// <b>Example:</b>
                /// <para>00:00:38</para>
                /// </summary>
                [NameInMap("ValidTotalBridgeTime")]
                [Validation(Required=false)]
                public string ValidTotalBridgeTime { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public string PageSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public string TotalCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalPageCount")]
            [Validation(Required=false)]
            public string TotalPageCount { get; set; }

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
