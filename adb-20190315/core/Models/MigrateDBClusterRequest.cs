// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class MigrateDBClusterRequest : TeaModel {
        /// <summary>
        /// <para>The amount of reserved computing resources.
        /// Valid values: 0ACU to 4096ACU. Step size: 16. Each AnalyticDB compute unit (ACU) is approximately equal to 1 core and 4 GB memory.</para>
        /// 
        /// <b>Example:</b>
        /// <para>32ACU</para>
        /// </summary>
        [NameInMap("ComputeResource")]
        [Validation(Required=false)]
        public string ComputeResource { get; set; }

        /// <summary>
        /// <para>The ID of the AnalyticDB for MySQL Data Warehouse Edition cluster.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>am-bp1xxxxxxxx47</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

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
        /// <b>Example:</b>
        /// <para>LegacyForm</para>
        /// </summary>
        [NameInMap("ProductForm")]
        [Validation(Required=false)]
        public string ProductForm { get; set; }

        [NameInMap("ProductVersion")]
        [Validation(Required=false)]
        public string ProductVersion { get; set; }

        [NameInMap("ReservedNodeCount")]
        [Validation(Required=false)]
        public int? ReservedNodeCount { get; set; }

        [NameInMap("ReservedNodeSize")]
        [Validation(Required=false)]
        public string ReservedNodeSize { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("SecondaryVSwitchId")]
        [Validation(Required=false)]
        public string SecondaryVSwitchId { get; set; }

        [NameInMap("SecondaryZoneId")]
        [Validation(Required=false)]
        public string SecondaryZoneId { get; set; }

        /// <summary>
        /// <para>The number of shards that you want to change during the data migration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>128</para>
        /// </summary>
        [NameInMap("ShardNumber")]
        [Validation(Required=false)]
        public string ShardNumber { get; set; }

        /// <summary>
        /// <para>The amount of reserved storage resources. Valid values: 0ACU to 2064ACU. The value must be in increments of the number of ACUs specified by the StorageResourceSize parameter × 3 (default value: 24ACU). Each ACU is approximately equal to 1 core and 4 GB memory.</para>
        /// <remarks>
        /// <para> This parameter must be specified with a unit.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>24ACU</para>
        /// </summary>
        [NameInMap("StorageResource")]
        [Validation(Required=false)]
        public string StorageResource { get; set; }

        /// <summary>
        /// <para>The node specifications of reserved storage resources. Valid values: 8ACU, 12ACU, and 16ACU.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8ACU</para>
        /// </summary>
        [NameInMap("StorageResourceSize")]
        [Validation(Required=false)]
        public string StorageResourceSize { get; set; }

    }

}
