// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveStreamTranscodeInfoResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("DomainTranscodeList")]
        [Validation(Required=false)]
        public DescribeLiveStreamTranscodeInfoResponseBodyDomainTranscodeList DomainTranscodeList { get; set; }
        public class DescribeLiveStreamTranscodeInfoResponseBodyDomainTranscodeList : TeaModel {
            [NameInMap("DomainTranscodeInfo")]
            [Validation(Required=false)]
            public List<DescribeLiveStreamTranscodeInfoResponseBodyDomainTranscodeListDomainTranscodeInfo> DomainTranscodeInfo { get; set; }
            public class DescribeLiveStreamTranscodeInfoResponseBodyDomainTranscodeListDomainTranscodeInfo : TeaModel {
                public DescribeLiveStreamTranscodeInfoResponseBodyDomainTranscodeListDomainTranscodeInfoCustomTranscodeParameters CustomTranscodeParameters { get; set; }
                public class DescribeLiveStreamTranscodeInfoResponseBodyDomainTranscodeListDomainTranscodeInfoCustomTranscodeParameters : TeaModel {
                    [NameInMap("VideoProfile")]
                    [Validation(Required=false)]
                    public string VideoProfile { get; set; }

                    [NameInMap("AudioBitrate")]
                    [Validation(Required=false)]
                    public int? AudioBitrate { get; set; }

                    [NameInMap("Height")]
                    [Validation(Required=false)]
                    public int? Height { get; set; }

                    [NameInMap("RtsFlag")]
                    [Validation(Required=false)]
                    public string RtsFlag { get; set; }

                    [NameInMap("TemplateType")]
                    [Validation(Required=false)]
                    public string TemplateType { get; set; }

                    [NameInMap("Bframes")]
                    [Validation(Required=false)]
                    public string Bframes { get; set; }

                    [NameInMap("AudioRate")]
                    [Validation(Required=false)]
                    public int? AudioRate { get; set; }

                    [NameInMap("AudioCodec")]
                    [Validation(Required=false)]
                    public string AudioCodec { get; set; }

                    [NameInMap("FPS")]
                    [Validation(Required=false)]
                    public int? FPS { get; set; }

                    [NameInMap("Gop")]
                    [Validation(Required=false)]
                    public string Gop { get; set; }

                    [NameInMap("Width")]
                    [Validation(Required=false)]
                    public int? Width { get; set; }

                    [NameInMap("VideoBitrate")]
                    [Validation(Required=false)]
                    public int? VideoBitrate { get; set; }

                    [NameInMap("AudioChannelNum")]
                    [Validation(Required=false)]
                    public int? AudioChannelNum { get; set; }

                    [NameInMap("AudioProfile")]
                    [Validation(Required=false)]
                    public string AudioProfile { get; set; }

                }
                public string TranscodeApp { get; set; }
                public string TranscodeTemplate { get; set; }
                public DescribeLiveStreamTranscodeInfoResponseBodyDomainTranscodeListDomainTranscodeInfoEncryptParameters EncryptParameters { get; set; }
                public class DescribeLiveStreamTranscodeInfoResponseBodyDomainTranscodeListDomainTranscodeInfoEncryptParameters : TeaModel {
                    [NameInMap("EncryptType")]
                    [Validation(Required=false)]
                    public string EncryptType { get; set; }

                    [NameInMap("KmsKeyID")]
                    [Validation(Required=false)]
                    public string KmsKeyID { get; set; }

                    [NameInMap("KmsKeyExpireInterval")]
                    [Validation(Required=false)]
                    public string KmsKeyExpireInterval { get; set; }

                }
                public string TranscodeName { get; set; }
            }
        };

    }

}
