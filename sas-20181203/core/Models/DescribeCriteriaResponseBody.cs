// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeCriteriaResponseBody : TeaModel {
        /// <summary>
        /// The information about the search conditions of assets.
        /// </summary>
        [NameInMap("CriteriaList")]
        [Validation(Required=false)]
        public List<DescribeCriteriaResponseBodyCriteriaList> CriteriaList { get; set; }
        public class DescribeCriteriaResponseBodyCriteriaList : TeaModel {
            /// <summary>
            /// The structured attribute values of the assets that match the keyword. The value of this parameter is in the JSON format and contains the following fields:
            /// 
            /// *   **vendor**: providers.
            /// *   **regionIds**: IDs of supported regions
            /// </summary>
            [NameInMap("MultiValues")]
            [Validation(Required=false)]
            public string MultiValues { get; set; }

            /// <summary>
            /// The name of the search condition. Valid values:
            /// 
            /// *   **internetIp**: the public IP address.
            /// *   **intranetIp**: the private IP address.
            /// *   **instanceName**: the name of the instance.
            /// *   **instanceId**: the instance ID.
            /// *   **vpcInstanceId**: the ID of the virtual private cloud (VPC) to which the instance belongs.
            /// *   **osName**: the operating system.
            /// *   **osType**: the operating system type.
            /// *   **hcStatus**: indicates whether baseline risks exist.
            /// *   **vulStatus**: indicates whether vulnerabilities exist.
            /// *   **alarmStatus**: indicates whether security alerts exist.
            /// *   **riskStatus**: indicates whether risks exist.
            /// *   **clientStatus**: indicates the status of the client.
            /// *   **runningStatus**: the running status of the asset.
            /// *   **tagName**: the name of the tag.
            /// *   **groupName**: the name of the server group.
            /// *   **regionId**: the region ID.
            /// *   **importance**: the importance of the asset.
            /// *   **exposedStatus**: indicates whether the server is exposed.
            /// *   **authVersion**: the authorization version.
            /// *   **flag**: the cloud service provider.
            /// *   **ipList**: the IP addresses.
            /// *   **uuidList** :the UUID.
            /// *   **tagKeyValue**: the ECS tag.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The type of the search condition. Valid values:
            /// 
            /// *   **input**: The search condition needs to be specified.
            /// *   **select**: The search condition is an option that can be selected from the drop-down list.
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// The attribute values of the assets that match the keyword.
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
