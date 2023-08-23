// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGeniessp_1_0.Models
{
    public class GetAlbumDetailByIdResponseBody : TeaModel {
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
        public GetAlbumDetailByIdResponseBodyResult Result { get; set; }
        public class GetAlbumDetailByIdResponseBodyResult : TeaModel {
            [NameInMap("AlbumContentList")]
            [Validation(Required=false)]
            public List<GetAlbumDetailByIdResponseBodyResultAlbumContentList> AlbumContentList { get; set; }
            public class GetAlbumDetailByIdResponseBodyResultAlbumContentList : TeaModel {
                [NameInMap("Duration")]
                [Validation(Required=false)]
                public string Duration { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("OrderIndex")]
                [Validation(Required=false)]
                public string OrderIndex { get; set; }

                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

            [NameInMap("AlbumCoverUrl")]
            [Validation(Required=false)]
            public string AlbumCoverUrl { get; set; }

            [NameInMap("AlbumDescription")]
            [Validation(Required=false)]
            public string AlbumDescription { get; set; }

            [NameInMap("AlbumId")]
            [Validation(Required=false)]
            public string AlbumId { get; set; }

            [NameInMap("AlbumTitle")]
            [Validation(Required=false)]
            public string AlbumTitle { get; set; }

        }

    }

}
