// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class ModifyDBClusterArchRequest : TeaModel {
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
        /// <para>Specifies whether to enable a hot standby cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>on</b>: Enables a hot standby cluster.</para>
        /// </description></item>
        /// <item><description><para><b>equal</b>: Enables a peer cluster.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("HotStandbyCluster")]
        [Validation(Required=false)]
        public string HotStandbyCluster { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>727xxxxxx934</para>
        /// </summary>
        [NameInMap("PromotionCode")]
        [Validation(Required=false)]
        public string PromotionCode { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <remarks>
        /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/98041.html">DescribeRegions</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The zone for the hot standby storage cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>auto</b> (default): The system automatically selects a zone.</description></item>
        /// </list>
        /// <remarks>
        /// <para>The default value is valid only when \<c>HotStandbyCluster\\</c> is set to \<c>on\\</c>. A specific zone is required when \<c>HotStandbyCluster\\</c> is set to \<c>equal\\</c>. For more information about zones, see <a href="https://help.aliyun.com/document_detail/98041.html">DescribeZones</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing-i</para>
        /// </summary>
        [NameInMap("StandbyAZ")]
        [Validation(Required=false)]
        public string StandbyAZ { get; set; }

    }

}
