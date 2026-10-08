// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class QueryApplicationStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the application.</para>
        /// </summary>
        [NameInMap("AppInfo")]
        [Validation(Required=false)]
        public QueryApplicationStatusResponseBodyAppInfo AppInfo { get; set; }
        public class QueryApplicationStatusResponseBodyAppInfo : TeaModel {
            /// <summary>
            /// <para>The basic information about the application.</para>
            /// </summary>
            [NameInMap("Application")]
            [Validation(Required=false)]
            public QueryApplicationStatusResponseBodyAppInfoApplication Application { get; set; }
            public class QueryApplicationStatusResponseBodyAppInfoApplication : TeaModel {
                /// <summary>
                /// <para>The ID of the application.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3616cdca-4f92-4413-<b><b>-</b></b>********</para>
                /// </summary>
                [NameInMap("ApplicationId")]
                [Validation(Required=false)]
                public string ApplicationId { get; set; }

                /// <summary>
                /// <para>The build package number of Enterprise Distributed Application Service (EDAS) Container.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("BuildPackageId")]
                [Validation(Required=false)]
                public int? BuildPackageId { get; set; }

                /// <summary>
                /// <para>The ID of the cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0d247b93-8d62-4e34-<b><b>-</b></b>********</para>
                /// </summary>
                [NameInMap("ClusterId")]
                [Validation(Required=false)]
                public string ClusterId { get; set; }

                /// <summary>
                /// <para>The number of CPU cores used by the application.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Cpu")]
                [Validation(Required=false)]
                public int? Cpu { get; set; }

                /// <summary>
                /// <para>The time when the application was created. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1573626207270</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>Indicates whether the application is a Docker application.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Dockerize")]
                [Validation(Required=false)]
                public bool? Dockerize { get; set; }

                /// <summary>
                /// <para>The email address of the user who created the application.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="mailto:1234567@qq.com">1234567@qq.com</a></para>
                /// </summary>
                [NameInMap("Email")]
                [Validation(Required=false)]
                public string Email { get; set; }

                /// <summary>
                /// <para>The health check URL.</para>
                /// 
                /// <b>Example:</b>
                /// <para>“”</para>
                /// </summary>
                [NameInMap("HealthCheckUrl")]
                [Validation(Required=false)]
                public string HealthCheckUrl { get; set; }

                /// <summary>
                /// <para>The number of application instances.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("InstanceCount")]
                [Validation(Required=false)]
                public int? InstanceCount { get; set; }

                /// <summary>
                /// <para>The time when the application was launched. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("LaunchTime")]
                [Validation(Required=false)]
                public long? LaunchTime { get; set; }

                /// <summary>
                /// <para>The memory size.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Memory")]
                [Validation(Required=false)]
                public int? Memory { get; set; }

                /// <summary>
                /// <para>The name of the application.</para>
                /// 
                /// <b>Example:</b>
                /// <para>EDAS-scaled-cluster：默认集群</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The ID of the user who created the application.</para>
                /// 
                /// <b>Example:</b>
                /// <para>edas_com***_****@<em><em><b><b>-</b></b></em>.</em>**</para>
                /// </summary>
                [NameInMap("Owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }

                /// <summary>
                /// <para>The mobile number of the user who created the application.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1886666****</para>
                /// </summary>
                [NameInMap("Phone")]
                [Validation(Required=false)]
                public string Phone { get; set; }

                /// <summary>
                /// <para>The port used by the application.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8080</para>
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                /// <summary>
                /// <para>The ID of the namespace.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-shenzhen:test</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The number of application instances that are running.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("RunningInstanceCount")]
                [Validation(Required=false)]
                public int? RunningInstanceCount { get; set; }

                /// <summary>
                /// <para>The ID of the Alibaba Cloud account.</para>
                /// 
                /// <b>Example:</b>
                /// <para>edas_com***_****@<em><em><b><b>-</b></b></em>.</em>**</para>
                /// </summary>
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

        }

        /// <summary>
        /// <para>The HTTP status code that is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The additional information that is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D16979DC-4D42-********</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
