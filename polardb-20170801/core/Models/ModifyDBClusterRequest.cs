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
        /// <para>The connection resource quota of the AgenticDB cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("ConnectionResourceQuota")]
        [Validation(Required=false)]
        public long? ConnectionResourceQuota { get; set; }

        /// <summary>
        /// <para>The cluster ID.</para>
        /// <remarks>
        /// <para>You can call the DescribeDBClusters operation to query all clusters in the specified region, including their cluster IDs.</para>
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
        /// <para>The list of instance names of the nodes to be drilled.</para>
        /// <remarks>
        /// <para>A node-level drill supports only a single node. For a zone-level drill, you can leave this parameter empty or pass all nodes.</para>
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
        /// <item><description><b>AsyncSync</b>: Asynchronous replication.</description></item>
        /// <item><description><b>SemiSync</b>: Semi-synchronous replication.</description></item>
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
        /// <item><description>0: instance fault injection based on <c>Crash SQL</c>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CrashSQLInjection</para>
        /// </summary>
        [NameInMap("FaultInjectionType")]
        [Validation(Required=false)]
        public string FaultInjectionType { get; set; }

        /// <summary>
        /// <para>The fault drill dimension of the cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>0</c> or <c>FaultInjection</c>: fault drill at the primary zone level.</description></item>
        /// <item><description><c>1</c>: fault drill at the node level.<remarks>
        /// <list type="bullet">
        /// <item><description>In the <b>fault drill at the primary zone level</b> scenario, all compute nodes in the primary zone become unavailable, and the disaster recovery switchover in this scenario is lossy.</description></item>
        /// <item><description>In the <b>fault drill at the node level</b> scenario, only a single compute node can be drilled. You can pass the desired compute node name through <c>DBNodeCrashList</c>.</description></item>
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
        /// <item><description><c>ON</c>: Enables the feature.</description></item>
        /// <item><description><c>OFF</c>: Disables the feature.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This feature is supported only by PolarDB for MySQL clusters.</description></item>
        /// <item><description>For cluster version limits, refer to <a href="https://help.aliyun.com/document_detail/2854119.html">Automatic seamless acceleration (AutoIndex)</a>.</description></item>
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
        /// <item><description><b>ON</b>: Enables cross-zone automatic switchover.</description></item>
        /// <item><description><b>OFF</b>: Disables cross-zone automatic switchover.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ON</para>
        /// </summary>
        [NameInMap("StandbyHAMode")]
        [Validation(Required=false)]
        public string StandbyHAMode { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable automatic storage scaling for a Standard Edition cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Enable: Enables automatic storage scaling.</description></item>
        /// <item><description>Disable: Disables automatic storage scaling.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Enable</para>
        /// </summary>
        [NameInMap("StorageAutoScale")]
        [Validation(Required=false)]
        public string StorageAutoScale { get; set; }

        /// <summary>
        /// <para>The upper limit for automatic storage scaling of a Standard Edition cluster. Unit: GB.</para>
        /// <remarks>
        /// <para>The maximum value is 32,000.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>800</para>
        /// </summary>
        [NameInMap("StorageUpperBound")]
        [Validation(Required=false)]
        public long? StorageUpperBound { get; set; }

        /// <summary>
        /// <para>The JSON string of the target database and table information to be restored. The values of the database and table information are all of the string type.
        /// Example: <c>[    {        &quot;tables&quot;:[            {                &quot;name&quot;:&quot;testtb&quot;,                &quot;type&quot;:&quot;table&quot;,                &quot;newname&quot;:&quot;testtb_restore&quot;            }        ],        &quot;name&quot;:&quot;testdb&quot;,        &quot;type&quot;:&quot;db&quot;,        &quot;newname&quot;:&quot;testdb_restore&quot;    } ]</c>.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/194770.html">DescribeMetaList</a> operation to query the details of the database and table names that support restoration, and fill the supported database and table information into the corresponding positions in the preceding example.</para>
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
