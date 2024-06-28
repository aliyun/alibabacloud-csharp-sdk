// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class ModifyComponentAssetRequest : TeaModel {
        /// <summary>
        /// The configuration of the asset. The value is a JSON object.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("AssetConfig")]
        [Validation(Required=false)]
        public string AssetConfig { get; set; }

        /// <summary>
        /// The language of the content within the request and response.
        /// 
        /// *   **zh**: Chinese (default)
        /// *   **en**: English
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

    }

}
