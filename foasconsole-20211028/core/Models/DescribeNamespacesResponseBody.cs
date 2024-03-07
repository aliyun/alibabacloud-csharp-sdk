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
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            [NameInMap("Ha")]
            [Validation(Required=false)]
            public bool? Ha { get; set; }

            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            [NameInMap("ResourceSpec")]
            [Validation(Required=false)]
            public DescribeNamespacesResponseBodyNamespacesResourceSpec ResourceSpec { get; set; }
            public class DescribeNamespacesResponseBodyNamespacesResourceSpec : TeaModel {
                [NameInMap("Cpu")]
                [Validation(Required=false)]
                public int? Cpu { get; set; }

                [NameInMap("MemoryGB")]
                [Validation(Required=false)]
                public int? MemoryGB { get; set; }

            }

            [NameInMap("ResourceUsed")]
            [Validation(Required=false)]
            public DescribeNamespacesResponseBodyNamespacesResourceUsed ResourceUsed { get; set; }
            public class DescribeNamespacesResponseBodyNamespacesResourceUsed : TeaModel {
                [NameInMap("Cpu")]
                [Validation(Required=false)]
                public float? Cpu { get; set; }

                [NameInMap("Cu")]
                [Validation(Required=false)]
                public float? Cu { get; set; }

                [NameInMap("MemoryGB")]
                [Validation(Required=false)]
                public float? MemoryGB { get; set; }

            }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<DescribeNamespacesResponseBodyNamespacesTags> Tags { get; set; }
            public class DescribeNamespacesResponseBodyNamespacesTags : TeaModel {
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        [NameInMap("PageIndex")]
        [Validation(Required=false)]
        public int? PageIndex { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        [NameInMap("TotalPage")]
        [Validation(Required=false)]
        public int? TotalPage { get; set; }

    }

}
