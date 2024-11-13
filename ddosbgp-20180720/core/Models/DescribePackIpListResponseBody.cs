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
        /// <para>The IP addresses that are protected by the instance.</para>
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
            /// <para>The ID of the member.</para>
            /// 
            /// <b>Example:</b>
            /// <para>170858869679****</para>
            /// </summary>
            [NameInMap("MemberUid")]
            [Validation(Required=false)]
            public string MemberUid { get; set; }

            /// <summary>
            /// <para>The time when the near-origin traffic diversion feature was disabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1715658000</para>
            /// </summary>
            [NameInMap("NsmExpireAt")]
            [Validation(Required=false)]
            public long? NsmExpireAt { get; set; }

            /// <summary>
            /// <para>The time when the near-origin traffic diversion feature was enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1715655000</para>
            /// </summary>
            [NameInMap("NsmStartAt")]
            [Validation(Required=false)]
            public long? NsmStartAt { get; set; }

            /// <summary>
            /// <para>The status of the near-origin traffic diversion feature. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: The near-origin traffic diversion feature is enabled.</description></item>
            /// <item><description><b>0</b>: The near-origin traffic diversion feature is disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("NsmStatus")]
            [Validation(Required=false)]
            public int? NsmStatus { get; set; }

            /// <summary>
            /// <para>The type of the cloud asset to which the IP address belongs. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>ECS</b>: an ECS instance.</description></item>
            /// <item><description><b>SLB</b>: a CLB (formerly SLB) instance.</description></item>
            /// <item><description><b>EIP</b>: an EIP. If the IP address belongs to an ALB instance, the value EIP is returned.</description></item>
            /// <item><description><b>WAF</b>: a WAF instance.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ECS</para>
            /// </summary>
            [NameInMap("Product")]
            [Validation(Required=false)]
            public string Product { get; set; }

            /// <summary>
            /// <para>The region to which the protected IP address belongs.</para>
            /// <remarks>
            /// <para> If the protected IP address is in the same region as the instance, this parameter is not returned.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// <para>The description of the cloud asset to which the IP address belongs. The asset can be an ECS instance or an SLB instance.</para>
            /// <remarks>
            /// <para> If no descriptions are provided for the asset, this parameter is not returned.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            /// <summary>
            /// <para>The status of the IP address. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>normal</b>: The IP address is not under attack.</description></item>
            /// <item><description><b>hole_begin</b>: Blackhole filtering is triggered for the IP address.</description></item>
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
        /// <item><description><b>true</b>: The call is successful.</description></item>
        /// <item><description><b>false</b>: The call fails.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The number of protected IP addresses.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
