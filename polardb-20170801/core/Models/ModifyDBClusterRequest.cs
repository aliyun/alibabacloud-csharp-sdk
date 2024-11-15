// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class ModifyDBClusterRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable storage compression. Set the value to <b>ON</b>.</para>
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

        /// <summary>
        /// <para>The list of nodes for the drill.</para>
        /// <remarks>
        /// <para> You can specify only one node for a node-level disaster recovery drill. For a primary zone-level disaster recovery drill, you can either choose not to specify this parameter or specify all nodes.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>pi-rwxxx</para>
        /// </summary>
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

        /// <summary>
        /// <para>The fault injection method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>CrashSQLInjection: <c>Crash SQL</c>-based fault injection.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("FaultInjectionType")]
        [Validation(Required=false)]
        public string FaultInjectionType { get; set; }

        /// <summary>
        /// <para>The level of the disaster recovery drill. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>0</c> or <c>FaultInjection</c>: The primary zone level.</description></item>
        /// <item><description><c>1</c>: The node level.</description></item>
        /// </list>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>In <b>primary zone-level disaster recovery drill</b> scenarios, all compute nodes in the primary zone are unavailable. Data loss occurs during failovers in the scenarios.</para>
        /// </description></item>
        /// <item><description><para>In <b>node-level disaster recovery drill</b> scenarios, you can specify only one compute node for the disaster recovery drill. You can use the <c>DBNodeCrashList</c> parameter to specify the name of the compute node that you want to use for the drill.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("FaultSimulateMode")]
        [Validation(Required=false)]
        public string FaultSimulateMode { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable automatic IMCI-based query acceleration. IMCI is short for In-Memory Column Index. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>ON</c>: enables automatic IMCI-based query acceleration.</description></item>
        /// <item><description><c>OFF</c>: disables automatic IMCI-based query acceleration.</description></item>
        /// </list>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>This parameter is supported only for PolarDB for MySQL clusters.</para>
        /// </description></item>
        /// <item><description><para>For information about the cluster version limits, see <a href="https://help.aliyun.com/document_detail/2854119.html">Automatic IMCI-based query acceleration</a>.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OFF</para>
        /// </summary>
        [NameInMap("ImciAutoIndex")]
        [Validation(Required=false)]
        public string ImciAutoIndex { get; set; }

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
        /// <para>Specifies whether to enable cross-zone automatic switchover. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ON</b>: enables cross-zone automatic switchover.</description></item>
        /// <item><description><b>OFF</b>: disables cross-zone automatic switchover.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ON</para>
        /// </summary>
        [NameInMap("StandbyHAMode")]
        [Validation(Required=false)]
        public string StandbyHAMode { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable automatic storage scaling. This parameter is available only for Standard Edition clusters. Valid values:</para>
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
