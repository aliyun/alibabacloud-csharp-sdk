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
            /// <para>The ID of the network access control list (ACL).</para>
            /// 
            /// <b>Example:</b>
            /// <para>acl-bp1xc6b9vs013jjtp****</para>
            /// </summary>
            [NameInMap("AclId")]
            [Validation(Required=false)]
            public string AclId { get; set; }

            [NameInMap("AiFunctionInstanceId")]
            [Validation(Required=false)]
            public string AiFunctionInstanceId { get; set; }

            /// <summary>
            /// <para>The instance architecture. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>onEci: deployed on ECI.</para>
            /// </description></item>
            /// <item><description><para>onECS: deployed on ECS.</para>
            /// </description></item>
            /// <item><description><para>onBareMetal: deployed on a bare metal resource pool.</para>
            /// </description></item>
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
            /// <para>Indicates whether the audit plugin is enabled.</para>
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
            /// <item><description><para>not_init: The instance is not initialized.</para>
            /// </description></item>
            /// <item><description><para>unpaid: The instance is pending payment.</para>
            /// </description></item>
            /// <item><description><para>paid: The payment is made.</para>
            /// </description></item>
            /// <item><description><para>creating: The instance is being created.</para>
            /// </description></item>
            /// <item><description><para>creating_failed: The instance failed to be created.</para>
            /// </description></item>
            /// <item><description><para>created: The instance is created.</para>
            /// </description></item>
            /// <item><description><para>running: The instance is running.</para>
            /// </description></item>
            /// <item><description><para>updating: The instance is being upgraded.</para>
            /// </description></item>
            /// <item><description><para>agent_creating: The agent is being created.</para>
            /// </description></item>
            /// <item><description><para>agent_scaling_up: The agent is being upgraded.</para>
            /// </description></item>
            /// <item><description><para>modifying_config: The configurations are being updated.</para>
            /// </description></item>
            /// <item><description><para>scaling_out: The instance is being scaled out.</para>
            /// </description></item>
            /// <item><description><para>restarting: The instance is restarting.</para>
            /// </description></item>
            /// <item><description><para>scaling_in: The instance is being scaled in.</para>
            /// </description></item>
            /// <item><description><para>scaling_up: The instance is being upgraded.</para>
            /// </description></item>
            /// <item><description><para>scaling_down: The instance is being downgraded.</para>
            /// </description></item>
            /// <item><description><para>upgrading: The instance is being upgraded.</para>
            /// </description></item>
            /// <item><description><para>enable_public_network: The public endpoint is being enabled.</para>
            /// </description></item>
            /// <item><description><para>disable_public_network: The public endpoint is being disabled.</para>
            /// </description></item>
            /// <item><description><para>convert_from_trial_to_official: The instance edition is being changed.</para>
            /// </description></item>
            /// <item><description><para>migration_cluster_to_serverless: The cluster is being migrated.</para>
            /// </description></item>
            /// <item><description><para>modifying_timezone: The time zone is being modified.</para>
            /// </description></item>
            /// <item><description><para>switch_az: The primary and secondary zones are being switched.</para>
            /// </description></item>
            /// <item><description><para>enabling: The instance is being resumed.</para>
            /// </description></item>
            /// <item><description><para>disable: The instance is unavailable.</para>
            /// </description></item>
            /// <item><description><para>actively_disabled: The instance is unavailable.</para>
            /// </description></item>
            /// <item><description><para>deleting: The instance is being deleted.</para>
            /// </description></item>
            /// <item><description><para>deleting_failed: The instance failed to be deleted.</para>
            /// </description></item>
            /// <item><description><para>deleted_with_error: The instance is deleted due to a creation failure.</para>
            /// </description></item>
            /// <item><description><para>deleted: The instance is deleted.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>running</para>
            /// </summary>
            [NameInMap("InstanceStatus")]
            [Validation(Required=false)]
            public string InstanceStatus { get; set; }

            /// <summary>
            /// <para>Indicates whether read/write splitting is enabled. If this parameter is set to true, the leader FE node processes write requests, and the other FE nodes process read requests.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsolateLeader")]
            [Validation(Required=false)]
            public bool? IsolateLeader { get; set; }

            /// <summary>
            /// <para>The ID of the KMS key.</para>
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
            /// <item><description><para>00:00-06:00</para>
            /// </description></item>
            /// <item><description><para>06:00-07:00</para>
            /// </description></item>
            /// <item><description><para>07:00-08:00</para>
            /// </description></item>
            /// <item><description><para>08:00-09:00</para>
            /// </description></item>
            /// <item><description><para>09:00-10:00</para>
            /// </description></item>
            /// <item><description><para>10:00-11:00</para>
            /// </description></item>
            /// <item><description><para>11:00-12:00</para>
            /// </description></item>
            /// <item><description><para>12:00-13:00</para>
            /// </description></item>
            /// <item><description><para>13:00-14:00</para>
            /// </description></item>
            /// <item><description><para>14:00-15:00</para>
            /// </description></item>
            /// <item><description><para>15:00-16:00</para>
            /// </description></item>
            /// <item><description><para>16:00-17:00</para>
            /// </description></item>
            /// <item><description><para>17:00-18:00</para>
            /// </description></item>
            /// <item><description><para>18:00-19:00</para>
            /// </description></item>
            /// <item><description><para>19:00-20:00</para>
            /// </description></item>
            /// <item><description><para>20:00-21:00</para>
            /// </description></item>
            /// <item><description><para>21:00-22:00</para>
            /// </description></item>
            /// <item><description><para>22:00-23:00</para>
            /// </description></item>
            /// <item><description><para>23:00-24:00</para>
            /// </description></item>
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
            /// <para>The type of the monitoring service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cms</para>
            /// </summary>
            [NameInMap("MonitorType")]
            [Validation(Required=false)]
            public string MonitorType { get; set; }

            /// <summary>
            /// <para>The OSS URL.</para>
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
            /// <item><description><para>trial: Trial Edition.</para>
            /// </description></item>
            /// <item><description><para>official: Standard Edition.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>official</para>
            /// </summary>
            [NameInMap("PackageType")]
            [Validation(Required=false)]
            public string PackageType { get; set; }

            /// <summary>
            /// <para>The billing method:</para>
            /// <list type="bullet">
            /// <item><description><para>prePaid: subscription.</para>
            /// </description></item>
            /// <item><description><para>postPaid: pay-as-you-go.</para>
            /// </description></item>
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
            /// <para>The running mode of the cluster:</para>
            /// <list type="bullet">
            /// <item><description><para>shared_nothing: all-in-one.</para>
            /// </description></item>
            /// <item><description><para>shared_data: storage-compute separation.</para>
            /// </description></item>
            /// <item><description><para>lakehouse: data lake analytics.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>shared_nothing</para>
            /// </summary>
            [NameInMap("RunMode")]
            [Validation(Required=false)]
            public string RunMode { get; set; }

            /// <summary>
            /// <para>The duration for which the cluster has been running. Unit: seconds.</para>
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
            /// <para>The tags attached to the instance.</para>
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
            /// <para>The list of vSwitches.</para>
            /// </summary>
            [NameInMap("VSwitches")]
            [Validation(Required=false)]
            public List<DescribeInstancesResponseBodyDataVSwitches> VSwitches { get; set; }
            public class DescribeInstancesResponseBodyDataVSwitches : TeaModel {
                /// <summary>
                /// <para>Indicates whether the vSwitch is the primary vSwitch.</para>
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
            /// <para>The VPC ID.</para>
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
