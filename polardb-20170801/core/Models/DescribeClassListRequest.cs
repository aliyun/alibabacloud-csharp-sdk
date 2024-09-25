// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeClassListRequest : TeaModel {
        /// <summary>
        /// <para>The code of the commodity. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>polardb_sub: the subscription cluster in regions in the Chinese mainland</description></item>
        /// <item><description>polardb_sub _intl: the subscription cluster in regions outside the Chinese mainland</description></item>
        /// <item><description>polardb_payg: the pay-as-you-go cluster in regions in the Chinese mainland</description></item>
        /// <item><description>polardb_payg_intl: the pay-as-you-go cluster in regions outside the Chinese mainland</description></item>
        /// <item><description>polardb_sub_jushita: the subscription cluster for CloudTmall</description></item>
        /// <item><description>polardb_payg_jushita: the pay-as-you-go cluster for CloudTmall</description></item>
        /// <item><description>polardb_sub_cainiao: the subscription cluster for Cainiao</description></item>
        /// <item><description>polardb_payg_cainiao: the pay-as-you-go cluster for Cainiao</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If you use an Alibaba Cloud account on the China site, you can view only the codes of the commodities that are available in the Chinese mainland.</description></item>
        /// <item><description>If you are using an Alibaba Cloud international account, you can view only the codes of the commodities that are available outside the Chinese mainland.</description></item>
        /// <item><description>If you use a CloudTmall account, you can view only the codes of the commodities that are available in CloudTmall.</description></item>
        /// <item><description>If you use a Cainiao account, you can view only the codes of the commodities that are available in Cainiao.</description></item>
        /// </list>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>polardb_sub</para>
        /// </summary>
        [NameInMap("CommodityCode")]
        [Validation(Required=false)]
        public string CommodityCode { get; set; }

        /// <summary>
        /// <para>The number of nodes. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>single: Standalone Edition.</description></item>
        /// <item><description>cluster: Cluster Edition.</description></item>
        /// <item><description>all: both Standalone Edition and Cluster Edition.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cluster</para>
        /// </summary>
        [NameInMap("MasterHa")]
        [Validation(Required=false)]
        public string MasterHa { get; set; }

        /// <summary>
        /// <para>The type of the order. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>BUY: The order is used to purchase a cluster.</description></item>
        /// <item><description>UPGRADE: The order is used to change the specifications of a cluster.</description></item>
        /// <item><description>RENEW: The order is used to renew a cluster.</description></item>
        /// <item><description>CONVERT: The order is used to change the billing method of a cluster.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>BUY</para>
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
        /// <para>The region ID of the cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-************</para>
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
