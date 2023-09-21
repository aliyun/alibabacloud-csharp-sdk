// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ChangeAssetRefreshTaskConfigRequest : TeaModel {
        /// <summary>
        /// The asset synchronization configurations.
        /// </summary>
        [NameInMap("AssetRefreshConfigs")]
        [Validation(Required=false)]
        public List<ChangeAssetRefreshTaskConfigRequestAssetRefreshConfigs> AssetRefreshConfigs { get; set; }
        public class ChangeAssetRefreshTaskConfigRequestAssetRefreshConfigs : TeaModel {
            [NameInMap("RefreshConfigType")]
            [Validation(Required=false)]
            public int? RefreshConfigType { get; set; }

            /// <summary>
            /// The interval at which assets are synchronized. Unit: minutes. Valid values:
            /// 
            /// *   **60**
            /// *   **180**
            /// *   **360**
            /// *   **720**
            /// *   **1440**
            /// *   **10080**
            /// </summary>
            [NameInMap("SchedulePeriod")]
            [Validation(Required=false)]
            public int? SchedulePeriod { get; set; }

            /// <summary>
            /// The status of the asset synchronization feature. Valid values:
            /// 
            /// *   **1**: Asset synchronization is enabled.
            /// *   **0**: Asset synchronization is disabled.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            [NameInMap("TargetId")]
            [Validation(Required=false)]
            public long? TargetId { get; set; }

            /// <summary>
            /// The service provider of the cloud asset. Valid values:
            /// 
            /// *   **3**: Tencent Cloud
            /// *   **4**: HUAWEI CLOUD
            /// *   **7**: Amazon Web Services (AWS)
            /// </summary>
            [NameInMap("Vendor")]
            [Validation(Required=false)]
            public int? Vendor { get; set; }

        }

        /// <summary>
        /// The region in which your Security Center service resides.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
