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
            /// The IDs of elasticity assurances. The value can be a JSON array that consists of up to 100 elasticity assurance IDs. Separate the IDs with commas (,).
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
        /// The instance types.
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// The number of entries to return on each page.
        /// 
        /// Maximum value: 100.
        /// 
        /// Default value: 10.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// The token used to start the query. Set the value to the NextToken value obtained from the response to the previous request.
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
        /// > This parameter is no longer used.
        /// </summary>
        [NameInMap("Platform")]
        [Validation(Required=false)]
        public string Platform { get; set; }

        /// <summary>
        /// The ID of the region to which the elasticity assurance belongs. You can call the [DescribeRegions](~~25609~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the resource group to which the snapshot belongs. When you use this parameter to query resources, up to 1,000 resources that belong to the specified resource group can be returned.
        /// 
        /// > Resources in the default resource group are displayed in the response regardless of how this parameter is set.
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
        /// The state of the elasticity assurance to query. Valid values:
        /// 
        /// *   All: Queries the elasticity assurances in all states.
        /// *   Preparing: The elasticity assurance is being prepared.
        /// *   Prepared: Queries the elasticity assurances that have not taken effect.
        /// *   Active: Queries the elasticity assurances that are in effect.
        /// *   Released: Queries the elasticity assurances that are released.
        /// 
        /// Default value: Active.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// The tags to use for the query.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeElasticityAssurancesRequestTag> Tag { get; set; }
        public class DescribeElasticityAssurancesRequestTag : TeaModel {
            /// <summary>
            /// The key of the tag N. N is the identifier for the tag, which you can use to set and query the tag. Valid values of N: 1 to 20.
            /// 
            /// If a single tag is specified to query resources, up to 1,000 resources with this tag are returned. If multiple tags are specified to query resources, up to 1,000 resources with all these tags are returned. To query more than 1,000 resources with the specified tags, call the [ListTagResources](~~110425~~) operation.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of a tag N. N is the identifier for the tag, which you can use to set and query the tag. Valid values of N: 1 to 20.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The zone ID of the elasticity assurance.
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
