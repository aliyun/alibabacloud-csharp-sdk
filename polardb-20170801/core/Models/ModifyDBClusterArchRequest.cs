// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class ModifyDBClusterArchRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to automatically use coupons. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true (default): Uses coupons.</description></item>
        /// <item><description>false: Does not use coupons.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("AutoUseCoupon")]
        [Validation(Required=false)]
        public bool? AutoUseCoupon { get; set; }

        /// <summary>
        /// <para>The cluster ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-****************</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the hot standby cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>on</b>: Enables the hot standby cluster.</description></item>
        /// <item><description><b>equal</b>: Enables the peer cluster.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("HotStandbyCluster")]
        [Validation(Required=false)]
        public string HotStandbyCluster { get; set; }

        /// <summary>
        /// <para>The coupon code. If this parameter is not specified, the default coupon is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>727xxxxxx934</para>
        /// </summary>
        [NameInMap("PromotionCode")]
        [Validation(Required=false)]
        public string PromotionCode { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/98041.html">DescribeRegions</a> operation to query region information.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The zone of the hot standby storage cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>auto</b> (default): Automatically selected.<remarks>
        /// <para>When the HotStandbyCluster parameter is set to on, you can use the default value. When the HotStandbyCluster parameter is set to equal, you must specify a specific zone. You can call the <a href="https://help.aliyun.com/document_detail/98041.html">DescribeZones</a> operation to query zone details.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing-i</para>
        /// </summary>
        [NameInMap("StandbyAZ")]
        [Validation(Required=false)]
        public string StandbyAZ { get; set; }

    }

}
