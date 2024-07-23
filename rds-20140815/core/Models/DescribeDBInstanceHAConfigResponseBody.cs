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
        /// <para>rm-uf6wjk5xxxxxx</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The high availability mode of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>RPO</b>: Data consistency is preferred. The instance ensures data reliability to minimize data losses. If you have high requirements on data consistency, select this mode.</description></item>
        /// <item><description><b>RTO</b>: Service availability is preferred. The instance restores the database service at the earliest opportunity to ensure service availability. If you have high requirements on instance availability, select this mode.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is returned only for instances that run MySQL.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>RPO</para>
        /// </summary>
        [NameInMap("HAMode")]
        [Validation(Required=false)]
        public string HAMode { get; set; }

        /// <summary>
        /// <para>An array that consists of the information of the primary and secondary instances.</para>
        /// </summary>
        [NameInMap("HostInstanceInfos")]
        [Validation(Required=false)]
        public DescribeDBInstanceHAConfigResponseBodyHostInstanceInfos HostInstanceInfos { get; set; }
        public class DescribeDBInstanceHAConfigResponseBodyHostInstanceInfos : TeaModel {
            [NameInMap("NodeInfo")]
            [Validation(Required=false)]
            public List<DescribeDBInstanceHAConfigResponseBodyHostInstanceInfosNodeInfo> NodeInfo { get; set; }
            public class DescribeDBInstanceHAConfigResponseBodyHostInstanceInfosNodeInfo : TeaModel {
                /// <summary>
                /// <para>The time when the secondary instance completed the synchronization of data from the primary instance. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2018-05-05T15:15:00Z</para>
                /// </summary>
                [NameInMap("DataSyncTime")]
                [Validation(Required=false)]
                public string DataSyncTime { get; set; }

                /// <summary>
                /// <para>The time when the secondary instance received logs from the primary instance. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2018-05-05T15:15:00Z</para>
                /// </summary>
                [NameInMap("LogSyncTime")]
                [Validation(Required=false)]
                public string LogSyncTime { get; set; }

                /// <summary>
                /// <para>The ID of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3397027</para>
                /// </summary>
                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public string NodeId { get; set; }

                /// <summary>
                /// <para>The type of the node. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Master</b>: the primary node</description></item>
                /// <item><description><b>Slave</b>: the secondary node</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Master</para>
                /// </summary>
                [NameInMap("NodeType")]
                [Validation(Required=false)]
                public string NodeType { get; set; }

                /// <summary>
                /// <para>The region ID of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The synchronization status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>NotAvailable</b>: The synchronization fails. This means that faults occur.</description></item>
                /// <item><description><b>Syncing</b>: The synchronization is in process. In this case, a primary/secondary switchover may cause data losses.</description></item>
                /// <item><description><b>Synchronized</b>: The synchronization is completed.</description></item>
                /// <item><description><b>NotSupport</b>: The database engine or database engine version does not involve the synchronization between the primary and secondary instances.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>NotAvailable</para>
                /// </summary>
                [NameInMap("SyncStatus")]
                [Validation(Required=false)]
                public string SyncStatus { get; set; }

                /// <summary>
                /// <para>The ID of the zone.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou-b</para>
                /// </summary>
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
        /// <para>The data replication mode of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Sync</b>: the synchronous mode</description></item>
        /// <item><description><b>Semi-sync</b>: the semi-synchronous replication mode</description></item>
        /// <item><description><b>Async</b>: the asynchronous mode</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is returned only for instances that run MySQL.</para>
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
