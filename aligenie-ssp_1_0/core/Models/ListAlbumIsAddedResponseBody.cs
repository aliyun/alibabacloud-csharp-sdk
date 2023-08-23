// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGeniessp_1_0.Models
{
    public class ListAlbumIsAddedResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<ListAlbumIsAddedResponseBodyResult> Result { get; set; }
        public class ListAlbumIsAddedResponseBodyResult : TeaModel {
            [NameInMap("AlbumId")]
            [Validation(Required=false)]
            public string AlbumId { get; set; }

            [NameInMap("IsAdded")]
            [Validation(Required=false)]
            public string IsAdded { get; set; }

        }

    }

}
