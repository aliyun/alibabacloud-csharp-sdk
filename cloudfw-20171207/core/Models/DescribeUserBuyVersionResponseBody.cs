// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeUserBuyVersionResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the Alibaba Cloud account that is used to purchase Cloud Firewall.</para>
        /// 
        /// <b>Example:</b>
        /// <para>119898001566xxxx</para>
        /// </summary>
        [NameInMap("AliUid")]
        [Validation(Required=false)]
        public long? AliUid { get; set; }

        /// <summary>
        /// <para>The time when Cloud Firewall expires.</para>
        /// <remarks>
        /// <para> The value is a timestamp in milliseconds.</para>
        /// </remarks>
        /// <remarks>
        /// <para> If you use Cloud Firewall that uses the pay-as-you-go billing method, ignore this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1726934400000</para>
        /// </summary>
        [NameInMap("Expire")]
        [Validation(Required=false)]
        public long? Expire { get; set; }

        /// <summary>
        /// <para>The instance ID of Cloud Firewall.</para>
        /// <remarks>
        /// <para> If you use a trial of Cloud Firewall, ignore this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>vipcloudfw-cn-xxxxx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The status of Cloud Firewall. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>normal</b>: Cloud Firewall is running as expected.</description></item>
        /// <item><description><b>init</b>: Cloud Firewall is being initialized.</description></item>
        /// <item><description><b>deleting</b>: Cloud Firewall is being deleted.</description></item>
        /// <item><description><b>abnormal</b>: An exception occurs in Cloud Firewall.</description></item>
        /// <item><description><b>free</b>: Cloud Firewall is invalid.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>normal</para>
        /// </summary>
        [NameInMap("InstanceStatus")]
        [Validation(Required=false)]
        public string InstanceStatus { get; set; }

        [NameInMap("InternetBandwidth")]
        [Validation(Required=false)]
        public long? InternetBandwidth { get; set; }

        /// <summary>
        /// <para>The number of public IP addresses that can be protected.</para>
        /// <remarks>
        /// <para> This parameter takes effect only for Cloud Firewall that uses the subscription billing method.</para>
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
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("LogStatus")]
        [Validation(Required=false)]
        public bool? LogStatus { get; set; }

        /// <summary>
        /// <para>The log storage capacity.</para>
        /// <remarks>
        /// <para> This parameter takes effect only for Cloud Firewall that uses the subscription billing method.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>3000</para>
        /// </summary>
        [NameInMap("LogStorage")]
        [Validation(Required=false)]
        public long? LogStorage { get; set; }

        /// <summary>
        /// <para>The status of the burstable protected traffic feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1000000</b>: enabled.</description></item>
        /// <item><description><b>0</b>: disabled.</description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter takes effect only for Cloud Firewall that uses the subscription billing method.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("MaxOverflow")]
        [Validation(Required=false)]
        public long? MaxOverflow { get; set; }

        [NameInMap("NatBandwidth")]
        [Validation(Required=false)]
        public long? NatBandwidth { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F71B03EE-xxxxx-91D79CC6AA1A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The time when Cloud Firewall was activated.</para>
        /// <remarks>
        /// <para> The value is a timestamp in milliseconds.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1692504764000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// <para>Indicates whether Cloud Firewall is valid. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("UserStatus")]
        [Validation(Required=false)]
        public bool? UserStatus { get; set; }

        /// <summary>
        /// <para>The edition of Cloud Firewall. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>2</b>: Premium Edition.</description></item>
        /// <item><description><b>3</b>: Enterprise Edition.</description></item>
        /// <item><description><b>4</b>: Ultimate Edition.</description></item>
        /// <item><description><b>10</b>: Cloud Firewall that uses the pay-as-you-go billing method.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Version")]
        [Validation(Required=false)]
        public int? Version { get; set; }

        [NameInMap("VpcBandwidth")]
        [Validation(Required=false)]
        public long? VpcBandwidth { get; set; }

        /// <summary>
        /// <para>The number of virtual private clouds (VPCs) that can be protected.</para>
        /// <remarks>
        /// <para> This parameter takes effect only for Cloud Firewall that uses the subscription billing method.</para>
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
