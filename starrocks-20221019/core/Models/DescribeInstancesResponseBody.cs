// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Starrocks20221019.Models
{
    public class DescribeInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>The query results.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeInstancesResponseBodyData> Data { get; set; }
        public class DescribeInstancesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The network access control list (ACL) ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acl-bp1xc6b9vs013jjtp****</para>
            /// </summary>
            [NameInMap("AclId")]
            [Validation(Required=false)]
            public string AclId { get; set; }

            /// <summary>
            /// <para>The AI dedicated cluster ID, prefixed with af-. This value is returned if an unreleased dedicated cluster exists (including clusters being created). This value is empty if no dedicated cluster has been created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>af-498ae4af</para>
            /// </summary>
            [NameInMap("AiFunctionClusterId")]
            [Validation(Required=false)]
            public string AiFunctionClusterId { get; set; }

            /// <summary>
            /// <para>The internal network connection endpoint of the AI dedicated cluster, in the format fe-{AiFunctionClusterId}-internal.starrocks.aliyuncs.com. This value is returned only after the dedicated cluster is created. This value is empty if no dedicated cluster has been created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>fe-af-498ae4af-internal.starrocks.aliyuncs.com</para>
            /// </summary>
            [NameInMap("AiFunctionEndpoint")]
            [Validation(Required=false)]
            public string AiFunctionEndpoint { get; set; }

            /// <summary>
            /// <para>The billing instance ID for the AI function.</para>
            /// </summary>
            [NameInMap("AiFunctionInstanceId")]
            [Validation(Required=false)]
            public string AiFunctionInstanceId { get; set; }

            /// <summary>
            /// <para>The instance architecture. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>onEci: deployed on Elastic Container Instance (ECI).</description></item>
            /// <item><description>onECS: deployed on Elastic Compute Service (ECS).</description></item>
            /// <item><description>onBareMetal: deployed on a bare metal resource pool.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>onECS</para>
            /// </summary>
            [NameInMap("Architecture")]
            [Validation(Required=false)]
            public string Architecture { get; set; }

            /// <summary>
            /// <para>The time when the cluster was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1733292921000</para>
            /// </summary>
            [NameInMap("BeginTime")]
            [Validation(Required=false)]
            public long? BeginTime { get; set; }

            /// <summary>
            /// <para>Indicates whether the AI center is enabled. Default value: false.</para>
            /// </summary>
            [NameInMap("EnableAiFunction")]
            [Validation(Required=false)]
            public bool? EnableAiFunction { get; set; }

            /// <summary>
            /// <para>Indicates whether automatic minor version upgrades are enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableAutoMinorVersionUpgrade")]
            [Validation(Required=false)]
            public bool? EnableAutoMinorVersionUpgrade { get; set; }

            [NameInMap("EnableMultiAz")]
            [Validation(Required=false)]
            public bool? EnableMultiAz { get; set; }

            /// <summary>
            /// <para>Indicates whether SSL is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableSSL")]
            [Validation(Required=false)]
            public bool? EnableSSL { get; set; }

            /// <summary>
            /// <para>Indicates whether the audit plug-in is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnabledAuditLoader")]
            [Validation(Required=false)]
            public bool? EnabledAuditLoader { get; set; }

            /// <summary>
            /// <para>Indicates whether encryption is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Encrypted")]
            [Validation(Required=false)]
            public bool? Encrypted { get; set; }

            /// <summary>
            /// <para>The time when the cluster expires.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4889001600000</para>
            /// </summary>
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public long? ExpireTime { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>c-d4be777ff5e8cXXX</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The instance name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sr_test_1</para>
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// <para>The instance status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>not_init: Not initialized.</description></item>
            /// <item><description>unpaid: Pending payment.</description></item>
            /// <item><description>paid: Paid.</description></item>
            /// <item><description>creating: Being created.</description></item>
            /// <item><description>creating_failed: Creation failed.</description></item>
            /// <item><description>created: Created.</description></item>
            /// <item><description>running: Running.</description></item>
            /// <item><description>updating: Being upgraded.</description></item>
            /// <item><description>agent_creating: Agent is being created.</description></item>
            /// <item><description>agent_scaling_up: Agent specifications are being upgraded.</description></item>
            /// <item><description>modifying_config: Configuration is being updated.</description></item>
            /// <item><description>scaling_out: Scaling out.</description></item>
            /// <item><description>restarting: Restarting.</description></item>
            /// <item><description>scaling_in: Scaling in.</description></item>
            /// <item><description>scaling_up: Specifications are being upgraded.</description></item>
            /// <item><description>scaling_down: Specifications are being downgraded.</description></item>
            /// <item><description>upgrading: Version is being upgraded.</description></item>
            /// <item><description>enable_public_network: Public network access is being enabled.</description></item>
            /// <item><description>disable_public_network: Public network access is being disabled.</description></item>
            /// <item><description>convert_from_trial_to_official: Edition is being converted.</description></item>
            /// <item><description>migration_cluster_to_serverless: Cluster is being migrated.</description></item>
            /// <item><description>modifying_timezone: Time zone is being modified.</description></item>
            /// <item><description>switch_az: Primary/secondary zone switchover is in progress.</description></item>
            /// <item><description>enabling: Being resumed.</description></item>
            /// <item><description>disable: Unavailable.</description></item>
            /// <item><description>actively_disabled: Unavailable.</description></item>
            /// <item><description>deleting: Being deleted.</description></item>
            /// <item><description>deleting_failed: Deletion failed.</description></item>
            /// <item><description>deleted_with_error: Creation failed and terminated.</description></item>
            /// <item><description>deleted: Deleted.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>running</para>
            /// </summary>
            [NameInMap("InstanceStatus")]
            [Validation(Required=false)]
            public string InstanceStatus { get; set; }

            /// <summary>
            /// <para>Indicates whether read/write splitting is enabled. When enabled, the Leader FE node handles write requests and other nodes handle read requests.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsolateLeader")]
            [Validation(Required=false)]
            public bool? IsolateLeader { get; set; }

            /// <summary>
            /// <para>The KMS key ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rewqfds****</para>
            /// </summary>
            [NameInMap("KmsKeyId")]
            [Validation(Required=false)]
            public string KmsKeyId { get; set; }

            /// <summary>
            /// <para>The maintenance window of the instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>00:00-06:00</description></item>
            /// <item><description>06:00-07:00</description></item>
            /// <item><description>07:00-08:00</description></item>
            /// <item><description>08:00-09:00</description></item>
            /// <item><description>09:00-10:00</description></item>
            /// <item><description>10:00-11:00</description></item>
            /// <item><description>11:00-12:00</description></item>
            /// <item><description>12:00-13:00</description></item>
            /// <item><description>13:00-14:00</description></item>
            /// <item><description>14:00-15:00</description></item>
            /// <item><description>15:00-16:00</description></item>
            /// <item><description>16:00-17:00</description></item>
            /// <item><description>17:00-18:00</description></item>
            /// <item><description>18:00-19:00</description></item>
            /// <item><description>19:00-20:00</description></item>
            /// <item><description>20:00-21:00</description></item>
            /// <item><description>21:00-22:00</description></item>
            /// <item><description>22:00-23:00</description></item>
            /// <item><description>23:00-24:00</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>00:00-06:00</para>
            /// </summary>
            [NameInMap("MaintainablePeriod")]
            [Validation(Required=false)]
            public string MaintainablePeriod { get; set; }

            /// <summary>
            /// <para>The minor version number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3.2.11-1.79-1.6.5</para>
            /// </summary>
            [NameInMap("MinorVersion")]
            [Validation(Required=false)]
            public string MinorVersion { get; set; }

            /// <summary>
            /// <para>The monitoring service type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cms</para>
            /// </summary>
            [NameInMap("MonitorType")]
            [Validation(Required=false)]
            public string MonitorType { get; set; }

            /// <summary>
            /// <para>The OSS path.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss://sr-c-****</para>
            /// </summary>
            [NameInMap("OssLocation")]
            [Validation(Required=false)]
            public string OssLocation { get; set; }

            /// <summary>
            /// <para>The instance edition. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>trial: Trial Edition.</description></item>
            /// <item><description>official: Standard Edition.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>official</para>
            /// </summary>
            [NameInMap("PackageType")]
            [Validation(Required=false)]
            public string PackageType { get; set; }

            /// <summary>
            /// <para>The billing method. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>prePaid: subscription.</description></item>
            /// <item><description>postPaid: pay-as-you-go.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>postPaid</para>
            /// </summary>
            [NameInMap("PayType")]
            [Validation(Required=false)]
            public string PayType { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The resource group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-acfmytyuofb****</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The running mode of the cluster. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>shared_nothing: Shared-nothing architecture.</description></item>
            /// <item><description>shared_data: Storage-compute disaggregation.</description></item>
            /// <item><description>lakehouse: Data lakehouse analytics.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>shared_nothing</para>
            /// </summary>
            [NameInMap("RunMode")]
            [Validation(Required=false)]
            public string RunMode { get; set; }

            /// <summary>
            /// <para>The duration that the cluster has been running. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3645445</para>
            /// </summary>
            [NameInMap("RunningTime")]
            [Validation(Required=false)]
            public long? RunningTime { get; set; }

            /// <summary>
            /// <para>Indicates whether the security group is a managed security group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("SecurityGroupManaged")]
            [Validation(Required=false)]
            public bool? SecurityGroupManaged { get; set; }

            /// <summary>
            /// <para>The security group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sg-8vbaz2etr66a62b9****</para>
            /// </summary>
            [NameInMap("SgId")]
            [Validation(Required=false)]
            public string SgId { get; set; }

            /// <summary>
            /// <para>The tags that are bound to the instance.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<DescribeInstancesResponseBodyDataTags> Tags { get; set; }
            public class DescribeInstancesResponseBodyDataTags : TeaModel {
                /// <summary>
                /// <para>The tag key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>k1</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The tag value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>v1</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The vSwitches.</para>
            /// </summary>
            [NameInMap("VSwitches")]
            [Validation(Required=false)]
            public List<DescribeInstancesResponseBodyDataVSwitches> VSwitches { get; set; }
            public class DescribeInstancesResponseBodyDataVSwitches : TeaModel {
                /// <summary>
                /// <para>Indicates whether this is the primary vSwitch.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Primary")]
                [Validation(Required=false)]
                public bool? Primary { get; set; }

                /// <summary>
                /// <para>The vSwitch ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-bp1p0mldwx5av55v0xXXX</para>
                /// </summary>
                [NameInMap("VswId")]
                [Validation(Required=false)]
                public string VswId { get; set; }

                /// <summary>
                /// <para>The zone ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou-i</para>
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

            /// <summary>
            /// <para>The cluster version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3.2</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

            /// <summary>
            /// <para>VPC ID。</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-bp1rbvag1cafkj4prwXXX</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InvalidParams</para>
        /// </summary>
        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Invalid params: [instance not exists].</para>
        /// </summary>
        [NameInMap("ErrMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>32A44F0D-BFF6-5664-999A-218BBDE74XXX</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
