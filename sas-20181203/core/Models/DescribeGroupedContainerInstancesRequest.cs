// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeGroupedContainerInstancesRequest : TeaModel {
        /// <summary>
        /// The search conditions for assets. Specify the value in the JSON format. Separate multiple search conditions with commas (,). Example: `[{"name":"riskStatus","value":"YES"},{"name":"riskLevel","value":"2"}]`.
        /// 
        /// >  Supported search conditions include the instance ID, instance name, virtual private cloud (VPC) ID, region, and public IP address. You can call the [DescribeCriteria](~~DescribeCriteria~~) operation to query the supported search conditions.
        /// </summary>
        [NameInMap("Criteria")]
        [Validation(Required=false)]
        public string Criteria { get; set; }

        /// <summary>
        /// The number of the page to return. Default value: **1**.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// The keyword that you want to use to query containers. This parameter depends on the value of the GroupField parameter.
        /// 
        /// *   If the **GroupField** parameter is set to **pod**, set this parameter to the name of the pod that you want to query.
        /// *   If the **GroupField** parameter is set to **appName**, set this parameter to the name of the application that you want to query.
        /// *   If the **GroupField** parameter is set to **namespace**, set this parameter to the namespace that you want to query.
        /// *   If the **GroupField** parameter is set to **clusterId**, set this parameter to the ID of the cluster that you want to query.
        /// *   If the **GroupField** parameter is set to **image**, set this parameter to the name of the image that you want to query.
        /// 
        /// >  Fuzzy match is supported.
        /// </summary>
        [NameInMap("FieldValue")]
        [Validation(Required=false)]
        public string FieldValue { get; set; }

        /// <summary>
        /// The group type that you want to use to query containers. Valid values:
        /// 
        /// *   **pod**
        /// *   **appName**
        /// *   **namespace**
        /// *   **clusterId**
        /// *   **image**
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("GroupField")]
        [Validation(Required=false)]
        public string GroupField { get; set; }

        /// <summary>
        /// The logical relationship that you want to use to evaluate multiple search conditions. Valid values:
        /// 
        /// *   **OR**: Search conditions are evaluated by using a logical **OR**.
        /// *   **AND**: Search conditions are evaluated by using a logical **AND**.
        /// </summary>
        [NameInMap("LogicalExp")]
        [Validation(Required=false)]
        public string LogicalExp { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Default value: **20**.
        /// 
        /// >  We recommend that you do not leave this parameter empty.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}
