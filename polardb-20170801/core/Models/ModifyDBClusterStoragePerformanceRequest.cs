// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class ModifyDBClusterStoragePerformanceRequest : TeaModel {
        [NameInMap("AutoUseCoupon")]
        [Validation(Required=false)]
        public bool? AutoUseCoupon { get; set; }

        /// <summary>
        /// <para>Specifies if the I/O performance burst feature is enabled for an ESSD AutoPL disk. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Enabled</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: Disabled (Default)</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter applies only when StorageType is set to ESSDAUTOPL.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("BurstingEnabled")]
        [Validation(Required=false)]
        public string BurstingEnabled { get; set; }

        /// <summary>
        /// <para>A client-generated token that ensures request idempotence. The token must be unique for each request. It is case-sensitive and can be up to 64 ASCII characters long.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6000170000591aed949d0f******************</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The cluster ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-*************</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The modification type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Upgrade</b>: Upgrades the storage performance.</para>
        /// </description></item>
        /// <item><description><para><b>Downgrade</b>: Downgrades the storage performance.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Upgrade</para>
        /// </summary>
        [NameInMap("ModifyType")]
        [Validation(Required=false)]
        public string ModifyType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>727xxxxxx934</para>
        /// </summary>
        [NameInMap("PromotionCode")]
        [Validation(Required=false)]
        public string PromotionCode { get; set; }

        /// <summary>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <para>Valid values: 0 to min{50,000, 1000 \* capacity - baseline performance}.</para>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <para>Baseline performance = min{1,800 + 50 \* capacity, 50,000}.</para>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <remarks>
        /// <para>This parameter applies only when StorageType is set to ESSDAUTOPL.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2500</para>
        /// </summary>
        [NameInMap("ProvisionedIops")]
        [Validation(Required=false)]
        public int? ProvisionedIops { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The target storage type. Valid values for Enterprise Edition:</para>
        /// <list type="bullet">
        /// <item><description><para><b>PSL5</b></para>
        /// </description></item>
        /// <item><description><para><b>PSL4</b></para>
        /// </description></item>
        /// </list>
        /// <para>Valid values for Standard Edition:</para>
        /// <list type="bullet">
        /// <item><description><para><b>ESSDPL0</b></para>
        /// </description></item>
        /// <item><description><para><b>ESSDPL1</b></para>
        /// </description></item>
        /// <item><description><para><b>ESSDPL2</b></para>
        /// </description></item>
        /// <item><description><para><b>ESSDPL3</b></para>
        /// </description></item>
        /// <item><description><para><b>ESSDAUTOPL</b></para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ESSDAUTOPL</para>
        /// </summary>
        [NameInMap("StorageType")]
        [Validation(Required=false)]
        public string StorageType { get; set; }

    }

}
