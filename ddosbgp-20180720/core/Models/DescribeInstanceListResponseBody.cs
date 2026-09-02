// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddosbgp20180720.Models
{
    public class DescribeInstanceListResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the Anti-DDoS Origin instances.</para>
        /// </summary>
        [NameInMap("InstanceList")]
        [Validation(Required=false)]
        public List<DescribeInstanceListResponseBodyInstanceList> InstanceList { get; set; }
        public class DescribeInstanceListResponseBodyInstanceList : TeaModel {
            /// <summary>
            /// <para>The automatic binding condition.</para>
            /// </summary>
            [NameInMap("AutoProtectCondition")]
            [Validation(Required=false)]
            public DescribeInstanceListResponseBodyInstanceListAutoProtectCondition AutoProtectCondition { get; set; }
            public class DescribeInstanceListResponseBodyInstanceListAutoProtectCondition : TeaModel {
                /// <summary>
                /// <para>The events on which automatic binding is based.</para>
                /// </summary>
                [NameInMap("Events")]
                [Validation(Required=false)]
                public List<string> Events { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether auto-renewal is enabled for the instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Enabled.</description></item>
            /// <item><description><b>false</b>: Disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("AutoRenewal")]
            [Validation(Required=false)]
            public bool? AutoRenewal { get; set; }

            /// <summary>
            /// <para>The number of IP addresses that are in blackhole filtering status among the assets that are assigned public IP addresses protected by the instance.</para>
            /// <remarks>
            /// <para>You can invoke <a href="https://help.aliyun.com/document_detail/118692.html">DeleteBlackhole</a> to deactivate blackhole filtering for a single protected IP address.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("BlackholdingCount")]
            [Validation(Required=false)]
            public string BlackholdingCount { get; set; }

            /// <summary>
            /// <para>The commodity type of the instance.</para>
            /// <list type="bullet">
            /// <item><description><b>ddos_ddosorigin_public_cn</b>: Anti-DDoS Origin 2.0 (Pay-as-you-go) China site.</description></item>
            /// <item><description><b>ddos_ddosorigin_public_intl</b>: Anti-DDoS Origin 2.0 (Pay-as-you-go) International site.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ddos_ddosorigin_public_cn</para>
            /// </summary>
            [NameInMap("CommodityType")]
            [Validation(Required=false)]
            public string CommodityType { get; set; }

            /// <summary>
            /// <para>The asset overwrite type of the instance.</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: Supports assets that are assigned public IP addresses in multiple regions globally.</description></item>
            /// <item><description><b>2</b>: Supports assets that are assigned public IP addresses in multiple regions in the Chinese mainland.</description></item>
            /// <item><description><b>3</b>: Supports assets that are assigned public IP addresses in multiple regions outside the Chinese mainland.</description></item>
            /// <item><description><b>4</b>: Supports assets that are assigned public IP addresses in a single region globally.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CoverageType")]
            [Validation(Required=false)]
            public int? CoverageType { get; set; }

            /// <summary>
            /// <para>The overdue payment status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: No overdue payment.</description></item>
            /// <item><description><b>1</b>: Overdue payment.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("DebtStatus")]
            [Validation(Required=false)]
            public long? DebtStatus { get; set; }

            /// <summary>
            /// <para>The expiration time of the instance. The value is a UNIX timestamp. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1640275200000</para>
            /// </summary>
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public long? ExpireTime { get; set; }

            /// <summary>
            /// <para>The purchase time of the instance. The value is a UNIX timestamp. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1592886047000</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ddosbgp-cn-oew1pjrk****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The mitigation plan type of the instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Professional.</description></item>
            /// <item><description><b>1</b>: Enterprise.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// <para>The protocol type of the IP assets protected by the instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>IPv4</b>: IPv4 protocol.</description></item>
            /// <item><description><b>IPv6</b>: IPv6 protocol.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>IPv4</para>
            /// </summary>
            [NameInMap("IpType")]
            [Validation(Required=false)]
            public string IpType { get; set; }

            /// <summary>
            /// <para>The full logs property.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;mitigationAnalysis\&quot;:\&quot;on\&quot;,\&quot;mitigationAnalysisCapacity\&quot;:1,\&quot;ttl\&quot;:180}</para>
            /// </summary>
            [NameInMap("LogExt")]
            [Validation(Required=false)]
            public string LogExt { get; set; }

            /// <summary>
            /// <para>The type of the cloud service associated with the instance. This parameter is not returned by default. It is returned only when the Anti-DDoS Origin instance is created by another cloud service, with the corresponding cloud service code.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>gamebox</b>: The Anti-DDoS Origin instance is created by Game Security Box.</description></item>
            /// <item><description><b>eip</b>: The Anti-DDoS Origin instance is created by an EIP with Anti-DDoS (Enhanced) enabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>gamebox</para>
            /// </summary>
            [NameInMap("Product")]
            [Validation(Required=false)]
            public string Product { get; set; }

            /// <summary>
            /// <para>The remark of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            /// <summary>
            /// <para>The resource group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-aek3ccjxxxxx</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The status of the instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: Normal.</description></item>
            /// <item><description><b>2</b>: Expired.</description></item>
            /// <item><description><b>3</b>: Released.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>381D5D33-BB8F-395F-8EE4-AE3BB4B523C4</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of Anti-DDoS Origin instances returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
