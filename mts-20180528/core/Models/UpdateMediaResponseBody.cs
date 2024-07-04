// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20180528.Models
{
    public class UpdateMediaResponseBody : TeaModel {
        [NameInMap("Media")]
        [Validation(Required=false)]
        public UpdateMediaResponseBodyMedia Media { get; set; }
        public class UpdateMediaResponseBodyMedia : TeaModel {
            [NameInMap("Bitrate")]
            [Validation(Required=false)]
            public string Bitrate { get; set; }

            [NameInMap("CateId")]
            [Validation(Required=false)]
            public long? CateId { get; set; }

            [NameInMap("CensorState")]
            [Validation(Required=false)]
            public string CensorState { get; set; }

            [NameInMap("CoverURL")]
            [Validation(Required=false)]
            public string CoverURL { get; set; }

            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("Duration")]
            [Validation(Required=false)]
            public string Duration { get; set; }

            [NameInMap("File")]
            [Validation(Required=false)]
            public UpdateMediaResponseBodyMediaFile File { get; set; }
            public class UpdateMediaResponseBodyMediaFile : TeaModel {
                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

                [NameInMap("URL")]
                [Validation(Required=false)]
                public string URL { get; set; }

            }

            [NameInMap("Format")]
            [Validation(Required=false)]
            public string Format { get; set; }

            [NameInMap("Fps")]
            [Validation(Required=false)]
            public string Fps { get; set; }

            [NameInMap("Height")]
            [Validation(Required=false)]
            public string Height { get; set; }

            [NameInMap("MediaId")]
            [Validation(Required=false)]
            public string MediaId { get; set; }

            [NameInMap("PublishState")]
            [Validation(Required=false)]
            public string PublishState { get; set; }

            [NameInMap("RunIdList")]
            [Validation(Required=false)]
            public UpdateMediaResponseBodyMediaRunIdList RunIdList { get; set; }
            public class UpdateMediaResponseBodyMediaRunIdList : TeaModel {
                [NameInMap("RunId")]
                [Validation(Required=false)]
                public List<string> RunId { get; set; }

            }

            [NameInMap("Size")]
            [Validation(Required=false)]
            public string Size { get; set; }

            [NameInMap("Tags")]
            [Validation(Required=false)]
            public UpdateMediaResponseBodyMediaTags Tags { get; set; }
            public class UpdateMediaResponseBodyMediaTags : TeaModel {
                [NameInMap("Tag")]
                [Validation(Required=false)]
                public List<string> Tag { get; set; }

            }

            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            [NameInMap("Width")]
            [Validation(Required=false)]
            public string Width { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
