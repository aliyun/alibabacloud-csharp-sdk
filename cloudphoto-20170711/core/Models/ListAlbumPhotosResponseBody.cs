// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudPhoto20170711.Models
{
    public class ListAlbumPhotosResponseBody : TeaModel {
        [NameInMap("Action")]
        [Validation(Required=false)]
        public string Action { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("NextCursor")]
        [Validation(Required=false)]
        public string NextCursor { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Results")]
        [Validation(Required=false)]
        public List<ListAlbumPhotosResponseBodyResults> Results { get; set; }
        public class ListAlbumPhotosResponseBodyResults : TeaModel {
            [NameInMap("PhotoIdStr")]
            [Validation(Required=false)]
            public string PhotoIdStr { get; set; }

            [NameInMap("Mtime")]
            [Validation(Required=false)]
            public long? Mtime { get; set; }

            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            [NameInMap("PhotoId")]
            [Validation(Required=false)]
            public long? PhotoId { get; set; }

        }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

    }

}
