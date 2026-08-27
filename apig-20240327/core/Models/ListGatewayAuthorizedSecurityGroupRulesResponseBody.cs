// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class ListGatewayAuthorizedSecurityGroupRulesResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Ok</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public ListGatewayAuthorizedSecurityGroupRulesResponseBodyData Data { get; set; }
        public class ListGatewayAuthorizedSecurityGroupRulesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The security group rules.</para>
            /// </summary>
            [NameInMap("items")]
            [Validation(Required=false)]
            public List<ListGatewayAuthorizedSecurityGroupRulesResponseBodyDataItems> Items { get; set; }
            public class ListGatewayAuthorizedSecurityGroupRulesResponseBodyDataItems : TeaModel {
                /// <summary>
                /// <para>The list of authorized CIDR blocks.</para>
                /// </summary>
                [NameInMap("authCidrs")]
                [Validation(Required=false)]
                public List<string> AuthCidrs { get; set; }

                /// <summary>
                /// <para>The rule description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>商品中心预发网关授权安全组</para>
                /// </summary>
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The protocol. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>TCP</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>TCP</para>
                /// </summary>
                [NameInMap("ipProtocol")]
                [Validation(Required=false)]
                public string IpProtocol { get; set; }

                /// <summary>
                /// <para>The port range.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8080/8089</para>
                /// </summary>
                [NameInMap("portRange")]
                [Validation(Required=false)]
                public string PortRange { get; set; }

                /// <summary>
                /// <para>The security group ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sg-bp1ftp5sm9os***</para>
                /// </summary>
                [NameInMap("securityGroupId")]
                [Validation(Required=false)]
                public string SecurityGroupId { get; set; }

                /// <summary>
                /// <para>The security group name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>商品中心集群安全组</para>
                /// </summary>
                [NameInMap("securityGroupName")]
                [Validation(Required=false)]
                public string SecurityGroupName { get; set; }

                /// <summary>
                /// <para>The rule ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>gsgr-cqadis5lhtgmv***</para>
                /// </summary>
                [NameInMap("securityGroupRuleId")]
                [Validation(Required=false)]
                public string SecurityGroupRuleId { get; set; }

                /// <summary>
                /// <para>The ID of the source security group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sg-bp19akuepfe***</para>
                /// </summary>
                [NameInMap("sourceSecurityGroupId")]
                [Validation(Required=false)]
                public string SourceSecurityGroupId { get; set; }

                /// <summary>
                /// <para>The virtual private cloud (VPC) ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-bp1g63b5q2q29***</para>
                /// </summary>
                [NameInMap("vpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

            }

        }

        /// <summary>
        /// <para>The response message returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>393E2630-DBE7-5221-AB35-9E740675491A</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
