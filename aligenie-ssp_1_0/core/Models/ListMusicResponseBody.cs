// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGeniessp_1_0.Models
{
    public class ListMusicResponseBody : TeaModel {
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
        public ListMusicResponseBodyResult Result { get; set; }
        public class ListMusicResponseBodyResult : TeaModel {
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            [NameInMap("Model")]
            [Validation(Required=false)]
            public List<ListMusicResponseBodyResultModel> Model { get; set; }
            public class ListMusicResponseBodyResultModel : TeaModel {
                [NameInMap("MusicId")]
                [Validation(Required=false)]
                public long? MusicId { get; set; }

                [NameInMap("MusicName")]
                [Validation(Required=false)]
                public string MusicName { get; set; }

                [NameInMap("MusicType")]
                [Validation(Required=false)]
                public long? MusicType { get; set; }

                [NameInMap("MusicTypeName")]
                [Validation(Required=false)]
                public string MusicTypeName { get; set; }

                [NameInMap("MusicUrl")]
                [Validation(Required=false)]
                public string MusicUrl { get; set; }

            }

            [NameInMap("PageCount")]
            [Validation(Required=false)]
            public int? PageCount { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

    }

}
