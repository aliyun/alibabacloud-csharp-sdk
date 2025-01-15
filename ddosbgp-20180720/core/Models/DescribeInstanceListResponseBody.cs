// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddosbgp20180720.Models
{
    public class DescribeInstanceListResponseBody : TeaModel {
        /// <summary>
        /// <para>The details about the Anti-DDoS Origin instances.</para>
        /// </summary>
        [NameInMap("InstanceList")]
        [Validation(Required=false)]
        public List<DescribeInstanceListResponseBodyInstanceList> InstanceList { get; set; }
        public class DescribeInstanceListResponseBodyInstanceList : TeaModel {
            /// <summary>
            /// <para>The event that triggers automatic association. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>any</b>: The instance is automatically associated with an object based on traffic scrubbing events or blackhole filtering events.</description></item>
            /// <item><description><b>clean</b>: The instance is automatically associated with an object based on traffic scrubbing events.</description></item>
            /// <item><description><b>blackhole</b>: The instance is automatically associated with an object based on blackhole filtering events.</description></item>
            /// </list>
            /// </summary>
            [NameInMap("AutoProtectCondition")]
            [Validation(Required=false)]
            public DescribeInstanceListResponseBodyInstanceListAutoProtectCondition AutoProtectCondition { get; set; }
            public class DescribeInstanceListResponseBodyInstanceListAutoProtectCondition : TeaModel {
                /// <summary>
                /// <para>Events which result in auto binding.</para>
                /// </summary>
                [NameInMap("Events")]
                [Validation(Required=false)]
                public List<string> Events { get; set; }

            }

            /// <summary>
            /// <para>The time when the instance expires. The value is a UNIX timestamp. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("AutoRenewal")]
            [Validation(Required=false)]
            public bool? AutoRenewal { get; set; }

            /// <summary>
            /// <para>The type of the instance.</para>
            /// <list type="bullet">
            /// <item><description><b>ddos_ddosorigin_public_cn</b>: Anti-DDoS Origin 2.0 (Pay-as-you-go) on the China site (aliyun.com).</description></item>
            /// <item><description><b>ddos_ddosorigin_public_intl</b>: Anti-DDoS Origin 2.0 (Pay-as-you-go) on the International site (alibabacloud.com).</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("BlackholdingCount")]
            [Validation(Required=false)]
            public string BlackholdingCount { get; set; }

            /// <summary>
            /// <para>The condition that triggers automatic association of the instance with an object.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ddos_ddosorigin_public_cn</para>
            /// </summary>
            [NameInMap("CommodityType")]
            [Validation(Required=false)]
            public string CommodityType { get; set; }

            /// <summary>
            /// <para>Indicates whether overdue payments exist. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Overdue payments do not exist.</description></item>
            /// <item><description><b>1</b>: Overdue payments exist.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CoverageType")]
            [Validation(Required=false)]
            public int? CoverageType { get; set; }

            /// <summary>
            /// <para>The events that trigger automatic association.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("DebtStatus")]
            [Validation(Required=false)]
            public long? DebtStatus { get; set; }

            /// <summary>
            /// <para>The time when the instance was purchased. The value is a UNIX timestamp. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1640275200000</para>
            /// </summary>
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public long? ExpireTime { get; set; }

            /// <summary>
            /// <para>The mitigation plan of the instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: the Professional mitigation plan</description></item>
            /// <item><description><b>1</b>: the Enterprise mitigation plan</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1592886047000</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// <para>The number of protected public IP addresses for which blackhole filtering is triggered.</para>
            /// <remarks>
            /// <para> You can call the <a href="https://help.aliyun.com/document_detail/118692.html">DeleteBlackhole</a> operation to deactivate blackhole filtering for a protected IP address.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>ddosbgp-cn-oew1pjrk****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The application scope of the instance.</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: The instance supports public IP addresses in all regions.</description></item>
            /// <item><description><b>2</b>: The instance supports public IP addresses in regions in the Chinese mainland.</description></item>
            /// <item><description><b>3</b>: The instance supports public IP addresses in regions outside the Chinese mainland.</description></item>
            /// <item><description><b>4</b>: The instance supports public IP addresses in a region in or outside the Chinese mainland.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// <para>The description of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>IPv4</para>
            /// </summary>
            [NameInMap("IpType")]
            [Validation(Required=false)]
            public string IpType { get; set; }

            /// <summary>
            /// <para>The ID of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>gamebox</para>
            /// </summary>
            [NameInMap("Product")]
            [Validation(Required=false)]
            public string Product { get; set; }

            /// <summary>
            /// <para>The type of the cloud service that is associated with the Anti-DDoS Origin instance By default, this parameter is not returned. If the Anti-DDoS Origin instance is created by using a different cloud service, the code of the cloud service is returned.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>gamebox</b>: The Anti-DDoS Origin instance is created by using Game Security Box.</description></item>
            /// <item><description><b>eip</b>: The Anti-DDoS Origin instance is created by using an elastic IP address (EIP) for which Anti-DDoS (Enhanced Edition) is enabled.</description></item>
            /// </list>
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
            /// <para>Indicates whether auto-renewal is enabled for the instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
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
        /// <para>The details about the Anti-DDoS Origin instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>381D5D33-BB8F-395F-8EE4-AE3BB4B523C4</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The details about the Anti-DDoS Origin instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
