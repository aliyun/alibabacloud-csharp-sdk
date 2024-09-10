// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeCloudCenterInstancesRequest : TeaModel {
        /// <summary>
        /// The search conditions. The value of this parameter is in the JSON format and is case-sensitive.
        /// 
        /// >  You can search for an asset by using the search conditions, such as the instance ID, instance name, VPC ID, region, or public IP address. You can call the [DescribeCriteria](https://help.aliyun.com/document_detail/149773.html) operation to query the supported search conditions.
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

        [NameInMap("Flags")]
        [Validation(Required=false)]
        public string Flags { get; set; }

        /// <summary>
        /// The importance of the asset. Valid values:
        /// 
        /// *   **2**: an important asset
        /// *   **1**: a common asset
        /// *   **0**: a test asset
        /// </summary>
        [NameInMap("Importance")]
        [Validation(Required=false)]
        public int? Importance { get; set; }

        /// <summary>
        /// The language of the content within the request and response. Default value: **zh**. Valid values:
        /// 
        /// *   **zh**: Chinese
        /// *   **en**: English
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The logical relationship among multiple search conditions. Valid values:
        /// 
        /// *   **OR**: The logical relationship among search conditions is **OR**.
        /// *   **AND**: The logical relationship among search conditions is **AND**.
        /// </summary>
        [NameInMap("LogicalExp")]
        [Validation(Required=false)]
        public string LogicalExp { get; set; }

        /// <summary>
        /// The type of the assets that you want to query. Valid values:
        /// 
        /// *   **ecs**: servers
        /// *   **cloud_product**: Alibaba Cloud service
        /// </summary>
        [NameInMap("MachineTypes")]
        [Validation(Required=false)]
        public string MachineTypes { get; set; }

        /// <summary>
        /// The value of NextToken that is returned when the NextToken method is used. You do not need to specify this parameter for the first request.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// Specifies whether to internationalize the name of the default group. Valid values:
        /// 
        /// *   **true**: The system returns the Chinese name of the default group for the GroupTrace response parameter.
        /// *   **false**: The system returns default for the GroupTrace response parameter.
        /// </summary>
        [NameInMap("NoGroupTrace")]
        [Validation(Required=false)]
        public bool? NoGroupTrace { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Default value: **20**.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the region in which the asset resides.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        [Obsolete]
        public string RegionId { get; set; }

        /// <summary>
        /// The Alibaba Cloud account ID of the member in the resource directory.
        /// 
        /// >  You can call the [DescribeMonitorAccounts](~~DescribeMonitorAccounts~~) operation to obtain the IDs.
        /// </summary>
        [NameInMap("ResourceDirectoryAccountId")]
        [Validation(Required=false)]
        public long? ResourceDirectoryAccountId { get; set; }

        /// <summary>
        /// Specifies whether to use the NextToken method to retrieve a new page of results. If you set UseNextToken to true, the value of TotalCount is not returned. Valid values:
        /// 
        /// - **true**: The NextToken method is used.
        /// - **false**: The NextToken method is not used.
        /// </summary>
        [NameInMap("UseNextToken")]
        [Validation(Required=false)]
        public bool? UseNextToken { get; set; }

    }

}
