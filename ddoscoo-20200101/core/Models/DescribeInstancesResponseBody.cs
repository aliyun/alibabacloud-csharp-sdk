// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>The details about the instances.</para>
        /// </summary>
        [NameInMap("Instances")]
        [Validation(Required=false)]
        public List<DescribeInstancesResponseBodyInstances> Instances { get; set; }
        public class DescribeInstancesResponseBodyInstances : TeaModel {
            /// <summary>
            /// <para>The time when the instance was created. The value is a UNIX timestamp. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1637751953000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The overdue status of the instance. The value is fixed as <b>0</b>, which indicates that your Alibaba Cloud account does not have overdue payments. The instance supports only the subscription billing method.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("DebtStatus")]
            [Validation(Required=false)]
            public int? DebtStatus { get; set; }

            /// <summary>
            /// <para>The mitigation plan of the instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Anti-DDoS Proxy (Outside Chinese Mainland) instance of the Insurance mitigation plan</description></item>
            /// <item><description><b>1</b>: Anti-DDoS Proxy (Outside Chinese Mainland) instance of the Unlimited mitigation plan</description></item>
            /// <item><description><b>2</b>: Anti-DDoS Proxy (Outside Chinese Mainland) instance of the Chinese Mainland Acceleration (CMA) mitigation plan</description></item>
            /// <item><description><b>9</b>: Anti-DDoS Proxy (Chinese Mainland) instance of the Profession mitigation plan</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>9</para>
            /// </summary>
            [NameInMap("Edition")]
            [Validation(Required=false)]
            public int? Edition { get; set; }

            /// <summary>
            /// <para>The traffic forwarding status of the instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: The instance no longer forwards service traffic.</description></item>
            /// <item><description><b>1</b>: The instance forwards service traffic as expected.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public int? Enabled { get; set; }

            /// <summary>
            /// <para>The time when the instance expires. The value is a UNIX timestamp. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1640361600000</para>
            /// </summary>
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public long? ExpireTime { get; set; }

            /// <summary>
            /// <para>The ID of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ddoscoo-cn-7pp2g9ed****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The IP address of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>203.199.XX.XX</para>
            /// </summary>
            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            /// <summary>
            /// <para>The IP address-based forwarding mode of the instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>fnat</b>: Requests from IPv4 addresses are forwarded to origin servers that use IPv4 addresses and requests from IPv6 addresses are forwarded to origin servers that use IPv6 addresses.</description></item>
            /// <item><description><b>v6tov4</b>: All requests are forwarded to origin servers that use IPv4 addresses.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>fnat</para>
            /// </summary>
            [NameInMap("IpMode")]
            [Validation(Required=false)]
            public string IpMode { get; set; }

            /// <summary>
            /// <para>The IP version of the instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Ipv4</b></description></item>
            /// <item><description><b>Ipv6</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Ipv4</para>
            /// </summary>
            [NameInMap("IpVersion")]
            [Validation(Required=false)]
            public string IpVersion { get; set; }

            /// <summary>
            /// <para>Indicates whether the metering method of the 95th percentile burstable clean bandwidth is enabled for the instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: no</description></item>
            /// <item><description>1: yes</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("IsFirstOpenBw")]
            [Validation(Required=false)]
            public long? IsFirstOpenBw { get; set; }

            /// <summary>
            /// <para>Indicates whether the metering method of the 95th percentile burstable QPS is enabled for the instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: no</description></item>
            /// <item><description>1: yes</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("IsFirstOpenQps")]
            [Validation(Required=false)]
            public long? IsFirstOpenQps { get; set; }

            /// <summary>
            /// <para>The remarks of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>doc-test</para>
            /// </summary>
            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            /// <summary>
            /// <para>The status of the instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: normal</description></item>
            /// <item><description><b>2</b>: expired</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A0AF40CC-814A-5A86-AEAA-6F19E88B8A39</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of the instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
