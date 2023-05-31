// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class RefreshContainerAssetsRequest : TeaModel {
        /// <summary>
        /// The type of the container asset whose statistics you want to refresh. Valid values:
        /// 
        /// *   **IMAGE**
        /// *   **CONTAINER**
        /// </summary>
        [NameInMap("AssetType")]
        [Validation(Required=false)]
        public string AssetType { get; set; }

    }

}
