// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ListDataStreamsResponseBody : TeaModel {
        [NameInMap("Headers")]
        [Validation(Required=false)]
        public ListDataStreamsResponseBodyHeaders Headers { get; set; }
        public class ListDataStreamsResponseBodyHeaders : TeaModel {
            [NameInMap("X-Managed-Count")]
            [Validation(Required=false)]
            public int? XManagedCount { get; set; }
            [NameInMap("X-Managed-StorageSize")]
            [Validation(Required=false)]
            public long? XManagedStorageSize { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<ListDataStreamsResponseBodyResult> Result { get; set; }
        public class ListDataStreamsResponseBodyResult : TeaModel {
            [NameInMap("health")]
            [Validation(Required=false)]
            public string Health { get; set; }

            [NameInMap("ilmPolicyName")]
            [Validation(Required=false)]
            public string IlmPolicyName { get; set; }

            [NameInMap("indexTemplateName")]
            [Validation(Required=false)]
            public string IndexTemplateName { get; set; }

            [NameInMap("indices")]
            [Validation(Required=false)]
            public List<ListDataStreamsResponseBodyResultIndices> Indices { get; set; }
            public class ListDataStreamsResponseBodyResultIndices : TeaModel {
                [NameInMap("createTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("health")]
                [Validation(Required=false)]
                public string Health { get; set; }

                [NameInMap("isManaged")]
                [Validation(Required=false)]
                public bool? IsManaged { get; set; }

                [NameInMap("managedStatus")]
                [Validation(Required=false)]
                public string ManagedStatus { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("size")]
                [Validation(Required=false)]
                public long? Size { get; set; }

            }

            [NameInMap("managedStorageSize")]
            [Validation(Required=false)]
            public long? ManagedStorageSize { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("totalStorageSize")]
            [Validation(Required=false)]
            public long? TotalStorageSize { get; set; }

        }

    }

}
