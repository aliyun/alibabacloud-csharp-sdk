// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeHadoopDataSourceResponseBody : TeaModel {
        /// <summary>
        /// <para>The time when the service was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-09-08T16:00:00Z</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The description of the service. The description can be up to 256 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pxf for hdfs data source</para>
        /// </summary>
        [NameInMap("DataSourceDescription")]
        [Validation(Required=false)]
        public string DataSourceDescription { get; set; }

        /// <summary>
        /// <para>The service directory in which Hadoop-related configuration files are stored.</para>
        /// 
        /// <b>Example:</b>
        /// <para>HadoopDir</para>
        /// </summary>
        [NameInMap("DataSourceDir")]
        [Validation(Required=false)]
        public string DataSourceDir { get; set; }

        /// <summary>
        /// <para>The data source ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("DataSourceId")]
        [Validation(Required=false)]
        public string DataSourceId { get; set; }

        /// <summary>
        /// <para>The name of the service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hdfs_pxf</para>
        /// </summary>
        [NameInMap("DataSourceName")]
        [Validation(Required=false)]
        public string DataSourceName { get; set; }

        /// <summary>
        /// <para>The status of the service. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Init</description></item>
        /// <item><description>Running</description></item>
        /// <item><description>Exception</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("DataSourceStatus")]
        [Validation(Required=false)]
        public string DataSourceStatus { get; set; }

        /// <summary>
        /// <para>The type of the data source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hive</para>
        /// </summary>
        [NameInMap("DataSourceType")]
        [Validation(Required=false)]
        public string DataSourceType { get; set; }

        /// <summary>
        /// <para>The E-MapReduce (EMR) Hadoop cluster ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c-1234567</para>
        /// </summary>
        [NameInMap("EmrInstanceId")]
        [Validation(Required=false)]
        public string EmrInstanceId { get; set; }

        /// <summary>
        /// <para>The Id of External Data Service</para>
        /// 
        /// <b>Example:</b>
        /// <para>2988</para>
        /// </summary>
        [NameInMap("ExternalDataServiceId")]
        [Validation(Required=false)]
        public string ExternalDataServiceId { get; set; }

        /// <summary>
        /// <para>The content of the Hadoop hdfs-site.xml file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxxxx</para>
        /// </summary>
        [NameInMap("HDFSConf")]
        [Validation(Required=false)]
        public string HDFSConf { get; set; }

        /// <summary>
        /// <para>The content of the Hadoop core-site.xml file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxxxx</para>
        /// </summary>
        [NameInMap("HadoopCoreConf")]
        [Validation(Required=false)]
        public string HadoopCoreConf { get; set; }

        /// <summary>
        /// <para>The type of the external service. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>emr</description></item>
        /// <item><description>selfCreate</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>HDFS</para>
        /// </summary>
        [NameInMap("HadoopCreateType")]
        [Validation(Required=false)]
        public string HadoopCreateType { get; set; }

        /// <summary>
        /// <para>The IP address and hostname of the Hadoop cluster (data source) in the /etc/hosts file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>127.0.0.1 localhost</para>
        /// </summary>
        [NameInMap("HadoopHostsAddress")]
        [Validation(Required=false)]
        public string HadoopHostsAddress { get; set; }

        /// <summary>
        /// <para>The content of the Hadoop hive-site.xml file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxxxx</para>
        /// </summary>
        [NameInMap("HiveConf")]
        [Validation(Required=false)]
        public string HiveConf { get; set; }

        /// <summary>
        /// <para>The content of the Hadoop mapred-site.xml file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxxxx</para>
        /// </summary>
        [NameInMap("MapReduceConf")]
        [Validation(Required=false)]
        public string MapReduceConf { get; set; }

        /// <summary>
        /// <para>The time when the service was last modified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-08-23T02:11:47Z</para>
        /// </summary>
        [NameInMap("ModifyTime")]
        [Validation(Required=false)]
        public string ModifyTime { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B4CAF581-2AC7-41AD-8940-D56DF7AADF5B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information about the service status. For example, if the service is in the exception state, the cause of the exception is displayed. If the service is in the running state, this parameter is left empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("StatusMessage")]
        [Validation(Required=false)]
        public string StatusMessage { get; set; }

        /// <summary>
        /// <para>The content of the Hadoop yarn-site.xml file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxxxx</para>
        /// </summary>
        [NameInMap("YarnConf")]
        [Validation(Required=false)]
        public string YarnConf { get; set; }

    }

}
