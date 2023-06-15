// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ListClassesRequest : TeaModel {
        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the generated token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The commodity code of the instances.
        /// 
        /// *   **bards_intl**: The instances are pay-as-you-go primary instances.
        /// *   **rds_intl**: The instances are subscription primary instances.
        /// *   **rords_intl**: The instances are pay-as-you-go read-only instances.
        /// *   **rds_rordspre_public_intl**: The instances are subscription read-only instances.
        /// </summary>
        [NameInMap("CommodityCode")]
        [Validation(Required=false)]
        public string CommodityCode { get; set; }

        /// <summary>
        /// The ID of the primary instance. You can call the [DescribeDBInstances](~~26232~~) operation to query the ID of the primary instance.
        /// 
        /// > If you use **CommodityCode** to query the instance types that are available to read-only instances, you must specify the DBInstanceId parameter.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// The type of order that you want to query. Valid values:
        /// 
        /// *   **BUY**: specifies the query orders that are used to purchase instances.
        /// *   **UPGRADE**: specifies the query orders that are used to change the specifications of instances.
        /// *   **RENEW**: specifies the query orders that are used to renew instances.
        /// *   **CONVERT**: specifies the query orders that are used to change the billing methods of instances.
        /// </summary>
        [NameInMap("OrderType")]
        [Validation(Required=false)]
        public string OrderType { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The ID of the region. You can call the [DescribeRegions](~~26243~~) operation to query the most recent region list.
        /// 
        /// > If you are using an Alibaba Cloud account on the International site (alibabacloud.com), you must specify the RegionId parameter.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
