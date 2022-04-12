// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class QueryApplicationStatusResponseBody : TeaModel {
        [NameInMap("AppInfo")]
        [Validation(Required=false)]
        public QueryApplicationStatusResponseBodyAppInfo AppInfo { get; set; }
        public class QueryApplicationStatusResponseBodyAppInfo : TeaModel {
            [NameInMap("Application")]
            [Validation(Required=false)]
            public QueryApplicationStatusResponseBodyAppInfoApplication Application { get; set; }
            public class QueryApplicationStatusResponseBodyAppInfoApplication : TeaModel {
                [NameInMap("ApplicationId")]
                [Validation(Required=false)]
                public string ApplicationId { get; set; }

                [NameInMap("BuildPackageId")]
                [Validation(Required=false)]
                public int? BuildPackageId { get; set; }

                [NameInMap("ClusterId")]
                [Validation(Required=false)]
                public string ClusterId { get; set; }

                [NameInMap("Cpu")]
                [Validation(Required=false)]
                public int? Cpu { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                [NameInMap("Dockerize")]
                [Validation(Required=false)]
                public bool? Dockerize { get; set; }

                [NameInMap("Email")]
                [Validation(Required=false)]
                public string Email { get; set; }

                [NameInMap("HealthCheckUrl")]
                [Validation(Required=false)]
                public string HealthCheckUrl { get; set; }

                [NameInMap("InstanceCount")]
                [Validation(Required=false)]
                public int? InstanceCount { get; set; }

                [NameInMap("LaunchTime")]
                [Validation(Required=false)]
                public long? LaunchTime { get; set; }

                [NameInMap("Memory")]
                [Validation(Required=false)]
                public int? Memory { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }

                [NameInMap("Phone")]
                [Validation(Required=false)]
                public string Phone { get; set; }

                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("RunningInstanceCount")]
                [Validation(Required=false)]
                public int? RunningInstanceCount { get; set; }

                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }
            [NameInMap("DeployRecordList")]
            [Validation(Required=false)]
            public QueryApplicationStatusResponseBodyAppInfoDeployRecordList DeployRecordList { get; set; }
            public class QueryApplicationStatusResponseBodyAppInfoDeployRecordList : TeaModel {
                [NameInMap("DeployRecord")]
                [Validation(Required=false)]
                public List<QueryApplicationStatusResponseBodyAppInfoDeployRecordListDeployRecord> DeployRecord { get; set; }
                public class QueryApplicationStatusResponseBodyAppInfoDeployRecordListDeployRecord : TeaModel {
                    [NameInMap("CreateTime")]
                    [Validation(Required=false)]
                    public long? CreateTime { get; set; }

                    [NameInMap("DeployRecordId")]
                    [Validation(Required=false)]
                    public string DeployRecordId { get; set; }

                    [NameInMap("EccId")]
                    [Validation(Required=false)]
                    public string EccId { get; set; }

                    [NameInMap("EcuId")]
                    [Validation(Required=false)]
                    public string EcuId { get; set; }

                    [NameInMap("PackageMd5")]
                    [Validation(Required=false)]
                    public string PackageMd5 { get; set; }

                    [NameInMap("PackageVersionId")]
                    [Validation(Required=false)]
                    public string PackageVersionId { get; set; }

                }

            }
            [NameInMap("EccList")]
            [Validation(Required=false)]
            public QueryApplicationStatusResponseBodyAppInfoEccList EccList { get; set; }
            public class QueryApplicationStatusResponseBodyAppInfoEccList : TeaModel {
                [NameInMap("Ecc")]
                [Validation(Required=false)]
                public List<QueryApplicationStatusResponseBodyAppInfoEccListEcc> Ecc { get; set; }
                public class QueryApplicationStatusResponseBodyAppInfoEccListEcc : TeaModel {
                    [NameInMap("AppId")]
                    [Validation(Required=false)]
                    public string AppId { get; set; }

                    [NameInMap("AppState")]
                    [Validation(Required=false)]
                    public int? AppState { get; set; }

                    [NameInMap("ContainerStatus")]
                    [Validation(Required=false)]
                    public string ContainerStatus { get; set; }

                    [NameInMap("CreateTime")]
                    [Validation(Required=false)]
                    public long? CreateTime { get; set; }

                    [NameInMap("EccId")]
                    [Validation(Required=false)]
                    public string EccId { get; set; }

                    [NameInMap("EcuId")]
                    [Validation(Required=false)]
                    public string EcuId { get; set; }

                    [NameInMap("GroupId")]
                    [Validation(Required=false)]
                    public string GroupId { get; set; }

                    [NameInMap("Ip")]
                    [Validation(Required=false)]
                    public string Ip { get; set; }

                    [NameInMap("TaskState")]
                    [Validation(Required=false)]
                    public int? TaskState { get; set; }

                    [NameInMap("UpdateTime")]
                    [Validation(Required=false)]
                    public long? UpdateTime { get; set; }

                    [NameInMap("VpcId")]
                    [Validation(Required=false)]
                    public string VpcId { get; set; }

                }

            }
            [NameInMap("EcuList")]
            [Validation(Required=false)]
            public QueryApplicationStatusResponseBodyAppInfoEcuList EcuList { get; set; }
            public class QueryApplicationStatusResponseBodyAppInfoEcuList : TeaModel {
                [NameInMap("Ecu")]
                [Validation(Required=false)]
                public List<QueryApplicationStatusResponseBodyAppInfoEcuListEcu> Ecu { get; set; }
                public class QueryApplicationStatusResponseBodyAppInfoEcuListEcu : TeaModel {
                    [NameInMap("AvailableCpu")]
                    [Validation(Required=false)]
                    public int? AvailableCpu { get; set; }

                    [NameInMap("AvailableMem")]
                    [Validation(Required=false)]
                    public int? AvailableMem { get; set; }

                    [NameInMap("CreateTime")]
                    [Validation(Required=false)]
                    public long? CreateTime { get; set; }

                    [NameInMap("DockerEnv")]
                    [Validation(Required=false)]
                    public bool? DockerEnv { get; set; }

                    [NameInMap("EcuId")]
                    [Validation(Required=false)]
                    public string EcuId { get; set; }

                    [NameInMap("GroupId")]
                    [Validation(Required=false)]
                    public string GroupId { get; set; }

                    [NameInMap("HeartbeatTime")]
                    [Validation(Required=false)]
                    public long? HeartbeatTime { get; set; }

                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                    [NameInMap("IpAddr")]
                    [Validation(Required=false)]
                    public string IpAddr { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("Online")]
                    [Validation(Required=false)]
                    public bool? Online { get; set; }

                    [NameInMap("RegionId")]
                    [Validation(Required=false)]
                    public string RegionId { get; set; }

                    [NameInMap("UpdateTime")]
                    [Validation(Required=false)]
                    public long? UpdateTime { get; set; }

                    [NameInMap("UserId")]
                    [Validation(Required=false)]
                    public string UserId { get; set; }

                    [NameInMap("VpcId")]
                    [Validation(Required=false)]
                    public string VpcId { get; set; }

                    [NameInMap("ZoneId")]
                    [Validation(Required=false)]
                    public string ZoneId { get; set; }

                }

            }
            [NameInMap("GroupList")]
            [Validation(Required=false)]
            public QueryApplicationStatusResponseBodyAppInfoGroupList GroupList { get; set; }
            public class QueryApplicationStatusResponseBodyAppInfoGroupList : TeaModel {
                [NameInMap("Group")]
                [Validation(Required=false)]
                public List<QueryApplicationStatusResponseBodyAppInfoGroupListGroup> Group { get; set; }
                public class QueryApplicationStatusResponseBodyAppInfoGroupListGroup : TeaModel {
                    [NameInMap("AppId")]
                    [Validation(Required=false)]
                    public string AppId { get; set; }

                    [NameInMap("AppVersionId")]
                    [Validation(Required=false)]
                    public string AppVersionId { get; set; }

                    [NameInMap("ClusterId")]
                    [Validation(Required=false)]
                    public string ClusterId { get; set; }

                    [NameInMap("CreateTime")]
                    [Validation(Required=false)]
                    public long? CreateTime { get; set; }

                    [NameInMap("GroupId")]
                    [Validation(Required=false)]
                    public string GroupId { get; set; }

                    [NameInMap("GroupName")]
                    [Validation(Required=false)]
                    public string GroupName { get; set; }

                    [NameInMap("GroupType")]
                    [Validation(Required=false)]
                    public int? GroupType { get; set; }

                    [NameInMap("PackageVersionId")]
                    [Validation(Required=false)]
                    public string PackageVersionId { get; set; }

                    [NameInMap("UpdateTime")]
                    [Validation(Required=false)]
                    public long? UpdateTime { get; set; }

                }

            }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
