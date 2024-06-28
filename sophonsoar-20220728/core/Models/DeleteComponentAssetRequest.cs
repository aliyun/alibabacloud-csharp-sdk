// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class DeleteComponentAssetRequest : TeaModel {
        /// <summary>
        /// The ID of the asset.
        /// 
        /// >  You can call the [DescribeComponentAssets](~~DescribeComponentAssets~~) operation to query the ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("AssetId")]
        [Validation(Required=false)]
        public long? AssetId { get; set; }

        /// <summary>
        /// The language of the content within the request and the response. Valid values:
        /// 
        /// *   **zh** (default): Chinese
        /// *   **en**: English
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

    }

}
