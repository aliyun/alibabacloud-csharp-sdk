// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class ListResourcesResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public ListResourcesResponseBodyData Data { get; set; }
        public class ListResourcesResponseBodyData : TeaModel {
            [NameInMap("marker")]
            [Validation(Required=false)]
            public string Marker { get; set; }

            [NameInMap("maxItem")]
            [Validation(Required=false)]
            public int? MaxItem { get; set; }

            [NameInMap("resources")]
            [Validation(Required=false)]
            public List<ListResourcesResponseBodyDataResources> Resources { get; set; }
            public class ListResourcesResponseBodyDataResources : TeaModel {
                [NameInMap("comment")]
                [Validation(Required=false)]
                public string Comment { get; set; }

                [NameInMap("contentMD5")]
                [Validation(Required=false)]
                public string ContentMD5 { get; set; }

                [NameInMap("creationTime")]
                [Validation(Required=false)]
                public long? CreationTime { get; set; }

                [NameInMap("displayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                [NameInMap("lastModifiedTime")]
                [Validation(Required=false)]
                public long? LastModifiedTime { get; set; }

                [NameInMap("lastUpdator")]
                [Validation(Required=false)]
                public string LastUpdator { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }

                [NameInMap("schema")]
                [Validation(Required=false)]
                public string Schema { get; set; }

                [NameInMap("size")]
                [Validation(Required=false)]
                public long? Size { get; set; }

                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
