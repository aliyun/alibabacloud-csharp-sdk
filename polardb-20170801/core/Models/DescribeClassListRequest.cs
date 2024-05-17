// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeClassListRequest : TeaModel {
        /// <summary>
        /// The code of the commodity. Valid values:
        /// 
        /// *   polardb_sub: the subscription cluster in regions in the Chinese mainland
        /// *   polardb_sub _intl: the subscription cluster in regions outside the Chinese mainland
        /// *   polardb_payg: the pay-as-you-go cluster in regions in the Chinese mainland
        /// *   polardb_payg_intl: the pay-as-you-go cluster in regions outside the Chinese mainland
        /// *   polardb_sub_jushita: the subscription cluster for CloudTmall
        /// *   polardb_payg_jushita: the pay-as-you-go cluster for CloudTmall
        /// *   polardb_sub_cainiao: the subscription cluster for Cainiao
        /// *   polardb_payg_cainiao: the pay-as-you-go cluster for Cainiao
        /// 
        /// > *   If you use an Alibaba Cloud account on the China site, you can view only the codes of the commodities that are available in the Chinese mainland.
        /// >*   If you are using an Alibaba Cloud international account, you can view only the codes of the commodities that are available outside the Chinese mainland.
        /// >*   If you use a CloudTmall account, you can view only the codes of the commodities that are available in CloudTmall.
        /// >*   If you use a Cainiao account, you can view only the codes of the commodities that are available in Cainiao.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("CommodityCode")]
        [Validation(Required=false)]
        public string CommodityCode { get; set; }

        /// <summary>
        /// The number of nodes. Valid values:
        /// 
        /// *   single: Standalone Edition.
        /// *   cluster: Cluster Edition.
        /// *   all: both Standalone Edition and Cluster Edition.
        /// </summary>
        [NameInMap("MasterHa")]
        [Validation(Required=false)]
        public string MasterHa { get; set; }

        /// <summary>
        /// The type of the order. Valid values:
        /// 
        /// *   BUY: The order is used to purchase a cluster.
        /// *   UPGRADE: The order is used to change the specifications of a cluster.
        /// *   RENEW: The order is used to renew a cluster.
        /// *   CONVERT: The order is used to change the billing method of a cluster.
        /// </summary>
        [NameInMap("OrderType")]
        [Validation(Required=false)]
        public string OrderType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The region ID of the cluster.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the resource group.
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

    }

}
