// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class DeleteVodPackagingAssetRequest : TeaModel {
        /// <summary>
        /// <para>The name of the VOD packaging asset.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30min_movie</para>
        /// </summary>
        [NameInMap("AssetName")]
        [Validation(Required=false)]
        public string AssetName { get; set; }

    }

}
