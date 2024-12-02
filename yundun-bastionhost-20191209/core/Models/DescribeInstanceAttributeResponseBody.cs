// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class DescribeInstanceAttributeResponseBody : TeaModel {
        /// <summary>
        /// <para>The attribute information about the bastion host.</para>
        /// </summary>
        [NameInMap("InstanceAttribute")]
        [Validation(Required=false)]
        public DescribeInstanceAttributeResponseBodyInstanceAttribute InstanceAttribute { get; set; }
        public class DescribeInstanceAttributeResponseBodyInstanceAttribute : TeaModel {
            [NameInMap("AppOperationModule")]
            [Validation(Required=false)]
            public string AppOperationModule { get; set; }

            /// <summary>
            /// <para>The IDs of authorized security groups.</para>
            /// </summary>
            [NameInMap("AuthorizedSecurityGroups")]
            [Validation(Required=false)]
            public List<string> AuthorizedSecurityGroups { get; set; }

            /// <summary>
            /// <para>The total bandwidth of the bastion host.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("Bandwidth")]
            [Validation(Required=false)]
            public string Bandwidth { get; set; }

            /// <summary>
            /// <para>The bandwidth plan ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("BandwidthPackage")]
            [Validation(Required=false)]
            public string BandwidthPackage { get; set; }

            /// <summary>
            /// <para>The status of the database O&amp;M feature.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Disable</para>
            /// </summary>
            [NameInMap("DbOperationModule")]
            [Validation(Required=false)]
            public string DbOperationModule { get; set; }

            /// <summary>
            /// <para>The description of the instance.</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The ID of the Elastic Network Interface (ENI).</para>
            /// 
            /// <b>Example:</b>
            /// <para>eni-bp1455jrzwm7moaxxxxx</para>
            /// </summary>
            [NameInMap("EniInstanceId")]
            [Validation(Required=false)]
            public string EniInstanceId { get; set; }

            /// <summary>
            /// <para>The time when the instance expires.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1578326400000</para>
            /// </summary>
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public long? ExpireTime { get; set; }

            [NameInMap("HSMModule")]
            [Validation(Required=false)]
            public string HSMModule { get; set; }

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
            /// <item><description>PENDING: The instance is not initialized.</description></item>
            /// <item><description>CREATING: The instance is being created.</description></item>
            /// <item><description>RUNNING: The instance is running.</description></item>
            /// <item><description>EXPIRED: The instance expired.</description></item>
            /// <item><description>CREATE_FAILED: The instance fails to be created.</description></item>
            /// <item><description>UPGRADING: The configurations of the instance are being changed.</description></item>
            /// <item><description>UPGRADE_FAILED: The configurations of the instance fail to be changed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>RUNNING</para>
            /// </summary>
            [NameInMap("InstanceStatus")]
            [Validation(Required=false)]
            public string InstanceStatus { get; set; }

            /// <summary>
            /// <para>The public endpoint.</para>
            /// 
            /// <b>Example:</b>
            /// <para>drawvxalwb-public.bastionhost.aliyuncs.com</para>
            /// </summary>
            [NameInMap("InternetEndpoint")]
            [Validation(Required=false)]
            public string InternetEndpoint { get; set; }

            /// <summary>
            /// <para>The private endpoint.</para>
            /// 
            /// <b>Example:</b>
            /// <para>drawvxalwb.bastionhost.aliyuncs.com</para>
            /// </summary>
            [NameInMap("IntranetEndpoint")]
            [Validation(Required=false)]
            public string IntranetEndpoint { get; set; }

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
            /// <para>The status of the automatic password change feature.</para>
            /// <list type="bullet">
            /// <item><description><b>Enable</b></description></item>
            /// <item><description><b>Disable</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Enable</para>
            /// </summary>
            [NameInMap("ModifyPasswordModule")]
            [Validation(Required=false)]
            public string ModifyPasswordModule { get; set; }

            /// <summary>
            /// <para>The status of the network domain feature.</para>
            /// <list type="bullet">
            /// <item><description><b>Enable</b></description></item>
            /// <item><description><b>Disable</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Enable</para>
            /// </summary>
            [NameInMap("NetworkProxyModule")]
            [Validation(Required=false)]
            public string NetworkProxyModule { get; set; }

            /// <summary>
            /// <para>An array that consists of the O&amp;M ports of the bastion host.</para>
            /// </summary>
            [NameInMap("Ports")]
            [Validation(Required=false)]
            public List<DescribeInstanceAttributeResponseBodyInstanceAttributePorts> Ports { get; set; }
            public class DescribeInstanceAttributeResponseBodyInstanceAttributePorts : TeaModel {
                /// <summary>
                /// <para>The custom port.</para>
                /// <remarks>
                /// <para>Only the SSH and RDP ports can be changed. If no custom O\&amp;M port is specified for the bastion host, the value of StandardPort is returned.</para>
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
                /// <item><description><b>SSH</b>: 60022.</description></item>
                /// <item><description><b>RDP</b>: 63389.</description></item>
                /// <item><description><b>HTTPS</b>: 443.</description></item>
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
            /// <para>An array that consists of the egress private IP addresses of the bastion host.</para>
            /// </summary>
            [NameInMap("PrivateExportIps")]
            [Validation(Required=false)]
            public List<string> PrivateExportIps { get; set; }

            /// <summary>
            /// <para>The private IP addresses that are allowed to access the instance.</para>
            /// </summary>
            [NameInMap("PrivateWhiteList")]
            [Validation(Required=false)]
            public List<string> PrivateWhiteList { get; set; }

            /// <summary>
            /// <para>An array that consists of the egress public IP addresses of the bastion host.</para>
            /// </summary>
            [NameInMap("PublicExportIps")]
            [Validation(Required=false)]
            public List<string> PublicExportIps { get; set; }

            /// <summary>
            /// <para>The public IP address.</para>
            /// </summary>
            [NameInMap("PublicIps")]
            [Validation(Required=false)]
            public List<string> PublicIps { get; set; }

            /// <summary>
            /// <para>Indicates whether the Bastionhost instance can be accessed over the Internet.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("PublicNetworkAccess")]
            [Validation(Required=false)]
            public bool? PublicNetworkAccess { get; set; }

            /// <summary>
            /// <para>The public IP addresses that are allowed to access the instance.</para>
            /// </summary>
            [NameInMap("PublicWhiteList")]
            [Validation(Required=false)]
            public List<string> PublicWhiteList { get; set; }

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
            /// <para>rg-aekzc427dbl2shy</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            [NameInMap("RouterRules")]
            [Validation(Required=false)]
            public List<string> RouterRules { get; set; }

            [NameInMap("ScriptDeliverModule")]
            [Validation(Required=false)]
            public string ScriptDeliverModule { get; set; }

            /// <summary>
            /// <para>The IDs of the security groups to which the instance belongs.</para>
            /// </summary>
            [NameInMap("SecurityGroupIds")]
            [Validation(Required=false)]
            public List<string> SecurityGroupIds { get; set; }

            [NameInMap("SlaveVswitchId")]
            [Validation(Required=false)]
            public string SlaveVswitchId { get; set; }

            /// <summary>
            /// <para>The time when the instance started.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1577681345000</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// <para>The storage capacity of the bastion host. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2199023255552</para>
            /// </summary>
            [NameInMap("Storage")]
            [Validation(Required=false)]
            public long? Storage { get; set; }

            /// <summary>
            /// <para>The ID of the VPC to which the instance belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-bp1c85tzgqu1bf5bxxxxx</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            /// <summary>
            /// <para>The ID of the vSwitch to which the instance connects.</para>
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
            /// <item><description><b>Enable</b></description></item>
            /// <item><description><b>Disable</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Enable</para>
            /// </summary>
            [NameInMap("WebTerminalModule")]
            [Validation(Required=false)]
            public string WebTerminalModule { get; set; }

            [NameInMap("WhiteListPolicies")]
            [Validation(Required=false)]
            public List<DescribeInstanceAttributeResponseBodyInstanceAttributeWhiteListPolicies> WhiteListPolicies { get; set; }
            public class DescribeInstanceAttributeResponseBodyInstanceAttributeWhiteListPolicies : TeaModel {
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("Entry")]
                [Validation(Required=false)]
                public string Entry { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>082FAB35-6AB9-4FD5-8750-D36673548E76</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
