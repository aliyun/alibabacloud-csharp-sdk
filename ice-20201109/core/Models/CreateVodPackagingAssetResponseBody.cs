// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class CreateVodPackagingAssetResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the asset.</para>
        /// </summary>
        [NameInMap("Asset")]
        [Validation(Required=false)]
        public VodPackagingAsset Asset { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>25818875-5F78-4A13-BEF6-D7393642CA58</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
