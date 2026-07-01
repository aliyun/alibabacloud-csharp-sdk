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

        [NameInMap("ConnectionResourceQuota")]
        [Validation(Required=false)]
        public long? ConnectionResourceQuota { get; set; }

        /// <summary>
        /// <para>The cluster ID.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/173433.html">DescribeDBClusters</a> operation to query information about all clusters in the specified region, including cluster IDs.</para>
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
        /// <para>The list of node instance names for the disaster recovery drill.</para>
        /// <remarks>
        /// <para>Node-level drills support only a single node. For zone-level drills, you can leave this parameter empty or specify all nodes.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>pi-rwxxx</para>
        /// </summary>
        [NameInMap("DBNodeCrashList")]
        [Validation(Required=false)]
        public string DBNodeCrashList { get; set; }

        /// <summary>
        /// <para>The cross-zone data replication mode of the cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>AsyncSync</b>: asynchronous</description></item>
        /// <item><description><b>SemiSync</b>: semi-synchronous</description></item>
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
        /// <item><description>0: instance fault injection based on <c>Crash SQL</c></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("FaultInjectionType")]
        [Validation(Required=false)]
        public string FaultInjectionType { get; set; }

        /// <summary>
        /// <para>The dimension of the disaster recovery drill for the cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>0</c> or <c>FaultInjection</c>: primary zone-level disaster recovery drill.</description></item>
        /// <item><description><c>1</c>: node-level disaster recovery drill.<remarks>
        /// <list type="bullet">
        /// <item><description>In the <b>primary zone-level disaster recovery drill</b> scenario, all compute nodes in the primary zone become unavailable. The failover in this scenario causes service interruptions.</description></item>
        /// <item><description>In the <b>node-level disaster recovery drill</b> scenario, only a single compute node is supported for the drill. Specify the desired compute node name by using <c>DBNodeCrashList</c>.</description></item>
        /// </list>
        /// </remarks>
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
        /// <para>The automatic IMCI-based query acceleration feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>ON</c>: enabled.</description></item>
        /// <item><description><c>OFF</c>: disabled.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Only PolarDB for MySQL clusters are supported.</description></item>
        /// <item><description>For cluster version requirements, see <a href="https://help.aliyun.com/document_detail/2854119.html">Automatic acceleration (AutoIndex)</a>.</description></item>
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
        /// <para>Modifies the row compression settings.</para>
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
        /// <para>The cross-zone automatic switchover mode of the cluster. Valid values:</para>
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
        /// <para>Specifies whether to enable automatic storage scaling for the Standard Edition cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Enable: enables automatic storage scaling.</description></item>
        /// <item><description>Disable: disables automatic storage scaling.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Enable</para>
        /// </summary>
        [NameInMap("StorageAutoScale")]
        [Validation(Required=false)]
        public string StorageAutoScale { get; set; }

        /// <summary>
        /// <para>The upper limit for automatic storage scaling of the Standard Edition cluster. Unit: GB.</para>
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
        /// <para>The JSON string that contains the information about the databases and tables to be restored. The values of the database and table information are strings.
        /// Example: <c>[    {        &quot;tables&quot;:[            {                &quot;name&quot;:&quot;testtb&quot;,                &quot;type&quot;:&quot;table&quot;,                &quot;newname&quot;:&quot;testtb_restore&quot;            }        ],        &quot;name&quot;:&quot;testdb&quot;,        &quot;type&quot;:&quot;db&quot;,        &quot;newname&quot;:&quot;testdb_restore&quot;    } ]</c>.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/194770.html">DescribeMetaList</a> operation to query the names of databases and tables that can be restored, and then specify the information in the corresponding fields in the preceding example.</para>
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
