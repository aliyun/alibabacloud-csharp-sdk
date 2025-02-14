// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class CreateVodPackagingConfigurationRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>hls_3s</para>
        /// </summary>
        [NameInMap("ConfigurationName")]
        [Validation(Required=false)]
        public string ConfigurationName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>HLS 3s vod packaging</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>vod_hls</para>
        /// </summary>
        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        [NameInMap("PackageConfig")]
        [Validation(Required=false)]
        public CreateVodPackagingConfigurationRequestPackageConfig PackageConfig { get; set; }
        public class CreateVodPackagingConfigurationRequestPackageConfig : TeaModel {
            /// <summary>
            /// <b>if can be null:</b>
            /// <c>true</c>
            /// </summary>
            [NameInMap("DrmProvider")]
            [Validation(Required=false)]
            public CreateVodPackagingConfigurationRequestPackageConfigDrmProvider DrmProvider { get; set; }
            public class CreateVodPackagingConfigurationRequestPackageConfigDrmProvider : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>AES_128</para>
                /// </summary>
                [NameInMap("EncryptionMethod")]
                [Validation(Required=false)]
                public string EncryptionMethod { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>00001111222233334444555566667777</para>
                /// </summary>
                [NameInMap("IV")]
                [Validation(Required=false)]
                public string IV { get; set; }

                [NameInMap("SystemIds")]
                [Validation(Required=false)]
                public List<string> SystemIds { get; set; }

                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>index</para>
            /// </summary>
            [NameInMap("ManifestName")]
            [Validation(Required=false)]
            public string ManifestName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>6</para>
            /// </summary>
            [NameInMap("SegmentDuration")]
            [Validation(Required=false)]
            public long? SegmentDuration { get; set; }

            [NameInMap("StreamSelection")]
            [Validation(Required=false)]
            public CreateVodPackagingConfigurationRequestPackageConfigStreamSelection StreamSelection { get; set; }
            public class CreateVodPackagingConfigurationRequestPackageConfigStreamSelection : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1000000000</para>
                /// </summary>
                [NameInMap("MaxVideoBitsPerSecond")]
                [Validation(Required=false)]
                public long? MaxVideoBitsPerSecond { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100000</para>
                /// </summary>
                [NameInMap("MinVideoBitsPerSecond")]
                [Validation(Required=false)]
                public long? MinVideoBitsPerSecond { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ORIGINAL</para>
                /// </summary>
                [NameInMap("StreamOrder")]
                [Validation(Required=false)]
                public string StreamOrder { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>HLS</para>
        /// </summary>
        [NameInMap("Protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

    }

}
