// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class ListGatewayAuthorizableSecurityGroupsResponseBody : TeaModel {
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
        public ListGatewayAuthorizableSecurityGroupsResponseBodyData Data { get; set; }
        public class ListGatewayAuthorizableSecurityGroupsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The security groups.</para>
            /// </summary>
            [NameInMap("items")]
            [Validation(Required=false)]
            public List<ListGatewayAuthorizableSecurityGroupsResponseBodyDataItems> Items { get; set; }
            public class ListGatewayAuthorizableSecurityGroupsResponseBodyDataItems : TeaModel {
                /// <summary>
                /// <para>The security group name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>商品中心集群安全组。</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

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
                /// <para>The type of the security group. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Normal: general security group</description></item>
                /// <item><description>Enterprise: enterprise security group</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Normal</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The virtual private cloud (VPC) ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-uf61resqa9am***</para>
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
        /// <para>585657D2-1C20-5B8A-AF17-D727C6490BE4</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
