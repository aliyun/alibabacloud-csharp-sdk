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
            [NameInMap("AiCreditStatus")]
            [Validation(Required=false)]
            public string AiCreditStatus { get; set; }

            [NameInMap("AiOpsModule")]
            [Validation(Required=false)]
            public string AiOpsModule { get; set; }

            /// <summary>
            /// <para>The application O&amp;M module. Valid values: Enable (enabled) and Disable (disabled).</para>
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
            /// <para>The total bandwidth of the bastion host instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("Bandwidth")]
            [Validation(Required=false)]
            public string Bandwidth { get; set; }

            /// <summary>
            /// <para>The extended bandwidth package of the bastion host.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("BandwidthPackage")]
            [Validation(Required=false)]
            public string BandwidthPackage { get; set; }

            /// <summary>
            /// <para>The status of the database O&amp;M feature.</para>
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
            /// <para>The description of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Test API</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The ID of the elastic network interface (ENI). An ENI is a virtual network interface controller (NIC) that can be attached to the bastion host instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eni-bp1455jrzwm7moaxxxxx</para>
            /// </summary>
            [NameInMap("EniInstanceId")]
            [Validation(Required=false)]
            public string EniInstanceId { get; set; }

            /// <summary>
            /// <para>The timestamp when the bastion host instance expires. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1578326400000</para>
            /// </summary>
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public long? ExpireTime { get; set; }

            /// <summary>
            /// <para>The status of the HSM hardware encryption module. Indicates whether the bastion host is integrated with HSM.</para>
            /// </summary>
            [NameInMap("HSMModule")]
            [Validation(Required=false)]
            public string HSMModule { get; set; }

            /// <summary>
            /// <para>The IDaaS integration module. Valid values: Enable (enabled) and Disable (disabled).</para>
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
            /// <item><description><b>PENDING</b>: Not initialized.</description></item>
            /// <item><description><b>CREATING</b>: Being created. </description></item>
            /// <item><description><b>RUNNING</b>: Running. </description></item>
            /// <item><description><b>EXPIRED</b>: Expired. </description></item>
            /// <item><description><b>CREATE_FAILED</b>: Creation failed.</description></item>
            /// <item><description><b>UPGRADING</b>: Being upgraded.</description></item>
            /// <item><description><b>UPGRADE_FAILED</b>: Upgrade failed.</description></item>
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
            /// <para>The KMS Secrets Manager integration module. Valid values: Enable (enabled) and Disable (disabled).</para>
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
            /// <para>The status of the password change task feature.</para>
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
            /// <para>The status of the network domain proxy feature.</para>
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
            /// <para>The O&amp;M ports of the bastion host.</para>
            /// </summary>
            [NameInMap("Ports")]
            [Validation(Required=false)]
            public List<DescribeInstanceAttributeResponseBodyInstanceAttributePorts> Ports { get; set; }
            public class DescribeInstanceAttributeResponseBodyInstanceAttributePorts : TeaModel {
                /// <summary>
                /// <para>The custom port defined by the user.</para>
                /// <remarks>
                /// <para>Only SSH and RDP ports can be modified. If no custom O&amp;M port is configured for the bastion host, the value is the same as the standard port.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>600xx</para>
                /// </summary>
                [NameInMap("CustomPort")]
                [Validation(Required=false)]
                public int? CustomPort { get; set; }

                /// <summary>
                /// <para>The standard port of the bastion host. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>SSH</b>: 60022 </description></item>
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
            /// <para>The list of internal egress IP addresses of the bastion host.</para>
            /// </summary>
            [NameInMap("PrivateExportIps")]
            [Validation(Required=false)]
            public List<string> PrivateExportIps { get; set; }

            /// <summary>
            /// <para>The list of IP addresses in the internal whitelist.</para>
            /// </summary>
            [NameInMap("PrivateWhiteList")]
            [Validation(Required=false)]
            public List<string> PrivateWhiteList { get; set; }

            /// <summary>
            /// <para>The list of public egress IP addresses of the bastion host.</para>
            /// </summary>
            [NameInMap("PublicExportIps")]
            [Validation(Required=false)]
            public List<string> PublicExportIps { get; set; }

            /// <summary>
            /// <para>The list of public IP addresses of the bastion host.</para>
            /// </summary>
            [NameInMap("PublicIps")]
            [Validation(Required=false)]
            public List<string> PublicIps { get; set; }

            /// <summary>
            /// <para>Indicates whether the bastion host instance is accessible over the Internet. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: The bastion host is accessible over the Internet.</description></item>
            /// <item><description><b>false</b>: The bastion host is not accessible over the Internet.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("PublicNetworkAccess")]
            [Validation(Required=false)]
            public bool? PublicNetworkAccess { get; set; }

            /// <summary>
            /// <para>The public whitelist of the bastion host.</para>
            /// </summary>
            [NameInMap("PublicWhiteList")]
            [Validation(Required=false)]
            public List<string> PublicWhiteList { get; set; }

            /// <summary>
            /// <para>The multi-account module. Valid values: Enable (enabled) and Disable (disabled).</para>
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
            /// <para>The list of rules for the bastion host instance.</para>
            /// </summary>
            [NameInMap("RouterRules")]
            [Validation(Required=false)]
            public List<string> RouterRules { get; set; }

            /// <summary>
            /// <para>The script O&amp;M module. Valid values: Enable (enabled) and Disable (disabled).</para>
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
            /// <para>The ID of the secondary vSwitch associated with the bastion host instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-uf6cmnae7hu5****</para>
            /// </summary>
            [NameInMap("SlaveVswitchId")]
            [Validation(Required=false)]
            public string SlaveVswitchId { get; set; }

            /// <summary>
            /// <para>The timestamp when the bastion host instance was purchased or renewed. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1577681345000</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// <para>The total storage capacity of the purchased bastion host. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2199023255552</para>
            /// </summary>
            [NameInMap("Storage")]
            [Validation(Required=false)]
            public long? Storage { get; set; }

            /// <summary>
            /// <para>The VPC ID associated with the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-bp1c85tzgqu1bf5bxxxxx</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            /// <summary>
            /// <para>The vSwitch ID associated with the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-bp1xfwzzfti0kjbfxxxxx</para>
            /// </summary>
            [NameInMap("VswitchId")]
            [Validation(Required=false)]
            public string VswitchId { get; set; }

            /// <summary>
            /// <para>The status of the Web Terminal feature.</para>
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
            /// <para>The IP address whitelist to configure.</para>
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
                /// <para>The IP address whitelist to configure. A maximum of 50 IP addresses are supported. Separate multiple IP addresses with commas (,).</para>
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
        /// <para>The ID of the request. Alibaba Cloud generates a unique identifier for each request. You can use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>082FAB35-6AB9-4FD5-8750-D36673548E76</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
