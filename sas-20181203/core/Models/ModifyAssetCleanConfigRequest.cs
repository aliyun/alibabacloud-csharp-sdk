// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyAssetCleanConfigRequest : TeaModel {
        /// <summary>
        /// The asset cleanup configurations.
        /// </summary>
        [NameInMap("AssetCleanConfigs")]
        [Validation(Required=false)]
        public List<ModifyAssetCleanConfigRequestAssetCleanConfigs> AssetCleanConfigs { get; set; }
        public class ModifyAssetCleanConfigRequestAssetCleanConfigs : TeaModel {
            /// <summary>
            /// The number of days before hosts whose provider cannot be identified are automatically cleaned after they enter the offline state. Valid value: an integer that ranges from 1 to 30.
            /// </summary>
            [NameInMap("CleanDays")]
            [Validation(Required=false)]
            public int? CleanDays { get; set; }

            /// <summary>
            /// Specifies whether to enable the feature of cleaning the offline hosts whose provider cannot be identified. Valid values:
            /// 
            /// *   **0**: disables the feature.
            /// *   **1**: enables the feature.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// The type of hosts that you want to clean.
            /// 
            /// Set the value to **1**, which indicates hosts whose provider cannot be identified.
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public int? Type { get; set; }

        }

    }

}
