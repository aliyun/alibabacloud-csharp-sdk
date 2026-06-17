// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeUserBuyVersionResponseBody : TeaModel {
        /// <summary>
        /// <para>The quota for ACK cluster connectors.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("AckClusterConnectorQuota")]
        [Validation(Required=false)]
        public long? AckClusterConnectorQuota { get; set; }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>119898001566xxxx</para>
        /// </summary>
        [NameInMap("AliUid")]
        [Validation(Required=false)]
        public long? AliUid { get; set; }

        /// <summary>
        /// <para>The default bandwidth of the edition.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("DefaultBandwidth")]
        [Validation(Required=false)]
        public long? DefaultBandwidth { get; set; }

        /// <summary>
        /// <para>The expiration time of the Cloud Firewall instance.</para>
        /// <remarks>
        /// <para>The value is a UNIX timestamp in milliseconds.</para>
        /// </remarks>
        /// <remarks>
        /// <para>This parameter does not apply to pay-as-you-go editions.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1726934400000</para>
        /// </summary>
        [NameInMap("Expire")]
        [Validation(Required=false)]
        public long? Expire { get; set; }

        /// <summary>
        /// <para>The extended bandwidth.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("ExtensionBandwidth")]
        [Validation(Required=false)]
        public long? ExtensionBandwidth { get; set; }

        /// <summary>
        /// <para>The number of general-purpose instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("GeneralInstance")]
        [Validation(Required=false)]
        public long? GeneralInstance { get; set; }

        /// <summary>
        /// <para>The ID of the Cloud Firewall instance.</para>
        /// <remarks>
        /// <para>This parameter does not apply to trial editions.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>vipcloudfw-cn-xxxxx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The operational status of the Cloud Firewall instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>normal</b>: The instance is running as expected.</para>
        /// </description></item>
        /// <item><description><para><b>init</b>: The instance is being initialized.</para>
        /// </description></item>
        /// <item><description><para><b>deleting</b>: The instance is being deleted.</para>
        /// </description></item>
        /// <item><description><para><b>abnormal</b>: The instance is in an abnormal state.</para>
        /// </description></item>
        /// <item><description><para><b>free</b>: No valid instance is available.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>normal</para>
        /// </summary>
        [NameInMap("InstanceStatus")]
        [Validation(Required=false)]
        public string InstanceStatus { get; set; }

        /// <summary>
        /// <para>The purchased traffic processing capability for the Internet firewall.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3000</para>
        /// </summary>
        [NameInMap("InternetBandwidth")]
        [Validation(Required=false)]
        public long? InternetBandwidth { get; set; }

        /// <summary>
        /// <para>The number of public IP addresses that can be protected.</para>
        /// <remarks>
        /// <para>This parameter applies only to subscription instances.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>63</para>
        /// </summary>
        [NameInMap("IpNumber")]
        [Validation(Required=false)]
        public long? IpNumber { get; set; }

        /// <summary>
        /// <para>Indicates whether log delivery is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Enabled</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: Disabled</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("LogStatus")]
        [Validation(Required=false)]
        public bool? LogStatus { get; set; }

        /// <summary>
        /// <para>The purchased log storage capacity.</para>
        /// <remarks>
        /// <para>This parameter applies only to subscription instances.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>3000</para>
        /// </summary>
        [NameInMap("LogStorage")]
        [Validation(Required=false)]
        public long? LogStorage { get; set; }

        /// <summary>
        /// <para>The major version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("MajorVersion")]
        [Validation(Required=false)]
        public long? MajorVersion { get; set; }

        /// <summary>
        /// <para>Indicates whether elastic billing for excess traffic is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>1000000</b>: Enabled</para>
        /// </description></item>
        /// <item><description><para><b>0</b>: Disabled</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter applies only to subscription instances.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("MaxOverflow")]
        [Validation(Required=false)]
        public long? MaxOverflow { get; set; }

        /// <summary>
        /// <para>The purchased traffic processing capability for the NAT firewall.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3000</para>
        /// </summary>
        [NameInMap("NatBandwidth")]
        [Validation(Required=false)]
        public long? NatBandwidth { get; set; }

        /// <summary>
        /// <para>The quota for private DNS connectors.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("PrivateDnsConnectorQuota")]
        [Validation(Required=false)]
        public long? PrivateDnsConnectorQuota { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F71B03EE-xxxxx-91D79CC6AA1A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether data leakage prevention is enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Sdl")]
        [Validation(Required=false)]
        public long? Sdl { get; set; }

        /// <summary>
        /// <para>The time when the Cloud Firewall instance was enabled.</para>
        /// <remarks>
        /// <para>The value is a UNIX timestamp in milliseconds.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1692504764000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// <para>The temporary bandwidth.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("TemporaryBandwidth")]
        [Validation(Required=false)]
        public long? TemporaryBandwidth { get; set; }

        /// <summary>
        /// <para>Indicates whether threat intelligence is enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ThreatIntelligence")]
        [Validation(Required=false)]
        public long? ThreatIntelligence { get; set; }

        /// <summary>
        /// <para>The status of the Cloud Firewall instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: The instance is valid.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: The instance is invalid.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("UserStatus")]
        [Validation(Required=false)]
        public bool? UserStatus { get; set; }

        /// <summary>
        /// <para>The edition of the Cloud Firewall instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>2</b>: Premium Edition</para>
        /// </description></item>
        /// <item><description><para><b>3</b>: Enterprise Edition</para>
        /// </description></item>
        /// <item><description><para><b>4</b>: Ultimate Edition</para>
        /// </description></item>
        /// <item><description><para><b>10</b>: Pay-as-you-go</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Version")]
        [Validation(Required=false)]
        public int? Version { get; set; }

        /// <summary>
        /// <para>The purchased traffic processing capability for the VPC firewall.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3000</para>
        /// </summary>
        [NameInMap("VpcBandwidth")]
        [Validation(Required=false)]
        public long? VpcBandwidth { get; set; }

        /// <summary>
        /// <para>The number of purchased VPC firewalls.</para>
        /// <remarks>
        /// <para>This parameter applies only to subscription instances.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>21</para>
        /// </summary>
        [NameInMap("VpcNumber")]
        [Validation(Required=false)]
        public long? VpcNumber { get; set; }

    }

}
