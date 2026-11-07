// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class DeleteSecurityGroupRuleResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DeleteSecurityGroupRuleResponseBodyData Data { get; set; }
        public class DeleteSecurityGroupRuleResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The description of the rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>auto-description1</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The gateway ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>103</para>
            /// </summary>
            [NameInMap("GatewayId")]
            [Validation(Required=false)]
            public long? GatewayId { get; set; }

            /// <summary>
            /// <para>The unique ID of the gateway.</para>
            /// 
            /// <b>Example:</b>
            /// <para>gw-7ea3da97b96543e19f6c597c****</para>
            /// </summary>
            [NameInMap("GatewayUniqueId")]
            [Validation(Required=false)]
            public string GatewayUniqueId { get; set; }

            /// <summary>
            /// <para>The time when the rule was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-01-07 18:07:57</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The time when the rule was last modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-01-11T14:12:55.000+0000</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>The rule ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The transport-layer protocol. The value is not case-sensitive. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>icmp</para>
            /// </description></item>
            /// <item><description><para>gre</para>
            /// </description></item>
            /// <item><description><para>tcp</para>
            /// </description></item>
            /// <item><description><para>udp</para>
            /// </description></item>
            /// <item><description><para>all: The rule applies to all protocols.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>tcp</para>
            /// </summary>
            [NameInMap("IpProtocol")]
            [Validation(Required=false)]
            public string IpProtocol { get; set; }

            /// <summary>
            /// <para>The transport-layer port range. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>For TCP or UDP, the port range is 1 to 65535. Use a forward slash (/) to separate the start port from the end port. For example: <c>1/200</c>.</para>
            /// </description></item>
            /// <item><description><para>For ICMP, the value is <c>-1/-1</c>.</para>
            /// </description></item>
            /// <item><description><para>For GRE, the value is <c>-1/-1</c>.</para>
            /// </description></item>
            /// <item><description><para>For all protocols, the value is <c>-1/-1</c>.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>8443/8443</para>
            /// </summary>
            [NameInMap("PortRange")]
            [Validation(Required=false)]
            public string PortRange { get; set; }

            /// <summary>
            /// <para>The security group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sg-uf6hgwe067prhg68agfa</para>
            /// </summary>
            [NameInMap("SecurityGroupId")]
            [Validation(Required=false)]
            public string SecurityGroupId { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The request is processed successfully.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>43E50CB7-258E-5AFF-9B93-ECC19928C699</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c>: The request was successful.</para>
        /// </description></item>
        /// <item><description><para><c>false</c>: The request failed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
