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
        /// <item><description>true (default): Uses the coupon.</description></item>
        /// <item><description>false: Does not use the coupon.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoUseCoupon")]
        [Validation(Required=false)]
        public bool? AutoUseCoupon { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable I/O performance burst for the ESSD AutoPL cloud disk. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Enabled.</description></item>
        /// <item><description><b>false</b>: Disabled (default).</description></item>
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
        /// <para>The client token that is used to ensure the idempotence of the request. The client generates the token to ensure uniqueness across different requests. The token is case-sensitive and can contain up to 64 ASCII characters.</para>
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
        /// <item><description><b>Upgrade</b>: Upgrades the specifications.</description></item>
        /// <item><description><b>Downgrade</b>: Downgrades the specifications.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Upgrade</para>
        /// </summary>
        [NameInMap("ModifyType")]
        [Validation(Required=false)]
        public string ModifyType { get; set; }

        /// <summary>
        /// <para>The coupon code. If you do not specify this parameter, the default coupon is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>727xxxxxx934</para>
        /// </summary>
        [NameInMap("PromotionCode")]
        [Validation(Required=false)]
        public string PromotionCode { get; set; }

        /// <summary>
        /// <p id="p_wyg_t4a_glm" props="china" icmsditafragmentmagic=1>The provisioned read and write IOPS for the ESSD AutoPL cloud disk. Valid values: 0 to min{50,000, 1000 × Capacity - Baseline performance}.</para>
        /// <p id="p_6de_jxy_k2g" props="china" icmsditafragmentmagic=1>Baseline performance = min{1,800 + 50 × Capacity, 50,000}.</para>
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
        /// <para>The target storage type. Valid values for Enterprise Edition:</para>
        /// <list type="bullet">
        /// <item><description><b>PSL5</b></description></item>
        /// <item><description><b>PSL4</b></description></item>
        /// </list>
        /// <para>Valid values for Standard Edition:</para>
        /// <list type="bullet">
        /// <item><description><b>ESSDPL0</b></description></item>
        /// <item><description><b>ESSDPL1</b></description></item>
        /// <item><description><b>ESSDPL2</b></description></item>
        /// <item><description><b>ESSDPL3</b></description></item>
        /// <item><description><b>ESSDAUTOPL</b></description></item>
        /// </list>
        /// <h2>Storage type change paths from source to target</h2>
        /// <para>Before you call this operation, you can call DescribeDBClusterAttribute to query the current StorageType, and then select the target StorageType and ModifyType based on the current type.</para>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>Cluster edition</th>
        /// <th>Current type</th>
        /// <th>Target StorageType</th>
        /// <th>ModifyType</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>Enterprise Edition</td>
        /// <td>PSL4</td>
        /// <td>PSL5</td>
        /// <td>Upgrade</td>
        /// </tr>
        /// <tr>
        /// <td>Standard Edition</td>
        /// <td>ESSDPL0</td>
        /// <td>ESSDPL1, ESSDPL2, ESSDPL3, or ESSDAUTOPL</td>
        /// <td>Upgrade</td>
        /// </tr>
        /// <tr>
        /// <td>Standard Edition</td>
        /// <td>ESSDPL1</td>
        /// <td>ESSDPL2, ESSDPL3, or ESSDAUTOPL</td>
        /// <td>Upgrade</td>
        /// </tr>
        /// <tr>
        /// <td>Standard Edition</td>
        /// <td>ESSDPL2</td>
        /// <td>ESSDPL3</td>
        /// <td>Upgrade</td>
        /// </tr>
        /// <tr>
        /// <td>Standard Edition</td>
        /// <td>ESSDPL2</td>
        /// <td>ESSDPL1 or ESSDAUTOPL</td>
        /// <td>Downgrade</td>
        /// </tr>
        /// <tr>
        /// <td>Standard Edition</td>
        /// <td>ESSDPL3</td>
        /// <td>ESSDPL1, ESSDPL2, or ESSDAUTOPL</td>
        /// <td>Downgrade</td>
        /// </tr>
        /// </tbody></table>
        /// <remarks>
        /// <para>Enterprise Edition does not support downgrading from PSL5 to PSL4. Standard Edition does not support downgrading to ESSDPL0 or downgrading from ESSDPL1. You cannot change ESSDAUTOPL to other storage types. However, you can retain ESSDAUTOPL and only adjust the provisioned IOPS or I/O burst configurations. In-place changes between Enterprise Edition PSL and Standard Edition ESSD types are not supported. This table lists the verified paths. Specific requests must still meet the requirements for cluster edition, cooldown period for specification changes, and IOPS limits. Operation description: This storage change path matrix describes the supported source-to-target storage type conversion directions and the corresponding ModifyType values for each cluster edition (Enterprise Edition or Standard Edition).</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ESSDAUTOPL</para>
        /// </summary>
        [NameInMap("StorageType")]
        [Validation(Required=false)]
        public string StorageType { get; set; }

    }

}
