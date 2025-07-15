// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveStreamTranscodeInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The transcoding configurations.</para>
        /// </summary>
        [NameInMap("DomainTranscodeList")]
        [Validation(Required=false)]
        public DescribeLiveStreamTranscodeInfoResponseBodyDomainTranscodeList DomainTranscodeList { get; set; }
        public class DescribeLiveStreamTranscodeInfoResponseBodyDomainTranscodeList : TeaModel {
            [NameInMap("DomainTranscodeInfo")]
            [Validation(Required=false)]
            public List<DescribeLiveStreamTranscodeInfoResponseBodyDomainTranscodeListDomainTranscodeInfo> DomainTranscodeInfo { get; set; }
            public class DescribeLiveStreamTranscodeInfoResponseBodyDomainTranscodeListDomainTranscodeInfo : TeaModel {
                /// <summary>
                /// <para>The custom transcoding configuration.</para>
                /// </summary>
                [NameInMap("CustomTranscodeParameters")]
                [Validation(Required=false)]
                public DescribeLiveStreamTranscodeInfoResponseBodyDomainTranscodeListDomainTranscodeInfoCustomTranscodeParameters CustomTranscodeParameters { get; set; }
                public class DescribeLiveStreamTranscodeInfoResponseBodyDomainTranscodeListDomainTranscodeInfoCustomTranscodeParameters : TeaModel {
                    /// <summary>
                    /// <para>The bitrate of the output audio. Unit: Kbit/s. Valid values: <b>1 to 1000</b>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>64</para>
                    /// </summary>
                    [NameInMap("AudioBitrate")]
                    [Validation(Required=false)]
                    public int? AudioBitrate { get; set; }

                    /// <summary>
                    /// <para>The number of sound channels. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>1</b>: mono</description></item>
                    /// <item><description><b>2</b>: binaural</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("AudioChannelNum")]
                    [Validation(Required=false)]
                    public int? AudioChannelNum { get; set; }

                    /// <summary>
                    /// <para>The audio encoding format.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ACC</para>
                    /// </summary>
                    [NameInMap("AudioCodec")]
                    [Validation(Required=false)]
                    public string AudioCodec { get; set; }

                    /// <summary>
                    /// <para>The audio encoding profile. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>aac_low</b></description></item>
                    /// <item><description><b>aac_he</b></description></item>
                    /// <item><description><b>aac_he_v2</b></description></item>
                    /// <item><description><b>aac_ld</b></description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>aac_low</para>
                    /// </summary>
                    [NameInMap("AudioProfile")]
                    [Validation(Required=false)]
                    public string AudioProfile { get; set; }

                    /// <summary>
                    /// <para>The audio sampling rate. Valid values: <b>22050 to 96000</b>.</para>
                    /// <remarks>
                    /// <para> If the value of AudioProfile is <b>aac_ld</b>, the audio sampling rate cannot exceed 44100.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>44100</para>
                    /// </summary>
                    [NameInMap("AudioRate")]
                    [Validation(Required=false)]
                    public int? AudioRate { get; set; }

                    /// <summary>
                    /// <para>Indicates whether B-frame removal is enabled. Fixed value: <b>0</b>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("Bframes")]
                    [Validation(Required=false)]
                    public string Bframes { get; set; }

                    /// <summary>
                    /// <para>The source-based bitrate settings.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{\&quot;UpLimit\&quot;:2500,\&quot;LowerLimit\&quot;:800,\&quot;Factor\&quot;:1}</para>
                    /// </summary>
                    [NameInMap("BitrateWithSource")]
                    [Validation(Required=false)]
                    public Dictionary<string, object> BitrateWithSource { get; set; }

                    /// <summary>
                    /// <para>Other source-based settings.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{\&quot;KeyFrameOpen\&quot;:\&quot;yes\&quot;,\&quot;Copyts\&quot;:\&quot;yes\&quot;,\&quot;SeiMode\&quot;:1}</para>
                    /// </summary>
                    [NameInMap("ExtWithSource")]
                    [Validation(Required=false)]
                    public Dictionary<string, object> ExtWithSource { get; set; }

                    /// <summary>
                    /// <para>The frame rate of the output video. Unit: frames per second (FPS).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>15</para>
                    /// </summary>
                    [NameInMap("FPS")]
                    [Validation(Required=false)]
                    public int? FPS { get; set; }

                    /// <summary>
                    /// <para>The source-based frame rate settings.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{\&quot;UpLimit\&quot;:60,\&quot;LowerLimit\&quot;:1}</para>
                    /// </summary>
                    [NameInMap("FpsWithSource")]
                    [Validation(Required=false)]
                    public Dictionary<string, object> FpsWithSource { get; set; }

                    /// <summary>
                    /// <para>The group of pictures (GOP) size of the output video. Unit: frames. Valid values: <b>1 to 3000</b>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("Gop")]
                    [Validation(Required=false)]
                    public string Gop { get; set; }

                    /// <summary>
                    /// <para>The height of the output video.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1200</para>
                    /// </summary>
                    [NameInMap("Height")]
                    [Validation(Required=false)]
                    public int? Height { get; set; }

                    /// <summary>
                    /// <para>The source-based resolution settings.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{\&quot;Type\&quot;:\&quot;short\&quot;,\&quot;Value\&quot;:\&quot;1080\&quot;}</para>
                    /// </summary>
                    [NameInMap("ResWithSource")]
                    [Validation(Required=false)]
                    public Dictionary<string, object> ResWithSource { get; set; }

                    /// <summary>
                    /// <para>The Real-Time Transcoding (RTS) flag. Fixed value: <b>true</b>.</para>
                    /// <remarks>
                    /// <para> This parameter is returned only if RTS is used for transcoding.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("RtsFlag")]
                    [Validation(Required=false)]
                    public string RtsFlag { get; set; }

                    /// <summary>
                    /// <para>The type of the custom transcoding template. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>h264</b>: custom H.264 standard transcoding</description></item>
                    /// <item><description><b>h264-nbhd</b>: custom H.264 Narrowband HD™ transcoding</description></item>
                    /// <item><description><b>h265</b>: custom H.265 standard transcoding</description></item>
                    /// <item><description><b>h265-nbhd</b>: custom H.265 Narrowband HD™ transcoding</description></item>
                    /// <item><description><b>audio</b>: audio-only transcoding</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>h264</para>
                    /// </summary>
                    [NameInMap("TemplateType")]
                    [Validation(Required=false)]
                    public string TemplateType { get; set; }

                    /// <summary>
                    /// <para>The bitrate of the output video. Unit: Kbit/s.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>3000</para>
                    /// </summary>
                    [NameInMap("VideoBitrate")]
                    [Validation(Required=false)]
                    public int? VideoBitrate { get; set; }

                    /// <summary>
                    /// <para>The video encoding profile. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>baseline</b>: suitable for mobile devices.</description></item>
                    /// <item><description><b>main</b>: suitable for standard-definition devices.</description></item>
                    /// <item><description><b>high</b>: suitable for high-definition devices.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>high</para>
                    /// </summary>
                    [NameInMap("VideoProfile")]
                    [Validation(Required=false)]
                    public string VideoProfile { get; set; }

                    /// <summary>
                    /// <para>The width of the output video.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("Width")]
                    [Validation(Required=false)]
                    public int? Width { get; set; }

                }

                /// <summary>
                /// <para>The encryption settings.</para>
                /// </summary>
                [NameInMap("EncryptParameters")]
                [Validation(Required=false)]
                public DescribeLiveStreamTranscodeInfoResponseBodyDomainTranscodeListDomainTranscodeInfoEncryptParameters EncryptParameters { get; set; }
                public class DescribeLiveStreamTranscodeInfoResponseBodyDomainTranscodeListDomainTranscodeInfoEncryptParameters : TeaModel {
                    /// <summary>
                    /// <para>The type of encryption. Fixed value: <b>aliyun</b>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>aliyun</para>
                    /// </summary>
                    [NameInMap("EncryptType")]
                    [Validation(Required=false)]
                    public string EncryptType { get; set; }

                    /// <summary>
                    /// <para>The rotation period of the CMK. Valid values: <b>60 to 3600</b>. Unit: seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>3600</para>
                    /// </summary>
                    [NameInMap("KmsKeyExpireInterval")]
                    [Validation(Required=false)]
                    public string KmsKeyExpireInterval { get; set; }

                    /// <summary>
                    /// <para>The ID of the customer master key (CMK) in Key Management Service (KMS).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>afce5722-81d2-43c3-9930-7601da11****</para>
                    /// </summary>
                    [NameInMap("KmsKeyID")]
                    [Validation(Required=false)]
                    public string KmsKeyID { get; set; }

                }

                /// <summary>
                /// <para>Indicates whether forcible transcoding is used. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b>: Delayed transcoding is used.</description></item>
                /// <item><description><b>false</b>: Forcible transcoding is used.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("IsLazy")]
                [Validation(Required=false)]
                public bool? IsLazy { get; set; }

                /// <summary>
                /// <para>The application name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>liveApp****</para>
                /// </summary>
                [NameInMap("TranscodeApp")]
                [Validation(Required=false)]
                public string TranscodeApp { get; set; }

                /// <summary>
                /// <para>The main streaming domain.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example.com</para>
                /// </summary>
                [NameInMap("TranscodeName")]
                [Validation(Required=false)]
                public string TranscodeName { get; set; }

                /// <summary>
                /// <para>The transcoding template ID. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>Standard transcoding</b>:</para>
                /// <list type="bullet">
                /// <item><description><b>lld</b>: low definition</description></item>
                /// <item><description><b>lsd</b>: standard definition</description></item>
                /// <item><description><b>lhd</b>: high definition</description></item>
                /// <item><description><b>lud</b>: ultra-high definition</description></item>
                /// </list>
                /// </description></item>
                /// <item><description><para><b>Narrowband HD™ transcoding</b>:</para>
                /// <list type="bullet">
                /// <item><description><b>ld</b>: low definition</description></item>
                /// <item><description><b>sd</b>: standard definition</description></item>
                /// <item><description><b>hd</b>: high definition</description></item>
                /// <item><description><b>ud</b>: ultra-high definition</description></item>
                /// </list>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>lld</para>
                /// </summary>
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
