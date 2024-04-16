// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Miniapplcdp20200113.Models
{
    public class ListArtifactsResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListArtifactsResponseBodyData Data { get; set; }
        public class ListArtifactsResponseBodyData : TeaModel {
            [NameInMap("Items")]
            [Validation(Required=false)]
            public List<ListArtifactsResponseBodyDataItems> Items { get; set; }
            public class ListArtifactsResponseBodyDataItems : TeaModel {
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                [NameInMap("ArtifactId")]
                [Validation(Required=false)]
                public string ArtifactId { get; set; }

                [NameInMap("ArtifactType")]
                [Validation(Required=false)]
                public string ArtifactType { get; set; }

                [NameInMap("Available")]
                [Validation(Required=false)]
                public bool? Available { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("ModifiedTime")]
                [Validation(Required=false)]
                public string ModifiedTime { get; set; }

                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
