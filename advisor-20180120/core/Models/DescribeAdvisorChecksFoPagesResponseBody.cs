// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Advisor20180120.Models
{
    public class DescribeAdvisorChecksFoPagesResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeAdvisorChecksFoPagesResponseBodyData> Data { get; set; }
        public class DescribeAdvisorChecksFoPagesResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNo")]
            [Validation(Required=false)]
            public int? PageNo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("Result")]
            [Validation(Required=false)]
            public List<DescribeAdvisorChecksFoPagesResponseBodyDataResult> Result { get; set; }
            public class DescribeAdvisorChecksFoPagesResponseBodyDataResult : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>21</para>
                /// </summary>
                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>EcsCostLowUtilizationCheck</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("ConfigSupport")]
                [Validation(Required=false)]
                public string ConfigSupport { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("InspectionScope")]
                [Validation(Required=false)]
                public string InspectionScope { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>[{\&quot;type\&quot;:\&quot;template\&quot;,\&quot;value\&quot;:\&quot;cloudmonitor.console.aliyun.com/index.htm?custom_trace=ecs_console#/hostDetail/chart/instanceId=${Resource.resourceId}&amp;system=Linux&amp;region=${Resource.regionId}&amp;aliyunhost=true\&quot;,\&quot;key\&quot;:\&quot;Detail\&quot;},{\&quot;type\&quot;:\&quot;template\&quot;,\&quot;value\&quot;:\&quot;/diagnosis?product=${Product}&amp;resourceId=${Resource.resourceId}\&quot;,\&quot;key\&quot;:\&quot;Refresh\&quot;}]</para>
                /// </summary>
                [NameInMap("OperateColumn")]
                [Validation(Required=false)]
                public string OperateColumn { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ECS</para>
                /// </summary>
                [NameInMap("Product")]
                [Validation(Required=false)]
                public string Product { get; set; }

                [NameInMap("RiskLevel")]
                [Validation(Required=false)]
                public long? RiskLevel { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Advisor</para>
                /// </summary>
                [NameInMap("Source")]
                [Validation(Required=false)]
                public string Source { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>enabled</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("SubCategory")]
                [Validation(Required=false)]
                public List<long?> SubCategory { get; set; }

                [NameInMap("Tips")]
                [Validation(Required=false)]
                public string Tips { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>[{\&quot;type\&quot;:\&quot;DEFAULT\&quot;,\&quot;key\&quot;:\&quot;EcsCostIdleCheck_resourceId\&quot;},{\&quot;type\&quot;:\&quot;DEFAULT\&quot;,\&quot;key\&quot;:\&quot;EcsCostIdleCheck_resourceName\&quot;},{\&quot;type\&quot;:\&quot;DEFAULT\&quot;,\&quot;key\&quot;:\&quot;EcsCostIdleCheck_regionId\&quot;},{\&quot;type\&quot;:\&quot;DEFAULT\&quot;,\&quot;key\&quot;:\&quot;EcsCostIdleCheck_instanceChargeType\&quot;},{\&quot;type\&quot;:\&quot;DEFAULT\&quot;,\&quot;key\&quot;:\&quot;EcsCostIdleCheck_instanceType\&quot;},{\&quot;type\&quot;:\&quot;DEFAULT\&quot;,\&quot;key\&quot;:\&quot;EcsCostIdleCheck_severity\&quot;},{\&quot;type\&quot;:\&quot;DEFAULT\&quot;,\&quot;key\&quot;:\&quot;EcsCostIdleCheck_costBefore\&quot;},{\&quot;type\&quot;:\&quot;DEFAULT\&quot;,\&quot;key\&quot;:\&quot;EcsCostIdleCheck_costAfter\&quot;},{\&quot;type\&quot;:\&quot;DEFAULT\&quot;,\&quot;key\&quot;:\&quot;EcsCostIdleCheck_costSavings\&quot;},{\&quot;type\&quot;:\&quot;DEFAULT\&quot;,\&quot;key\&quot;:\&quot;First_time\&quot;},{\&quot;type\&quot;:\&quot;DEFAULT\&quot;,\&quot;key\&quot;:\&quot;Duration_time\&quot;}]</para>
                /// </summary>
                [NameInMap("ViewColumn")]
                [Validation(Required=false)]
                public string ViewColumn { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>566331F9-5AB3-550F-B745-A730331F97A9</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
