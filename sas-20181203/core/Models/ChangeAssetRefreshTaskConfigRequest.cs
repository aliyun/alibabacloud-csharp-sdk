// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ChangeAssetRefreshTaskConfigRequest : TeaModel {
        /// <summary>
        /// The asset synchronization configuration.
        /// </summary>
        [NameInMap("AssetRefreshConfigs")]
        [Validation(Required=false)]
        public List<ChangeAssetRefreshTaskConfigRequestAssetRefreshConfigs> AssetRefreshConfigs { get; set; }
        public class ChangeAssetRefreshTaskConfigRequestAssetRefreshConfigs : TeaModel {
            /// <summary>
            /// The configuration type. Valid values:
            /// 
            /// *   **0**: host refresh task
            /// *   **1**: cloud service refresh task
            /// *   **2**: scheduled AccessKey pair verification task
            /// </summary>
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
            /// Specifies whether to enable the feature. Valid values:
            /// 
            /// *   **1**: enables the feature.
            /// *   **0**: disables the feature.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// The AccessKey ID of the scheduled AccessKey pair verification task.
            /// </summary>
            [NameInMap("TargetId")]
            [Validation(Required=false)]
            public long? TargetId { get; set; }

            /// <summary>
            /// The cloud asset type. Valid values:
            /// 
            /// *   **3**: Tencent Cloud
            /// *   **4**: Huawei Cloud
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
