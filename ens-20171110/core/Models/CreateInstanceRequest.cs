// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class CreateInstanceRequest : TeaModel {
        [NameInMap("DataDisk")]
        [Validation(Required=false)]
        public List<CreateInstanceRequestDataDisk> DataDisk { get; set; }
        public class CreateInstanceRequestDataDisk : TeaModel {
            /// <summary>
            /// <para>The capacity of the first data disk. Unit: GiB. The capacity is at least 20 GiB and is a multiple of 10 GiB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public string Size { get; set; }

        }

        [NameInMap("SystemDisk")]
        [Validation(Required=false)]
        public CreateInstanceRequestSystemDisk SystemDisk { get; set; }
        public class CreateInstanceRequestSystemDisk : TeaModel {
            /// <summary>
            /// <para>The size of the system disk. Unit: GiB. Valid values: <b>20</b> and <b>40</b>. The value cannot be smaller than the size of the image and must be a multiple of 10 GiB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>40</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public string Size { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether to enable the auto-renewal feature. Valid values: <b>True</b> and <b>False</b>. Default value: False.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public string AutoRenew { get; set; }

        /// <summary>
        /// <para>The auto-renewal period for the instance. This parameter is required when the <b>AutoRenew</b> parameter is set to <b>True</b>. Valid values: <b>1</b> to <b>12</b>. Unit: months.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("AutoRenewPeriod")]
        [Validation(Required=false)]
        public string AutoRenewPeriod { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("EnsRegionId")]
        [Validation(Required=false)]
        public string EnsRegionId { get; set; }

        /// <summary>
        /// <para>The hostname of the Elastic Compute Service (ECS) instance. General naming rules: The hostname cannot start or end with a period (.) or hyphen (-). It cannot contain consecutive periods (.) or hyphens (-).</para>
        /// <para>Naming rules for specific instances:</para>
        /// <list type="bullet">
        /// <item><description>For Windows instances, the hostname must be <b>2</b> to <b>15</b> characters in length and cannot contain periods (.) or contain only digits. The hostname cannot contain periods (.) or contain only digits.</description></item>
        /// <item><description>For instances that run one of other operating systems such as Linux, the hostname must be <b>2</b> to <b>64</b> characters in length. You can use periods (.) to separate the hostname into multiple segments. Each segment can contain letters, digits, and hyphens (-).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>test-HostName</para>
        /// </summary>
        [NameInMap("HostName")]
        [Validation(Required=false)]
        public string HostName { get; set; }

        /// <summary>
        /// <para>The ID of the image file that you select when creating the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>yourImage ID</para>
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// <para>The name of the instance. The name must conform to the following naming conventions:</para>
        /// <list type="bullet">
        /// <item><description>The name must be <b>2</b> to <b>128</b> characters in length.</description></item>
        /// <item><description>It must start with a letter but cannot start with http:// or https://.</description></item>
        /// <item><description>The name can contain letters, digits, colons (:), underscores (_), periods (.), and hyphens (-).</description></item>
        /// </list>
        /// <para>If you do not specify this parameter, the instance ID is used as the instance name by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test:Instance_Name.1-2</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>The type of the instance.</para>
        /// <para>For more information, see <a href="~~66124~~"></a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ens.se1.tiny</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <para>This parameter is required if you create the instance for the first time. The existing billing method is used by default if you have created an instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>BandwidthByDay</b>: Pay by daily peak bandwidth.</description></item>
        /// <item><description><b>95BandwidthByMonth</b>: Pay by monthly 95th percentile bandwidth.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>95BandwidthByMonth</para>
        /// </summary>
        [NameInMap("InternetChargeType")]
        [Validation(Required=false)]
        public string InternetChargeType { get; set; }

        /// <summary>
        /// <para>The type of the IP address. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ipv4</b> (default)</description></item>
        /// <item><description><b>ipv6</b></description></item>
        /// <item><description><b>ipv4Andipv6</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ipv4</para>
        /// </summary>
        [NameInMap("IpType")]
        [Validation(Required=false)]
        public string IpType { get; set; }

        /// <summary>
        /// <para>The name of the key pair. You can specify only one name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TestKeyPairName</para>
        /// </summary>
        [NameInMap("KeyPairName")]
        [Validation(Required=false)]
        public string KeyPairName { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The password of the instance.</para>
        /// <para>The password must be 8 to 30 characters in length and contain at least three of the following character types: uppercase letters, lowercase letters, digits, and special characters. Special characters include: <c>()`~!@#$%^&amp;*-_+=|{}[]:;\\&quot;&lt;&gt;,.?/</c></para>
        /// 
        /// <b>Example:</b>
        /// <para>yourPassword:1</para>
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// <para>Specifies whether to use the preset password of the image. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: The password preset in the image is used, and the <b>Password</b> parameter must be null. For secure access, make sure that the selected image has a password configured.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: does not use the password preset in the image.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("PasswordInherit")]
        [Validation(Required=false)]
        public bool? PasswordInherit { get; set; }

        /// <summary>
        /// <para>The billing method of the instance. Set the value to Subscription.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Subscription</para>
        /// </summary>
        [NameInMap("PaymentType")]
        [Validation(Required=false)]
        public string PaymentType { get; set; }

        /// <summary>
        /// <para>The subscription period of the instance. Valid values: <b>1</b> to <b>9</b> and <b>12</b>. Unit: months.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

        /// <summary>
        /// <para>The internal IP address. If this parameter is specified, you must specify the vSwitch ID. The vSwitch must be created first. Otherwise, an error is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.10.10.10</para>
        /// </summary>
        [NameInMap("PrivateIpAddress")]
        [Validation(Required=false)]
        public string PrivateIpAddress { get; set; }

        /// <summary>
        /// <para>Specifies whether a public IP address can be assigned to the specified instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("PublicIpIdentification")]
        [Validation(Required=false)]
        public bool? PublicIpIdentification { get; set; }

        /// <summary>
        /// <para>The number of instances.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Quantity")]
        [Validation(Required=false)]
        public string Quantity { get; set; }

        /// <summary>
        /// <para>Specifies whether to automatically append sequential suffixes to the hostnames specified by the <b>HostName</b> parameter and instance names specified by the <b>InstanceName</b> parameter. The sequential suffixes range from <b>001</b> to <b>999</b>.</para>
        /// <para>Examples: <b>LocalHost001</b> and <b>LocalHost002</b>, and <b>MyInstance001</b> and <b>MyInstance002</b>.</para>
        /// <para>Default value: <b>false</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("UniqueSuffix")]
        [Validation(Required=false)]
        public bool? UniqueSuffix { get; set; }

        /// <summary>
        /// <para>Custom data. The data starts with <c>#!</c>. The data can be at most 256 characters in length and 16 KB in size. Only custom scripts are supported and cannot be rendered by InstanceMetaData.</para>
        /// <para>You can specify custom data. The data is encoded in Base64. The system does not encrypt your custom data when API requests are initiated. We recommend that you do not pass in confidential information such as passwords and private keys in plaintext. If you want to provide sensitive data such as passwords and private keys, encrypt the data and then encode it in Base64. The data is decrypted on the instance in the way it is encrypted.</para>
        /// <para>For more information, see <a href="https://cloudinit.readthedocs.io/en/latest/topics/format.html">User data formats</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>#!/bin/sh  echo &quot;Hello World.  The time is now $(date -R)!&quot; | tee /home/output.txt</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

        /// <summary>
        /// <para>The ID of the vSwitch.</para>
        /// 
        /// <b>Example:</b>
        /// <para>YourVSwitchId</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

    }

}
