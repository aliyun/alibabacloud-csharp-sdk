// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ListDhcpOptionsSetsRequest : TeaModel {
        /// <summary>
        /// The ID of the DHCP options set. You can specify at most 20 IDs.
        /// </summary>
        [NameInMap("DhcpOptionsSetId")]
        [Validation(Required=false)]
        public List<string> DhcpOptionsSetId { get; set; }

        /// <summary>
        /// The name of the DHCP options set.
        /// 
        /// The name must be 1 to 128 characters in length and can contain digits, underscores (\_), and hyphens (-). It must start with a letter.
        /// 
        /// Valid values:
        /// 
        /// *   tf-testAccVpcDhcpOptionsSets-1585169790614573448
        /// 
        ///     <!-- -->
        /// 
        ///     :
        /// 
        ///     <!-- -->
        /// 
        ///     tf-testAccVpcDhcpOptionsSets-1585169790614573448
        /// 
        ///     <!-- -->
        /// 
        ///     .
        /// </summary>
        [NameInMap("DhcpOptionsSetName")]
        [Validation(Required=false)]
        public string DhcpOptionsSetName { get; set; }

        /// <summary>
        /// The root domain. For example, you can set the value to example.com.
        /// 
        /// After a DHCP options set is associated with a virtual private cloud (VPC), the root domain in the DHCP options set is automatically synchronized with the ECS instances in the VPC.
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// The number of entries per page. Valid values: **1** to **100**. Default value: **10**.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// The pagination token that is used in the next request to retrieve a new page of results. Valid values:
        /// 
        /// *   You do not need to specify this parameter for the first request.
        /// *   You must specify the token that is obtained from the previous query as the value of the **NextToken** parameter.
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
        /// The region ID of the DHCP options sets that you want to query.
        /// 
        /// You can call the [DescribeRegions](~~36063~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the resource group to which the DHCP options set belongs.
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
        /// The tag list.
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<ListDhcpOptionsSetsRequestTags> Tags { get; set; }
        public class ListDhcpOptionsSetsRequestTags : TeaModel {
            /// <summary>
            /// The tag key. You can specify up to 20 tag keys. The tag key cannot be an empty string.
            /// 
            /// The tag key can be up to 64 characters in length and can contain digits, periods (.), underscores (\_), and hyphens (-). The tag key must start with a letter but cannot start with `aliyun` or `acs:`. The tag key cannot contain `http://` or `https://`.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The tag value. You can specify at most 20 tag values. The tag value can be an empty string.
            /// 
            /// The tag value can be up to 128 characters in length and can contain digits, periods (.), underscores (\_), and hyphens (-). The tag value must start with a letter but cannot start with `aliyun` or `acs:`. The tag value cannot contain `http://` or `https://`.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
