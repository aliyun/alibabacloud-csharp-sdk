// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Advisor20180120.Models
{
    public class DescribeAdvisorChecksResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeAdvisorChecksResponseBodyData Data { get; set; }
        public class DescribeAdvisorChecksResponseBodyData : TeaModel {
            [NameInMap("AdvisorCheck")]
            [Validation(Required=false)]
            public List<DescribeAdvisorChecksResponseBodyDataAdvisorCheck> AdvisorCheck { get; set; }
            public class DescribeAdvisorChecksResponseBodyDataAdvisorCheck : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>EcsHighCpuUtilization</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2023-07-01 00:00:00</para>
                /// </summary>
                [NameInMap("GmtCreated")]
                [Validation(Required=false)]
                public string GmtCreated { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2023-07-01 00:00:00</para>
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("OperateColumn")]
                [Validation(Required=false)]
                public string OperateColumn { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ecs</para>
                /// </summary>
                [NameInMap("Product")]
                [Validation(Required=false)]
                public string Product { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>enabled</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("Tips")]
                [Validation(Required=false)]
                public string Tips { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>[
                ///     {
                ///         &quot;key&quot;:&quot;EcsHighCpuUtilization_xxxx&quot;,
                ///         &quot;type&quot;:&quot;DEFAULT&quot;
                ///     },
                ///     {
                ///         &quot;key&quot;:&quot;EcsHighCpuUtilization_xxxx&quot;,
                ///         &quot;type&quot;:&quot;DEFAULT&quot;
                ///     },
                ///     {
                ///         &quot;key&quot;:&quot;EcsHighCpuUtilization_xxxx&quot;,
                ///         &quot;type&quot;:&quot;DEFAULT&quot;
                ///     },
                /// ]</para>
                /// </summary>
                [NameInMap("ViewColumn")]
                [Validation(Required=false)]
                public string ViewColumn { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>566331F9-5AB3-550F-B745-A730331F97A9</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
