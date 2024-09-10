// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeVulListRequest : TeaModel {
        /// <summary>
        /// The name of the vulnerability.
        /// </summary>
        [NameInMap("AliasName")]
        [Validation(Required=false)]
        public string AliasName { get; set; }

        /// <summary>
        /// The additional type of the vulnerabilities. You need to specify this parameter when you query application vulnerabilities. Set the value to **sca**. If you set **Type** to **app**, you must specify this parameter.
        /// 
        /// > If you set this parameter to **sca**, application vulnerabilities and the vulnerabilities that are detected based on software component analysis are queried. If you do not specify this parameter, only application vulnerabilities are queried.
        /// </summary>
        [NameInMap("AttachTypes")]
        [Validation(Required=false)]
        public string AttachTypes { get; set; }

        /// <summary>
        /// The number of the page to return. Default value: **1**.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// Specifies whether the vulnerabilities are fixed. Valid values:
        /// 
        /// *   **y**: yes
        /// *   **n**: no
        /// </summary>
        [NameInMap("Dealed")]
        [Validation(Required=false)]
        public string Dealed { get; set; }

        /// <summary>
        /// The ID of the asset group.
        /// 
        /// > You can call the [DescribeAllGroups](~~DescribeAllGroups~~) operation to query the IDs of asset groups.
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// The IDs of vulnerabilities. You can specify up to 50 IDs. Separate multiple IDs with commas (,).
        /// </summary>
        [NameInMap("Ids")]
        [Validation(Required=false)]
        public string Ids { get; set; }

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
        /// The alias of the vulnerability.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The priority to fix the vulnerability. Separate multiple priorities with commas (,). Valid values:
        /// 
        /// *   **asap**: high
        /// *   **later**: medium
        /// *   **nntf**: low
        /// </summary>
        [NameInMap("Necessity")]
        [Validation(Required=false)]
        public string Necessity { get; set; }

        /// <summary>
        /// The pagination token that is used in the next request to retrieve a new page of results. You must specify the token that is obtained from the previous query as the value of NextToken. You do not need to specify this parameter for the first request.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The number of entries per page. Default value: **10**.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The remarks for the asset affected by the vulnerability. The value can be the private IP address, public IP address, or name of the asset.
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// The Alibaba Cloud account ID of the member in the resource directory.
        /// 
        /// >  You can call the [DescribeMonitorAccounts](~~DescribeMonitorAccounts~~) operation to obtain the IDs.
        /// </summary>
        [NameInMap("ResourceDirectoryAccountId")]
        [Validation(Required=false)]
        public long? ResourceDirectoryAccountId { get; set; }

        /// <summary>
        /// The status of the vulnerability. Separate multiple statuses with commas (,). Valid values:
        /// 
        /// - 1: unfixed
        /// - 2: fix failed
        /// - 3: rollback failed
        /// - 4: being fixed
        /// - 5: being rolled back
        /// - 6: being verified
        /// - 7: fixed
        /// - 8: fixed and to be restarted
        /// - 9: rolled back
        /// - 10: ignored
        /// - 11: rolled back and to be restarted
        /// - 12: not found
        /// - 20: expired
        /// </summary>
        [NameInMap("StatusList")]
        [Validation(Required=false)]
        public string StatusList { get; set; }

        /// <summary>
        /// The type of the vulnerability. Valid values:
        /// 
        /// *   **cve**: Linux software vulnerability
        /// *   **sys**: Windows system vulnerability
        /// *   **cms**: Web-CMS vulnerability.
        /// *   **app**: application vulnerability that is detected by using web scanner
        /// *   **emg**: urgent vulnerability.
        /// *   **sca**: application vulnerability that is detected by using software component analysis
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// Specifies whether to use NextToken to query the data of vulnerabilities. If you set UseNextToken to true, the value of TotalCount is not returned. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("UseNextToken")]
        [Validation(Required=false)]
        public bool? UseNextToken { get; set; }

        /// <summary>
        /// The UUIDs of the servers on which you want to query the vulnerabilities. Separate multiple UUIDs with commas (,).
        /// 
        /// >  You can call the [DescribeCloudCenterInstances](~~DescribeCloudCenterInstances~~) operation to obtain the UUIDs.
        /// </summary>
        [NameInMap("Uuids")]
        [Validation(Required=false)]
        public string Uuids { get; set; }

        /// <summary>
        /// The ID of the virtual private cloud (VPC) in which the vulnerabilities are detected. Separate multiple IDs with commas (,).
        /// </summary>
        [NameInMap("VpcInstanceIds")]
        [Validation(Required=false)]
        public string VpcInstanceIds { get; set; }

    }

}
