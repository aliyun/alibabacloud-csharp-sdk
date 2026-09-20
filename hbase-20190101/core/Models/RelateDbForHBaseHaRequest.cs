// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.HBase20190101.Models
{
    public class RelateDbForHBaseHaRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the BDS cluster. You can call the <a href="https://help.aliyun.com/document_detail/144595.html">DescribeInstances</a> operation to obtain the cluster ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bds-t4nj9v2x85******</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The instance ID of the primary instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hb-bp1w6krp539******</para>
        /// </summary>
        [NameInMap("HaActive")]
        [Validation(Required=false)]
        public string HaActive { get; set; }

        /// <summary>
        /// <para>The ZooKeeper address of the primary instance. This parameter is required when the primary instance is a non-standard instance (IsActiveStandard is set to false).</para>
        /// 
        /// <b>Example:</b>
        /// <para>hb-t4naqsay5gn******-master1-001.hbase.singapore.rds.aliyuncs.com,hb-t4naqsay5gn******-master3-001.hbase.singapore.rds.aliyuncs.com,hb-t4naqsay5gn******-master2-001.hbase.singapore.rds.aliyuncs.com:2181:/hbase</para>
        /// </summary>
        [NameInMap("HaActiveClusterKey")]
        [Validation(Required=false)]
        public string HaActiveClusterKey { get; set; }

        /// <summary>
        /// <para>The cluster type of the primary instance. Valid values: <b>HBase</b> and <b>HBaseue</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hbase</para>
        /// </summary>
        [NameInMap("HaActiveDBType")]
        [Validation(Required=false)]
        public string HaActiveDBType { get; set; }

        /// <summary>
        /// <para>The HDFS directory of the primary instance. This parameter is required when the primary instance is a non-standard instance (IsActiveStandard is set to false).</para>
        /// 
        /// <b>Example:</b>
        /// <para>/hbase</para>
        /// </summary>
        [NameInMap("HaActiveHbaseFsDir")]
        [Validation(Required=false)]
        public string HaActiveHbaseFsDir { get; set; }

        /// <summary>
        /// <para>The HDFS URI of the primary instance. This parameter is required when the primary instance is a non-standard instance (IsActiveStandard is set to false).</para>
        /// 
        /// <b>Example:</b>
        /// <para>hdfs://hb-t4naqsay5gn******-master1-001.hbase.rds.aliyuncs.com:8020,hb-t4naqsay5gn******-master2-001.hbase.rds.aliyuncs.com:8020</para>
        /// </summary>
        [NameInMap("HaActiveHdfsUri")]
        [Validation(Required=false)]
        public string HaActiveHdfsUri { get; set; }

        /// <summary>
        /// <para>The password that corresponds to the username of the primary instance. This parameter is required when the primary instance is <b>HBaseue</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>root</para>
        /// </summary>
        [NameInMap("HaActivePassword")]
        [Validation(Required=false)]
        public string HaActivePassword { get; set; }

        /// <summary>
        /// <para>The username of the primary instance. This parameter is required when the primary instance is <b>HBaseue</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>root</para>
        /// </summary>
        [NameInMap("HaActiveUser")]
        [Validation(Required=false)]
        public string HaActiveUser { get; set; }

        /// <summary>
        /// <para>The database engine version of the primary instance. This parameter is required when the primary instance is a non-standard instance (IsActiveStandard is set to false). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>HBase1x</b>: HBase 1.x.</description></item>
        /// <item><description><b>HBase2x</b>: HBase 2.x.</description></item>
        /// <item><description><b>HBaseUE</b>: HBaseue.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>HBase2x</para>
        /// </summary>
        [NameInMap("HaActiveVersion")]
        [Validation(Required=false)]
        public string HaActiveVersion { get; set; }

        /// <summary>
        /// <para>The synchronization type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>CLUSTER</b>: instance-level synchronization.</description></item>
        /// <item><description><b>TABLE</b>: table-level synchronization.</description></item>
        /// <item><description><b>SKIP</b>: no synchronization required.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CLUSTER</para>
        /// </summary>
        [NameInMap("HaMigrateType")]
        [Validation(Required=false)]
        public string HaMigrateType { get; set; }

        /// <summary>
        /// <para>The ID of the secondary instance cluster.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hb-bp1bl7iqzka******</para>
        /// </summary>
        [NameInMap("HaStandby")]
        [Validation(Required=false)]
        public string HaStandby { get; set; }

        /// <summary>
        /// <para>The ZooKeeper address of the secondary instance. This parameter is required when the secondary instance is a non-standard instance (IsStandbyStandard is set to false).</para>
        /// 
        /// <b>Example:</b>
        /// <para>hb-bp1w6krp539******-master1-001.hbase.singapore.rds.aliyuncs.com,hb-bp1w6krp539******-master3-001.hbase.singapore.rds.aliyuncs.com,hb-t4naqsay5gn******-master2-001.hbase.singapore.rds.aliyuncs.com:2181:/hbase</para>
        /// </summary>
        [NameInMap("HaStandbyClusterKey")]
        [Validation(Required=false)]
        public string HaStandbyClusterKey { get; set; }

        /// <summary>
        /// <para>The cluster type of the secondary instance. Valid values: <b>HBase</b> and <b>HBaseue</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hbase</para>
        /// </summary>
        [NameInMap("HaStandbyDBType")]
        [Validation(Required=false)]
        public string HaStandbyDBType { get; set; }

        /// <summary>
        /// <para>The HDFS directory of the secondary instance. This parameter is required when the secondary instance is a non-standard instance (IsStandbyStandard is set to false).</para>
        /// 
        /// <b>Example:</b>
        /// <para>/hbase</para>
        /// </summary>
        [NameInMap("HaStandbyHbaseFsDir")]
        [Validation(Required=false)]
        public string HaStandbyHbaseFsDir { get; set; }

        /// <summary>
        /// <para>The HDFS URI of the secondary instance. This parameter is required when the secondary instance is a non-standard instance (IsStandbyStandard is set to false).</para>
        /// 
        /// <b>Example:</b>
        /// <para>hdfs://hb-bp1w6krp539******-master1-001.hbase.rds.aliyuncs.com:8020,hb-bp1w6krp539******-master2-001.hbase.rds.aliyuncs.com:8020</para>
        /// </summary>
        [NameInMap("HaStandbyHdfsUri")]
        [Validation(Required=false)]
        public string HaStandbyHdfsUri { get; set; }

        /// <summary>
        /// <para>The password that corresponds to the username of the secondary instance. This parameter is required when the secondary instance is <b>hbaseue</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>root</para>
        /// </summary>
        [NameInMap("HaStandbyPassword")]
        [Validation(Required=false)]
        public string HaStandbyPassword { get; set; }

        /// <summary>
        /// <para>The username of the secondary instance. This parameter is required when the secondary instance is <b>hbaseue</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>root</para>
        /// </summary>
        [NameInMap("HaStandbyUser")]
        [Validation(Required=false)]
        public string HaStandbyUser { get; set; }

        /// <summary>
        /// <para>The database engine version of the secondary instance. This parameter is required when the secondary instance is a non-standard instance (IsStandbyStandard is set to false). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>HBase1x</b>: HBase 1.x.</description></item>
        /// <item><description><b>HBase2x</b>: HBase 2.x.</description></item>
        /// <item><description><b>HBaseUE</b>: HBaseue.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>HBase2x</para>
        /// </summary>
        [NameInMap("HaStandbyVersion")]
        [Validation(Required=false)]
        public string HaStandbyVersion { get; set; }

        /// <summary>
        /// <para>The tables to synchronize. This parameter is required when HaMigrateType is set to TABLE. Separate multiple tables with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>test,test1</para>
        /// </summary>
        [NameInMap("HaTables")]
        [Validation(Required=false)]
        public string HaTables { get; set; }

        /// <summary>
        /// <para>Specifies whether the primary instance is a standard instance. Set this parameter to <b>true</b> for a standard instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsActiveStandard")]
        [Validation(Required=false)]
        public bool? IsActiveStandard { get; set; }

        /// <summary>
        /// <para>Specifies whether the secondary instance is a standard instance. Set this parameter to <b>true</b> for a standard instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsStandbyStandard")]
        [Validation(Required=false)]
        public bool? IsStandbyStandard { get; set; }

    }

}
