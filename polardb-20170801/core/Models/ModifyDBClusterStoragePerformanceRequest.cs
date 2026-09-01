// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class ModifyDBClusterStoragePerformanceRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to automatically use coupons. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true (default): uses coupons.</description></item>
        /// <item><description>false: does not use coupons.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("AutoUseCoupon")]
        [Validation(Required=false)]
        public bool? AutoUseCoupon { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable I/O performance burst for the ESSD AutoPL cloud disk. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: enabled.</description></item>
        /// <item><description><b>false</b>: disabled (default).</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is supported only when StorageType is set to ESSDAUTOPL.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("BurstingEnabled")]
        [Validation(Required=false)]
        public string BurstingEnabled { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token is case-sensitive and can contain only ASCII characters. The token can be up to 64 characters in length.</para>
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
        /// <para>The type of the specification change. Valid values: </para>
        /// <list type="bullet">
        /// <item><description><b>Upgrade</b>: upgrades the specifications.</description></item>
        /// <item><description><b>Downgrade</b>: downgrades the specifications.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Upgrade</para>
        /// </summary>
        [NameInMap("ModifyType")]
        [Validation(Required=false)]
        public string ModifyType { get; set; }

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
        /// <p id="p_wyg_t4a_glm" props="china" icmsditafragmentmagic=1>The provisioned read/write IOPS of the ESSD AutoPL cloud disk. Valid values: 0 to min{50,000, 1000 × Capacity - Baseline performance}.</para>
        /// <p id="p_6de_jxy_k2g" props="china" icmsditafragmentmagic=1>Baseline performance = min{1,800 + 50 × Capacity, 50000}.</para>
        /// <note id="note_7kj_j0o_rgs" props="china" icmsditafragmentmagic=1>This parameter is supported only when StorageType is set to ESSDAUTOPL.</note>
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
        /// <para>The target storage type. Valid values for PolarDB Enterprise Edition:</para>
        /// <list type="bullet">
        /// <item><description><b>PSL5</b></description></item>
        /// <item><description><b>PSL4</b></description></item>
        /// </list>
        /// <para>Valid values for PolarDB for MySQL Standard Edition:</para>
        /// <list type="bullet">
        /// <item><description><b>ESSDPL0</b></description></item>
        /// <item><description><b>ESSDPL1</b></description></item>
        /// <item><description><b>ESSDPL2</b></description></item>
        /// <item><description><b>ESSDPL3</b></description></item>
        /// <item><description><b>ESSDAUTOPL</b></description></item>
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
