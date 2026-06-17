// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class ModifyDBClusterRequest : TeaModel {
        /// <summary>
        /// <para>Enables storage compression. Set the value to <b>ON</b>.</para>
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
        /// <para>You can call the DescribeDBClusters operation to query the details of all clusters in a specific region, including their cluster IDs.</para>
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
        /// <para>The names of the nodes to target in the fault simulation.</para>
        /// <remarks>
        /// <para>For a node-level simulation, you can specify only a single node. For a zone-level simulation, you can leave this parameter empty or specify all nodes.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>pi-rwxxx</para>
        /// </summary>
        [NameInMap("DBNodeCrashList")]
        [Validation(Required=false)]
        public string DBNodeCrashList { get; set; }

        /// <summary>
        /// <para>The cross-zone data replication method for the cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>AsyncSync</b>: asynchronous.</para>
        /// </description></item>
        /// <item><description><para><b>SemiSync</b>: semi-synchronous.</para>
        /// </description></item>
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
        /// <item><description><c>0</c>: instance-level fault injection based on Crash SQL.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("FaultInjectionType")]
        [Validation(Required=false)]
        public string FaultInjectionType { get; set; }

        /// <summary>
        /// <para>The fault simulation scope for the cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>0</c> or <c>FaultInjection</c>: primary zone-level fault simulation.</para>
        /// </description></item>
        /// <item><description><para><c>1</c>: node-level fault simulation.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>In a <b>primary zone-level fault simulation</b>, all compute nodes in the primary zone become unavailable. The disaster recovery failover in this scenario is lossy.</para>
        /// </description></item>
        /// <item><description><para>In a <b>node-level fault simulation</b>, you can simulate a fault on only a single compute node. You must specify the target compute node by using the <c>DBNodeCrashList</c> parameter.</para>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("FaultSimulateMode")]
        [Validation(Required=false)]
        public string FaultSimulateMode { get; set; }

        /// <summary>
        /// <para>Controls the automatic columnar index feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>ON</c>: enables the feature.</para>
        /// </description></item>
        /// <item><description><para><c>OFF</c>: disables the feature.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>This feature is available only for PolarDB for MySQL clusters.</para>
        /// </description></item>
        /// <item><description><para>For cluster version limits, see <a href="https://help.aliyun.com/document_detail/2854119.html">Automatic indexing (AutoIndex)</a>.</para>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>OFF</para>
        /// </summary>
        [NameInMap("ImciAutoIndex")]
        [Validation(Required=false)]
        public string ImciAutoIndex { get; set; }

        /// <summary>
        /// <para>Enables or disables row-level compression.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OFF</para>
        /// </summary>
        [NameInMap("ModifyRowCompression")]
        [Validation(Required=false)]
        public string ModifyRowCompression { get; set; }

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
        /// <para>The automatic cross-zone failover mode for the cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>ON</b>: enables automatic cross-zone failover.</para>
        /// </description></item>
        /// <item><description><para><b>OFF</b>: disables automatic cross-zone failover.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ON</para>
        /// </summary>
        [NameInMap("StandbyHAMode")]
        [Validation(Required=false)]
        public string StandbyHAMode { get; set; }

        /// <summary>
        /// <para>Enables or disables automatic storage scaling for a standard cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Enable: enables automatic storage scaling.</para>
        /// </description></item>
        /// <item><description><para>Disable: disables automatic storage scaling.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Enable</para>
        /// </summary>
        [NameInMap("StorageAutoScale")]
        [Validation(Required=false)]
        public string StorageAutoScale { get; set; }

        /// <summary>
        /// <para>The upper limit for automatic storage scaling on a standard cluster. Unit: GB.</para>
        /// <remarks>
        /// <para>The maximum value is 32000.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>800</para>
        /// </summary>
        [NameInMap("StorageUpperBound")]
        [Validation(Required=false)]
        public long? StorageUpperBound { get; set; }

        /// <summary>
        /// <para>A JSON string that specifies information about the destination databases and tables to be restored. All values in the database and table information must be strings.
        /// Example: <c>[ { &quot;tables&quot;:[ { &quot;name&quot;:&quot;testtb&quot;, &quot;type&quot;:&quot;table&quot;, &quot;newname&quot;:&quot;testtb_restore&quot; } ], &quot;name&quot;:&quot;testdb&quot;, &quot;type&quot;:&quot;db&quot;, &quot;newname&quot;:&quot;testdb_restore&quot; } ]</c>.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/194770.html">DescribeMetaList</a> operation to query for restorable databases and tables. Use the returned information to populate the fields in the example JSON.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[ { &quot;tables&quot;:[ { &quot;name&quot;:&quot;testtb&quot;, &quot;type&quot;:&quot;table&quot;, &quot;newname&quot;:&quot;testtb_restore&quot; } ], &quot;name&quot;:&quot;testdb&quot;, &quot;type&quot;:&quot;db&quot;, &quot;newname&quot;:&quot;testdb_restore&quot; } ]</para>
        /// </summary>
        [NameInMap("TableMeta")]
        [Validation(Required=false)]
        public string TableMeta { get; set; }

    }

}
