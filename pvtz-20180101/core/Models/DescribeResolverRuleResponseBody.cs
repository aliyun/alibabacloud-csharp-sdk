// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pvtz20180101.Models
{
    public class DescribeResolverRuleResponseBody : TeaModel {
        /// <summary>
        /// <para>The virtual private clouds (VPCs) that are associated with the forwarding rule.</para>
        /// </summary>
        [NameInMap("BindVpcs")]
        [Validation(Required=false)]
        public List<DescribeResolverRuleResponseBodyBindVpcs> BindVpcs { get; set; }
        public class DescribeResolverRuleResponseBodyBindVpcs : TeaModel {
            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The region name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hangzhou</para>
            /// </summary>
            [NameInMap("RegionName")]
            [Validation(Required=false)]
            public string RegionName { get; set; }

            /// <summary>
            /// <para>The VPC ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-f8zvrvr1payllgz38****</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            /// <summary>
            /// <para>The VPC name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-name-test</para>
            /// </summary>
            [NameInMap("VpcName")]
            [Validation(Required=false)]
            public string VpcName { get; set; }

            /// <summary>
            /// <para>The VPC type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>STANDARD: standard VPC</description></item>
            /// <item><description>EDS: Elastic Desktop Service (EDS) workspace VPC</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>STANDARD</para>
            /// </summary>
            [NameInMap("VpcType")]
            [Validation(Required=false)]
            public string VpcType { get; set; }

            /// <summary>
            /// <para>The ID of the user to which the VPC belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>32454****</para>
            /// </summary>
            [NameInMap("VpcUserId")]
            [Validation(Required=false)]
            public string VpcUserId { get; set; }

        }

        /// <summary>
        /// <para>The time when the forwarding rule was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-07-13 10:51:44</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The time when the forwarding rule was created. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1594608704000</para>
        /// </summary>
        [NameInMap("CreateTimestamp")]
        [Validation(Required=false)]
        public long? CreateTimestamp { get; set; }

        /// <summary>
        /// <para>The endpoint ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hr****</para>
        /// </summary>
        [NameInMap("EndpointId")]
        [Validation(Required=false)]
        public string EndpointId { get; set; }

        /// <summary>
        /// <para>The endpoint name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>endpoint-test</para>
        /// </summary>
        [NameInMap("EndpointName")]
        [Validation(Required=false)]
        public string EndpointName { get; set; }

        /// <summary>
        /// <para>The destination IP addresses.</para>
        /// </summary>
        [NameInMap("ForwardIps")]
        [Validation(Required=false)]
        public List<DescribeResolverRuleResponseBodyForwardIps> ForwardIps { get; set; }
        public class DescribeResolverRuleResponseBodyForwardIps : TeaModel {
            /// <summary>
            /// <para>The destination IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>172.16.XX.XX</para>
            /// </summary>
            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            /// <summary>
            /// <para>The port number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8080</para>
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public int? Port { get; set; }

        }

        /// <summary>
        /// <para>The ID of the forwarding rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hr****</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>The name of the forwarding rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>forward rule-test</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>13D5113B-7E34-407F-A9C1-D96CD2B04277</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The type of the forwarding rule. Valid value:</para>
        /// <para>OUTBOUND: outbound forwarding rule. This type of rule forwards Domain Name System (DNS) requests to one or more external IP addresses.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OUTBOUND</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The time when the forwarding rule was updated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-07-13 10:51:44</para>
        /// </summary>
        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

        /// <summary>
        /// <para>The time when the forwarding rule was updated. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1594608704000</para>
        /// </summary>
        [NameInMap("UpdateTimestamp")]
        [Validation(Required=false)]
        public long? UpdateTimestamp { get; set; }

        /// <summary>
        /// <para>The name of the forward zone.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("ZoneName")]
        [Validation(Required=false)]
        public string ZoneName { get; set; }

    }

}
