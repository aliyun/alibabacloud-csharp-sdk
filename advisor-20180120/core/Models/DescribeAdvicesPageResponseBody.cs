// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Advisor20180120.Models
{
    public class DescribeAdvicesPageResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeAdvicesPageResponseBodyData Data { get; set; }
        public class DescribeAdvicesPageResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNo")]
            [Validation(Required=false)]
            public long? PageNo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            [NameInMap("Result")]
            [Validation(Required=false)]
            public List<DescribeAdvicesPageResponseBodyDataResult> Result { get; set; }
            public class DescribeAdvicesPageResponseBodyDataResult : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1234567891234567</para>
                /// </summary>
                [NameInMap("AliyunId")]
                [Validation(Required=false)]
                public long? AliyunId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>EcsHighCpuUtilization</para>
                /// </summary>
                [NameInMap("CheckId")]
                [Validation(Required=false)]
                public string CheckId { get; set; }

                [NameInMap("CheckName")]
                [Validation(Required=false)]
                public string CheckName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>[
                ///     {
                ///         &quot;key&quot;:&quot;EcsHighCpuUtilization_xxxx&quot;,
                ///         &quot;value&quot;:xxx
                ///     },
                ///     {
                ///         &quot;key&quot;:&quot;EcsHighCpuUtilization_xxxx&quot;,
                ///         &quot;value&quot;:xxx
                ///     },
                ///     {
                ///         &quot;key&quot;:&quot;EcsHighCpuUtilization_xxxx&quot;,
                ///         &quot;value&quot;:xxx
                ///     },
                /// ]</para>
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

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

                /// <summary>
                /// <para>ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("IsExpired")]
                [Validation(Required=false)]
                public bool? IsExpired { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ecs</para>
                /// </summary>
                [NameInMap("Product")]
                [Validation(Required=false)]
                public string Product { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>{
                ///     &quot;resourceId&quot;: xxxx,
                ///     &quot;resourceName&quot;: xxxxxx,
                ///     &quot;regionId&quot;: xxxx,
                ///     ...
                /// }</para>
                /// </summary>
                [NameInMap("Resource")]
                [Validation(Required=false)]
                public string Resource { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>i-bp67acfmxazb4p****</para>
                /// </summary>
                [NameInMap("ResourceId")]
                [Validation(Required=false)]
                public string ResourceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Severity")]
                [Validation(Required=false)]
                public long? Severity { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

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
