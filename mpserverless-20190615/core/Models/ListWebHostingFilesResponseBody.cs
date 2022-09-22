// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MPServerless20190615.Models
{
    public class ListWebHostingFilesResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListWebHostingFilesResponseBodyData Data { get; set; }
        public class ListWebHostingFilesResponseBodyData : TeaModel {
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            [NameInMap("NextMarker")]
            [Validation(Required=false)]
            public string NextMarker { get; set; }

            [NameInMap("WebHostingFiles")]
            [Validation(Required=false)]
            public List<ListWebHostingFilesResponseBodyDataWebHostingFiles> WebHostingFiles { get; set; }
            public class ListWebHostingFilesResponseBodyDataWebHostingFiles : TeaModel {
                [NameInMap("ContentType")]
                [Validation(Required=false)]
                public string ContentType { get; set; }

                [NameInMap("ETag")]
                [Validation(Required=false)]
                public string ETag { get; set; }

                [NameInMap("FilePath")]
                [Validation(Required=false)]
                public string FilePath { get; set; }

                [NameInMap("LastModifiedTime")]
                [Validation(Required=false)]
                public long? LastModifiedTime { get; set; }

                [NameInMap("SignedUrl")]
                [Validation(Required=false)]
                public string SignedUrl { get; set; }

                [NameInMap("Size")]
                [Validation(Required=false)]
                public long? Size { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
