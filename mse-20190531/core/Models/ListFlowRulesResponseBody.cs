// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class ListFlowRulesResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The node data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListFlowRulesResponseBodyData Data { get; set; }
        public class ListFlowRulesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The returned collection.</para>
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public List<ListFlowRulesResponseBodyDataResult> Result { get; set; }
            public class ListFlowRulesResponseBodyDataResult : TeaModel {
                /// <summary>
                /// <para>The application ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>hkhon1po62@5f1b08becb*****</para>
                /// </summary>
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                /// <summary>
                /// <para>The application name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>finance</para>
                /// </summary>
                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                /// <summary>
                /// <para>The flow control behavior.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ControlBehavior")]
                [Validation(Required=false)]
                public int? ControlBehavior { get; set; }

                /// <summary>
                /// <para>Indicates whether the rule is enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Enable")]
                [Validation(Required=false)]
                public bool? Enable { get; set; }

                /// <summary>
                /// <para>The fallback behavior.</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;{\&quot;appName\&quot;:\&quot;spring-cloud-a\&quot;,\&quot;fallbackBehavior\&quot;:{\&quot;webFallbackMode\&quot;:0,\&quot;webRespContentType\&quot;:0,\&quot;webRespMessage\&quot;:\&quot;Blocked\&quot;,\&quot;webRespStatusCode\&quot;:429},\&quot;id\&quot;:977,\&quot;name\&quot;:\&quot;Fallback\&quot;,\&quot;namespace\&quot;:\&quot;default\&quot;,\&quot;resourceClassification\&quot;:1}&quot;</para>
                /// </summary>
                [NameInMap("FallbackObject")]
                [Validation(Required=false)]
                public string FallbackObject { get; set; }

                /// <summary>
                /// <para>The source application of the request.</para>
                /// 
                /// <b>Example:</b>
                /// <para>spring-cloud-a</para>
                /// </summary>
                [NameInMap("LimitApp")]
                [Validation(Required=false)]
                public string LimitApp { get; set; }

                /// <summary>
                /// <para>The timeout period in milliseconds when the flow control behavior is set to queuing.</para>
                /// 
                /// <b>Example:</b>
                /// <para>500</para>
                /// </summary>
                [NameInMap("MaxQueueingTimeMs")]
                [Validation(Required=false)]
                public int? MaxQueueingTimeMs { get; set; }

                /// <summary>
                /// <para>The statistical dimension. A value of 1 indicates the number of passed requests.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("MetricType")]
                [Validation(Required=false)]
                public int? MetricType { get; set; }

                /// <summary>
                /// <para>The namespace.</para>
                /// 
                /// <b>Example:</b>
                /// <para>default</para>
                /// </summary>
                [NameInMap("Namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

                /// <summary>
                /// <para>The region ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The API resource name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/a</para>
                /// </summary>
                [NameInMap("Resource")]
                [Validation(Required=false)]
                public string Resource { get; set; }

                /// <summary>
                /// <para>The API resource category.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ResourceType")]
                [Validation(Required=false)]
                public int? ResourceType { get; set; }

                /// <summary>
                /// <para>The rule ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("RuleId")]
                [Validation(Required=false)]
                public long? RuleId { get; set; }

                /// <summary>
                /// <para>The threshold of the flow control rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("Threshold")]
                [Validation(Required=false)]
                public float? Threshold { get; set; }

                /// <summary>
                /// <para>The reserved field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{\&quot;origin\&quot;:\&quot;default\&quot;}</para>
                /// </summary>
                [NameInMap("TrafficTags")]
                [Validation(Required=false)]
                public Dictionary<string, object> TrafficTags { get; set; }

            }

            /// <summary>
            /// <para>The total number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>11</para>
            /// </summary>
            [NameInMap("TotalSize")]
            [Validation(Required=false)]
            public int? TotalSize { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The request is processed successfully.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>316F5F64-F73D-42DC-8632-01E308B6****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
