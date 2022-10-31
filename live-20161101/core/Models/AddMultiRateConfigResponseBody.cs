// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class AddMultiRateConfigResponseBody : TeaModel {
        [NameInMap("Body")]
        [Validation(Required=false)]
        public AddMultiRateConfigResponseBodyBody Body { get; set; }
        public class AddMultiRateConfigResponseBodyBody : TeaModel {
            [NameInMap("FailedTemplates")]
            [Validation(Required=false)]
            public List<AddMultiRateConfigResponseBodyBodyFailedTemplates> FailedTemplates { get; set; }
            public class AddMultiRateConfigResponseBodyBodyFailedTemplates : TeaModel {
                [NameInMap("AudioBitrate")]
                [Validation(Required=false)]
                public int? AudioBitrate { get; set; }

                [NameInMap("AudioChannelNum")]
                [Validation(Required=false)]
                public int? AudioChannelNum { get; set; }

                [NameInMap("AudioCodec")]
                [Validation(Required=false)]
                public string AudioCodec { get; set; }

                [NameInMap("AudioProfile")]
                [Validation(Required=false)]
                public string AudioProfile { get; set; }

                [NameInMap("AudioRate")]
                [Validation(Required=false)]
                public int? AudioRate { get; set; }

                [NameInMap("BandWidth")]
                [Validation(Required=false)]
                public int? BandWidth { get; set; }

                [NameInMap("Fps")]
                [Validation(Required=false)]
                public int? Fps { get; set; }

                [NameInMap("Gop")]
                [Validation(Required=false)]
                public string Gop { get; set; }

                [NameInMap("Height")]
                [Validation(Required=false)]
                public int? Height { get; set; }

                [NameInMap("Profile")]
                [Validation(Required=false)]
                public int? Profile { get; set; }

                [NameInMap("Template")]
                [Validation(Required=false)]
                public string Template { get; set; }

                [NameInMap("TemplateType")]
                [Validation(Required=false)]
                public string TemplateType { get; set; }

                [NameInMap("VideoBitrate")]
                [Validation(Required=false)]
                public int? VideoBitrate { get; set; }

                [NameInMap("Width")]
                [Validation(Required=false)]
                public int? Width { get; set; }

            }

        }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
