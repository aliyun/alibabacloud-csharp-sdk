// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GetVodPackagingAssetResponseBody : TeaModel {
        [NameInMap("Asset")]
        [Validation(Required=false)]
        public GetVodPackagingAssetResponseBodyAsset Asset { get; set; }
        public class GetVodPackagingAssetResponseBodyAsset : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>30min_movie</para>
            /// </summary>
            [NameInMap("AssetName")]
            [Validation(Required=false)]
            public string AssetName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>movie</para>
            /// </summary>
            [NameInMap("ContentId")]
            [Validation(Required=false)]
            public string ContentId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-11-21T06:45:32Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("EgressEndpoints")]
            [Validation(Required=false)]
            public List<GetVodPackagingAssetResponseBodyAssetEgressEndpoints> EgressEndpoints { get; set; }
            public class GetVodPackagingAssetResponseBodyAssetEgressEndpoints : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>hls_3s</para>
                /// </summary>
                [NameInMap("ConfigurationName")]
                [Validation(Required=false)]
                public string ConfigurationName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Playable</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>vod_hls</para>
            /// </summary>
            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            [NameInMap("Input")]
            [Validation(Required=false)]
            public GetVodPackagingAssetResponseBodyAssetInput Input { get; set; }
            public class GetVodPackagingAssetResponseBodyAssetInput : TeaModel {
                [NameInMap("Media")]
                [Validation(Required=false)]
                public string Media { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>OSS</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0622C702-41BE-467E-AF2E-883D4517962E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
