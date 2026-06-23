// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class DescribeInstanceAttributeResponseBody : TeaModel {
        /// <summary>
        /// <para>The attributes of the instance.</para>
        /// </summary>
        [NameInMap("InstanceAttribute")]
        [Validation(Required=false)]
        public DescribeInstanceAttributeResponseBodyInstanceAttribute InstanceAttribute { get; set; }
        public class DescribeInstanceAttributeResponseBodyInstanceAttribute : TeaModel {
            /// <summary>
            /// <para>Indicates whether the application O\&amp;M module is enabled. Valid values are <c>Enable</c> and <c>Disable</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Enable</para>
            /// </summary>
            [NameInMap("AppOperationModule")]
            [Validation(Required=false)]
            public string AppOperationModule { get; set; }

            /// <summary>
            /// <para>A list of authorized security group IDs.</para>
            /// </summary>
            [NameInMap("AuthorizedSecurityGroups")]
            [Validation(Required=false)]
            public List<string> AuthorizedSecurityGroups { get; set; }

            /// <summary>
            /// <para>The total bandwidth of the Bastionhost instance, in Mbit/s.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("Bandwidth")]
            [Validation(Required=false)]
            public string Bandwidth { get; set; }

            /// <summary>
            /// <para>The extra bandwidth package of the Bastionhost instance, in Mbit/s.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("BandwidthPackage")]
            [Validation(Required=false)]
            public string BandwidthPackage { get; set; }

            /// <summary>
            /// <para>The status of the database O\&amp;M feature.</para>
            /// <list type="bullet">
            /// <item><description><para><b>Enable</b>: The database O\&amp;M feature is enabled.</para>
            /// </description></item>
            /// <item><description><para><b>Disable</b>: The database O\&amp;M feature is disabled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Disable</para>
            /// </summary>
            [NameInMap("DbOperationModule")]
            [Validation(Required=false)]
            public string DbOperationModule { get; set; }

            /// <summary>
            /// <para>The description of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Test API</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The ID of the elastic network interface (ENI).</para>
            /// 
            /// <b>Example:</b>
            /// <para>eni-bp1455jrzwm7moaxxxxx</para>
            /// </summary>
            [NameInMap("EniInstanceId")]
            [Validation(Required=false)]
            public string EniInstanceId { get; set; }

            /// <summary>
            /// <para>The expiration timestamp, in milliseconds, of the Bastionhost instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1578326400000</para>
            /// </summary>
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public long? ExpireTime { get; set; }

            /// <summary>
            /// <para>Indicates whether the Bastionhost instance is integrated with a Hardware Security Module (HSM).</para>
            /// </summary>
            [NameInMap("HSMModule")]
            [Validation(Required=false)]
            public string HSMModule { get; set; }

            /// <summary>
            /// <para>Indicates whether the IDaaS integration module is enabled. Valid values are <c>Enable</c> and <c>Disable</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Enable</para>
            /// </summary>
            [NameInMap("IDaaSModule")]
            [Validation(Required=false)]
            public string IDaaSModule { get; set; }

            /// <summary>
            /// <para>The ID of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>bastionhost-cn-78v1ghxxxxx</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The status of the instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>PENDING</b>: The instance is being initialized.</para>
            /// </description></item>
            /// <item><description><para><b>CREATING</b>: The instance is being created.</para>
            /// </description></item>
            /// <item><description><para><b>RUNNING</b>: The instance is running.</para>
            /// </description></item>
            /// <item><description><para><b>EXPIRED</b>: The instance has expired.</para>
            /// </description></item>
            /// <item><description><para><b>CREATE_FAILED</b>: Instance creation failed.</para>
            /// </description></item>
            /// <item><description><para><b>UPGRADING</b>: The instance is being upgraded.</para>
            /// </description></item>
            /// <item><description><para><b>UPGRADE_FAILED</b>: Instance upgrade failed.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>RUNNING</para>
            /// </summary>
            [NameInMap("InstanceStatus")]
            [Validation(Required=false)]
            public string InstanceStatus { get; set; }

            /// <summary>
            /// <para>The public domain name of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>******lwb-public.bastionhost.aliyuncs.com</para>
            /// </summary>
            [NameInMap("InternetEndpoint")]
            [Validation(Required=false)]
            public string InternetEndpoint { get; set; }

            /// <summary>
            /// <para>The internal endpoint of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>******xalwb.bastionhost.aliyuncs.com</para>
            /// </summary>
            [NameInMap("IntranetEndpoint")]
            [Validation(Required=false)]
            public string IntranetEndpoint { get; set; }

            /// <summary>
            /// <para>Indicates whether the instance is integrated with Key Management Service (KMS) and Secrets Manager. Valid values are <c>Enable</c> and <c>Disable</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Enable</para>
            /// </summary>
            [NameInMap("KmsSecretModule")]
            [Validation(Required=false)]
            public string KmsSecretModule { get; set; }

            /// <summary>
            /// <para>The license code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>bhah_ent_50_asset</para>
            /// </summary>
            [NameInMap("LicenseCode")]
            [Validation(Required=false)]
            public string LicenseCode { get; set; }

            /// <summary>
            /// <para>The status of the password change feature.</para>
            /// <list type="bullet">
            /// <item><description><para><b>Enable</b>: The feature is enabled.</para>
            /// </description></item>
            /// <item><description><para><b>Disable</b>: The feature is disabled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Enable</para>
            /// </summary>
            [NameInMap("ModifyPasswordModule")]
            [Validation(Required=false)]
            public string ModifyPasswordModule { get; set; }

            /// <summary>
            /// <para>The status of the network domain proxy feature.</para>
            /// <list type="bullet">
            /// <item><description><para><b>Enable</b>: The network domain proxy feature is enabled.</para>
            /// </description></item>
            /// <item><description><para><b>Disable</b>: The network domain proxy feature is disabled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Enable</para>
            /// </summary>
            [NameInMap("NetworkProxyModule")]
            [Validation(Required=false)]
            public string NetworkProxyModule { get; set; }

            /// <summary>
            /// <para>The O\&amp;M ports of the Bastionhost instance.</para>
            /// </summary>
            [NameInMap("Ports")]
            [Validation(Required=false)]
            public List<DescribeInstanceAttributeResponseBodyInstanceAttributePorts> Ports { get; set; }
            public class DescribeInstanceAttributeResponseBodyInstanceAttributePorts : TeaModel {
                /// <summary>
                /// <para>The custom O\&amp;M port.</para>
                /// <remarks>
                /// <para>Only SSH and RDP ports can be customized. If no custom port is set, this parameter returns the value of the <c>StandardPort</c> parameter.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>600xx</para>
                /// </summary>
                [NameInMap("CustomPort")]
                [Validation(Required=false)]
                public int? CustomPort { get; set; }

                /// <summary>
                /// <para>The standard O\&amp;M port number. The following are the default standard ports for specific protocols:</para>
                /// <list type="bullet">
                /// <item><description><para><b>SSH</b>: 60022</para>
                /// </description></item>
                /// <item><description><para><b>RDP</b>: 63389</para>
                /// </description></item>
                /// <item><description><para><b>HTTPS</b>: 443</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>60022</para>
                /// </summary>
                [NameInMap("StandardPort")]
                [Validation(Required=false)]
                public int? StandardPort { get; set; }

            }

            /// <summary>
            /// <para>A list of private egress IP addresses of the Bastionhost instance.</para>
            /// </summary>
            [NameInMap("PrivateExportIps")]
            [Validation(Required=false)]
            public List<string> PrivateExportIps { get; set; }

            /// <summary>
            /// <para>The private whitelist of the instance.</para>
            /// </summary>
            [NameInMap("PrivateWhiteList")]
            [Validation(Required=false)]
            public List<string> PrivateWhiteList { get; set; }

            /// <summary>
            /// <para>A list of public egress IP addresses of the Bastionhost instance.</para>
            /// </summary>
            [NameInMap("PublicExportIps")]
            [Validation(Required=false)]
            public List<string> PublicExportIps { get; set; }

            /// <summary>
            /// <para>A list of public IP addresses of the Bastionhost instance.</para>
            /// </summary>
            [NameInMap("PublicIps")]
            [Validation(Required=false)]
            public List<string> PublicIps { get; set; }

            /// <summary>
            /// <para>Indicates whether the Bastionhost instance is accessible over the public network. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: The Bastionhost instance is accessible over the public network.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: The Bastionhost instance is not accessible over the public network.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("PublicNetworkAccess")]
            [Validation(Required=false)]
            public bool? PublicNetworkAccess { get; set; }

            /// <summary>
            /// <para>The public whitelist of the Bastionhost instance.</para>
            /// </summary>
            [NameInMap("PublicWhiteList")]
            [Validation(Required=false)]
            public List<string> PublicWhiteList { get; set; }

            /// <summary>
            /// <para>Indicates whether the multi-account module is enabled. Valid values are <c>Enable</c> and <c>Disable</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Enable</para>
            /// </summary>
            [NameInMap("RDModule")]
            [Validation(Required=false)]
            public string RDModule { get; set; }

            /// <summary>
            /// <para>The ID of the region where the Bastionhost instance is located.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The ID of the instance\&quot;s resource group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-aekzc427db******</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>A list of routing rules for the Bastionhost instance.</para>
            /// </summary>
            [NameInMap("RouterRules")]
            [Validation(Required=false)]
            public List<string> RouterRules { get; set; }

            /// <summary>
            /// <para>Indicates whether the script-based O\&amp;M module is enabled. Valid values are <c>Enable</c> and <c>Disable</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Enable</para>
            /// </summary>
            [NameInMap("ScriptDeliverModule")]
            [Validation(Required=false)]
            public string ScriptDeliverModule { get; set; }

            /// <summary>
            /// <para>A list of the instance\&quot;s security group IDs.</para>
            /// </summary>
            [NameInMap("SecurityGroupIds")]
            [Validation(Required=false)]
            public List<string> SecurityGroupIds { get; set; }

            /// <summary>
            /// <para>The ID of the standby VSwitch for the Bastionhost instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-uf6cmnae7hu5****</para>
            /// </summary>
            [NameInMap("SlaveVswitchId")]
            [Validation(Required=false)]
            public string SlaveVswitchId { get; set; }

            /// <summary>
            /// <para>The timestamp, in milliseconds, when the Bastionhost instance was purchased or renewed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1577681345000</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// <para>The total storage capacity of the Bastionhost instance, in bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2199023255552</para>
            /// </summary>
            [NameInMap("Storage")]
            [Validation(Required=false)]
            public long? Storage { get; set; }

            /// <summary>
            /// <para>The ID of the instance\&quot;s Virtual Private Cloud (VPC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-bp1c85tzgqu1bf5bxxxxx</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            /// <summary>
            /// <para>The ID of the instance\&quot;s VSwitch.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-bp1xfwzzfti0kjbfxxxxx</para>
            /// </summary>
            [NameInMap("VswitchId")]
            [Validation(Required=false)]
            public string VswitchId { get; set; }

            /// <summary>
            /// <para>The status of the web terminal.</para>
            /// <list type="bullet">
            /// <item><description><para><b>Enable</b>: Supports web-based remote connections.</para>
            /// </description></item>
            /// <item><description><para><b>Disable</b>: Does not support web-based remote connections.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Enable</para>
            /// </summary>
            [NameInMap("WebTerminalModule")]
            [Validation(Required=false)]
            public string WebTerminalModule { get; set; }

            /// <summary>
            /// <para>The configured IP address whitelist policies.</para>
            /// </summary>
            [NameInMap("WhiteListPolicies")]
            [Validation(Required=false)]
            public List<DescribeInstanceAttributeResponseBodyInstanceAttributeWhiteListPolicies> WhiteListPolicies { get; set; }
            public class DescribeInstanceAttributeResponseBodyInstanceAttributeWhiteListPolicies : TeaModel {
                /// <summary>
                /// <para>The description of the whitelist rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>description</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>An IP address or CIDR block in the whitelist.</para>
                /// 
                /// <b>Example:</b>
                /// <para>94.74.xx.xx/32</para>
                /// </summary>
                [NameInMap("Entry")]
                [Validation(Required=false)]
                public string Entry { get; set; }

            }

        }

        /// <summary>
        /// <para>The unique ID of the request. You can use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>082FAB35-6AB9-4FD5-8750-D36673548E76</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
