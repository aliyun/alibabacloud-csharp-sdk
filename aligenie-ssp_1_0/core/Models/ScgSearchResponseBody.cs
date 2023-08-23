// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGeniessp_1_0.Models
{
    public class ScgSearchResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<ScgSearchResponseBodyResult> Result { get; set; }
        public class ScgSearchResponseBodyResult : TeaModel {
            [NameInMap("Album")]
            [Validation(Required=false)]
            public bool? Album { get; set; }

            [NameInMap("AlbumRawId")]
            [Validation(Required=false)]
            public string AlbumRawId { get; set; }

            [NameInMap("AlbumType")]
            [Validation(Required=false)]
            public int? AlbumType { get; set; }

            [NameInMap("Alias")]
            [Validation(Required=false)]
            public List<string> Alias { get; set; }

            [NameInMap("AuthorIds")]
            [Validation(Required=false)]
            public List<long?> AuthorIds { get; set; }

            [NameInMap("AuthorNames")]
            [Validation(Required=false)]
            public List<string> AuthorNames { get; set; }

            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            [NameInMap("ContentType")]
            [Validation(Required=false)]
            public string ContentType { get; set; }

            [NameInMap("Cover")]
            [Validation(Required=false)]
            public ScgSearchResponseBodyResultCover Cover { get; set; }
            public class ScgSearchResponseBodyResultCover : TeaModel {
                [NameInMap("Img")]
                [Validation(Required=false)]
                public string Img { get; set; }

                [NameInMap("Large")]
                [Validation(Required=false)]
                public string Large { get; set; }

                [NameInMap("Medium")]
                [Validation(Required=false)]
                public string Medium { get; set; }

                [NameInMap("Small")]
                [Validation(Required=false)]
                public string Small { get; set; }

                [NameInMap("canResize")]
                [Validation(Required=false)]
                public bool? CanResize { get; set; }

            }

            [NameInMap("IsAudition")]
            [Validation(Required=false)]
            public bool? IsAudition { get; set; }

            [NameInMap("IsCharge")]
            [Validation(Required=false)]
            public string IsCharge { get; set; }

            [NameInMap("NeedCharge")]
            [Validation(Required=false)]
            public bool? NeedCharge { get; set; }

            [NameInMap("RawId")]
            [Validation(Required=false)]
            public string RawId { get; set; }

            [NameInMap("Singers")]
            [Validation(Required=false)]
            public string Singers { get; set; }

            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            [NameInMap("SupportAudition")]
            [Validation(Required=false)]
            public bool? SupportAudition { get; set; }

            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
