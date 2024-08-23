// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeHadoopDataSourceResponseBody : TeaModel {
        /// <summary>
        /// The time when the service was created.
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// The description of the service. The description can be up to 256 characters in length.
        /// </summary>
        [NameInMap("DataSourceDescription")]
        [Validation(Required=false)]
        public string DataSourceDescription { get; set; }

        /// <summary>
        /// The service directory in which Hadoop-related configuration files are stored.
        /// </summary>
        [NameInMap("DataSourceDir")]
        [Validation(Required=false)]
        public string DataSourceDir { get; set; }

        /// <summary>
        /// The data source ID.
        /// </summary>
        [NameInMap("DataSourceId")]
        [Validation(Required=false)]
        public string DataSourceId { get; set; }

        /// <summary>
        /// The name of the service.
        /// </summary>
        [NameInMap("DataSourceName")]
        [Validation(Required=false)]
        public string DataSourceName { get; set; }

        /// <summary>
        /// The status of the service. Valid values:
        /// 
        /// *   init
        /// *   running
        /// *   exception
        /// </summary>
        [NameInMap("DataSourceStatus")]
        [Validation(Required=false)]
        public string DataSourceStatus { get; set; }

        [NameInMap("DataSourceType")]
        [Validation(Required=false)]
        public string DataSourceType { get; set; }

        /// <summary>
        /// The E-MapReduce (EMR) Hadoop cluster ID.
        /// </summary>
        [NameInMap("EmrInstanceId")]
        [Validation(Required=false)]
        public string EmrInstanceId { get; set; }

        [NameInMap("ExternalDataServiceId")]
        [Validation(Required=false)]
        public string ExternalDataServiceId { get; set; }

        /// <summary>
        /// The content of the Hadoop hdfs-site.xml file.
        /// </summary>
        [NameInMap("HDFSConf")]
        [Validation(Required=false)]
        public string HDFSConf { get; set; }

        /// <summary>
        /// The content of the Hadoop core-site.xml file.
        /// </summary>
        [NameInMap("HadoopCoreConf")]
        [Validation(Required=false)]
        public string HadoopCoreConf { get; set; }

        /// <summary>
        /// The type of the external service. Valid values:
        /// 
        /// *   HDFS
        /// *   HIVE
        /// </summary>
        [NameInMap("HadoopCreateType")]
        [Validation(Required=false)]
        public string HadoopCreateType { get; set; }

        /// <summary>
        /// *   The address and hostname of the Hadoop cluster (data source) in the /etc/hosts directory.
        /// *
        /// </summary>
        [NameInMap("HadoopHostsAddress")]
        [Validation(Required=false)]
        public string HadoopHostsAddress { get; set; }

        /// <summary>
        /// The content of the Hadoop hive-site.xml file.
        /// </summary>
        [NameInMap("HiveConf")]
        [Validation(Required=false)]
        public string HiveConf { get; set; }

        /// <summary>
        /// The content of the Hadoop MapReduceConf file.
        /// </summary>
        [NameInMap("MapReduceConf")]
        [Validation(Required=false)]
        public string MapReduceConf { get; set; }

        [NameInMap("ModifyTime")]
        [Validation(Required=false)]
        public string ModifyTime { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The information about the service status. For example, if the service is in the exception state, the cause of the exception is displayed. If the service is in the running state, this parameter is left empty.
        /// </summary>
        [NameInMap("StatusMessage")]
        [Validation(Required=false)]
        public string StatusMessage { get; set; }

        /// <summary>
        /// The content of the Hadoop yarn-site.xml file.
        /// </summary>
        [NameInMap("YarnConf")]
        [Validation(Required=false)]
        public string YarnConf { get; set; }

    }

}
