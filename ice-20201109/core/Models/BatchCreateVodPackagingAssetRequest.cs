// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class BatchCreateVodPackagingAssetRequest : TeaModel {
        [NameInMap("Assets")]
        [Validation(Required=false)]
        public List<BatchCreateVodPackagingAssetRequestAssets> Assets { get; set; }
        public class BatchCreateVodPackagingAssetRequestAssets : TeaModel {
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

            [NameInMap("Input")]
            [Validation(Required=false)]
            public BatchCreateVodPackagingAssetRequestAssetsInput Input { get; set; }
            public class BatchCreateVodPackagingAssetRequestAssetsInput : TeaModel {
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
        /// <para>vod_hls</para>
        /// </summary>
        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

    }

}
