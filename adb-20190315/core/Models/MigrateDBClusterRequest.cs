// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class MigrateDBClusterRequest : TeaModel {
        /// <summary>
        /// <para>The reserved computing resources. Valid values: 0 ACU to 4096 ACU. The step size is 16. One AnalyticDB Compute Unit (ACU) is approximately equivalent to 1 core and 4 GB of memory.</para>
        /// <remarks>
        /// <para>Include the unit when you specify this parameter. This parameter is required only when ProductForm is set to LegacyForm.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>32ACU</para>
        /// </summary>
        [NameInMap("ComputeResource")]
        [Validation(Required=false)]
        public string ComputeResource { get; set; }

        /// <summary>
        /// <para>The ID of the Data Warehouse Edition cluster.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>am-bp1xxxxxxxx47</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run. Default value: false. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Sends a check request to verify that the migration requirements are met. The migration is <b>not</b> performed.</para>
        /// </description></item>
        /// <item><description><para><b>false</b> (Default): Sends a normal request.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The product form. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>IntegrationForm</b>: Integrated form.</para>
        /// </description></item>
        /// <item><description><para><b>LegacyForm</b>: Data Lakehouse Edition.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>LegacyForm</para>
        /// </summary>
        [NameInMap("ProductForm")]
        [Validation(Required=false)]
        public string ProductForm { get; set; }

        /// <summary>
        /// <para>The product edition. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>BasicVersion</b>: Basic Edition.</para>
        /// </description></item>
        /// <item><description><para><b>EnterpriseVersion</b>: Enterprise Edition.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is required only when ProductForm is set to IntegrationForm.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>EnterpriseVersion</para>
        /// </summary>
        [NameInMap("ProductVersion")]
        [Validation(Required=false)]
        public string ProductVersion { get; set; }

        /// <summary>
        /// <para>The number of reserved nodes.</para>
        /// <list type="bullet">
        /// <item><description><para>For the Enterprise Edition, the default value is 3 and the step size is 3.</para>
        /// </description></item>
        /// <item><description><para>For the Basic Edition, the default value is 1.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is required only when ProductForm is set to IntegrationForm.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("ReservedNodeCount")]
        [Validation(Required=false)]
        public int? ReservedNodeCount { get; set; }

        /// <summary>
        /// <para>The node specifications for the reserved storage resources. Valid values: 8ACU, 12ACU, and 16ACU.</para>
        /// <remarks>
        /// <para>Include the unit when you specify this parameter. This parameter is required only when ProductForm is set to IntegrationForm.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>8ACU</para>
        /// </summary>
        [NameInMap("ReservedNodeSize")]
        [Validation(Required=false)]
        public string ReservedNodeSize { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the secondary virtual switch.</para>
        /// <remarks>
        /// <para>This parameter cannot have the same value as the VSwitchId parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp1aadw9k19x451gx****</para>
        /// </summary>
        [NameInMap("SecondaryVSwitchId")]
        [Validation(Required=false)]
        public string SecondaryVSwitchId { get; set; }

        /// <summary>
        /// <para>The ID of the secondary zone.</para>
        /// <remarks>
        /// <para>This parameter cannot have the same value as the ZoneId parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing-h</para>
        /// </summary>
        [NameInMap("SecondaryZoneId")]
        [Validation(Required=false)]
        public string SecondaryZoneId { get; set; }

        /// <summary>
        /// <para>The number of shards. Specify this parameter to change the number of shards for the instance during the migration.</para>
        /// <remarks>
        /// <para>This parameter is required only when ProductForm is set to LegacyForm.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>128</para>
        /// </summary>
        [NameInMap("ShardNumber")]
        [Validation(Required=false)]
        public string ShardNumber { get; set; }

        /// <summary>
        /// <para>The reserved storage resources. Valid values: 0 ACU to 2064 ACU. The step size is 3 × the number of ACUs specified by the StorageResourceSize parameter. The default value is 24 ACU. One ACU is approximately equivalent to 1 core and 4 GB of memory.</para>
        /// <remarks>
        /// <para>Include the unit when you specify this parameter. This parameter is required only when ProductForm is set to LegacyForm.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>24ACU</para>
        /// </summary>
        [NameInMap("StorageResource")]
        [Validation(Required=false)]
        public string StorageResource { get; set; }

        /// <summary>
        /// <para>The node specifications for the reserved storage resources. Valid values: 8ACU, 12ACU, and 16ACU.</para>
        /// <remarks>
        /// <para>Include the unit when you specify this parameter. This parameter is required only when ProductForm is set to LegacyForm.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>8ACU</para>
        /// </summary>
        [NameInMap("StorageResourceSize")]
        [Validation(Required=false)]
        public string StorageResourceSize { get; set; }

    }

}
