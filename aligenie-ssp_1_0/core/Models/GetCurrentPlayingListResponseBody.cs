// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGeniessp_1_0.Models
{
    public class GetCurrentPlayingListResponseBody : TeaModel {
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
        public List<GetCurrentPlayingListResponseBodyResult> Result { get; set; }
        public class GetCurrentPlayingListResponseBodyResult : TeaModel {
            [NameInMap("AlbumName")]
            [Validation(Required=false)]
            public string AlbumName { get; set; }

            [NameInMap("AlbumRawId")]
            [Validation(Required=false)]
            public string AlbumRawId { get; set; }

            [NameInMap("AudioLength")]
            [Validation(Required=false)]
            public int? AudioLength { get; set; }

            [NameInMap("Copyright")]
            [Validation(Required=false)]
            public int? Copyright { get; set; }

            [NameInMap("Cover")]
            [Validation(Required=false)]
            public GetCurrentPlayingListResponseBodyResultCover Cover { get; set; }
            public class GetCurrentPlayingListResponseBodyResultCover : TeaModel {
                [NameInMap("CanResize")]
                [Validation(Required=false)]
                public bool? CanResize { get; set; }

                [NameInMap("Img")]
                [Validation(Required=false)]
                public string Img { get; set; }

                [NameInMap("Large")]
                [Validation(Required=false)]
                public string Large { get; set; }

                [NameInMap("Mediam")]
                [Validation(Required=false)]
                public string Mediam { get; set; }

                [NameInMap("Medium")]
                [Validation(Required=false)]
                public string Medium { get; set; }

                [NameInMap("Small")]
                [Validation(Required=false)]
                public string Small { get; set; }

            }

            [NameInMap("DefaultPlayOrder")]
            [Validation(Required=false)]
            public int? DefaultPlayOrder { get; set; }

            [NameInMap("ItemUrl")]
            [Validation(Required=false)]
            public string ItemUrl { get; set; }

            [NameInMap("Liked")]
            [Validation(Required=false)]
            public bool? Liked { get; set; }

            [NameInMap("LyricUrl")]
            [Validation(Required=false)]
            public string LyricUrl { get; set; }

            [NameInMap("PlayMode")]
            [Validation(Required=false)]
            public string PlayMode { get; set; }

            [NameInMap("Pos")]
            [Validation(Required=false)]
            public int? Pos { get; set; }

            [NameInMap("Progress")]
            [Validation(Required=false)]
            public int? Progress { get; set; }

            [NameInMap("RawId")]
            [Validation(Required=false)]
            public string RawId { get; set; }

            [NameInMap("Singer")]
            [Validation(Required=false)]
            public string Singer { get; set; }

            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("Valid")]
            [Validation(Required=false)]
            public string Valid { get; set; }

        }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
