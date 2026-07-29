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
        /// <para>The list of IP addresses that are protected by the Anti-DDoS Origin instance.</para>
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
            /// <para>The end time of cross-border traffic blocking.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1715658000</para>
            /// </summary>
            [NameInMap("NsmExpireAt")]
            [Validation(Required=false)]
            public long? NsmExpireAt { get; set; }

            /// <summary>
            /// <para>The start time of cross-border traffic blocking.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1715655000</para>
            /// </summary>
            [NameInMap("NsmStartAt")]
            [Validation(Required=false)]
            public long? NsmStartAt { get; set; }

            /// <summary>
            /// <para>The status of cross-border traffic blocking. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>1</b>: Cross-border traffic is being blocked.</para>
            /// </description></item>
            /// <item><description><para><b>0</b>: Cross-border traffic is not blocked.</para>
            /// </description></item>
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
            /// <item><description><para><b>ECS</b>: an ECS instance.</para>
            /// </description></item>
            /// <item><description><para><b>SLB</b>: a CLB instance.</para>
            /// </description></item>
            /// <item><description><para><b>EIP</b>: an EIP instance. This includes the EIP used by an ALB instance.</para>
            /// </description></item>
            /// <item><description><para><b>WAF</b>: a WAF instance.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ECS</para>
            /// </summary>
            [NameInMap("Product")]
            [Validation(Required=false)]
            public string Product { get; set; }

            /// <summary>
            /// <para>The region where the protected IP address is deployed.</para>
            /// <remarks>
            /// <para>This parameter is not returned if the protected IP address is deployed in the same region as the instance.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// <para>The remarks on the cloud asset to which the IP address belongs, such as an ECS instance or an SLB instance.</para>
            /// <remarks>
            /// <para>This parameter is not returned if no remarks are specified for the cloud asset.</para>
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
            /// <item><description><para><b>normal</b>: The IP address is not under attack.</para>
            /// </description></item>
            /// <item><description><para><b>hole_begin</b>: The IP address is in blackhole filtering status.</para>
            /// </description></item>
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
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: The request was successful.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: The request failed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The number of protected IP addresses that are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
