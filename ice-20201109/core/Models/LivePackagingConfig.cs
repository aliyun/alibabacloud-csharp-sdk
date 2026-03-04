// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class LivePackagingConfig : TeaModel {
        /// <summary>
        /// <para>Configuration for the DRM provider. To disable DRM, leave all fields in this object empty.</para>
        /// </summary>
        [NameInMap("DrmConfig")]
        [Validation(Required=false)]
        public LivePackagingConfigDrmConfig DrmConfig { get; set; }
        public class LivePackagingConfigDrmConfig : TeaModel {
            /// <summary>
            /// <para>The content ID in the DRM system. The maximum length is 256 characters. Letters, digits, underscores (_), and hyphens (-) are supported. You must ensure this ID is unique to prevent playback failures.</para>
            /// 
            /// <b>Example:</b>
            /// <para>live-axb1-9dd2fa123</para>
            /// </summary>
            [NameInMap("ContentId")]
            [Validation(Required=false)]
            public string ContentId { get; set; }

            /// <summary>
            /// <para>The encryption method. Valid value:</para>
            /// <list type="bullet">
            /// <item><description>SAMPLE_AES</description></item>
            /// </list>
            /// <para>If not specified, encryption is disabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SAMPLE_AES</para>
            /// </summary>
            [NameInMap("EncryptionMethod")]
            [Validation(Required=false)]
            public string EncryptionMethod { get; set; }

            /// <summary>
            /// <para>A 128-bit, 16-byte hex value represented by a 32-character string that is used with the key for encrypting data blocks. If you leave this parameter empty, MediaPackage creates a constant initialization vector (IV). If it is specified, the value is passed to the DRM service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>00000000000000000000000000000000</para>
            /// </summary>
            [NameInMap("IV")]
            [Validation(Required=false)]
            public string IV { get; set; }

            /// <summary>
            /// <para>The key rotation interval for DRM, in seconds. The default value of 0 disables key rotation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("RotatePeriod")]
            [Validation(Required=false)]
            public int? RotatePeriod { get; set; }

            /// <summary>
            /// <para>The ID of the DRM system. The supported systems depend on the protocol.</para>
            /// <list type="bullet">
            /// <item><description>DASH: Supports Google Widevine and Microsoft PlayReady.</description></item>
            /// <item><description>HLS: DRM is not supported.</description></item>
            /// <item><description>HLS-CMAF: Supports Apple FairPlay, Google Widevine, and Microsoft PlayReady.</description></item>
            /// </list>
            /// <para>The corresponding System IDs are:</para>
            /// <list type="bullet">
            /// <item><description>Apple FairPlay: 94ce86fb-07ff-4f43-adb8-93d2fa968ca2</description></item>
            /// <item><description>Google Widevine: edef8ba9-79d6-4ace-a3c8-27dcd51d21ed</description></item>
            /// <item><description>Microsoft PlayReady: 9a04f079-9840-4286-ab92-e65be0885f95</description></item>
            /// </list>
            /// </summary>
            [NameInMap("SystemIds")]
            [Validation(Required=false)]
            public List<string> SystemIds { get; set; }

            /// <summary>
            /// <para>The URL of the DRM key provider.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://exampledrm.com/path?arg1=xxx">https://exampledrm.com/path?arg1=xxx</a></para>
            /// </summary>
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        /// <summary>
        /// <para>Live stream manifest configuration. Only one configuration is supported.</para>
        /// </summary>
        [NameInMap("LiveManifestConfigs")]
        [Validation(Required=false)]
        public List<LiveManifestConfig> LiveManifestConfigs { get; set; }

        /// <summary>
        /// <para>The duration of each output segment, in seconds. If not set, this defaults to the channel\&quot;s configured segment duration. The final segment duration is a multiple of the source segment duration that is closest to and not less than this value. Valid values: 1 to 30.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("SegmentDuration")]
        [Validation(Required=false)]
        public int? SegmentDuration { get; set; }

        /// <summary>
        /// <para>Specifies whether to create separate audio rendition groups for TS segments.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("UseAudioRenditionGroups")]
        [Validation(Required=false)]
        public bool? UseAudioRenditionGroups { get; set; }

    }

}
