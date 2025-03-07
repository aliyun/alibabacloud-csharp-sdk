// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class CreateVodPackagingConfigurationRequest : TeaModel {
        /// <summary>
        /// <para>The name of the packaging configuration. The name must be unique in an account and can be up to 128 characters in length. Letters, digits, underscores (_), and hyphens (-) are supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hls_3s</para>
        /// </summary>
        [NameInMap("ConfigurationName")]
        [Validation(Required=false)]
        public string ConfigurationName { get; set; }

        /// <summary>
        /// <para>The description of the packaging configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>HLS 3s vod packaging</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The name of the packaging group. The name can be up to 128 characters in length. Letters, digits, underscores (_), and hyphens (-) are supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vod_hls</para>
        /// </summary>
        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        /// <summary>
        /// <para>The packaging configuration.</para>
        /// </summary>
        [NameInMap("PackageConfig")]
        [Validation(Required=false)]
        public CreateVodPackagingConfigurationRequestPackageConfig PackageConfig { get; set; }
        public class CreateVodPackagingConfigurationRequestPackageConfig : TeaModel {
            /// <summary>
            /// <para>The settings of digital rights management (DRM) encryption.</para>
            /// 
            /// <b>if can be null:</b>
            /// <c>true</c>
            /// </summary>
            [NameInMap("DrmProvider")]
            [Validation(Required=false)]
            public CreateVodPackagingConfigurationRequestPackageConfigDrmProvider DrmProvider { get; set; }
            public class CreateVodPackagingConfigurationRequestPackageConfigDrmProvider : TeaModel {
                /// <summary>
                /// <para>The encryption method. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>AES_128: Advanced Encryption Standard (AES) with 128-bit key length.</description></item>
                /// <item><description>SAMPLE_AES: an encryption method that encrypts individual media samples.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>AES_128</para>
                /// </summary>
                [NameInMap("EncryptionMethod")]
                [Validation(Required=false)]
                public string EncryptionMethod { get; set; }

                /// <summary>
                /// <para>A 128-bit, 16-byte hex value represented by a 32-character string that is used with the key for encrypting data blocks. If you leave this parameter empty, MediaPackage creates a constant initialization vector (IV). If it is specified, the value is passed to the DRM service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>00001111222233334444555566667777</para>
                /// </summary>
                [NameInMap("IV")]
                [Validation(Required=false)]
                public string IV { get; set; }

                /// <summary>
                /// <para>The ID of the DRM system. The maximum number of system IDs allowed is determined by the protocol type. Limits:</para>
                /// <list type="bullet">
                /// <item><description>DASH: 2</description></item>
                /// <item><description>HLS: 1</description></item>
                /// <item><description>HLS_CMAF: 2</description></item>
                /// </list>
                /// <para>Apple FairPlay, Google Widevine, and Microsoft PlayReady are supported. Their system IDs are as follows:</para>
                /// <list type="bullet">
                /// <item><description>Apple FairPlay: 94ce86fb-07ff-4f43-adb8-93d2fa968ca2</description></item>
                /// <item><description>Google Widevine: edef8ba9-79d6-4ace-a3c8-27dcd51d21e</description></item>
                /// <item><description>Microsoft PlayReady: 9a04f079-9840-4286-ab92-e65be0885f95</description></item>
                /// </list>
                /// </summary>
                [NameInMap("SystemIds")]
                [Validation(Required=false)]
                public List<string> SystemIds { get; set; }

                /// <summary>
                /// <para>The URL of the DRM key provider.</para>
                /// </summary>
                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            /// <summary>
            /// <para>The manifest name. The name can be up to 128 characters in length. Letters, digits, underscores (_), and hyphens (-) are supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>index</para>
            /// </summary>
            [NameInMap("ManifestName")]
            [Validation(Required=false)]
            public string ManifestName { get; set; }

            /// <summary>
            /// <para>The duration of each segment in a packaged stream. Unit: seconds. MediaPackage rounds segments to the nearest multiple of the input segment duration. Valid values: 1 to 30.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6</para>
            /// </summary>
            [NameInMap("SegmentDuration")]
            [Validation(Required=false)]
            public long? SegmentDuration { get; set; }

            /// <summary>
            /// <para>The settings of stream selection.</para>
            /// </summary>
            [NameInMap("StreamSelection")]
            [Validation(Required=false)]
            public CreateVodPackagingConfigurationRequestPackageConfigStreamSelection StreamSelection { get; set; }
            public class CreateVodPackagingConfigurationRequestPackageConfigStreamSelection : TeaModel {
                /// <summary>
                /// <para>The maximum bitrate of the video stream. Unit: bit/s.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000000000</para>
                /// </summary>
                [NameInMap("MaxVideoBitsPerSecond")]
                [Validation(Required=false)]
                public long? MaxVideoBitsPerSecond { get; set; }

                /// <summary>
                /// <para>The minimum bitrate of the video stream. Unit: bit/s.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100000</para>
                /// </summary>
                [NameInMap("MinVideoBitsPerSecond")]
                [Validation(Required=false)]
                public long? MinVideoBitsPerSecond { get; set; }

                /// <summary>
                /// <para>The order of manifest files in the master playlist. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>ORIGINAL: sorts the manifest files in the same order as the source.</description></item>
                /// <item><description>VIDEO_BITRATE_ASCENDING: sorts the manifest files in ascending order of bitrates, from lowest to highest.</description></item>
                /// <item><description>VIDEO_BITRATE_DESCENDING: sorts the manifest files in descending order of bitrates, from highest to lowest.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ORIGINAL</para>
                /// </summary>
                [NameInMap("StreamOrder")]
                [Validation(Required=false)]
                public string StreamOrder { get; set; }

            }

        }

        /// <summary>
        /// <para>The package type.</para>
        /// <list type="bullet">
        /// <item><description>HLS: packages content into TS segments for delivery over the HLS protocol.</description></item>
        /// <item><description>HLS_CMAF: packages content into CMAF segments for delivery over the HLS protocol.</description></item>
        /// <item><description>DASH: packages content for delivery over the DASH protocol.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>HLS</para>
        /// </summary>
        [NameInMap("Protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

    }

}
