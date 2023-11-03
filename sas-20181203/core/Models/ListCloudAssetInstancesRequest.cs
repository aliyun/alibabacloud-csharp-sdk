// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListCloudAssetInstancesRequest : TeaModel {
        /// <summary>
        /// The cloud assets.
        /// </summary>
        [NameInMap("CloudAssetTypes")]
        [Validation(Required=false)]
        public List<ListCloudAssetInstancesRequestCloudAssetTypes> CloudAssetTypes { get; set; }
        public class ListCloudAssetInstancesRequestCloudAssetTypes : TeaModel {
            /// <summary>
            /// The subtype of the cloud asset.
            /// 
            /// You can call the [GetCloudAssetCriteria](~~GetCloudAssetCriteria~~) operation to query the subtypes of cloud assets from the AssetSubType response parameter.
            /// </summary>
            [NameInMap("AssetSubType")]
            [Validation(Required=false)]
            public int? AssetSubType { get; set; }

            /// <summary>
            /// The type of the cloud asset.
            /// 
            /// You can call the [GetCloudAssetCriteria](~~GetCloudAssetCriteria~~) operation to query the types of cloud assets from the AssetType response parameter.
            /// </summary>
            [NameInMap("AssetType")]
            [Validation(Required=false)]
            public int? AssetType { get; set; }

            [NameInMap("Vendor")]
            [Validation(Required=false)]
            public int? Vendor { get; set; }

        }

        /// <summary>
        /// The search conditions for assets. The value of this parameter is in the JSON format and contains the following fields:
        /// 
        /// *   **name**: the name of the search condition.
        /// 
        /// *   **value**: the value of the search condition.
        /// 
        /// *   **logicalExp**: the logical relation for multiple search conditions. Valid values:
        /// 
        ///     *   **OR**: The search conditions use a logical **OR**.
        ///     *   **AND**: The search conditions use a logical **AND**.
        /// 
        /// > You can call the [GetCloudAssetCriteria](~~GetCloudAssetCriteria~~) operation to query supported search conditions.
        /// </summary>
        [NameInMap("Criteria")]
        [Validation(Required=false)]
        public string Criteria { get; set; }

        /// <summary>
        /// The number of the page to return.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// The logical relation for multiple search conditions. Valid values:
        /// 
        /// *   **OR**: The search conditions use a logical **OR**.
        /// *   **AND**: The search conditions use a logical **AND**.
        /// </summary>
        [NameInMap("LogicalExp")]
        [Validation(Required=false)]
        public string LogicalExp { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Maximum value: 100. Default value: 20.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The region ID of the instance.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
