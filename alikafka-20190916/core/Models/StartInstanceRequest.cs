// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alikafka20190916.Models
{
    public class StartInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The initial configurations of the ApsaraMQ for Kafka instance. The values must be valid JSON strings. If you do not specify this parameter, it is left empty.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>You cannot configure this parameter when you deploy an ApsaraMQ for Confluent instance.</description></item>
        /// <item><description>You cannot configure enable.acl for instances whose versions are earlier than 2.2.0.</description></item>
        /// </list>
        /// </remarks>
        /// <para>The <b>Config</b> parameter supports the following parameters:</para>
        /// <list type="bullet">
        /// <item><description><para><b>enable.vpc_sasl_ssl</b>: specifies whether to enable VPC transmission encryption. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: enables VPC transmission encryption. If you enable VPC transmission encryption, you must also enable access control list (ACL).</description></item>
        /// <item><description><b>false</b>: disables VPC transmission encryption. This is the default value.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>enable.acl</b>: specifies whether to enable ACL. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: enables ACL.</description></item>
        /// <item><description><b>false</b>: disables the ACL feature. This is the default value.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>kafka.log.retention.hours</b>: the maximum message retention period when the disk capacity is sufficient. Unit: hours. Valid values: 24 to 480. Default value: <b>72</b>. When the disk usage reaches 85%, the disk capacity is insufficient. In this case, the system deletes the earliest stored messages to ensure service availability.</para>
        /// </description></item>
        /// <item><description><para><b>kafka.message.max.bytes</b>: the maximum size of a message that can be sent and received by ApsaraMQ for Kafka. Unit: bytes. Valid values: 1048576 to 10485760. Default value: <b>1048576</b>. Before you change the maximum message size to a new value, make sure that the new value matches the configurations of the producers and consumers.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;kafka.log.retention.hours&quot;:&quot;33&quot;}</para>
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// <para>Specifies whether cross-zone deployment is required. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// <para>Default value: true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("CrossZone")]
        [Validation(Required=false)]
        public bool? CrossZone { get; set; }

        /// <summary>
        /// <para>The deployment mode. If the instance is an ApsaraMQ for Kafka V2 instance, this parameter is required. If the instance is an ApsaraMQ for Kafka V3 instance or an ApsaraMQ for Confluent instance, this parameter is optional. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>vpc</b>: deploys the instance in a virtual private cloud (VPC).</description></item>
        /// <item><description><b>eip</b>: deploys the instance over the Internet and in the VPC.</description></item>
        /// </list>
        /// <para>The deployment mode of the ApsaraMQ for Kafka instance must be consistent with the instance type. If the instance is a VPC-connected instance, set this parameter to <b>vpc</b>. If the instance is an Internet- and VPC-connected instance, set this parameter to <b>eip</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc</para>
        /// </summary>
        [NameInMap("DeployModule")]
        [Validation(Required=false)]
        public string DeployModule { get; set; }

        /// <summary>
        /// <para>The ID of the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alikafka_post-cn-v0h1fgs2****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Specifies whether the instance supports elastic IP addresses (EIPs). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: supports EIPs and allows access from the Internet and a VPC.</description></item>
        /// <item><description><b>false</b>: does not support EIPs and allows access only from a VPC.</description></item>
        /// </list>
        /// <para>The value of this parameter must match the type of the instance. For example, if the instance allows access only from a VPC, set this parameter to <b>false</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsEipInner")]
        [Validation(Required=false)]
        public bool? IsEipInner { get; set; }

        /// <summary>
        /// <para>Specifies whether to forcibly deploy the instance in the selected zones.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsForceSelectedZones")]
        [Validation(Required=false)]
        public bool? IsForceSelectedZones { get; set; }

        /// <summary>
        /// <para>Specifies whether to set a new username and password. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: sets a new username and password.</description></item>
        /// <item><description><b>false</b>: does not set a new username or password.</description></item>
        /// </list>
        /// <para>This parameter is available only if you deploy an instance that allows access from the Internet and a VPC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsSetUserAndPassword")]
        [Validation(Required=false)]
        public bool? IsSetUserAndPassword { get; set; }

        /// <summary>
        /// <para>The ID of the key that is used for disk encryption in the region where the instance is deployed. You can obtain the ID of the key in the <a href="https://kms.console.aliyun.com/?spm=a2c4g.11186623.2.5.336745b8hfiU21">Key Management Service (KMS) console</a> or create a key. For more information, see <a href="https://help.aliyun.com/document_detail/181610.html">Manage CMKs</a>.</para>
        /// <para>If this parameter is configured, disk encryption is enabled for the instance. You cannot disable disk encryption after disk encryption is enabled. When you call this operation, the system checks whether the AliyunServiceRoleForAlikafkaInstanceEncryption service-linked role is created. If the role is not created, the system automatically creates the role. For more information, see <a href="https://help.aliyun.com/document_detail/190460.html">Service-linked roles</a>.</para>
        /// <remarks>
        /// <para>When you deploy a serverless ApsaraMQ for Kafka V3 instance, you cannot configure this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0d24xxxx-da7b-4786-b981-9a164dxxxxxx</para>
        /// </summary>
        [NameInMap("KMSKeyId")]
        [Validation(Required=false)]
        public string KMSKeyId { get; set; }

        /// <summary>
        /// <para>The name of the instance.</para>
        /// <remarks>
        /// <para> If you specify a value for this parameter, make sure that the specified value is unique in the region of the instance.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>newInstanceName</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The alert contact.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Mr. Wang</para>
        /// </summary>
        [NameInMap("Notifier")]
        [Validation(Required=false)]
        public string Notifier { get; set; }

        /// <summary>
        /// <para>The instance password.</para>
        /// <list type="bullet">
        /// <item><description>This parameter is available only for Internet- and VPC- connected ApsaraMQ for Kafka V2 and V3 instances.</description></item>
        /// <item><description>If the instance is an ApsaraMQ for Confluent instance, this parameter is required. The value of this parameter must be 8 to 32 characters in length and contain at least three of the following character types: uppercase letters, lowercase letters, digits, and special characters. The following special characters are supported: ! @ # $ % ^ &amp; \* () _ + - =</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>password</para>
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// <para>The region ID of the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The security group of the instance.</para>
        /// <para>If you do not specify this parameter, ApsaraMQ for Kafka automatically configures a security group for your instance. If you specify this parameter, you must create a security group in advance. For more information, see <a href="https://help.aliyun.com/document_detail/25468.html">Create a security group</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sg-bp13wfx7kz9pko****</para>
        /// </summary>
        [NameInMap("SecurityGroup")]
        [Validation(Required=false)]
        public string SecurityGroup { get; set; }

        /// <summary>
        /// <para>The two-dimensional arrays that consist of the candidate set for primary zones and the candidate set for secondary zones. Custom code in the <c>zone {zone}</c> format and standard code in the <c>cn-RegionID-{zone}</c> format are supported.</para>
        /// <list type="bullet">
        /// <item><description>If you set CrossZone to true and specify Zone H and Zone F as the candidate set for primary zones and Zone K as the candidate set for secondary zones, set this parameter to <c>[[&quot;zoneh&quot;,&quot;zonef&quot;],[&quot;zonek&quot;]]</c>.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If you specify multiple zones as the primary or secondary zones, the system deploys the instance in one of the zones without prioritizing them. For example, if you set this parameter to <c>[[&quot;zoneh&quot;,&quot;zonef&quot;],[&quot;zonek&quot;]]</c>, the primary zone in which the instance is deployed can be Zone H or Zone F, and the secondary zone is Zone K.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>If you set CrossZone to false and want to deploy the instance in Zone K, set this parameter to <c>[[&quot;zonek&quot;],[]]</c>. In this case, the value of this parameter must still be two-dimensional arrays, but the array that specifies the candidate for secondary zones is left empty.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>[[\&quot;zonel\&quot;],[\&quot;zonek\&quot;]]</para>
        /// </summary>
        [NameInMap("SelectedZones")]
        [Validation(Required=false)]
        public string SelectedZones { get; set; }

        /// <summary>
        /// <para>The version of the ApsaraMQ for Kafka instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ApsaraMQ for Kafka V2 instances: 2.2.0 and 2.6.2.</description></item>
        /// <item><description>ApsaraMQ for Kafka V3 instances: 3.3.1.</description></item>
        /// <item><description>ApsaraMQ for Confluent instances: 7.4.0.</description></item>
        /// </list>
        /// <para>Default value:</para>
        /// <list type="bullet">
        /// <item><description>ApsaraMQ for Kafka V2 instances: 2.2.0.</description></item>
        /// <item><description>ApsaraMQ for Kafka V3 instances: 3.3.1.</description></item>
        /// <item><description>ApsaraMQ for Confluent instances: 7.4.0.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ApsaraMQ for Kafka V2 instances: 2.2.0
        /// ApsaraMQ for Kafka V3 instances: 3.3.1
        /// ApsaraMQ for Confluent instances: 7.4.0</para>
        /// </summary>
        [NameInMap("ServiceVersion")]
        [Validation(Required=false)]
        public string ServiceVersion { get; set; }

        /// <summary>
        /// <para>The mobile phone number of the alert contact.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1581234****</para>
        /// </summary>
        [NameInMap("UserPhoneNum")]
        [Validation(Required=false)]
        public string UserPhoneNum { get; set; }

        /// <summary>
        /// <para>The instance username.</para>
        /// <list type="bullet">
        /// <item><description>This parameter is available only for Internet- and VPC- connected ApsaraMQ for Kafka V2 and V3 instances.</description></item>
        /// <item><description>If the instance is an ApsaraMQ for Confluent instance, set this parameter to root or leave this parameter empty.</description></item>
        /// </list>
        /// <para>Default value for ApsaraMQ for Kafka V2 and V3 instances: username. Default value for ApsaraMQ for Confluent instances: root.</para>
        /// 
        /// <b>Example:</b>
        /// <para>username</para>
        /// </summary>
        [NameInMap("Username")]
        [Validation(Required=false)]
        public string Username { get; set; }

        /// <summary>
        /// <para>The ID of the vSwitch to which you want to connect the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp1j3sg5979fstnpl****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The IDs of the vSwitches with which the instance is associated. If the instance is an ApsaraMQ for Kafka V2 or V3 instance, this parameter is required. If the instance is an ApsaraMQ for Confluent instance, you must configure one of VSwitchIds and VSwitchId. If you configure both of the parameters, the value of VSwitchIds takes effect.</para>
        /// </summary>
        [NameInMap("VSwitchIds")]
        [Validation(Required=false)]
        public List<string> VSwitchIds { get; set; }

        /// <summary>
        /// <para>The ID of the virtual private cloud (VPC) in which you want to deploy the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp1r4eg3yrxmygv****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// <para>The ID of the zone where you want to deploy the ApsaraMQ for Kafka instance.</para>
        /// <list type="bullet">
        /// <item><description>The zone ID of the ApsaraMQ for Kafka instance must be the same as that of the vSwitch.</description></item>
        /// <item><description>The value must be in the zoneX or Region ID-X format. Examples: zonea and cn-hangzhou-k.</description></item>
        /// </list>
        /// <remarks>
        /// <para> If resources in the specified zone is insufficient, the instance may be deployed in another zone.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-k</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
