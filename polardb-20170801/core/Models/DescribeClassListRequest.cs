// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeClassListRequest : TeaModel {
        /// <summary>
        /// <para>The commodity code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>polardb_sub: subscription for the Chinese mainland.</para>
        /// </description></item>
        /// <item><description><para>polardb_sub_intl: subscription for regions in Hong Kong (China) and outside the Chinese mainland.</para>
        /// </description></item>
        /// <item><description><para>polardb_payg: pay-as-you-go for the Chinese mainland.</para>
        /// </description></item>
        /// <item><description><para>polardb_payg_intl: pay-as-you-go for regions in Hong Kong (China) and outside the Chinese mainland.</para>
        /// </description></item>
        /// <item><description><para>polardb_sub_jushita: Jushita subscription.</para>
        /// </description></item>
        /// <item><description><para>polardb_payg_jushita: Jushita pay-as-you-go.</para>
        /// </description></item>
        /// <item><description><para>polardb_sub_cainiao: Cainiao subscription.</para>
        /// </description></item>
        /// <item><description><para>polardb_payg_cainiao: Cainiao pay-as-you-go.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>If you use an Alibaba Cloud China site account, you can view only the commodity codes for the Chinese mainland.</para>
        /// </description></item>
        /// <item><description><para>If you use an Alibaba Cloud international site account, you can view only the commodity codes for regions outside the Chinese mainland.</para>
        /// </description></item>
        /// <item><description><para>If you use a Jushita account, you can view only the commodity codes for Jushita.</para>
        /// </description></item>
        /// <item><description><para>If you use a Cainiao account, you can view only the commodity codes for Cainiao.</para>
        /// </description></item>
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
        /// <item><description><para>single: single node.</para>
        /// </description></item>
        /// <item><description><para>cluster: cluster.</para>
        /// </description></item>
        /// <item><description><para>all: single node and cluster.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cluster</para>
        /// </summary>
        [NameInMap("MasterHa")]
        [Validation(Required=false)]
        public string MasterHa { get; set; }

        /// <summary>
        /// <para>The order type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>BUY: new purchase.</para>
        /// </description></item>
        /// <item><description><para>UPGRADE: changes the configuration.</para>
        /// </description></item>
        /// <item><description><para>RENEW: renews the instance.</para>
        /// </description></item>
        /// <item><description><para>CONVERT: changes the billing method.</para>
        /// </description></item>
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
        /// <para>The region ID.</para>
        /// <remarks>
        /// <para>This parameter is required if you use an Alibaba Cloud international site account.</para>
        /// </remarks>
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
