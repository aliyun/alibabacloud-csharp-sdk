// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GetVodPackagingAssetResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the asset.</para>
        /// </summary>
        [NameInMap("Asset")]
        [Validation(Required=false)]
        public GetVodPackagingAssetResponseBodyAsset Asset { get; set; }
        public class GetVodPackagingAssetResponseBodyAsset : TeaModel {
            /// <summary>
            /// <para>The name of the asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30min_movie</para>
            /// </summary>
            [NameInMap("AssetName")]
            [Validation(Required=false)]
            public string AssetName { get; set; }

            /// <summary>
            /// <para>The content ID in the DRM system. The maximum length is 256 characters. Letters, digits, underscores (_), and hyphens (-) are supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>movie</para>
            /// </summary>
            [NameInMap("ContentId")]
            [Validation(Required=false)]
            public string ContentId { get; set; }

            /// <summary>
            /// <para>The time when the asset was created. It follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-11-21T06:45:32Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The egress endpoints, each corresponding to a packaging configuration.</para>
            /// </summary>
            [NameInMap("EgressEndpoints")]
            [Validation(Required=false)]
            public List<GetVodPackagingAssetResponseBodyAssetEgressEndpoints> EgressEndpoints { get; set; }
            public class GetVodPackagingAssetResponseBodyAssetEgressEndpoints : TeaModel {
                /// <summary>
                /// <para>The name of the packaging configuration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>hls_3s</para>
                /// </summary>
                [NameInMap("ConfigurationName")]
                [Validation(Required=false)]
                public string ConfigurationName { get; set; }

                /// <summary>
                /// <para>The asset status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Queuing: The asset is waiting for packaging.</description></item>
                /// <item><description>Playable: The asset is packaged and playable.</description></item>
                /// <item><description>Failed: The asset fails to be packaged.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Playable</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The playback URL. If the asset fails to be packaged, no playback URL is returned.</para>
                /// </summary>
                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            /// <summary>
            /// <para>The name of the packaging group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vod_hls</para>
            /// </summary>
            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            /// <summary>
            /// <para>The asset input configurations.</para>
            /// </summary>
            [NameInMap("Input")]
            [Validation(Required=false)]
            public GetVodPackagingAssetResponseBodyAssetInput Input { get; set; }
            public class GetVodPackagingAssetResponseBodyAssetInput : TeaModel {
                /// <summary>
                /// <para>The URL of the media file. Only M3U8 files stored in OSS are supported.</para>
                /// </summary>
                [NameInMap("Media")]
                [Validation(Required=false)]
                public string Media { get; set; }

                /// <summary>
                /// <para>The input type. Only Object Storage Service (OSS) is supported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>OSS</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0622C702-41BE-467E-AF2E-883D4517962E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
