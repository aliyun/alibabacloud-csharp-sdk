// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class AddAssetSelectionCriteriaRequest : TeaModel {
        /// <summary>
        /// The search conditions that are used to query assets. The value of this parameter is in the JSON format and is case-sensitive.
        /// 
        /// > A search condition can be an instance ID, instance name, virtual private cloud (VPC) ID, region, or public IP address. You can call the [DescribeCriteria](~~DescribeCriteria~~) operation to query the supported search conditions.
        /// </summary>
        [NameInMap("Criteria")]
        [Validation(Required=false)]
        public string Criteria { get; set; }

        /// <summary>
        /// The type of the operation on search conditions. Valid values:
        /// 
        /// *   **add**: adds assets.
        /// *   **del**: deletes assets.
        /// </summary>
        [NameInMap("CriteriaOperation")]
        [Validation(Required=false)]
        public string CriteriaOperation { get; set; }

        /// <summary>
        /// The unique ID of the asset.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("SelectionKey")]
        [Validation(Required=false)]
        public string SelectionKey { get; set; }

        /// <summary>
        /// The list of assets.
        /// </summary>
        [NameInMap("TargetOperationList")]
        [Validation(Required=false)]
        public List<AddAssetSelectionCriteriaRequestTargetOperationList> TargetOperationList { get; set; }
        public class AddAssetSelectionCriteriaRequestTargetOperationList : TeaModel {
            /// <summary>
            /// The type of the operation. Valid values:
            /// 
            /// *   **add**
            /// *   **del**
            /// </summary>
            [NameInMap("Operation")]
            [Validation(Required=false)]
            public string Operation { get; set; }

            /// <summary>
            /// The ID of the asset.
            /// </summary>
            [NameInMap("Target")]
            [Validation(Required=false)]
            public string Target { get; set; }

        }

    }

}
