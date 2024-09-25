// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class ModifyDBClusterRequest : TeaModel {
        /// <summary>
        /// <para>Enable storage compression function. The value of this parameter is ON.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ON</para>
        /// </summary>
        [NameInMap("CompressStorage")]
        [Validation(Required=false)]
        public string CompressStorage { get; set; }

        /// <summary>
        /// <para>The cluster ID.</para>
        /// <remarks>
        /// <para> You can call the DescribeDBClusters operation to query information about all PolarDB clusters that are deployed in a specified region, such as cluster IDs.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-*************</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        [NameInMap("DBNodeCrashList")]
        [Validation(Required=false)]
        public string DBNodeCrashList { get; set; }

        /// <summary>
        /// <para>The method used to replicate data across zones. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>AsyncSync</b>: the asynchronous mode.</description></item>
        /// <item><description><b>SemiSync</b>: the semi-synchronous mode.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>AsynSync</para>
        /// </summary>
        [NameInMap("DataSyncMode")]
        [Validation(Required=false)]
        public string DataSyncMode { get; set; }

        [NameInMap("FaultInjectionType")]
        [Validation(Required=false)]
        public string FaultInjectionType { get; set; }

        /// <summary>
        /// <para>The fault scenario that you want to simulate for the cluster.</para>
        /// <list type="bullet">
        /// <item><description>Set the value to <b>0</b>. The value 0 indicates the scenario in which the primary zone of the cluster fails.</description></item>
        /// </list>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>This parameter takes effect only when you set the <c>StandbyHAMode</c> parameter to 0.</para>
        /// </description></item>
        /// <item><description><para>If you set this parameter to 0, all compute nodes deployed in the primary zone are unavailable. In this case, the switchover degrades the cluster performance.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("FaultSimulateMode")]
        [Validation(Required=false)]
        public string FaultSimulateMode { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the cross-zone automatic switchover mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ON</b>: Enable the cross-zone automatic switchover mode.</description></item>
        /// <item><description><b>OFF</b>: Disable the cross-zone automatic switchover mode.</description></item>
        /// <item><description><b>0</b>: Enable the customer drill mode.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ON</para>
        /// </summary>
        [NameInMap("StandbyHAMode")]
        [Validation(Required=false)]
        public string StandbyHAMode { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable automatic storage scaling for the cluster of Standard Edition. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Enable</description></item>
        /// <item><description>Disable</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Enable</para>
        /// </summary>
        [NameInMap("StorageAutoScale")]
        [Validation(Required=false)]
        public string StorageAutoScale { get; set; }

        /// <summary>
        /// <para>The maximum storage capacity of the cluster of Standard Edition in automatic scaling. Unit: GB.</para>
        /// <remarks>
        /// <para> The maximum value of this parameter is 32000.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>800</para>
        /// </summary>
        [NameInMap("StorageUpperBound")]
        [Validation(Required=false)]
        public long? StorageUpperBound { get; set; }

    }

}
