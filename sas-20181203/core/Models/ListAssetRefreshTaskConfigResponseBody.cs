// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListAssetRefreshTaskConfigResponseBody : TeaModel {
        /// <summary>
        /// An array that consist of the configurations.
        /// </summary>
        [NameInMap("AssetRefreshConfig")]
        [Validation(Required=false)]
        public List<ListAssetRefreshTaskConfigResponseBodyAssetRefreshConfig> AssetRefreshConfig { get; set; }
        public class ListAssetRefreshTaskConfigResponseBodyAssetRefreshConfig : TeaModel {
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
            /// The status of asset synchonization. Valid values:
            /// 
            /// *   **1**: enabled
            /// *   **0**: disabled
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// The service provider of the cloud asset. Valid values:
            /// 
            /// *   **3**: Tencent Cloud
            /// *   **4**: HUAWEI CLOUD
            /// *   **7**: Amazon Web Services (AWS) Cloud
            /// </summary>
            [NameInMap("Vendor")]
            [Validation(Required=false)]
            public int? Vendor { get; set; }

        }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
