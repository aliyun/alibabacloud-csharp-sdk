// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class CreateHadoopDataSourceRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gp-xxxxxxx</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The service description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pxf for hdfs data source</para>
        /// </summary>
        [NameInMap("DataSourceDescription")]
        [Validation(Required=false)]
        public string DataSourceDescription { get; set; }

        /// <summary>
        /// <para>The service name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hdfs_pxf</para>
        /// </summary>
        [NameInMap("DataSourceName")]
        [Validation(Required=false)]
        public string DataSourceName { get; set; }

        /// <summary>
        /// <para>The type of the Hadoop external table to enable. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>HDFS</description></item>
        /// <item><description>Hive</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>HDFS</para>
        /// </summary>
        [NameInMap("DataSourceType")]
        [Validation(Required=false)]
        public string DataSourceType { get; set; }

        /// <summary>
        /// <para>The ID of the EMR instance. This parameter is required when HadoopCreateType is set to Emr.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c-1234567</para>
        /// </summary>
        [NameInMap("EmrInstanceId")]
        [Validation(Required=false)]
        public string EmrInstanceId { get; set; }

        /// <summary>
        /// <para>The content string of the Hadoop hdfs-site.xml file. This parameter is required when you enable HDFS external tables.</para>
        /// 
        /// <b>Example:</b>
        /// <?xml version="1.0" ?>
        /// <!-- Created at 2023-08-15 13:52:43.945 -->
        /// <configuration>
        ///     <property>
        ///         <name>dfs.datanode.cache.revocation.timeout.ms</name>
        ///         <value>900000</value>
        ///     </property>
        ///     <property>
        ///         <name>dfs.namenode.resource.check.interval</name>
        ///         <value>5000</value>
        ///     </property>
        /// </configuration>
        /// </summary>
        [NameInMap("HDFSConf")]
        [Validation(Required=false)]
        public string HDFSConf { get; set; }

        /// <summary>
        /// <para>The content string of the Hadoop core-site.xml file.</para>
        /// 
        /// <b>Example:</b>
        /// <?xml version="1.0" ?>
        /// <!-- Created at 2023-08-15 13:52:39.527 -->
        /// <configuration>
        ///     <property>
        ///         <name>hadoop.http.authentication.kerberos.keytab</name>
        ///         <value>/etc/emr/hadoop-conf/http.keytab</value>
        ///     </property>
        ///     <property>
        ///         <name>fs.oss.idle.timeout.millisecond</name>
        ///         <value>30000</value>
        ///     </property>
        ///     <property>
        ///         <name>fs.oss.download.thread.concurrency</name>
        ///         <value>32</value>
        ///     </property>
        /// </configuration>
        /// </summary>
        [NameInMap("HadoopCoreConf")]
        [Validation(Required=false)]
        public string HadoopCoreConf { get; set; }

        /// <summary>
        /// <para>The external service type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>emr</description></item>
        /// <item><description>hadoop: self-managed Hadoop.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>emr</para>
        /// </summary>
        [NameInMap("HadoopCreateType")]
        [Validation(Required=false)]
        public string HadoopCreateType { get; set; }

        /// <summary>
        /// <para>The addresses and hostnames of the source nodes in the Hadoop cluster in the /etc/hosts file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.220.128 master-1-1.c-xxx.cn-shanghai.emr.aliyuncs.com
        /// 192.168.220.129 core-1-1.c-xxx.cn-shanghai.emr.aliyuncs.com
        /// 192.168.220.130 core-1-2.c-xxx.cn-shanghai.emr.aliyuncs.com</para>
        /// </summary>
        [NameInMap("HadoopHostsAddress")]
        [Validation(Required=false)]
        public string HadoopHostsAddress { get; set; }

        /// <summary>
        /// <para>The content string of the Hadoop hive-site.xml file. This parameter is required when you enable Hive external tables.</para>
        /// 
        /// <b>Example:</b>
        /// <?xml version="1.0" ?>
        /// <!-- Created at 2023-08-15 13:52:50.646 -->
        /// <configuration>
        ///     <property>
        ///         <name>hive.exec.reducers.bytes.per.reducer</name>
        ///         <value>256000000</value>
        ///     </property>
        ///     <property>
        ///         <name>hive.stats.column.autogather</name>
        ///         <value>false</value>
        ///     </property>
        /// </configuration>
        /// </summary>
        [NameInMap("HiveConf")]
        [Validation(Required=false)]
        public string HiveConf { get; set; }

        /// <summary>
        /// <para>The content string of the Hadoop mapred-site.xml file. This parameter is required when you enable HDFS external tables.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxxxx</para>
        /// </summary>
        [NameInMap("MapReduceConf")]
        [Validation(Required=false)]
        public string MapReduceConf { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/86912.html">DescribeRegions</a> operation to query available region IDs.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The content string of the Hadoop yarn-site.xml file. This parameter is required when you enable HDFS external tables.</para>
        /// 
        /// <b>Example:</b>
        /// <?xml version="1.0" ?>
        /// <!-- Created at 2023-08-15 13:53:29.021 -->
        /// <configuration>
        ///     <property>
        ///         <name>yarn.nodemanager.linux-container-executor.nonsecure-mode.local-user</name>
        ///         <value>hadoop</value>
        ///     </property>
        ///     <property>
        ///         <name>yarn.scheduler.fair.dynamic.max.assign</name>
        ///         <value>true</value>
        ///     </property>
        /// </configuration>
        /// </summary>
        [NameInMap("YarnConf")]
        [Validation(Required=false)]
        public string YarnConf { get; set; }

    }

}
