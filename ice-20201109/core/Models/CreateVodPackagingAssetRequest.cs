// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class CreateVodPackagingAssetRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>hls_3s</para>
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
        /// <para>HLS 3 second packaging</para>
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

        [NameInMap("Input")]
        [Validation(Required=false)]
        public CreateVodPackagingAssetRequestInput Input { get; set; }
        public class CreateVodPackagingAssetRequestInput : TeaModel {
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

}
