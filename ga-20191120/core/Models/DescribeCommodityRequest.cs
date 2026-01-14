// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class DescribeCommodityRequest : TeaModel {
        /// <summary>
        /// <para>The commodity code.</para>
        /// <para>Valid values on the China site (aliyun.com):</para>
        /// <list type="bullet">
        /// <item><description><b>ga_gapluspre_public_cn</b>: GA instance.</description></item>
        /// <item><description><b>ga_plusbwppre_public_cn</b>: basic bandwidth plan.</description></item>
        /// </list>
        /// <para>Valid values on the international site (alibabacloud.com):</para>
        /// <list type="bullet">
        /// <item><description><b>ga_pluspre_public_intl</b>: GA instance.</description></item>
        /// <item><description><b>ga_bwppreintl_public_intl:</b> basic bandwidth plan.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ga_gapluspre_public_cn</para>
        /// </summary>
        [NameInMap("CommodityCode")]
        [Validation(Required=false)]
        public string CommodityCode { get; set; }

        /// <summary>
        /// <para>The type of the order. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>BUY</b>: purchase order.</description></item>
        /// <item><description><b>RENEW</b>: renewal order.</description></item>
        /// <item><description><b>UPGRADE</b>: upgrade order.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BUY</para>
        /// </summary>
        [NameInMap("OrderType")]
        [Validation(Required=false)]
        public string OrderType { get; set; }

        /// <summary>
        /// <para>The ID of the region where the Global Accelerator (GA) instance is deployed. Set the value to <b>cn-hangzhou</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
