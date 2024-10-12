// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class ListResourcesResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1e195c5116124202371861018d5bde</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Resources")]
        [Validation(Required=false)]
        public List<ListResourcesResponseBodyResources> Resources { get; set; }
        public class ListResourcesResponseBodyResources : TeaModel {
            [NameInMap("Encryption")]
            [Validation(Required=false)]
            public ListResourcesResponseBodyResourcesEncryption Encryption { get; set; }
            public class ListResourcesResponseBodyResourcesEncryption : TeaModel {
                [NameInMap("Algorithm")]
                [Validation(Required=false)]
                public string Algorithm { get; set; }

                [NameInMap("Enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>prod</para>
            /// </summary>
            [NameInMap("EnvType")]
            [Validation(Required=false)]
            public string EnvType { get; set; }

            [NameInMap("Executor")]
            [Validation(Required=false)]
            public ListResourcesResponseBodyResourcesExecutor Executor { get; set; }
            public class ListResourcesResponseBodyResourcesExecutor : TeaModel {
                [NameInMap("OwnerId")]
                [Validation(Required=false)]
                public string OwnerId { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2021-01-21T17:12:35.232Z</para>
            /// </summary>
            [NameInMap("GmtCreateTime")]
            [Validation(Required=false)]
            public string GmtCreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>groupName</para>
            /// </summary>
            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsDefault")]
            [Validation(Required=false)]
            public bool? IsDefault { get; set; }

            [NameInMap("Labels")]
            [Validation(Required=false)]
            public List<ListResourcesResponseBodyResourcesLabels> Labels { get; set; }
            public class ListResourcesResponseBodyResourcesLabels : TeaModel {
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ResourceName</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>MaxCompute</para>
            /// </summary>
            [NameInMap("ProductType")]
            [Validation(Required=false)]
            public string ProductType { get; set; }

            [NameInMap("Quotas")]
            [Validation(Required=false)]
            public List<ListResourcesResponseBodyResourcesQuotas> Quotas { get; set; }
            public class ListResourcesResponseBodyResourcesQuotas : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>cpu</para>
                /// </summary>
                [NameInMap("CardType")]
                [Validation(Required=false)]
                public string CardType { get; set; }

                [NameInMap("DisplayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>develop</para>
                /// </summary>
                [NameInMap("Mode")]
                [Validation(Required=false)]
                public string Mode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>QuotaName</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>MaxCompute_isolate</para>
                /// </summary>
                [NameInMap("ProductCode")]
                [Validation(Required=false)]
                public string ProductCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>MaxCompute</para>
                /// </summary>
                [NameInMap("QuotaType")]
                [Validation(Required=false)]
                public string QuotaType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>{\&quot;cu\&quot;:\&quot;11500\&quot;,\&quot;minCu\&quot;:\&quot;2300\&quot;,\&quot;parentId\&quot;:\&quot;0\&quot;}</para>
                /// </summary>
                [NameInMap("Specs")]
                [Validation(Required=false)]
                public List<ListResourcesResponseBodyResourcesQuotasSpecs> Specs { get; set; }
                public class ListResourcesResponseBodyResourcesQuotasSpecs : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>cu</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>11500</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

            }

            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>对于MaxCompute {&quot;Endpoint&quot;: &quot;odps.alibaba-inc.com&quot;, &quot;Project&quot;: &quot;mignshi&quot;}</para>
            /// </summary>
            [NameInMap("Spec")]
            [Validation(Required=false)]
            public Dictionary<string, object> Spec { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("WorkspaceId")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
