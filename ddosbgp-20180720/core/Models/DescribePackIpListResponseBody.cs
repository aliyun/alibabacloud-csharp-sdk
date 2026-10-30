// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddosbgp20180720.Models
{
    public class DescribePackIpListResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code of the request.</para>
        /// <para>For more information about status codes, see <a href="https://help.aliyun.com/document_detail/118841.html">Common parameters</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The list of IP addresses protected by the Anti-DDoS Origin instance.</para>
        /// </summary>
        [NameInMap("IpList")]
        [Validation(Required=false)]
        public List<DescribePackIpListResponseBodyIpList> IpList { get; set; }
        public class DescribePackIpListResponseBodyIpList : TeaModel {
            /// <summary>
            /// <para>The IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>47.98.XX.XX</para>
            /// </summary>
            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            /// <summary>
            /// <para>The UID of the member account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>170858869679****</para>
            /// </summary>
            [NameInMap("MemberUid")]
            [Validation(Required=false)]
            public string MemberUid { get; set; }

            /// <summary>
            /// <para>The end time of near-origin traffic diversion.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1715658000</para>
            /// </summary>
            [NameInMap("NsmExpireAt")]
            [Validation(Required=false)]
            public long? NsmExpireAt { get; set; }

            /// <summary>
            /// <para>The start time of near-origin traffic diversion.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1715655000</para>
            /// </summary>
            [NameInMap("NsmStartAt")]
            [Validation(Required=false)]
            public long? NsmStartAt { get; set; }

            /// <summary>
            /// <para>The status of near-origin traffic diversion. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: Near-origin traffic diversion is in progress.</description></item>
            /// <item><description><b>0</b>: Near-origin traffic diversion is not in progress.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("NsmStatus")]
            [Validation(Required=false)]
            public int? NsmStatus { get; set; }

            /// <summary>
            /// <para>The cloud asset type to which the IP address belongs. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>ECS</b>: ECS instance.</description></item>
            /// <item><description><b>SLB</b>: Classic Load Balancer (CLB) instance.</description></item>
            /// <item><description><b>EIP</b>: EIP, including the EIPs used by Application Load Balancer (ALB) instances.</description></item>
            /// <item><description><b>WAF</b>: Web Application Firewall (WAF) instance.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ECS</para>
            /// </summary>
            [NameInMap("Product")]
            [Validation(Required=false)]
            public string Product { get; set; }

            /// <summary>
            /// <para>The region of the protected IP address.</para>
            /// <remarks>
            /// <para>If the region of the protected IP address is the same as the region of the instance, this parameter is not returned.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// <para>The description of the cloud asset to which the IP address belongs, such as an ECS instance or a CLB instance.</para>
            /// <remarks>
            /// <para>If the cloud asset has no description, this parameter is not returned.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            /// <summary>
            /// <para>The current status of the IP address. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>normal</b>: The IP address is normal and not under attack.</description></item>
            /// <item><description><b>hole_begin</b>: The IP address is under blackhole filtering.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>normal</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4FD1578A-BD77-50B7-A969-45A374A7ED22</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The request is successful.</description></item>
        /// <item><description><b>false</b>: The request fails.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The number of protected IP addresses queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
