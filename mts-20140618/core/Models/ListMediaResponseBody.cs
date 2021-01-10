// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class ListMediaResponseBody : TeaModel {
        [NameInMap("MediaList")]
        [Validation(Required=false)]
        public ListMediaResponseBodyMediaList MediaList { get; set; }
        public class ListMediaResponseBodyMediaList : TeaModel {
            [NameInMap("Media")]
            [Validation(Required=false)]
            public List<ListMediaResponseBodyMediaListMedia> Media { get; set; }
            public class ListMediaResponseBodyMediaListMedia : TeaModel {
                public string CreationTime { get; set; }
                public long? CateId { get; set; }
                public string Height { get; set; }
                public string CensorState { get; set; }
                public ListMediaResponseBodyMediaListMediaTags Tags { get; set; }
                public class ListMediaResponseBodyMediaListMediaTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<string> Tag { get; set; }

                }
                public string Bitrate { get; set; }
                public string MediaId { get; set; }
                public ListMediaResponseBodyMediaListMediaFile File { get; set; }
                public class ListMediaResponseBodyMediaListMediaFile : TeaModel {
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
                public ListMediaResponseBodyMediaListMediaRunIdList RunIdList { get; set; }
                public class ListMediaResponseBodyMediaListMediaRunIdList : TeaModel {
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

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("NextPageToken")]
        [Validation(Required=false)]
        public string NextPageToken { get; set; }

    }

}
