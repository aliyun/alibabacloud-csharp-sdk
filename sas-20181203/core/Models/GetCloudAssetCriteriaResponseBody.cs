// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetCloudAssetCriteriaResponseBody : TeaModel {
        /// <summary>
        /// An array consisting of the information about the filter conditions that are used to search for cloud assets.
        /// </summary>
        [NameInMap("CriteriaList")]
        [Validation(Required=false)]
        public List<GetCloudAssetCriteriaResponseBodyCriteriaList> CriteriaList { get; set; }
        public class GetCloudAssetCriteriaResponseBodyCriteriaList : TeaModel {
            /// <summary>
            /// The structured attribute values of the assets that match the keyword. The value of this parameter is in the JSON format and contains the following fields:
            /// 
            /// *   **vendor**: providers
            /// *   **regionIds**: IDs of supported regions
            /// </summary>
            [NameInMap("MultiValues")]
            [Validation(Required=false)]
            public string MultiValues { get; set; }

            /// <summary>
            /// The name of the filter condition. Valid values:
            /// 
            /// *   **instanceId**: the ID of the instance
            /// *   **instanceName**: the name of an instance
            /// *   **internetIp**: the public IP address
            /// *   **riskStatus**: the risk status
            /// *   **vendorRegionId**: the region ID by service provider
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The type of the filter condition. Valid values:
            /// 
            /// *   **input**: The filter condition needs to be specified.
            /// *   **select**: The filter condition is an option that can be selected from the drop-down list.
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// The values of the search condition. This parameter is returned only if the value of **Type** is **select**.
            /// 
            /// >  If the value of **Type** is **input**, the value of this parameter is an empty string.
            /// </summary>
            [NameInMap("Values")]
            [Validation(Required=false)]
            public string Values { get; set; }

        }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
