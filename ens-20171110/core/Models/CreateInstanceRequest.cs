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
            /// <para>The size of the first data cloud disk. Unit: GiB. The size must be at least 20 GiB and a multiple of 10.</para>
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
            /// <para>The size of the system cloud disk. Unit: GiB. The value must be a multiple of 10 and cannot be smaller than the image size. For the valid range, refer to the SystemDiskMinSize and SystemDiskMaxSize values returned by DescribeAvailableResourceInfo. 20 GiB and 40 GiB are common configurations and do not indicate that only these two values are supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>40</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public string Size { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether to enable auto-renewal. Valid values: <b>True</b> | <b>False</b> (default).</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public string AutoRenew { get; set; }

        /// <summary>
        /// <para>The auto-renewal period. This parameter is required when <b>AutoRenew</b> is set to <b>True</b>. Valid values: <b>1</b> to <b>12</b>. Unit: months.</para>
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
        /// <para>The hostname of the instance.
        /// General naming conventions: Periods (.) and hyphens (-) cannot be used as the first or last character and cannot be used consecutively.</para>
        /// <para>Specific naming conventions:</para>
        /// <list type="bullet">
        /// <item><description>Windows instances: The hostname must be <b>2</b> to <b>15</b> characters in length. Periods (.) are not supported. The hostname cannot consist entirely of digits. Uppercase letters, lowercase letters, digits, and hyphens (-) are allowed.</description></item>
        /// <item><description>Other instances (such as Linux): The hostname must be <b>2</b> to <b>64</b> characters in length. Multiple periods (.) are supported. Each segment separated by a period can contain uppercase letters, lowercase letters, digits, and hyphens (-).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>test-HostName</para>
        /// </summary>
        [NameInMap("HostName")]
        [Validation(Required=false)]
        public string HostName { get; set; }

        /// <summary>
        /// <para>The ID of the image that is used to start the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>yourImage ID</para>
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// <para>The name of the instance. Naming conventions:</para>
        /// <list type="bullet">
        /// <item><description>The name must be <b>2</b> to <b>128</b> characters in length and can contain letters and Chinese characters.</description></item>
        /// <item><description>The name must start with an uppercase letter, a lowercase letter, or a Chinese character. It cannot start with http:// or https://.</description></item>
        /// <item><description>The name can contain digits, colons (:), underscores (_), periods (.), or hyphens (-).</description></item>
        /// </list>
        /// <para>If this parameter is not specified, the default value is the InstanceId of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test：Instance_Name.1-2</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>The instance type.</para>
        /// <para>For details about instance types, see <a href="https://help.aliyun.com/document_detail/66124.html">Limits</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ens.se1.tiny</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <para>This parameter is required when you create an instance for the first time. If you already have instance resources, the existing billing method is used by default. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>BandwidthByDay</b>: daily peak bandwidth.</para>
        /// </description></item>
        /// <item><description><para><b>95BandwidthByMonth</b>: monthly 95th percentile bandwidth.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>95BandwidthByMonth</para>
        /// </summary>
        [NameInMap("InternetChargeType")]
        [Validation(Required=false)]
        public string InternetChargeType { get; set; }

        /// <summary>
        /// <para>The IP type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>ipv4</b> (default): IPv4.</para>
        /// </description></item>
        /// <item><description><para><b>ipv6</b>: IPv6.</para>
        /// </description></item>
        /// <item><description><para><b>ipv4Andipv6</b>: IPv4 and IPv6.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ipv4</para>
        /// </summary>
        [NameInMap("IpType")]
        [Validation(Required=false)]
        public string IpType { get; set; }

        /// <summary>
        /// <para>The name of the key pair. Only a single name is supported.</para>
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
        /// <para>The password must be 8 to 30 characters in length and must contain at least three of the following character types: uppercase letters, lowercase letters, digits, and special characters. The following special characters are supported: <c>()`~!@#$%^&amp;*-_+=|{}[]:;\\&quot;&lt;&gt;,.?/</c></para>
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
        /// <item><description><b>true</b>: The preset password of the image is used. The <b>Password</b> parameter must be empty, and you must make sure that the image has a preset password.</description></item>
        /// <item><description><b>false</b>: The preset password of the image is not used.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("PasswordInherit")]
        [Validation(Required=false)]
        public bool? PasswordInherit { get; set; }

        /// <summary>
        /// <para>The payment method. Currently, this is a fixed value of Subscription (subscription instance). Modification is not supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Subscription</para>
        /// </summary>
        [NameInMap("PaymentType")]
        [Validation(Required=false)]
        public string PaymentType { get; set; }

        /// <summary>
        /// <para>The subscription duration. Valid values: <b>1</b> to <b>9</b> and <b>12</b>. Unit: months.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

        /// <summary>
        /// <para>The private IP address. If you specify a private IP address, you must also specify the VSwitchId parameter. The vSwitch must be created in advance. Otherwise, an error is returned.</para>
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
        /// <item><description><b>true</b> (default): A public IP address can be assigned.</description></item>
        /// <item><description><b>false</b>: A public IP address cannot be assigned.</description></item>
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
        /// <para>Specifies whether to add sequential suffixes to <b>HostName</b> and <b>InstanceName</b>. The sequential suffixes start from <b>001</b> and cannot exceed <b>999</b>.</para>
        /// <para>Example: <b>LocalHost001</b>, <b>LocalHost002</b>, <b>MyInstance001</b>, and <b>MyInstance002</b>.</para>
        /// <para>Default value: <b>false</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("UniqueSuffix")]
        [Validation(Required=false)]
        public bool? UniqueSuffix { get; set; }

        /// <summary>
        /// <para>The custom data. The data must start with <c>#!</c>. The maximum length is 256 characters and the maximum size is 16 KB. Only custom data scripts are supported. InstanceMetaData rendering is not supported.</para>
        /// <para>You can pass in custom data that is Base64-encoded. When you call the API to initiate a request, the custom data you specify is not encrypted. Do not pass in confidential information such as passwords and private keys in plaintext. If you need to pass in passwords or private keys, encrypt the content first and then Base64-encode it before passing it in. Decrypt the content in the same way inside the instance.</para>
        /// <para>For more information, see <a href="https://cloudinit.readthedocs.io/en/latest/topics/format.html">Data format</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>#!/bin/sh  echo &quot;Hello World.  The time is now $(date -R)!&quot; | tee /home/output.txt</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

        /// <summary>
        /// <para>The vSwitch ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>YourVSwitchId</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

    }

}
