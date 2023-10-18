// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ListPublicIpAddressPoolsRequest : TeaModel {
        /// <summary>
        /// Specifies whether to perform a dry run, without performing the actual request. Valid values:
        /// 
        /// *   **true**: performs only a dry run. The system checks the request for potential issues, including missing parameter values, incorrect request syntax, and service limits. If the request fails the dry run, an error message is returned. If the request passes the dry run, the `DryRunOperation` error code is returned.
        /// *   **false**(default): performs a dry run and performs the actual request. If the request passes the dry run, a 2xx HTTP status code is returned and the operation is performed.
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// The line type. Valid values:
        /// 
        /// *   **BGP** (default): BGP (Multi-ISP) line
        /// *   **BGP_PRO**: BGP (Multi-ISP) Pro line
        /// 
        /// For more information about the BGP (Multi-ISP) line and BGP (Multi-ISP) Pro line, see the "Line types" section of [What is EIP?](~~32321~~)
        /// 
        /// If you are allowed to use single-ISP bandwidth, you can also choose one of the following values:
        /// 
        /// *   **ChinaTelecom**
        /// *   **ChinaUnicom**
        /// *   **ChinaMobile**
        /// *   **ChinaTelecom_L2**
        /// *   **ChinaUnicom_L2**
        /// *   **ChinaMobile_L2**
        /// 
        /// If your services are deployed in China East 1 Finance, this parameter is required and you must set the parameter to **BGP_FinanceCloud**.
        /// </summary>
        [NameInMap("Isp")]
        [Validation(Required=false)]
        public string Isp { get; set; }

        /// <summary>
        /// The maximum number of entries to return. Valid values: **10** to **100**. Default value: **10**.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// The name of the IP address pool.
        /// 
        /// If you enter a name, the name must be 1 to 128 characters in length and can contain digits, periods (.), underscores (\_), and hyphens (-). The name must start with a letter but cannot start with `http://` or `https://`.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The pagination token that is used in the next request to retrieve a new page of results.
        /// 
        /// *   You do not need to specify this parameter for the first request.
        /// *   You must specify the token that is obtained from the previous query as the value of NextToken.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The IDs of the IP address pool.
        /// 
        /// You can enter up to 100 IDs.
        /// </summary>
        [NameInMap("PublicIpAddressPoolIds")]
        [Validation(Required=false)]
        public List<string> PublicIpAddressPoolIds { get; set; }

        /// <summary>
        /// The ID of the region in which the IP address pool that you want to query resides.
        /// 
        /// You can call the [DescribeRegions](~~36063~~) operation to query the region ID.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the resource group to which the IP address pool belongs.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The status of the IP address pool. Valid values:
        /// 
        /// *   **Created**
        /// *   **Deleting**
        /// *   **Modifying**
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// The tags to add to the resource.
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<ListPublicIpAddressPoolsRequestTags> Tags { get; set; }
        public class ListPublicIpAddressPoolsRequestTags : TeaModel {
            /// <summary>
            /// The tag key to add to the resource. You can specify up to 20 tag keys. The tag key cannot be an empty string.
            /// 
            /// The tag key can be up to 128 characters in length. It cannot start with `aliyun` or `acs:`, and cannot contain `http://` or `https://`.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The tag value to add to the resource. You can specify up to 20 tag values. The tag value can be an empty string.
            /// 
            /// The tag key can be up to 128 characters in length. It cannot start with `aliyun` or `acs:` and cannot contain `http://` or `https://`.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
