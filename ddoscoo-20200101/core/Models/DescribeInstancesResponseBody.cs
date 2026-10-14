// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the Anti-DDoS Pro or Anti-DDoS Premium instances.</para>
        /// </summary>
        [NameInMap("Instances")]
        [Validation(Required=false)]
        public List<DescribeInstancesResponseBodyInstances> Instances { get; set; }
        public class DescribeInstancesResponseBodyInstances : TeaModel {
            /// <summary>
            /// <para>The time when the instance was created. The value is a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1637751953000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The overdue payment status of the instance. The value is fixed as <b>0</b>, which indicates no overdue payments, because Anti-DDoS Pro and Anti-DDoS Premium currently only supports the subscription billing method.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("DebtStatus")]
            [Validation(Required=false)]
            public int? DebtStatus { get; set; }

            /// <summary>
            /// <para>The mitigation plan edition of the instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Anti-DDoS Pro and Anti-DDoS Premium (outside the Chinese mainland) Insurance edition.</description></item>
            /// <item><description><b>1</b>: Anti-DDoS Pro and Anti-DDoS Premium (outside the Chinese mainland) Unlimited edition.</description></item>
            /// <item><description><b>2</b>: Anti-DDoS Pro and Anti-DDoS Premium (outside the Chinese mainland) acceleration line.</description></item>
            /// <item><description><b>9</b>: Anti-DDoS Pro and Anti-DDoS Premium (the Chinese mainland) Professional Edition.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>9</para>
            /// </summary>
            [NameInMap("Edition")]
            [Validation(Required=false)]
            public int? Edition { get; set; }

            /// <summary>
            /// <para>The service traffic forwarding status of the instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Service traffic forwarding is stopped.</description></item>
            /// <item><description><b>1</b>: Service traffic forwarding is normal.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public int? Enabled { get; set; }

            /// <summary>
            /// <para>The expiration time of the instance. The value is a UNIX timestamp in milliseconds.</para>
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
            /// <para>The IP address of the Anti-DDoS Pro or Anti-DDoS Premium instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>203.199.XX.XX</para>
            /// </summary>
            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            /// <summary>
            /// <para>The IP forwarding mode of the instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>fnat</b>: The IP versions of the origin server and the client are the same. Requests from IPv4 clients are forwarded to IPv4 origin servers, and requests from IPv6 clients are forwarded to IPv6 origin servers.</description></item>
            /// <item><description><b>v6tov4</b>: Requests from IPv6 clients are forwarded to IPv4 origin servers.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>fnat</para>
            /// </summary>
            [NameInMap("IpMode")]
            [Validation(Required=false)]
            public string IpMode { get; set; }

            /// <summary>
            /// <para>The IP protocol version of the instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Ipv4</b>: IPv4.</description></item>
            /// <item><description><b>Ipv6</b>: IPv6.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Ipv4</para>
            /// </summary>
            [NameInMap("IpVersion")]
            [Validation(Required=false)]
            public string IpVersion { get; set; }

            /// <summary>
            /// <para>Indicates whether the 95th percentile burstable clean bandwidth metering method was enabled for the instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: No.</description></item>
            /// <item><description>1: Yes.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("IsFirstOpenBw")]
            [Validation(Required=false)]
            public long? IsFirstOpenBw { get; set; }

            /// <summary>
            /// <para>Indicates whether the 95th percentile burstable QPS metering method was enabled for the instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: No.</description></item>
            /// <item><description>1: Yes.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("IsFirstOpenQps")]
            [Validation(Required=false)]
            public long? IsFirstOpenQps { get; set; }

            /// <summary>
            /// <para>The description of the instance.</para>
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
            /// <item><description><b>1</b>: Normal.</description></item>
            /// <item><description><b>2</b>: Expired.</description></item>
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
        /// <para>The ID of the request, which is a unique identifier generated by Alibaba Cloud for the request and can be used to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A0AF40CC-814A-5A86-AEAA-6F19E88B8A39</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of Anti-DDoS Pro or Anti-DDoS Premium instances queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
