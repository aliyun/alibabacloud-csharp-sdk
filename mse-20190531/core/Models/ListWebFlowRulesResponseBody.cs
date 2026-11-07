// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class ListWebFlowRulesResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListWebFlowRulesResponseBodyData Data { get; set; }
        public class ListWebFlowRulesResponseBodyData : TeaModel {
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
            /// <para>The number of entries returned per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The returned results.</para>
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public List<ListWebFlowRulesResponseBodyDataResult> Result { get; set; }
            public class ListWebFlowRulesResponseBodyDataResult : TeaModel {
                /// <summary>
                /// <para>The application ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>hkhon1XXXX@c3df23522bXXXXX</para>
                /// </summary>
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                /// <summary>
                /// <para>The application name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>spring-cloud-a</para>
                /// </summary>
                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                /// <summary>
                /// <para>The number of additional requests allowed for burst requests. The effect is equivalent to the maximum number of tokens for the token bucket algorithm.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Burst")]
                [Validation(Required=false)]
                public int? Burst { get; set; }

                /// <summary>
                /// <para>The flow control method. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>0: fast failure</para>
                /// </description></item>
                /// <item><description><para>2: wait in queue</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ControlBehavior")]
                [Validation(Required=false)]
                public int? ControlBehavior { get; set; }

                /// <summary>
                /// <para>Indicates whether the rule is enabled or disabled.</para>
                /// <list type="bullet">
                /// <item><description><para><c>true</c>: enabled.</para>
                /// </description></item>
                /// <item><description><para><c>false</c>: disabled.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Enable")]
                [Validation(Required=false)]
                public bool? Enable { get; set; }

                /// <summary>
                /// <para>The behavior that was bound to the rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{\&quot;appName\&quot;:\&quot;spring-cloud-a\&quot;,\&quot;fallbackBehavior\&quot;:{\&quot;webFallbackMode\&quot;:0,\&quot;webRespContentType\&quot;:0,\&quot;webRespMessage\&quot;:\&quot;Blocked\&quot;,\&quot;webRespStatusCode\&quot;:429},\&quot;id\&quot;:977,\&quot;name\&quot;:\&quot;Fallback\&quot;,\&quot;namespace\&quot;:\&quot;default\&quot;,\&quot;resourceClassification\&quot;:1}</para>
                /// </summary>
                [NameInMap("FallbackObject")]
                [Validation(Required=false)]
                public string FallbackObject { get; set; }

                /// <summary>
                /// <para>The timeout period for queuing when the ControlBehavior parameter is set to 2. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("MaxQueueingTimeMs")]
                [Validation(Required=false)]
                public int? MaxQueueingTimeMs { get; set; }

                /// <summary>
                /// <para>The threshold type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>1: number of requests</description></item>
                /// </list>
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
                /// <para>The parameter description item, which is a JSON string containing the following key-value pairs:</para>
                /// <list type="bullet">
                /// <item><description><para>parseStrategy: the parameter property (0: client IP address. 1: remote host. 2: header. 3: URL parameter)</para>
                /// </description></item>
                /// <item><description><para>fieldName: the header name or URL parameter name. You must specify this key only if parseStrategy is set to 2 or 3</para>
                /// </description></item>
                /// <item><description><para>matchStrategy: the method to match the property value. You must specify this key only if parseStrategy is set to 2 or 3 and the property value is matched. Valid values: 0 (exact match), 2 (regular expression match), and 3 (substring match)</para>
                /// </description></item>
                /// <item><description><para>pattern: the match string. You must specify this key only if parseStrategy is set to 2 or 3 and the property value is matched</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;fieldName&quot;:&quot;testKey&quot;,&quot;matchStrategy&quot;:2,&quot;parseStrategy&quot;:2,&quot;pattern&quot;:&quot;testValue&quot;}</para>
                /// </summary>
                [NameInMap("ParamItem")]
                [Validation(Required=false)]
                public string ParamItem { get; set; }

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
                /// <para>The name of the interface resource.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/flow</para>
                /// </summary>
                [NameInMap("Resource")]
                [Validation(Required=false)]
                public string Resource { get; set; }

                /// <summary>
                /// <para>The resource mode. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>0: resource name mode</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ResourceMode")]
                [Validation(Required=false)]
                public int? ResourceMode { get; set; }

                /// <summary>
                /// <para>The resource type</para>
                /// <list type="bullet">
                /// <item><description><para>0: custom interface</para>
                /// </description></item>
                /// <item><description><para>1: WEB</para>
                /// </description></item>
                /// <item><description><para>2: RPC</para>
                /// </description></item>
                /// </list>
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
                /// <para>1</para>
                /// </summary>
                [NameInMap("RuleId")]
                [Validation(Required=false)]
                public string RuleId { get; set; }

                /// <summary>
                /// <para>The length of the time window. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("StatIntervalMs")]
                [Validation(Required=false)]
                public int? StatIntervalMs { get; set; }

                /// <summary>
                /// <para>The threshold.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("Threshold")]
                [Validation(Required=false)]
                public float? Threshold { get; set; }

            }

            /// <summary>
            /// <para>The total number of queried rules.</para>
            /// 
            /// <b>Example:</b>
            /// <para>36</para>
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
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4AE73569-304C-5AA9-AE11-C1D99C7D1689</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c>: The request was successful.</para>
        /// </description></item>
        /// <item><description><para><c>false</c>: The request failed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
