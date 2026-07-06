// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alikafka20190916.Models
{
    public class StartInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The initial configurations of the ApsaraMQ for Kafka instance. The value must be a valid JSON string. If you do not specify this parameter, the default value is empty.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>You cannot specify the Config parameter when you deploy a Confluent instance.</para>
        /// </description></item>
        /// <item><description><para>The enable.acl configuration is not supported for instances of versions earlier than 2.2.0. Only Professional Edition and Serverless instances support access control lists (ACLs).</para>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// <para>The following parameters of <b>Config</b> are supported for reserved instances:</para>
        /// <list type="bullet">
        /// <item><description><para><b>enable.vpc_sasl_ssl</b></para>
        /// </description></item>
        /// <item><description><para><b>enable.acl</b></para>
        /// </description></item>
        /// <item><description><para><b>kafka.log.retention.hours</b></para>
        /// </description></item>
        /// <item><description><para><b>kafka.message.max.bytes</b></para>
        /// </description></item>
        /// </list>
        /// <para>The following parameters of <b>Config</b> are supported for Serverless instances:</para>
        /// <list type="bullet">
        /// <item><description><para><b>enable.vpc_sasl_ssl</b></para>
        /// </description></item>
        /// <item><description><para><b>enable.acl</b></para>
        /// </description></item>
        /// <item><description><para><b>log.retention.hours</b></para>
        /// </description></item>
        /// <item><description><para><b>offsets.retention.minutes</b></para>
        /// </description></item>
        /// <item><description><para><b>message.max.bytes</b></para>
        /// </description></item>
        /// <item><description><para><b>auto.create.topics.enable</b></para>
        /// </description></item>
        /// <item><description><para><b>num.partitions</b></para>
        /// </description></item>
        /// </list>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <para>For more information, see <a href="https://help.aliyun.com/zh/apsaramq-for-kafka/cloud-message-queue-for-kafka/developer-reference/api-alikafka-2019-09-16-updateinstanceconfig?spm=a2c4g.11186623.0.0.3e9e2a04vLr5nF">UpdateInstanceConfig</a>.</para>
        /// <para>&lt;props=&quot;intl&quot;&gt;</para>
        /// <para>For more information, see <a href="https://www.alibabacloud.com/help/zh/apsaramq-for-kafka/cloud-message-queue-for-kafka/developer-reference/api-alikafka-2019-09-16-updateinstanceconfig?spm=a2c63.p38356.0.i1">UpdateInstanceConfig</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;kafka.log.retention.hours&quot;:&quot;33&quot;}</para>
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// <para>Specifies whether to deploy the instance across zones.</para>
        /// <list type="bullet">
        /// <item><description><para>true: Deploy the instance across zones.</para>
        /// </description></item>
        /// <item><description><para>false: Do not deploy the instance across zones.</para>
        /// </description></item>
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
        /// <para>The deployment mode of the instance. This parameter is required for provisioned instances. This parameter is not required for Serverless and Confluent instances. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>vpc</b>: VPC instance</para>
        /// </description></item>
        /// <item><description><para><b>eip</b>: Internet/VPC instance</para>
        /// </description></item>
        /// </list>
        /// <para>The deployment mode of the instance must be consistent with the instance type. If the instance is a VPC instance, set this parameter to <b>vpc</b>. If the instance is an Internet/VPC instance, set this parameter to <b>eip</b>.</para>
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
        /// <para>Specifies whether to enable elastic IP addresses (EIPs). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: The instance is an Internet/VPC instance.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: The instance is a VPC instance.</para>
        /// </description></item>
        /// </list>
        /// <para>The value of this parameter must be consistent with the instance type. For example, if the instance is a VPC instance, you must set this parameter to <b>false</b>.</para>
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
        /// <item><description><para><b>true</b>: Set a new username and password.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: Do not set a new username and password.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is supported only for Internet/VPC instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsSetUserAndPassword")]
        [Validation(Required=false)]
        public bool? IsSetUserAndPassword { get; set; }

        /// <summary>
        /// <para>The ID of the key that is used for disk encryption in the same region. You can view the key ID in the <a href="https://kms.console.aliyun.com/?spm=a2c4g.11186623.2.5.336745b8hfiU21">Key Management Service (KMS) console</a> or create a key. For more information, see <a href="https://help.aliyun.com/document_detail/181610.html">Manage keys</a>.</para>
        /// <para>If you specify this parameter, disk encryption is enabled. You cannot disable disk encryption after it is enabled. When you call this operation, the system checks whether the AliyunServiceRoleForAlikafkaInstanceEncryption service-linked role is created. If the role is not created, the system automatically creates the role. For more information, see <a href="https://help.aliyun.com/document_detail/190460.html">Service-linked Role</a>.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>You cannot specify the KMSKeyId parameter when you deploy a Serverless instance.</description></item>
        /// </list>
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
        /// <para>This parameter is not supported for Serverless and Confluent instances.</para>
        /// <remarks>
        /// <para>If you specify this parameter, make sure that the value is unique in the same region.</para>
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
        /// <para>The password.</para>
        /// <list type="bullet">
        /// <item><description><para>For provisioned and Serverless instances, this parameter is supported only for Internet/VPC instances.</para>
        /// </description></item>
        /// <item><description><para>This parameter is required for Confluent instances. The password must be 8 to 32 characters in length and contain at least three of the following character types: uppercase letters, lowercase letters, digits, and special characters. Special characters are !@#$%^&amp;\*()_+-=.</para>
        /// </description></item>
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
        /// <para>If you do not specify this parameter, ApsaraMQ for Kafka automatically configures a security group for your instance. If you want to specify this parameter, you must create a security group for the instance in advance. For more information, see <a href="https://help.aliyun.com/document_detail/25468.html">Create a security group</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sg-bp13wfx7kz9pko****</para>
        /// </summary>
        [NameInMap("SecurityGroup")]
        [Validation(Required=false)]
        public string SecurityGroup { get; set; }

        /// <summary>
        /// <para>A two-dimensional array that consists of the candidate set of the primary zone and the candidate set of the secondary zone. The values can be custom codes (<c>zone{zone}</c>) or standard codes (<c>cn-RegionID-{zone}</c>).</para>
        /// <list type="bullet">
        /// <item><description><para>If you want to deploy the instance across zones (isCrossZone=true), the candidate set of the primary zone is Zone H or Zone F, and the candidate set of the secondary zone is Zone K, set this parameter to <c>[[\\&quot;zoneh\\&quot;,\\&quot;zonef\\&quot;],[\\&quot;zonek\\&quot;]]</c>. This example uses custom codes.</para>
        /// <remarks>
        /// <para>If you specify multiple zones for the primary or secondary zone, the system selects one of the zones for deployment without a priority. For example, if you set the parameter to <c>[[\\&quot;zoneh\\&quot;,\\&quot;zonef\\&quot;],[\\&quot;zonek\\&quot;]]</c>, the primary zone of the deployed instance is Zone H or Zone F, and the secondary zone is Zone K.</para>
        /// </remarks>
        /// </description></item>
        /// <item><description><para>If you do not want to deploy the instance across zones (isCrossZone=false) and want to deploy the instance in Zone K, set this parameter to <c>[[\\&quot;zonek\\&quot;],[]]</c>. This example uses a custom code. Note that you must still specify two arrays. The second array, which represents the candidate set of the secondary zone, can be empty [].</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>Relationship between the SelectedZones and VSwitchIds parameters for provisioned instances</para>
        /// <list type="bullet">
        /// <item><description>If you specify only VSwitchIds and do not specify SelectedZones, the system preferentially selects the zones that correspond to the vSwitches in VSwitchIds.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[[\&quot;zonel\&quot;],[\&quot;zonek\&quot;]]</para>
        /// </summary>
        [NameInMap("SelectedZones")]
        [Validation(Required=false)]
        public string SelectedZones { get; set; }

        /// <summary>
        /// <para>The version of the ApsaraMQ for Kafka instance that you want to deploy.</para>
        /// <list type="bullet">
        /// <item><description><para>For provisioned instances, valid values are 2.2.0 and 2.6.2.</para>
        /// </description></item>
        /// <item><description><para>For Serverless instances, the valid value is 3.3.1.</para>
        /// </description></item>
        /// <item><description><para>For Confluent instances, the valid value is 7.4.0.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value:</para>
        /// <list type="bullet">
        /// <item><description><para>Provisioned instances: 2.2.0</para>
        /// </description></item>
        /// <item><description><para>Serverless instances: 3.3.1</para>
        /// </description></item>
        /// <item><description><para>Confluent instances: 7.4.0</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Reserved Instance Series: 2.2.0
        /// Serverless Instance Series: 3.3.1
        /// Confluent Series: 7.4.0</para>
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
        /// <para>The username.</para>
        /// <list type="bullet">
        /// <item><description><para>For provisioned and Serverless instances, this parameter is supported only for Internet/VPC instances.</para>
        /// </description></item>
        /// <item><description><para>For Confluent instances, you can set this parameter only to root or leave it empty.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: For provisioned and Serverless instances, the default value is username. For Confluent instances, the default value is root.</para>
        /// 
        /// <b>Example:</b>
        /// <para>username</para>
        /// </summary>
        [NameInMap("Username")]
        [Validation(Required=false)]
        public string Username { get; set; }

        /// <summary>
        /// <para>The ID of the vSwitch to which the instance is deployed.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp1j3sg5979fstnpl****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The list of vSwitch IDs. This parameter is required for provisioned and Serverless instances. This parameter is supported for Confluent instances. You must specify at least one of VSwitchIds and VSwitchId. If you specify both, VSwitchIds takes precedence.</para>
        /// </summary>
        [NameInMap("VSwitchIds")]
        [Validation(Required=false)]
        public List<string> VSwitchIds { get; set; }

        /// <summary>
        /// <para>The ID of the VPC in which the instance is deployed.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp1r4eg3yrxmygv****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// <para>The ID of the zone in which the instance is deployed.</para>
        /// <list type="bullet">
        /// <item><description><para>The value must be the zone ID of the vSwitch.</para>
        /// </description></item>
        /// <item><description><para>The value can be in the zoneX or RegionId-X format. For example, you can set the value to zonea or cn-hangzhou-k.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If resources in the specified zone are insufficient, the instance may be deployed in another zone.</para>
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
