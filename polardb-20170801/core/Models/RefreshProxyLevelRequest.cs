// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class RefreshProxyLevelRequest : TeaModel {
        /// <summary>
        /// <para>The PolarDB cluster ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-******************</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>Specifies whether the execution is initiated by the scheduled task service. Default value: false. If this parameter is set to false and PlannedStartTime is specified, a scheduled task is created. If this parameter is set to true, the task is executed immediately. Usage notes: If the DBClusterStatus of the cluster is not Running, you must specify the PlannedStartTime and PlannedEndTime parameters to create a scheduled task. The description of this parameter specifies that the task can be executed immediately only when the cluster is in the Running state and this parameter is set to true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("FromTimeService")]
        [Validation(Required=false)]
        public bool? FromTimeService { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The latest time to start the proxy upgrade, in the YYYY-MM-DDThh:mm:ssZ format (UTC). Usage notes: If the DBClusterStatus of the cluster is not Running, you must specify both the PlannedStartTime and PlannedEndTime parameters to create a scheduled task. The description of the FromTimeService parameter specifies that the task can be executed immediately only when the cluster is in the Running state and FromTimeService is set to true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-04-28T14:30:00Z</para>
        /// </summary>
        [NameInMap("PlannedEndTime")]
        [Validation(Required=false)]
        public string PlannedEndTime { get; set; }

        /// <summary>
        /// <para>The earliest time to start the proxy upgrade, in the YYYY-MM-DDThh:mm:ssZ format (UTC). Usage notes: If the DBClusterStatus of the cluster is not Running, you must specify both the PlannedStartTime and PlannedEndTime parameters to create a scheduled task. The description of the FromTimeService parameter specifies that the task can be executed immediately only when the cluster is in the Running state and FromTimeService is set to true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-04-28T14:00:00Z</para>
        /// </summary>
        [NameInMap("PlannedStartTime")]
        [Validation(Required=false)]
        public string PlannedStartTime { get; set; }

        /// <summary>
        /// <para>The target proxy performance level. Valid values: ProxyStandard, ProxyStandardx2, and ProxyStandardx4.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ProxyStandard</para>
        /// </summary>
        [NameInMap("ProxyTargetClass")]
        [Validation(Required=false)]
        public string ProxyTargetClass { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
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
