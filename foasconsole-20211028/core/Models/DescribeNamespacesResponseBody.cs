// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Foasconsole20211028.Models
{
    public class DescribeNamespacesResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of namespaces.</para>
        /// </summary>
        [NameInMap("Namespaces")]
        [Validation(Required=false)]
        public List<DescribeNamespacesResponseBodyNamespaces> Namespaces { get; set; }
        public class DescribeNamespacesResponseBodyNamespaces : TeaModel {
            /// <summary>
            /// <para>The elastic resource specifications of the namespace.</para>
            /// </summary>
            [NameInMap("ElasticResourceSpec")]
            [Validation(Required=false)]
            public DescribeNamespacesResponseBodyNamespacesElasticResourceSpec ElasticResourceSpec { get; set; }
            public class DescribeNamespacesResponseBodyNamespacesElasticResourceSpec : TeaModel {
                /// <summary>
                /// <para>The maximum CPU limit for pay-as-you-go resources.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Cpu")]
                [Validation(Required=false)]
                public int? Cpu { get; set; }

                /// <summary>
                /// <para>The maximum memory limit for pay-as-you-go resources, in GB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("MemoryGB")]
                [Validation(Required=false)]
                public int? MemoryGB { get; set; }

            }

            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1629879567394</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// <para>The modification time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1629879567394</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            /// <summary>
            /// <para>The subscription resources allocated to the namespace.</para>
            /// </summary>
            [NameInMap("GuaranteedResourceSpec")]
            [Validation(Required=false)]
            public DescribeNamespacesResponseBodyNamespacesGuaranteedResourceSpec GuaranteedResourceSpec { get; set; }
            public class DescribeNamespacesResponseBodyNamespacesGuaranteedResourceSpec : TeaModel {
                /// <summary>
                /// <para>The number of CPUs for subscription resources.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Cpu")]
                [Validation(Required=false)]
                public int? Cpu { get; set; }

                /// <summary>
                /// <para>The memory size for subscription resources, in GB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("MemoryGB")]
                [Validation(Required=false)]
                public int? MemoryGB { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether zone-disaster recovery is enabled for the namespace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Ha")]
            [Validation(Required=false)]
            public bool? Ha { get; set; }

            /// <summary>
            /// <para>The namespace name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ns-1</para>
            /// </summary>
            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            /// <summary>
            /// <para>The resource specification information.</para>
            /// </summary>
            [NameInMap("ResourceSpec")]
            [Validation(Required=false)]
            public DescribeNamespacesResponseBodyNamespacesResourceSpec ResourceSpec { get; set; }
            public class DescribeNamespacesResponseBodyNamespacesResourceSpec : TeaModel {
                /// <summary>
                /// <para>The number of CPUs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("Cpu")]
                [Validation(Required=false)]
                public int? Cpu { get; set; }

                /// <summary>
                /// <para>The memory size.</para>
                /// 
                /// <b>Example:</b>
                /// <para>40</para>
                /// </summary>
                [NameInMap("MemoryGB")]
                [Validation(Required=false)]
                public int? MemoryGB { get; set; }

            }

            /// <summary>
            /// <para>The resources that have been used.</para>
            /// </summary>
            [NameInMap("ResourceUsed")]
            [Validation(Required=false)]
            public DescribeNamespacesResponseBodyNamespacesResourceUsed ResourceUsed { get; set; }
            public class DescribeNamespacesResponseBodyNamespacesResourceUsed : TeaModel {
                /// <summary>
                /// <para>The number of CPUs used.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Cpu")]
                [Validation(Required=false)]
                public float? Cpu { get; set; }

                /// <summary>
                /// <para>The number of compute units (CUs) used.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Cu")]
                [Validation(Required=false)]
                public float? Cu { get; set; }

                /// <summary>
                /// <para>The amount of memory used.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("MemoryGB")]
                [Validation(Required=false)]
                public float? MemoryGB { get; set; }

            }

            /// <summary>
            /// <para>The namespace status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>CREATING: The namespace is being created.</description></item>
            /// <item><description>DELETING: The namespace is being deleted.</description></item>
            /// <item><description>MODIFYING: The resource specifications are being modified.</description></item>
            /// <item><description>SUCCESS: The last operation succeeded.</description></item>
            /// <item><description>FAILED: The last operation failed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SUCCESS</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The list of tags.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<DescribeNamespacesResponseBodyNamespacesTags> Tags { get; set; }
            public class DescribeNamespacesResponseBodyNamespacesTags : TeaModel {
                /// <summary>
                /// <para>The tag key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>flink</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The tag value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        /// <summary>
        /// <para>The current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageIndex")]
        [Validation(Required=false)]
        public int? PageIndex { get; set; }

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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>67F33190-946B-1105-B6A1-E2DF0426DD51</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The request succeeded.</description></item>
        /// <item><description>false: The request failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        /// <summary>
        /// <para>The total number of pages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalPage")]
        [Validation(Required=false)]
        public int? TotalPage { get; set; }

    }

}
