// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeContainerGroupedFieldDetailRequest : TeaModel {
        /// <summary>
        /// The search conditions that are used to query assets. The value of this parameter is in the JSON format. Separate multiple search conditions with commas (,). Example: `[{"name":"riskStatus","value":"YES"},{"name":"riskLevel","value":"2"}]`.
        /// 
        /// >  Supported search conditions include the instance ID, instance name, virtual private cloud (VPC) ID, region, and public IP address. You can call the [DescribeCriteria](~~DescribeCriteria~~) operation to query the supported search conditions.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Criteria")]
        [Validation(Required=false)]
        public string Criteria { get; set; }

        /// <summary>
        /// The filter condition for a grouping and aggregation query. Valid values:
        /// 
        /// *   **pod**
        /// *   **appName**
        /// *   **clusterId**
        /// *   **namespace**
        /// *   **image**
        /// *   **containerScan**
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("GroupField")]
        [Validation(Required=false)]
        public string GroupField { get; set; }

    }

}
