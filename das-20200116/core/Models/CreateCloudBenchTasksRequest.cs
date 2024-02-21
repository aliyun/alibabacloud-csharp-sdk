// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class CreateCloudBenchTasksRequest : TeaModel {
        /// <summary>
        /// The total number of stress testing tasks that you want to create. Valid values: **0** to **30**. Default value: **1**.
        /// </summary>
        [NameInMap("Amount")]
        [Validation(Required=false)]
        public string Amount { get; set; }

        /// <summary>
        /// The ID of the backup set. You can call the [DescribeBackups](~~26273~~) operation to query the ID of the backup set.
        /// </summary>
        [NameInMap("BackupId")]
        [Validation(Required=false)]
        public string BackupId { get; set; }

        /// <summary>
        /// The time when the backup starts. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.
        /// </summary>
        [NameInMap("BackupTime")]
        [Validation(Required=false)]
        public string BackupTime { get; set; }

        /// <summary>
        /// The type of the stress testing client. Valid values:
        /// 
        /// *   **ECS**: indicates that you must create the [DBGateway](~~64905~~).
        /// *   **DAS_ECS**: indicates that DAS automatically purchases and deploys an Elastic Compute Service (ECS) instance for stress testing.
        /// </summary>
        [NameInMap("ClientType")]
        [Validation(Required=false)]
        public string ClientType { get; set; }

        /// <summary>
        /// The description of the stress testing task.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The endpoint of the destination instance. The specified endpoint must be the endpoint of an ApsaraDB RDS for MySQL instance or a PolarDB for MySQL instance.
        /// 
        /// >  This parameter takes effect only if you set **DstType** to **ConnectionString**.
        /// </summary>
        [NameInMap("DstConnectionString")]
        [Validation(Required=false)]
        public string DstConnectionString { get; set; }

        /// <summary>
        /// The ID of the destination instance. The instance must be an ApsaraDB RDS for MySQL instance or a PolarDB for MySQL instance. You can call the [GetInstanceInspections](~~202857~~) operation to query the ID.
        /// 
        /// >  This parameter must be specified if you set **DstType** to **Instance**.
        /// </summary>
        [NameInMap("DstInstanceId")]
        [Validation(Required=false)]
        public string DstInstanceId { get; set; }

        /// <summary>
        /// The port number of the instance that you want to access.
        /// 
        /// >  This parameter takes effect only if you set **DstType** to **ConnectionString**.
        /// </summary>
        [NameInMap("DstPort")]
        [Validation(Required=false)]
        public string DstPort { get; set; }

        /// <summary>
        /// The name of the privileged account for the destination instance.
        /// </summary>
        [NameInMap("DstSuperAccount")]
        [Validation(Required=false)]
        public string DstSuperAccount { get; set; }

        /// <summary>
        /// The password of the privileged account for the destination instance.
        /// </summary>
        [NameInMap("DstSuperPassword")]
        [Validation(Required=false)]
        public string DstSuperPassword { get; set; }

        /// <summary>
        /// The type of the identifier that is used to indicate the destination instance. Valid values:
        /// 
        /// *   **Instance**: the instance ID. This is the default value.
        /// *   **ConnectionString**: the endpoint of the instance.
        /// </summary>
        [NameInMap("DstType")]
        [Validation(Required=false)]
        public string DstType { get; set; }

        /// <summary>
        /// The specification of the Data Transmission Service (DTS) migration task. You can call the [DescribeCloudbenchTask](~~230669~~) operation to query the specification.
        /// 
        /// >  You must migrate the basic data in the source instance to the destination instance before you start a stress testing task. When you create a DTS migration task, you must specify this parameter.
        /// </summary>
        [NameInMap("DtsJobClass")]
        [Validation(Required=false)]
        public string DtsJobClass { get; set; }

        /// <summary>
        /// The ID of the DTS migration task. You can call the [ConfigureDtsJob](~~208399~~) operation to query the ID.
        /// 
        /// >  After a DTS migration task is created in the DTS console, you must specify this parameter.
        /// </summary>
        [NameInMap("DtsJobId")]
        [Validation(Required=false)]
        public string DtsJobId { get; set; }

        /// <summary>
        /// The state that specifies the last operation that is performed for the stress testing task. Valid values:
        /// 
        /// *   **WAIT_TARGET**: prepares the destination instance
        /// *   **WAIT_DBGATEWAY**: prepares the DBGateway
        /// *   **WAIT_SQL**: prepares the full SQL statistics
        /// *   **WAIT_LOGIC**: prepares to replay the traffic
        /// 
        /// >  When the state of a stress testing task changes to the state that is specified by the EndState parameter, the stress testing task becomes completed.
        /// </summary>
        [NameInMap("EndState")]
        [Validation(Required=false)]
        public string EndState { get; set; }

        /// <summary>
        /// The ID of the virtual private cloud (VPC) in which the database gateway (DBGateway) is deployed.
        /// 
        /// >  This parameter must be specified if you set **ClientType** to **ECS**.
        /// </summary>
        [NameInMap("GatewayVpcId")]
        [Validation(Required=false)]
        public string GatewayVpcId { get; set; }

        /// <summary>
        /// The IP address or domain name of the DBGateway.
        /// 
        /// >  This parameter must be specified if you set **ClientType** to **ECS**.
        /// </summary>
        [NameInMap("GatewayVpcIp")]
        [Validation(Required=false)]
        public string GatewayVpcIp { get; set; }

        /// <summary>
        /// The rate at which the traffic captured from the source instance is replayed on the destination instance. The value must be a positive integer. Valid values: **1** to **30**. Default value: **1**.
        /// </summary>
        [NameInMap("Rate")]
        [Validation(Required=false)]
        public string Rate { get; set; }

        /// <summary>
        /// The duration of the stress testing task for which the traffic is captured from the source instance. Unit: milliseconds.
        /// </summary>
        [NameInMap("RequestDuration")]
        [Validation(Required=false)]
        public string RequestDuration { get; set; }

        /// <summary>
        /// The time when the stress testing task ends. Set this parameter to a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
        /// </summary>
        [NameInMap("RequestEndTime")]
        [Validation(Required=false)]
        public string RequestEndTime { get; set; }

        /// <summary>
        /// The time when the stress testing task starts. Set this parameter to a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
        /// </summary>
        [NameInMap("RequestStartTime")]
        [Validation(Required=false)]
        public string RequestStartTime { get; set; }

        /// <summary>
        /// The duration within which the traffic generation stressing test takes effect. Unit: milliseconds.
        /// 
        /// >  This parameter must be specified if you set **TaskType** to **smart pressure test**.
        /// </summary>
        [NameInMap("SmartPressureTime")]
        [Validation(Required=false)]
        public string SmartPressureTime { get; set; }

        /// <summary>
        /// The ID of the source instance. The instance must be an ApsaraDB RDS for MySQL instance or a PolarDB for MySQL instance. You can call the [GetInstanceInspections](~~202857~~) operation to query the ID.
        /// 
        /// >  This parameter must be specified if you set **DstType** to **Instance**.
        /// </summary>
        [NameInMap("SrcInstanceId")]
        [Validation(Required=false)]
        public string SrcInstanceId { get; set; }

        /// <summary>
        /// The reserved parameter.
        /// </summary>
        [NameInMap("SrcPublicIp")]
        [Validation(Required=false)]
        public string SrcPublicIp { get; set; }

        /// <summary>
        /// The name of the privileged account for the source instance. Set the value to **admin**.
        /// 
        /// >  This parameter must be specified if you set **DstType** to **Instance**.
        /// </summary>
        [NameInMap("SrcSuperAccount")]
        [Validation(Required=false)]
        public string SrcSuperAccount { get; set; }

        /// <summary>
        /// The password of the privileged account for the source instance.
        /// 
        /// >  This parameter must be specified if you set **DstType** to **Instance**.
        /// </summary>
        [NameInMap("SrcSuperPassword")]
        [Validation(Required=false)]
        public string SrcSuperPassword { get; set; }

        /// <summary>
        /// The type of the stress testing task. Valid values:
        /// 
        /// *   **pressure test** (default): A task of this type replays the traffic that is captured from the source instance on the destination instance at the maximum playback rate that is supported by the destination instance.
        /// *   **smart pressure test**: A task of this type analyzes the traffic that is captured from the source instance over a short period of time and generates traffic on the destination instance for continuous stress testing. The business model based on which the traffic is generated on the destination instance and the traffic distribution are consistent with those on the source instance. Stress testing tasks of this type can help you reduce the amount of time that is consumed to collect data from the source instance and reduce storage costs and performance overheads.
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

        /// <summary>
        /// The temporary directory generated for stress testing.
        /// </summary>
        [NameInMap("WorkDir")]
        [Validation(Required=false)]
        public string WorkDir { get; set; }

    }

}
