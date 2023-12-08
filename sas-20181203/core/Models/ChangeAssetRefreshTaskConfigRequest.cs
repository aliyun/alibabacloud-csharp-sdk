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
            /// The type of the configuration. Valid values:
            /// 
            /// *   **0**: server synchronization task
            /// *   **1**: cloud service synchronization task
            /// *   **2**: scheduled AccessKey pair verification task
            /// </summary>
            [NameInMap("RefreshConfigType")]
            [Validation(Required=false)]
            public int? RefreshConfigType { get; set; }

            /// <summary>
            /// The synchronization cycle. Valid values:
            /// 
            /// *   **60**: 60 minutes
            /// *   **180**: 3 hours
            /// *   **360**: 6 hours
            /// *   **720**: 12 hours
            /// *   **1440**: 1 day
            /// *   **10080**: 7 days
            /// </summary>
            [NameInMap("SchedulePeriod")]
            [Validation(Required=false)]
            public int? SchedulePeriod { get; set; }

            /// <summary>
            /// The status of the configuration. Valid values:
            /// 
            /// *   **1**: enabled
            /// *   **0**: disabled
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// The ID of the data entry containing the AccessKey pair that you specify when you configure the scheduled AccessKey pair verification task.
            /// </summary>
            [NameInMap("TargetId")]
            [Validation(Required=false)]
            public long? TargetId { get; set; }

            /// <summary>
            /// The service provider of the cloud asset. Valid values:
            /// 
            /// *   **3**: Tencent Cloud
            /// *   **4**: Huawei Cloud
            /// *   **7**: Amazon Web Services (AWS) Cloud
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
