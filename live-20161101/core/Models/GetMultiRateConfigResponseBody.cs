// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class GetMultiRateConfigResponseBody : TeaModel {
        [NameInMap("App")]
        [Validation(Required=false)]
        public string App { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("IsLazy")]
        [Validation(Required=false)]
        public string IsLazy { get; set; }

        [NameInMap("IsTimeAlign")]
        [Validation(Required=false)]
        public string IsTimeAlign { get; set; }

        [NameInMap("Stream")]
        [Validation(Required=false)]
        public string Stream { get; set; }

        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        [NameInMap("AvFormat")]
        [Validation(Required=false)]
        public string AvFormat { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("TemplatesInfo")]
        [Validation(Required=false)]
        public GetMultiRateConfigResponseBodyTemplatesInfo TemplatesInfo { get; set; }
        public class GetMultiRateConfigResponseBodyTemplatesInfo : TeaModel {
            [NameInMap("Detail")]
            [Validation(Required=false)]
            public List<GetMultiRateConfigResponseBodyTemplatesInfoDetail> Detail { get; set; }
            public class GetMultiRateConfigResponseBodyTemplatesInfoDetail : TeaModel {
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

        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

    }

}
