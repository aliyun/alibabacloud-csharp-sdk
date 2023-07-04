// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ListPublicIpAddressPoolsRequest : TeaModel {
        /// <summary>
        /// Specifies whether to perform a dry run. Valid values:
        /// 
        /// *   **true**: performs a dry run. The system checks the required parameters, request syntax, and limits. If the request fails the dry run, an error message is returned. If the request passes the dry run, the `DryRunOperation` error code is returned.
        /// *   **false** (default): performs a dry run and sends the request. If the request passes the dry run, an HTTP 2xx status code is returned and the operation is performed.
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// The line type. Valid values:
        /// 
        /// *   **BGP** (default): BGP (Multi-ISP) lines
        /// *   **BGP_PRO**: BGP (Multi-ISP) Pro lines
        /// 
        /// For more information about BGP (Multi-ISP) and BGP (Multi-ISP) Pro, see [EIP line types](~~32321~~).
        /// 
        /// If you are allowed to use single-ISP bandwidth, you can also choose one of the following values:
        /// 
        /// *   **ChinaTelecom**: China Telecom
        /// *   **ChinaUnicom**: China Unicom
        /// *   **ChinaMobile**: China Mobile
        /// *   **ChinaTelecom_L2**: China Telecom L2
        /// *   **ChinaUnicom_L2**: China Unicom L2
        /// *   **ChinaMobile_L2**: China Mobile L2
        /// 
        /// If your services are deployed in China East 1 Finance, this parameter is required and you must set the value to **BGP_FinanceCloud**.
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
        /// This parameter is optional. The name must be 1 to 128 characters in length, and can contain digits, periods (.), underscores (\_), and hyphens (-). The name must start with a letter but cannot start with `http://` or `https://`.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The token that determines the start point of the next query. Valid values:
        /// 
        /// *   If this is your first query and no subsequent queries are to be sent, ignore this parameter.
        /// *   If a subsequent query is to be sent, set the parameter to the value of NextToken that is returned from the last call.
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

        [NameInMap("PublicIpAddressPoolIds")]
        [Validation(Required=false)]
        public List<string> PublicIpAddressPoolIds { get; set; }

        /// <summary>
        /// The ID of the region where you want to query IP address pools.
        /// 
        /// You can call the [DescribeRegions](~~36063~~) operation to query the most recent region list.
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
        /// *   **Created**: The IP address pool is available.
        /// *   **Deleting**: The IP address pool is being deleted.
        /// *   **Modifying**: The IP address pool is being modified.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<ListPublicIpAddressPoolsRequestTags> Tags { get; set; }
        public class ListPublicIpAddressPoolsRequestTags : TeaModel {
            /// <summary>
            /// The key of the tag. You can specify at most 20 tag keys. The tag key cannot be an empty string.
            /// 
            /// The key cannot exceed 64 characters in length, and can contain digits, periods (.), underscores (\_), and hyphens (-). The key must start with a letter but cannot start with `aliyun` or `acs:`. The key cannot contain `http://` or `https://`.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of the tag. You can specify at most 20 tag values. The tag value can be an empty string.
            /// 
            /// The tag value cannot exceed 128 characters in length, and can contain digits, periods (.), underscores (\_), and hyphens (-). The key must start with a letter but cannot start with `aliyun` or `acs:`. The key cannot contain `http://` or `https://`.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
