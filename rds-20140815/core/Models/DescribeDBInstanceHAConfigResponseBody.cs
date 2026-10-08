// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeDBInstanceHAConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-uf6wjk5****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The High-availability Mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>RPO</b>: Data consistency is preferred. The instance prioritizes data reliability to minimize data loss. Use RPO mode if you have high requirements for data consistency.</description></item>
        /// <item><description><b>RTO</b>: Instance availability is preferred. The instance recovers services as soon as possible to maximize available time. Use RTO mode if you have high requirements for database uptime.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is returned only for ApsaraDB RDS for MySQL instances.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>RPO</para>
        /// </summary>
        [NameInMap("HAMode")]
        [Validation(Required=false)]
        public string HAMode { get; set; }

        [NameInMap("HostInstanceInfos")]
        [Validation(Required=false)]
        public DescribeDBInstanceHAConfigResponseBodyHostInstanceInfos HostInstanceInfos { get; set; }
        public class DescribeDBInstanceHAConfigResponseBodyHostInstanceInfos : TeaModel {
            [NameInMap("NodeInfo")]
            [Validation(Required=false)]
            public List<DescribeDBInstanceHAConfigResponseBodyHostInstanceInfosNodeInfo> NodeInfo { get; set; }
            public class DescribeDBInstanceHAConfigResponseBodyHostInstanceInfosNodeInfo : TeaModel {
                [NameInMap("DataSyncTime")]
                [Validation(Required=false)]
                public string DataSyncTime { get; set; }

                [NameInMap("LogSyncTime")]
                [Validation(Required=false)]
                public string LogSyncTime { get; set; }

                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public string NodeId { get; set; }

                [NameInMap("NodeType")]
                [Validation(Required=false)]
                public string NodeType { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("SyncStatus")]
                [Validation(Required=false)]
                public string SyncStatus { get; set; }

                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1AD222E9-E606-4A42-BF6D-8A4442913CEF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The data replication mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Sync</b>: synchronous replication</description></item>
        /// <item><description><b>Semi-sync</b>: semi-synchronous replication</description></item>
        /// <item><description><b>Async</b>: asynchronous replication</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is returned only for ApsaraDB RDS for MySQL instances.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Sync</para>
        /// </summary>
        [NameInMap("SyncMode")]
        [Validation(Required=false)]
        public string SyncMode { get; set; }

    }

}
