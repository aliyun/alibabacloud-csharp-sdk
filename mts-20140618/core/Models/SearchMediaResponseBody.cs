// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class SearchMediaResponseBody : TeaModel {
        [NameInMap("MediaList")]
        [Validation(Required=false)]
        public SearchMediaResponseBodyMediaList MediaList { get; set; }
        public class SearchMediaResponseBodyMediaList : TeaModel {
            [NameInMap("Media")]
            [Validation(Required=false)]
            public List<SearchMediaResponseBodyMediaListMedia> Media { get; set; }
            public class SearchMediaResponseBodyMediaListMedia : TeaModel {
                public string CreationTime { get; set; }
                public long? CateId { get; set; }
                public string Height { get; set; }
                public SearchMediaResponseBodyMediaListMediaTags Tags { get; set; }
                public class SearchMediaResponseBodyMediaListMediaTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<string> Tag { get; set; }

                }
                public string Bitrate { get; set; }
                public string MediaId { get; set; }
                public SearchMediaResponseBodyMediaListMediaFile File { get; set; }
                public class SearchMediaResponseBodyMediaListMediaFile : TeaModel {
                    [NameInMap("State")]
                    [Validation(Required=false)]
                    public string State { get; set; }

                    [NameInMap("URL")]
                    [Validation(Required=false)]
                    public string URL { get; set; }

                }
                public string PublishState { get; set; }
                public string Description { get; set; }
                public string Width { get; set; }
                public string Size { get; set; }
                public string CoverURL { get; set; }
                public SearchMediaResponseBodyMediaListMediaRunIdList RunIdList { get; set; }
                public class SearchMediaResponseBodyMediaListMediaRunIdList : TeaModel {
                    [NameInMap("RunId")]
                    [Validation(Required=false)]
                    public List<string> RunId { get; set; }

                }
                public string Duration { get; set; }
                public string Fps { get; set; }
                public string Title { get; set; }
                public string Format { get; set; }
            }
        };

        [NameInMap("TotalNum")]
        [Validation(Required=false)]
        public long? TotalNum { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

    }

}
