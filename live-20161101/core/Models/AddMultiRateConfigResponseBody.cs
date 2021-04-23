// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class AddMultiRateConfigResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Body")]
        [Validation(Required=false)]
        public AddMultiRateConfigResponseBodyBody Body { get; set; }
        public class AddMultiRateConfigResponseBodyBody : TeaModel {
            [NameInMap("FailedTemplates")]
            [Validation(Required=false)]
            public List<AddMultiRateConfigResponseBodyBodyFailedTemplates> FailedTemplates { get; set; }
            public class AddMultiRateConfigResponseBodyBodyFailedTemplates : TeaModel {
                public int? AudioBitrate { get; set; }
                public int? Height { get; set; }
                public string Template { get; set; }
                public string TemplateType { get; set; }
                public int? BandWidth { get; set; }
                public int? Profile { get; set; }
                public int? AudioRate { get; set; }
                public string AudioCodec { get; set; }
                public string Gop { get; set; }
                public int? VideoBitrate { get; set; }
                public int? Width { get; set; }
                public int? AudioChannelNum { get; set; }
                public int? Fps { get; set; }
                public string AudioProfile { get; set; }
            }
        };

    }

}
