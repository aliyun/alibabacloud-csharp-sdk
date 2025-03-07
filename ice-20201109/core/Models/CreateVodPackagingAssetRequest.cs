// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class CreateVodPackagingAssetRequest : TeaModel {
        /// <summary>
        /// <para>The name of the asset. The name must be unique and can be up to 128 characters in length. Letters, digits, underscores (_), and hyphens (-) are supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hls_3s</para>
        /// </summary>
        [NameInMap("AssetName")]
        [Validation(Required=false)]
        public string AssetName { get; set; }

        /// <summary>
        /// <para>The content ID in the digital rights management (DRM) system. The maximum length is 256 characters. Letters, digits, underscores (_), and hyphens (-) are supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>movie</para>
        /// </summary>
        [NameInMap("ContentId")]
        [Validation(Required=false)]
        public string ContentId { get; set; }

        /// <summary>
        /// <para>The asset description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>HLS 3 second packaging</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

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
        public CreateVodPackagingAssetRequestInput Input { get; set; }
        public class CreateVodPackagingAssetRequestInput : TeaModel {
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

}
