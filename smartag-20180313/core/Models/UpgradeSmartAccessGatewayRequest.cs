// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class UpgradeSmartAccessGatewayRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether automatic payment is enabled for the bills of upfront instances. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Yes.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: No.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// <para>The bandwidth of the Smart Access Gateway instance. </para>
        /// <list type="bullet">
        /// <item><description><para>If the device specification is sag-100wm, the value ranges from 2 to 50 Mbit/s.</para>
        /// </description></item>
        /// <item><description><para>If the device specification is sag-1000, the value ranges from 10 to 500 Mbit/s.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("BandWidthSpec")]
        [Validation(Required=false)]
        public long? BandWidthSpec { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID of the Smart Access Gateway.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
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

        /// <summary>
        /// <para>The revert epoch for a temporary upgrade. This parameter specifies the expiration epoch of the temporary bandwidth upgrade. By default, if this parameter is left empty, the upgrade remains effective until the end-of-life (EOL) of the instance. If a specific epoch is specified, the bandwidth automatically reverts to the pre-upgrade configuration at the specified epoch.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-11-10 18</para>
        /// </summary>
        [NameInMap("RestoreTime")]
        [Validation(Required=false)]
        public string RestoreTime { get; set; }

        /// <summary>
        /// <para>The Smart Access Gateway instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sag-d3m51apgw4po******</para>
        /// </summary>
        [NameInMap("SmartAGId")]
        [Validation(Required=false)]
        public string SmartAGId { get; set; }

    }

}
