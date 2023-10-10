// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class QueryApplicationStatusResponseBody : TeaModel {
        /// <summary>
        /// The information about the application.
        /// </summary>
        [NameInMap("AppInfo")]
        [Validation(Required=false)]
        public QueryApplicationStatusResponseBodyAppInfo AppInfo { get; set; }
        public class QueryApplicationStatusResponseBodyAppInfo : TeaModel {
            /// <summary>
            /// The basic information about the application.
            /// </summary>
            [NameInMap("Application")]
            [Validation(Required=false)]
            public QueryApplicationStatusResponseBodyAppInfoApplication Application { get; set; }
            public class QueryApplicationStatusResponseBodyAppInfoApplication : TeaModel {
                /// <summary>
                /// The ID of the application.
                /// </summary>
                [NameInMap("ApplicationId")]
                [Validation(Required=false)]
                public string ApplicationId { get; set; }

                /// <summary>
                /// The build package number of Enterprise Distributed Application Service (EDAS) Container.
                /// </summary>
                [NameInMap("BuildPackageId")]
                [Validation(Required=false)]
                public int? BuildPackageId { get; set; }

                /// <summary>
                /// The ID of the cluster.
                /// </summary>
                [NameInMap("ClusterId")]
                [Validation(Required=false)]
                public string ClusterId { get; set; }

                /// <summary>
                /// The number of CPU cores used by the application.
                /// </summary>
                [NameInMap("Cpu")]
                [Validation(Required=false)]
                public int? Cpu { get; set; }

                /// <summary>
                /// The time when the application was created. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// Indicates whether the application is a Docker application.
                /// </summary>
                [NameInMap("Dockerize")]
                [Validation(Required=false)]
                public bool? Dockerize { get; set; }

                /// <summary>
                /// The email address of the user who created the application.
                /// </summary>
                [NameInMap("Email")]
                [Validation(Required=false)]
                public string Email { get; set; }

                /// <summary>
                /// The health check URL.
                /// </summary>
                [NameInMap("HealthCheckUrl")]
                [Validation(Required=false)]
                public string HealthCheckUrl { get; set; }

                /// <summary>
                /// The number of application instances.
                /// </summary>
                [NameInMap("InstanceCount")]
                [Validation(Required=false)]
                public int? InstanceCount { get; set; }

                /// <summary>
                /// The time when the application was launched. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
                /// </summary>
                [NameInMap("LaunchTime")]
                [Validation(Required=false)]
                public long? LaunchTime { get; set; }

                /// <summary>
                /// The memory size.
                /// </summary>
                [NameInMap("Memory")]
                [Validation(Required=false)]
                public int? Memory { get; set; }

                /// <summary>
                /// The name of the application.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The ID of the user who created the application.
                /// </summary>
                [NameInMap("Owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }

                /// <summary>
                /// The mobile number of the user who created the application.
                /// </summary>
                [NameInMap("Phone")]
                [Validation(Required=false)]
                public string Phone { get; set; }

                /// <summary>
                /// The port used by the application.
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                /// <summary>
                /// The ID of the namespace.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// The number of application instances that are running.
                /// </summary>
                [NameInMap("RunningInstanceCount")]
                [Validation(Required=false)]
                public int? RunningInstanceCount { get; set; }

                /// <summary>
                /// The ID of the Alibaba Cloud account.
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            /// <summary>
            /// The information about deployment records.
            /// </summary>
            [NameInMap("DeployRecordList")]
            [Validation(Required=false)]
            public QueryApplicationStatusResponseBodyAppInfoDeployRecordList DeployRecordList { get; set; }
            public class QueryApplicationStatusResponseBodyAppInfoDeployRecordList : TeaModel {
                [NameInMap("DeployRecord")]
                [Validation(Required=false)]
                public List<QueryApplicationStatusResponseBodyAppInfoDeployRecordListDeployRecord> DeployRecord { get; set; }
                public class QueryApplicationStatusResponseBodyAppInfoDeployRecordListDeployRecord : TeaModel {
                    /// <summary>
                    /// The time when the deployment record was created. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
                    /// </summary>
                    [NameInMap("CreateTime")]
                    [Validation(Required=false)]
                    public long? CreateTime { get; set; }

                    /// <summary>
                    /// The ID of the deployment record.
                    /// </summary>
                    [NameInMap("DeployRecordId")]
                    [Validation(Required=false)]
                    public string DeployRecordId { get; set; }

                    /// <summary>
                    /// The unique ID of the ECC.
                    /// </summary>
                    [NameInMap("EccId")]
                    [Validation(Required=false)]
                    public string EccId { get; set; }

                    /// <summary>
                    /// The unique ID of the ECU.
                    /// </summary>
                    [NameInMap("EcuId")]
                    [Validation(Required=false)]
                    public string EcuId { get; set; }

                    /// <summary>
                    /// The MD5 hash value of the deployment package.
                    /// </summary>
                    [NameInMap("PackageMd5")]
                    [Validation(Required=false)]
                    public string PackageMd5 { get; set; }

                    /// <summary>
                    /// The version of the deployment package that was used to deploy an application in the instance group.
                    /// </summary>
                    [NameInMap("PackageVersionId")]
                    [Validation(Required=false)]
                    public string PackageVersionId { get; set; }

                }

            }

            /// <summary>
            /// The information about elastic compute containers (ECCs).
            /// </summary>
            [NameInMap("EccList")]
            [Validation(Required=false)]
            public QueryApplicationStatusResponseBodyAppInfoEccList EccList { get; set; }
            public class QueryApplicationStatusResponseBodyAppInfoEccList : TeaModel {
                [NameInMap("Ecc")]
                [Validation(Required=false)]
                public List<QueryApplicationStatusResponseBodyAppInfoEccListEcc> Ecc { get; set; }
                public class QueryApplicationStatusResponseBodyAppInfoEccListEcc : TeaModel {
                    /// <summary>
                    /// The ID of the application.
                    /// </summary>
                    [NameInMap("AppId")]
                    [Validation(Required=false)]
                    public string AppId { get; set; }

                    /// <summary>
                    /// The status of the application instance. Valid values:
                    /// 
                    /// *   0: AGENT_OFF: indicates that the agent is offline.
                    /// *   1: STOPPED: indicates that the application is stopped.
                    /// *   3: RUNNING_BUT_URL_FAILED: indicates that the health check failed.
                    /// *   7: RUNNING: indicates that the application is running.
                    /// </summary>
                    [NameInMap("AppState")]
                    [Validation(Required=false)]
                    public int? AppState { get; set; }

                    /// <summary>
                    /// The status of the container.
                    /// </summary>
                    [NameInMap("ContainerStatus")]
                    [Validation(Required=false)]
                    public string ContainerStatus { get; set; }

                    /// <summary>
                    /// The time when the ECC was created. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
                    /// </summary>
                    [NameInMap("CreateTime")]
                    [Validation(Required=false)]
                    public long? CreateTime { get; set; }

                    /// <summary>
                    /// The unique ID of the ECC.
                    /// </summary>
                    [NameInMap("EccId")]
                    [Validation(Required=false)]
                    public string EccId { get; set; }

                    /// <summary>
                    /// The unique ID of the ECU.
                    /// </summary>
                    [NameInMap("EcuId")]
                    [Validation(Required=false)]
                    public string EcuId { get; set; }

                    /// <summary>
                    /// The ID of the instance group.
                    /// </summary>
                    [NameInMap("GroupId")]
                    [Validation(Required=false)]
                    public string GroupId { get; set; }

                    /// <summary>
                    /// The private IP address of the ECU.
                    /// </summary>
                    [NameInMap("Ip")]
                    [Validation(Required=false)]
                    public string Ip { get; set; }

                    /// <summary>
                    /// The state of the latest task initiated on the application instance. Valid values:
                    /// 
                    /// *   0: UNKNOWN: indicates that the state of the latest task is unknown.
                    /// *   1: PROCESSING: indicates that the latest task is being processed.
                    /// *   2: SUCCESS: indicates that the latest task is executed.
                    /// *   3: FAILED: indicates that the latest task failed.
                    /// </summary>
                    [NameInMap("TaskState")]
                    [Validation(Required=false)]
                    public int? TaskState { get; set; }

                    /// <summary>
                    /// The time when the ECC was last modified. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
                    /// </summary>
                    [NameInMap("UpdateTime")]
                    [Validation(Required=false)]
                    public long? UpdateTime { get; set; }

                    /// <summary>
                    /// The ID of the VPC.
                    /// </summary>
                    [NameInMap("VpcId")]
                    [Validation(Required=false)]
                    public string VpcId { get; set; }

                }

            }

            /// <summary>
            /// The information about elastic compute units (ECUs).
            /// </summary>
            [NameInMap("EcuList")]
            [Validation(Required=false)]
            public QueryApplicationStatusResponseBodyAppInfoEcuList EcuList { get; set; }
            public class QueryApplicationStatusResponseBodyAppInfoEcuList : TeaModel {
                [NameInMap("Ecu")]
                [Validation(Required=false)]
                public List<QueryApplicationStatusResponseBodyAppInfoEcuListEcu> Ecu { get; set; }
                public class QueryApplicationStatusResponseBodyAppInfoEcuListEcu : TeaModel {
                    /// <summary>
                    /// The number of available CPU cores.
                    /// </summary>
                    [NameInMap("AvailableCpu")]
                    [Validation(Required=false)]
                    public int? AvailableCpu { get; set; }

                    /// <summary>
                    /// The size of the available memory.
                    /// </summary>
                    [NameInMap("AvailableMem")]
                    [Validation(Required=false)]
                    public int? AvailableMem { get; set; }

                    /// <summary>
                    /// The time when the ECU was created. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
                    /// </summary>
                    [NameInMap("CreateTime")]
                    [Validation(Required=false)]
                    public long? CreateTime { get; set; }

                    /// <summary>
                    /// Indicates whether Docker is installed.
                    /// </summary>
                    [NameInMap("DockerEnv")]
                    [Validation(Required=false)]
                    public bool? DockerEnv { get; set; }

                    /// <summary>
                    /// The unique ID of the ECU. You can run the `dmidecode` command on the ECS instance to query the ECU ID.
                    /// </summary>
                    [NameInMap("EcuId")]
                    [Validation(Required=false)]
                    public string EcuId { get; set; }

                    /// <summary>
                    /// The ID of the group.
                    /// </summary>
                    [NameInMap("GroupId")]
                    [Validation(Required=false)]
                    public string GroupId { get; set; }

                    /// <summary>
                    /// The time when the last heartbeat detection was performed. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
                    /// </summary>
                    [NameInMap("HeartbeatTime")]
                    [Validation(Required=false)]
                    public long? HeartbeatTime { get; set; }

                    /// <summary>
                    /// The ID of the instance.
                    /// </summary>
                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                    /// <summary>
                    /// The private IP address of the ECU.
                    /// </summary>
                    [NameInMap("IpAddr")]
                    [Validation(Required=false)]
                    public string IpAddr { get; set; }

                    /// <summary>
                    /// The name of the ECU.
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// Indicates whether the ECU is online.
                    /// </summary>
                    [NameInMap("Online")]
                    [Validation(Required=false)]
                    public bool? Online { get; set; }

                    /// <summary>
                    /// The ID of the region.
                    /// </summary>
                    [NameInMap("RegionId")]
                    [Validation(Required=false)]
                    public string RegionId { get; set; }

                    /// <summary>
                    /// The time when the ECU was last modified. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
                    /// </summary>
                    [NameInMap("UpdateTime")]
                    [Validation(Required=false)]
                    public long? UpdateTime { get; set; }

                    /// <summary>
                    /// The ID of the user associated with the ECU.
                    /// </summary>
                    [NameInMap("UserId")]
                    [Validation(Required=false)]
                    public string UserId { get; set; }

                    /// <summary>
                    /// The ID of the virtual private cloud (VPC).
                    /// </summary>
                    [NameInMap("VpcId")]
                    [Validation(Required=false)]
                    public string VpcId { get; set; }

                    /// <summary>
                    /// The ID of the zone.
                    /// </summary>
                    [NameInMap("ZoneId")]
                    [Validation(Required=false)]
                    public string ZoneId { get; set; }

                }

            }

            /// <summary>
            /// The information about the instance groups.
            /// </summary>
            [NameInMap("GroupList")]
            [Validation(Required=false)]
            public QueryApplicationStatusResponseBodyAppInfoGroupList GroupList { get; set; }
            public class QueryApplicationStatusResponseBodyAppInfoGroupList : TeaModel {
                [NameInMap("Group")]
                [Validation(Required=false)]
                public List<QueryApplicationStatusResponseBodyAppInfoGroupListGroup> Group { get; set; }
                public class QueryApplicationStatusResponseBodyAppInfoGroupListGroup : TeaModel {
                    /// <summary>
                    /// The ID of the application.
                    /// </summary>
                    [NameInMap("AppId")]
                    [Validation(Required=false)]
                    public string AppId { get; set; }

                    /// <summary>
                    /// The ID of the change process for application deployment in the instance group.
                    /// </summary>
                    [NameInMap("AppVersionId")]
                    [Validation(Required=false)]
                    public string AppVersionId { get; set; }

                    /// <summary>
                    /// The ID of the cluster.
                    /// </summary>
                    [NameInMap("ClusterId")]
                    [Validation(Required=false)]
                    public string ClusterId { get; set; }

                    /// <summary>
                    /// The time when the instance group was created. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
                    /// </summary>
                    [NameInMap("CreateTime")]
                    [Validation(Required=false)]
                    public long? CreateTime { get; set; }

                    /// <summary>
                    /// The ID of the instance group.
                    /// </summary>
                    [NameInMap("GroupId")]
                    [Validation(Required=false)]
                    public string GroupId { get; set; }

                    /// <summary>
                    /// The name of the instance group.
                    /// </summary>
                    [NameInMap("GroupName")]
                    [Validation(Required=false)]
                    public string GroupName { get; set; }

                    /// <summary>
                    /// The type of the instance group. Valid values:
                    /// 
                    /// *   0: default group
                    /// *   1: self-managed group
                    /// *   2: canary release group
                    /// </summary>
                    [NameInMap("GroupType")]
                    [Validation(Required=false)]
                    public int? GroupType { get; set; }

                    /// <summary>
                    /// The version of the deployment package that was used to deploy an application in the instance group.
                    /// </summary>
                    [NameInMap("PackageVersionId")]
                    [Validation(Required=false)]
                    public string PackageVersionId { get; set; }

                    /// <summary>
                    /// The time when the instance group was last modified. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
                    /// </summary>
                    [NameInMap("UpdateTime")]
                    [Validation(Required=false)]
                    public long? UpdateTime { get; set; }

                }

            }

        }

        /// <summary>
        /// The HTTP status code that is returned.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The additional information that is returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
