// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Foasconsole20211028.Models
{
    public class DescribeNamespacesResponseBody : TeaModel {
        [NameInMap("Namespaces")]
        [Validation(Required=false)]
        public List<DescribeNamespacesResponseBodyNamespaces> Namespaces { get; set; }
        public class DescribeNamespacesResponseBodyNamespaces : TeaModel {
            [NameInMap("ElasticResourceSpec")]
            [Validation(Required=false)]
            public DescribeNamespacesResponseBodyNamespacesElasticResourceSpec ElasticResourceSpec { get; set; }
            public class DescribeNamespacesResponseBodyNamespacesElasticResourceSpec : TeaModel {
                [NameInMap("Cpu")]
                [Validation(Required=false)]
                public int? Cpu { get; set; }

                [NameInMap("MemoryGB")]
                [Validation(Required=false)]
                public int? MemoryGB { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1629879567394</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1629879567394</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            [NameInMap("GuaranteedResourceSpec")]
            [Validation(Required=false)]
            public DescribeNamespacesResponseBodyNamespacesGuaranteedResourceSpec GuaranteedResourceSpec { get; set; }
            public class DescribeNamespacesResponseBodyNamespacesGuaranteedResourceSpec : TeaModel {
                [NameInMap("Cpu")]
                [Validation(Required=false)]
                public int? Cpu { get; set; }

                [NameInMap("MemoryGB")]
                [Validation(Required=false)]
                public int? MemoryGB { get; set; }

            }

            [NameInMap("Ha")]
            [Validation(Required=false)]
            public bool? Ha { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ns-1</para>
            /// </summary>
            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            [NameInMap("ResourceSpec")]
            [Validation(Required=false)]
            public DescribeNamespacesResponseBodyNamespacesResourceSpec ResourceSpec { get; set; }
            public class DescribeNamespacesResponseBodyNamespacesResourceSpec : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("Cpu")]
                [Validation(Required=false)]
                public int? Cpu { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>40</para>
                /// </summary>
                [NameInMap("MemoryGB")]
                [Validation(Required=false)]
                public int? MemoryGB { get; set; }

            }

            [NameInMap("ResourceUsed")]
            [Validation(Required=false)]
            public DescribeNamespacesResponseBodyNamespacesResourceUsed ResourceUsed { get; set; }
            public class DescribeNamespacesResponseBodyNamespacesResourceUsed : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Cpu")]
                [Validation(Required=false)]
                public float? Cpu { get; set; }

                [NameInMap("Cu")]
                [Validation(Required=false)]
                public float? Cu { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("MemoryGB")]
                [Validation(Required=false)]
                public float? MemoryGB { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>SUCCESS</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<DescribeNamespacesResponseBodyNamespacesTags> Tags { get; set; }
            public class DescribeNamespacesResponseBodyNamespacesTags : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>flink</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageIndex")]
        [Validation(Required=false)]
        public int? PageIndex { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>67F33190-946B-1105-B6A1-E2DF0426DD51</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalPage")]
        [Validation(Required=false)]
        public int? TotalPage { get; set; }

    }

}
