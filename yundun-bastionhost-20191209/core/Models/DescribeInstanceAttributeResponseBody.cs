// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class DescribeInstanceAttributeResponseBody : TeaModel {
        /// <summary>
        /// <para>The instance attribute information.</para>
        /// </summary>
        [NameInMap("InstanceAttribute")]
        [Validation(Required=false)]
        public DescribeInstanceAttributeResponseBodyInstanceAttribute InstanceAttribute { get; set; }
        public class DescribeInstanceAttributeResponseBodyInstanceAttribute : TeaModel {
            /// <summary>
            /// <para>The AI credit status (Available/Exhausted).</para>
            /// 
            /// <b>Example:</b>
            /// <para>Available</para>
            /// </summary>
            [NameInMap("AiCreditStatus")]
            [Validation(Required=false)]
            public string AiCreditStatus { get; set; }

            /// <summary>
            /// <para>The total number of AI credits in the package.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AiCreditsTotal")]
            [Validation(Required=false)]
            public long? AiCreditsTotal { get; set; }

            /// <summary>
            /// <para>The number of used AI credits in the package.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AiCreditsUs")]
            [Validation(Required=false)]
            public long? AiCreditsUs { get; set; }

            /// <summary>
            /// <para>The AI O&amp;M audit status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Disabled</para>
            /// </summary>
            [NameInMap("AiOpsAuditStatus")]
            [Validation(Required=false)]
            public string AiOpsAuditStatus { get; set; }

            /// <summary>
            /// <para>The switch status of the intelligent O&amp;M module (Enable/Disable).</para>
            /// 
            /// <b>Example:</b>
            /// <para>Enable</para>
            /// </summary>
            [NameInMap("AiOpsModule")]
            [Validation(Required=false)]
            public string AiOpsModule { get; set; }

            /// <summary>
            /// <para>The application O&amp;M module. Valid values: Enable and Disable.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Enable</para>
            /// </summary>
            [NameInMap("AppOperationModule")]
            [Validation(Required=false)]
            public string AppOperationModule { get; set; }

            /// <summary>
            /// <para>The list of authorized security group IDs.</para>
            /// </summary>
            [NameInMap("AuthorizedSecurityGroups")]
            [Validation(Required=false)]
            public List<string> AuthorizedSecurityGroups { get; set; }

            /// <summary>
            /// <para>The total bandwidth of the Bastionhost instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("Bandwidth")]
            [Validation(Required=false)]
            public string Bandwidth { get; set; }

            /// <summary>
            /// <para>The extended bandwidth plan of the Bastionhost instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("BandwidthPackage")]
            [Validation(Required=false)]
            public string BandwidthPackage { get; set; }

            /// <summary>
            /// <para>The database O&amp;M status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Enable</b>: Database O&amp;M is supported.</description></item>
            /// <item><description><b>Disable</b>: Database O&amp;M is not supported.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Disable</para>
            /// </summary>
            [NameInMap("DbOperationModule")]
            [Validation(Required=false)]
            public string DbOperationModule { get; set; }

            /// <summary>
            /// <para>The description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Test API</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The ID of the elastic network interface controller (NIC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>eni-bp1455jrzwm7moaxxxxx</para>
            /// </summary>
            [NameInMap("EniInstanceId")]
            [Validation(Required=false)]
            public string EniInstanceId { get; set; }

            /// <summary>
            /// <para>The expiration timestamp of the Bastionhost instance. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1578326400000</para>
            /// </summary>
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public long? ExpireTime { get; set; }

            /// <summary>
            /// <para>The status of the HSM hardware encryption module. Indicates whether the Bastionhost instance is integrated with an HSM.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Disable</para>
            /// </summary>
            [NameInMap("HSMModule")]
            [Validation(Required=false)]
            public string HSMModule { get; set; }

            /// <summary>
            /// <para>The IDaaS integration module. Valid values: Enable and Disable.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Enable</para>
            /// </summary>
            [NameInMap("IDaaSModule")]
            [Validation(Required=false)]
            public string IDaaSModule { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>bastionhost-cn-78v1ghxxxxx</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The instance status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>PENDING</b>: Uninitialized.</description></item>
            /// <item><description><b>CREATING</b>: Creating.</description></item>
            /// <item><description><b>RUNNING</b>: Running.</description></item>
            /// <item><description><b>EXPIRED</b>: Expired.</description></item>
            /// <item><description><b>CREATE_FAILED</b>: Creation failed.</description></item>
            /// <item><description><b>UPGRADING</b>: Upgrading or downgrading.</description></item>
            /// <item><description><b>UPGRADE_FAILED</b>: Upgrade or downgrade failed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>RUNNING</para>
            /// </summary>
            [NameInMap("InstanceStatus")]
            [Validation(Required=false)]
            public string InstanceStatus { get; set; }

            /// <summary>
            /// <para>The public domain name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>******lwb-public.bastionhost.aliyuncs.com</para>
            /// </summary>
            [NameInMap("InternetEndpoint")]
            [Validation(Required=false)]
            public string InternetEndpoint { get; set; }

            /// <summary>
            /// <para>The internal domain name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>******xalwb.bastionhost.aliyuncs.com</para>
            /// </summary>
            [NameInMap("IntranetEndpoint")]
            [Validation(Required=false)]
            public string IntranetEndpoint { get; set; }

            /// <summary>
            /// <para>The KMS Secrets Manager integration module. Valid values: Enable and Disable.</para>
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
            /// <para>The status of the password change task feature. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Enable</b>: Enabled.</description></item>
            /// <item><description><b>Disable</b>: Disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Enable</para>
            /// </summary>
            [NameInMap("ModifyPasswordModule")]
            [Validation(Required=false)]
            public string ModifyPasswordModule { get; set; }

            /// <summary>
            /// <para>The network domain proxy status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Enable</b>: The network domain proxy mode is supported.</description></item>
            /// <item><description><b>Disable</b>: The network domain proxy mode is not supported.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Enable</para>
            /// </summary>
            [NameInMap("NetworkProxyModule")]
            [Validation(Required=false)]
            public string NetworkProxyModule { get; set; }

            /// <summary>
            /// <para>The O&amp;M ports of the Bastionhost instance.</para>
            /// </summary>
            [NameInMap("Ports")]
            [Validation(Required=false)]
            public List<DescribeInstanceAttributeResponseBodyInstanceAttributePorts> Ports { get; set; }
            public class DescribeInstanceAttributeResponseBodyInstanceAttributePorts : TeaModel {
                /// <summary>
                /// <para>The custom port.</para>
                /// <remarks>
                /// <para>Only SSH and RDP ports can be modified. If no custom O&amp;M port is specified for the Bastionhost instance, the standard port is returned.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>600xx</para>
                /// </summary>
                [NameInMap("CustomPort")]
                [Validation(Required=false)]
                public int? CustomPort { get; set; }

                /// <summary>
                /// <para>The standard port of the Bastionhost instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>SSH</b>: 60022</description></item>
                /// <item><description><b>RDP</b>: 63389</description></item>
                /// <item><description><b>HTTPS</b>: 443</description></item>
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
            /// <para>The list of internal outbound IP addresses of the Bastionhost instance.</para>
            /// </summary>
            [NameInMap("PrivateExportIps")]
            [Validation(Required=false)]
            public List<string> PrivateExportIps { get; set; }

            /// <summary>
            /// <para>The list of IP addresses in the internal network whitelist.</para>
            /// </summary>
            [NameInMap("PrivateWhiteList")]
            [Validation(Required=false)]
            public List<string> PrivateWhiteList { get; set; }

            /// <summary>
            /// <para>The list of public outbound IP addresses of the Bastionhost instance.</para>
            /// </summary>
            [NameInMap("PublicExportIps")]
            [Validation(Required=false)]
            public List<string> PublicExportIps { get; set; }

            /// <summary>
            /// <para>The list of public IP addresses of the Bastionhost instance.</para>
            /// </summary>
            [NameInMap("PublicIps")]
            [Validation(Required=false)]
            public List<string> PublicIps { get; set; }

            /// <summary>
            /// <para>Indicates whether the Bastionhost instance can be accessed over the Internet. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: The Bastionhost instance can be accessed over the Internet.</description></item>
            /// <item><description><b>false</b>: The Bastionhost instance cannot be accessed over the Internet.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("PublicNetworkAccess")]
            [Validation(Required=false)]
            public bool? PublicNetworkAccess { get; set; }

            /// <summary>
            /// <para>The list of IP addresses in the public network whitelist of the Bastionhost instance.</para>
            /// </summary>
            [NameInMap("PublicWhiteList")]
            [Validation(Required=false)]
            public List<string> PublicWhiteList { get; set; }

            /// <summary>
            /// <para>The multi-account module. Valid values: Enable and Disable.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Enable</para>
            /// </summary>
            [NameInMap("RDModule")]
            [Validation(Required=false)]
            public string RDModule { get; set; }

            /// <summary>
            /// <para>The region ID of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The ID of the resource group to which the instance belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-aekzc427db******</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The list of rules for the Bastionhost instance.</para>
            /// </summary>
            [NameInMap("RouterRules")]
            [Validation(Required=false)]
            public List<string> RouterRules { get; set; }

            /// <summary>
            /// <para>The script O&amp;M module. Valid values: Enable and Disable.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Enable</para>
            /// </summary>
            [NameInMap("ScriptDeliverModule")]
            [Validation(Required=false)]
            public string ScriptDeliverModule { get; set; }

            /// <summary>
            /// <para>The list of security group IDs to which the instance belongs.</para>
            /// </summary>
            [NameInMap("SecurityGroupIds")]
            [Validation(Required=false)]
            public List<string> SecurityGroupIds { get; set; }

            /// <summary>
            /// <para>The ID of the secondary vSwitch bound to the Bastionhost instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-uf6cmnae7hu5****</para>
            /// </summary>
            [NameInMap("SlaveVswitchId")]
            [Validation(Required=false)]
            public string SlaveVswitchId { get; set; }

            /// <summary>
            /// <para>The timestamp when the Bastionhost instance was purchased or renewed. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1577681345000</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// <para>The total purchased storage capacity of the Bastionhost instance. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2199023255552</para>
            /// </summary>
            [NameInMap("Storage")]
            [Validation(Required=false)]
            public long? Storage { get; set; }

            /// <summary>
            /// <para>The ID of the VPC to which the instance is connected.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-bp1c85tzgqu1bf5bxxxxx</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            /// <summary>
            /// <para>The ID of the vSwitch to which the instance is connected.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-bp1xfwzzfti0kjbfxxxxx</para>
            /// </summary>
            [NameInMap("VswitchId")]
            [Validation(Required=false)]
            public string VswitchId { get; set; }

            /// <summary>
            /// <para>The Web Terminal status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Enable</b>: Web remote connection is supported.</description></item>
            /// <item><description><b>Disable</b>: Web remote connection is not supported.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Enable</para>
            /// </summary>
            [NameInMap("WebTerminalModule")]
            [Validation(Required=false)]
            public string WebTerminalModule { get; set; }

            /// <summary>
            /// <para>The IP address whitelist to be configured.</para>
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
                /// <para>The IP address whitelist to be configured. You can configure up to 50 IP addresses. Separate multiple IP addresses with commas (,).</para>
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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>082FAB35-6AB9-4FD5-8750-D36673548E76</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
