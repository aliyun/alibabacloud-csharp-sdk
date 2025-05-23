// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class BatchCreateVodPackagingAssetShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The assets that you want to ingest.</para>
        /// </summary>
        [NameInMap("Assets")]
        [Validation(Required=false)]
        public string AssetsShrink { get; set; }

        /// <summary>
        /// <para>The name of the packaging group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vod_hls</para>
        /// </summary>
        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

    }

}
