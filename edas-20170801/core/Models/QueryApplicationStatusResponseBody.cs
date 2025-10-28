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
                /// <para>EDAS-scaled-cluster:default cluster</para>
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

            /// <summary>
            /// <para>The information about deployment records.</para>
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
                    /// <para>The time when the deployment record was created. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1573626226691</para>
                    /// </summary>
                    [NameInMap("CreateTime")]
                    [Validation(Required=false)]
                    public long? CreateTime { get; set; }

                    /// <summary>
                    /// <para>The ID of the deployment record.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>bbc6c0d5-d792-4907-<b><b>-</b></b>********</para>
                    /// </summary>
                    [NameInMap("DeployRecordId")]
                    [Validation(Required=false)]
                    public string DeployRecordId { get; set; }

                    /// <summary>
                    /// <para>The unique ID of the ECC.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0cf49a6c-95a8-4aa8-<b><b>-</b></b>********</para>
                    /// </summary>
                    [NameInMap("EccId")]
                    [Validation(Required=false)]
                    public string EccId { get; set; }

                    /// <summary>
                    /// <para>The unique ID of the ECU.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>07bd417a-b863-477d-<b><b>-</b></b>********</para>
                    /// </summary>
                    [NameInMap("EcuId")]
                    [Validation(Required=false)]
                    public string EcuId { get; set; }

                    /// <summary>
                    /// <para>The MD5 hash value of the deployment package.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>d0db5bcb442e492104d0f00e10a03dd9</para>
                    /// </summary>
                    [NameInMap("PackageMd5")]
                    [Validation(Required=false)]
                    public string PackageMd5 { get; set; }

                    /// <summary>
                    /// <para>The version of the deployment package that was used to deploy an application in the instance group.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>441beb18-da42-44dc-<b><b>-</b></b>********</para>
                    /// </summary>
                    [NameInMap("PackageVersionId")]
                    [Validation(Required=false)]
                    public string PackageVersionId { get; set; }

                }

            }

            /// <summary>
            /// <para>The information about elastic compute containers (ECCs).</para>
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
                    /// <para>The ID of the application.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>3616cdca-4f92-4413-<b><b>-</b></b>********</para>
                    /// </summary>
                    [NameInMap("AppId")]
                    [Validation(Required=false)]
                    public string AppId { get; set; }

                    /// <summary>
                    /// <para>The status of the application instance. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>0: AGENT_OFF: indicates that the agent is offline.</description></item>
                    /// <item><description>1: STOPPED: indicates that the application is stopped.</description></item>
                    /// <item><description>3: RUNNING_BUT_URL_FAILED: indicates that the health check failed.</description></item>
                    /// <item><description>7: RUNNING: indicates that the application is running.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>7</para>
                    /// </summary>
                    [NameInMap("AppState")]
                    [Validation(Required=false)]
                    public int? AppState { get; set; }

                    /// <summary>
                    /// <para>The status of the container.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>“”</para>
                    /// </summary>
                    [NameInMap("ContainerStatus")]
                    [Validation(Required=false)]
                    public string ContainerStatus { get; set; }

                    /// <summary>
                    /// <para>The time when the ECC was created. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1573626226691</para>
                    /// </summary>
                    [NameInMap("CreateTime")]
                    [Validation(Required=false)]
                    public long? CreateTime { get; set; }

                    /// <summary>
                    /// <para>The unique ID of the ECC.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0cf49a6c-95a8-4aa8-<b><b>-</b></b>********</para>
                    /// </summary>
                    [NameInMap("EccId")]
                    [Validation(Required=false)]
                    public string EccId { get; set; }

                    /// <summary>
                    /// <para>The unique ID of the ECU.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>07bd417a-b863-477d-<b><b>-</b></b>********</para>
                    /// </summary>
                    [NameInMap("EcuId")]
                    [Validation(Required=false)]
                    public string EcuId { get; set; }

                    /// <summary>
                    /// <para>The ID of the instance group.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>8123db90-880f-486f-<b><b>-</b></b>********</para>
                    /// </summary>
                    [NameInMap("GroupId")]
                    [Validation(Required=false)]
                    public string GroupId { get; set; }

                    /// <summary>
                    /// <para>The private IP address of the ECU.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>172.16.<em>.</em>**</para>
                    /// </summary>
                    [NameInMap("Ip")]
                    [Validation(Required=false)]
                    public string Ip { get; set; }

                    /// <summary>
                    /// <para>The state of the latest task initiated on the application instance. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>0: UNKNOWN: indicates that the state of the latest task is unknown.</description></item>
                    /// <item><description>1: PROCESSING: indicates that the latest task is being processed.</description></item>
                    /// <item><description>2: SUCCESS: indicates that the latest task is executed.</description></item>
                    /// <item><description>3: FAILED: indicates that the latest task failed.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>3</para>
                    /// </summary>
                    [NameInMap("TaskState")]
                    [Validation(Required=false)]
                    public int? TaskState { get; set; }

                    /// <summary>
                    /// <para>The time when the ECC was last modified. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1573635952012</para>
                    /// </summary>
                    [NameInMap("UpdateTime")]
                    [Validation(Required=false)]
                    public long? UpdateTime { get; set; }

                    /// <summary>
                    /// <para>The ID of the VPC.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>vpc-wz9b246zg************</para>
                    /// </summary>
                    [NameInMap("VpcId")]
                    [Validation(Required=false)]
                    public string VpcId { get; set; }

                }

            }

            /// <summary>
            /// <para>The information about elastic compute units (ECUs).</para>
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
                    /// <para>The number of available CPU cores.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("AvailableCpu")]
                    [Validation(Required=false)]
                    public int? AvailableCpu { get; set; }

                    /// <summary>
                    /// <para>The size of the available memory.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("AvailableMem")]
                    [Validation(Required=false)]
                    public int? AvailableMem { get; set; }

                    /// <summary>
                    /// <para>The time when the ECU was created. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1573626207270</para>
                    /// </summary>
                    [NameInMap("CreateTime")]
                    [Validation(Required=false)]
                    public long? CreateTime { get; set; }

                    /// <summary>
                    /// <para>Indicates whether Docker is installed.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("DockerEnv")]
                    [Validation(Required=false)]
                    public bool? DockerEnv { get; set; }

                    /// <summary>
                    /// <para>The unique ID of the ECU. You can run the <c>dmidecode</c> command on the ECS instance to query the ECU ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>07bd417a-b863-477d-<b><b>-</b></b>********</para>
                    /// </summary>
                    [NameInMap("EcuId")]
                    [Validation(Required=false)]
                    public string EcuId { get; set; }

                    /// <summary>
                    /// <para>The ID of the group.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>8123db90-880f-486f-<b><b>-</b></b>********</para>
                    /// </summary>
                    [NameInMap("GroupId")]
                    [Validation(Required=false)]
                    public string GroupId { get; set; }

                    /// <summary>
                    /// <para>The time when the last heartbeat detection was performed. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1573635952012</para>
                    /// </summary>
                    [NameInMap("HeartbeatTime")]
                    [Validation(Required=false)]
                    public long? HeartbeatTime { get; set; }

                    /// <summary>
                    /// <para>The ID of the instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>i-wz9fp1ljg***********</para>
                    /// </summary>
                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                    /// <summary>
                    /// <para>The private IP address of the ECU.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>172.16.<em>.</em>*</para>
                    /// </summary>
                    [NameInMap("IpAddr")]
                    [Validation(Required=false)]
                    public string IpAddr { get; set; }

                    /// <summary>
                    /// <para>The name of the ECU.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>EDAS-scaled-cluster: default cluster</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the ECU is online.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("Online")]
                    [Validation(Required=false)]
                    public bool? Online { get; set; }

                    /// <summary>
                    /// <para>The ID of the region.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cn-shen****-*</para>
                    /// </summary>
                    [NameInMap("RegionId")]
                    [Validation(Required=false)]
                    public string RegionId { get; set; }

                    /// <summary>
                    /// <para>The time when the ECU was last modified. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1573635952012</para>
                    /// </summary>
                    [NameInMap("UpdateTime")]
                    [Validation(Required=false)]
                    public long? UpdateTime { get; set; }

                    /// <summary>
                    /// <para>The ID of the user associated with the ECU.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>edas_com***_****@<em><em><b><b>-</b></b></em>.</em>**</para>
                    /// </summary>
                    [NameInMap("UserId")]
                    [Validation(Required=false)]
                    public string UserId { get; set; }

                    /// <summary>
                    /// <para>The ID of the virtual private cloud (VPC).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>vpc-wz9b246zg************</para>
                    /// </summary>
                    [NameInMap("VpcId")]
                    [Validation(Required=false)]
                    public string VpcId { get; set; }

                    /// <summary>
                    /// <para>The ID of the zone.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cn-shen****-*</para>
                    /// </summary>
                    [NameInMap("ZoneId")]
                    [Validation(Required=false)]
                    public string ZoneId { get; set; }

                }

            }

            /// <summary>
            /// <para>The information about the instance groups.</para>
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
                    /// <para>The ID of the application.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>3616cdca-4f92-4413-<b><b>-</b></b>********</para>
                    /// </summary>
                    [NameInMap("AppId")]
                    [Validation(Required=false)]
                    public string AppId { get; set; }

                    /// <summary>
                    /// <para>The ID of the change process for application deployment in the instance group.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>changeorder_a**_*******_**</para>
                    /// </summary>
                    [NameInMap("AppVersionId")]
                    [Validation(Required=false)]
                    public string AppVersionId { get; set; }

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
                    /// <para>The time when the instance group was created. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1573626155185</para>
                    /// </summary>
                    [NameInMap("CreateTime")]
                    [Validation(Required=false)]
                    public long? CreateTime { get; set; }

                    /// <summary>
                    /// <para>The ID of the instance group.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>8123db90-880f-486f-<b><b>-</b></b>********</para>
                    /// </summary>
                    [NameInMap("GroupId")]
                    [Validation(Required=false)]
                    public string GroupId { get; set; }

                    /// <summary>
                    /// <para>The name of the instance group.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>_DEFAULT_GROUP</para>
                    /// </summary>
                    [NameInMap("GroupName")]
                    [Validation(Required=false)]
                    public string GroupName { get; set; }

                    /// <summary>
                    /// <para>The type of the instance group. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>0: default group</description></item>
                    /// <item><description>1: self-managed group</description></item>
                    /// <item><description>2: canary release group</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("GroupType")]
                    [Validation(Required=false)]
                    public int? GroupType { get; set; }

                    /// <summary>
                    /// <para>The version of the deployment package that was used to deploy an application in the instance group.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>441beb18-da42-44dc-<b><b>-</b></b>********</para>
                    /// </summary>
                    [NameInMap("PackageVersionId")]
                    [Validation(Required=false)]
                    public string PackageVersionId { get; set; }

                    /// <summary>
                    /// <para>The time when the instance group was last modified. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1573627441388</para>
                    /// </summary>
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
