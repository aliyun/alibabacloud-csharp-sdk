// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveStreamTranscodeInfoResponseBody : TeaModel {
        [NameInMap("DomainTranscodeList")]
        [Validation(Required=false)]
        public DescribeLiveStreamTranscodeInfoResponseBodyDomainTranscodeList DomainTranscodeList { get; set; }
        public class DescribeLiveStreamTranscodeInfoResponseBodyDomainTranscodeList : TeaModel {
            [NameInMap("DomainTranscodeInfo")]
            [Validation(Required=false)]
            public List<DescribeLiveStreamTranscodeInfoResponseBodyDomainTranscodeListDomainTranscodeInfo> DomainTranscodeInfo { get; set; }
            public class DescribeLiveStreamTranscodeInfoResponseBodyDomainTranscodeListDomainTranscodeInfo : TeaModel {
                [NameInMap("CustomTranscodeParameters")]
                [Validation(Required=false)]
                public DescribeLiveStreamTranscodeInfoResponseBodyDomainTranscodeListDomainTranscodeInfoCustomTranscodeParameters CustomTranscodeParameters { get; set; }
                public class DescribeLiveStreamTranscodeInfoResponseBodyDomainTranscodeListDomainTranscodeInfoCustomTranscodeParameters : TeaModel {
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

                    [NameInMap("Bframes")]
                    [Validation(Required=false)]
                    public string Bframes { get; set; }

                    [NameInMap("BitrateWithSource")]
                    [Validation(Required=false)]
                    public Dictionary<string, object> BitrateWithSource { get; set; }

                    [NameInMap("DeInterlaced")]
                    [Validation(Required=false)]
                    public bool? DeInterlaced { get; set; }

                    [NameInMap("ExtWithSource")]
                    [Validation(Required=false)]
                    public Dictionary<string, object> ExtWithSource { get; set; }

                    [NameInMap("FPS")]
                    [Validation(Required=false)]
                    public int? FPS { get; set; }

                    [NameInMap("FpsWithSource")]
                    [Validation(Required=false)]
                    public Dictionary<string, object> FpsWithSource { get; set; }

                    [NameInMap("Gop")]
                    [Validation(Required=false)]
                    public string Gop { get; set; }

                    [NameInMap("Height")]
                    [Validation(Required=false)]
                    public int? Height { get; set; }

                    [NameInMap("ResWithSource")]
                    [Validation(Required=false)]
                    public Dictionary<string, object> ResWithSource { get; set; }

                    [NameInMap("RtsFlag")]
                    [Validation(Required=false)]
                    public string RtsFlag { get; set; }

                    [NameInMap("TemplateType")]
                    [Validation(Required=false)]
                    public string TemplateType { get; set; }

                    [NameInMap("VideoBitrate")]
                    [Validation(Required=false)]
                    public int? VideoBitrate { get; set; }

                    [NameInMap("VideoProfile")]
                    [Validation(Required=false)]
                    public string VideoProfile { get; set; }

                    [NameInMap("Width")]
                    [Validation(Required=false)]
                    public int? Width { get; set; }

                }

                [NameInMap("EncryptParameters")]
                [Validation(Required=false)]
                public DescribeLiveStreamTranscodeInfoResponseBodyDomainTranscodeListDomainTranscodeInfoEncryptParameters EncryptParameters { get; set; }
                public class DescribeLiveStreamTranscodeInfoResponseBodyDomainTranscodeListDomainTranscodeInfoEncryptParameters : TeaModel {
                    [NameInMap("EncryptType")]
                    [Validation(Required=false)]
                    public string EncryptType { get; set; }

                    [NameInMap("KmsKeyExpireInterval")]
                    [Validation(Required=false)]
                    public string KmsKeyExpireInterval { get; set; }

                    [NameInMap("KmsKeyID")]
                    [Validation(Required=false)]
                    public string KmsKeyID { get; set; }

                }

                [NameInMap("IsLazy")]
                [Validation(Required=false)]
                public bool? IsLazy { get; set; }

                [NameInMap("TranscodeApp")]
                [Validation(Required=false)]
                public string TranscodeApp { get; set; }

                [NameInMap("TranscodeName")]
                [Validation(Required=false)]
                public string TranscodeName { get; set; }

                [NameInMap("TranscodeTemplate")]
                [Validation(Required=false)]
                public string TranscodeTemplate { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>62136AE6-7793-45ED-B14A-60D19A9486D3</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
