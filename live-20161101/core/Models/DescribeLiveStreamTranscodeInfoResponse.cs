// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveStreamTranscodeInfoResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("DomainTranscodeList")]
        [Validation(Required=true)]
        public DescribeLiveStreamTranscodeInfoResponseDomainTranscodeList DomainTranscodeList { get; set; }
        public class DescribeLiveStreamTranscodeInfoResponseDomainTranscodeList : TeaModel {
            [NameInMap("DomainTranscodeInfo")]
            [Validation(Required=true)]
            public List<DescribeLiveStreamTranscodeInfoResponseDomainTranscodeListDomainTranscodeInfo> DomainTranscodeInfo { get; set; }
            public class DescribeLiveStreamTranscodeInfoResponseDomainTranscodeListDomainTranscodeInfo : TeaModel {
                public string TranscodeApp { get; set; }
                public string TranscodeName { get; set; }
                public string TranscodeTemplate { get; set; }
                public DescribeLiveStreamTranscodeInfoResponseDomainTranscodeListDomainTranscodeInfoCustomTranscodeParameters CustomTranscodeParameters { get; set; }
                public class DescribeLiveStreamTranscodeInfoResponseDomainTranscodeListDomainTranscodeInfoCustomTranscodeParameters : TeaModel {
                    [NameInMap("RtsFlag")]
                    [Validation(Required=true)]
                    public string RtsFlag { get; set; }

                    [NameInMap("Bframes")]
                    [Validation(Required=true)]
                    public string Bframes { get; set; }

                    [NameInMap("VideoBitrate")]
                    [Validation(Required=true)]
                    public int? VideoBitrate { get; set; }

                    [NameInMap("FPS")]
                    [Validation(Required=true)]
                    public int? FPS { get; set; }

                    [NameInMap("Height")]
                    [Validation(Required=true)]
                    public int? Height { get; set; }

                    [NameInMap("Width")]
                    [Validation(Required=true)]
                    public int? Width { get; set; }

                    [NameInMap("TemplateType")]
                    [Validation(Required=true)]
                    public string TemplateType { get; set; }

                    [NameInMap("VideoProfile")]
                    [Validation(Required=true)]
                    public string VideoProfile { get; set; }

                    [NameInMap("Gop")]
                    [Validation(Required=true)]
                    public string Gop { get; set; }

                    [NameInMap("AudioBitrate")]
                    [Validation(Required=true)]
                    public int? AudioBitrate { get; set; }

                    [NameInMap("AudioProfile")]
                    [Validation(Required=true)]
                    public string AudioProfile { get; set; }

                    [NameInMap("AudioCodec")]
                    [Validation(Required=true)]
                    public string AudioCodec { get; set; }

                    [NameInMap("AudioRate")]
                    [Validation(Required=true)]
                    public int? AudioRate { get; set; }

                    [NameInMap("AudioChannelNum")]
                    [Validation(Required=true)]
                    public int? AudioChannelNum { get; set; }

                }
            }
        };

    }

}
