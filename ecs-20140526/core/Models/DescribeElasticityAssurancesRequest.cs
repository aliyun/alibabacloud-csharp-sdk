// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeElasticityAssurancesRequest : TeaModel {
        [NameInMap("PrivatePoolOptions")]
        [Validation(Required=false)]
        public DescribeElasticityAssurancesRequestPrivatePoolOptions PrivatePoolOptions { get; set; }
        public class DescribeElasticityAssurancesRequestPrivatePoolOptions : TeaModel {
            /// <summary>
            /// The IDs of the elasticity assurances. The value can be a JSON array that consists of up to 100 elasticity assurance IDs. Separate the IDs with commas (,).
            /// </summary>
            [NameInMap("Ids")]
            [Validation(Required=false)]
            public string Ids { get; set; }

        }

        /// <summary>
        /// The billing method of the instance. Set the value to PostPaid. Only pay-as-you-go instances can be created by using elasticity assurances.
        /// 
        /// Default value: PostPaid.
        /// </summary>
        [NameInMap("InstanceChargeType")]
        [Validation(Required=false)]
        public string InstanceChargeType { get; set; }

        /// <summary>
        /// The instance type.
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// The maximum number of entries per page.
        /// 
        /// Maximum value: 100.
        /// 
        /// Default value: 10.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// The pagination token that is used in the request to retrieve a new page of results. You must specify the token that is obtained from the previous query as the value of NextToken.
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
        /// > This parameter is deprecated.
        /// </summary>
        [NameInMap("Platform")]
        [Validation(Required=false)]
        public string Platform { get; set; }

        /// <summary>
        /// The region ID of the elasticity assurances. You can call the [DescribeRegions](https://help.aliyun.com/document_detail/25609.html) operation to query the most recent region list.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the resource group. If you configure this parameter to query resources, up to 1,000 resources that belong to the specified resource group can be displayed in the response.
        /// 
        /// > Resources in the default resource group are displayed in the response regardless of whether you configure this parameter.
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
        /// The status of the elasticity assurances. Valid values:
        /// 
        /// *   All
        /// *   Preparing
        /// *   Prepared
        /// *   Active
        /// *   Released
        /// 
        /// Default value: Active.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// The tags.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeElasticityAssurancesRequestTag> Tag { get; set; }
        public class DescribeElasticityAssurancesRequestTag : TeaModel {
            /// <summary>
            /// The key of tag N. Valid values of N: 1 to 20.
            /// 
            /// If you specify a tag to query resources, up to 1,000 resources with this tag are returned in the response. If you specify multiple tags to query resources, up to 1,000 resources with all these tags are returned in the response. To query more than 1,000 resources that have specified tags added, call the [ListTagResources](https://help.aliyun.com/document_detail/110425.html) operation.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of tag N. Valid values of N: 1 to 20.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The zone ID of the elasticity assurances.
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
