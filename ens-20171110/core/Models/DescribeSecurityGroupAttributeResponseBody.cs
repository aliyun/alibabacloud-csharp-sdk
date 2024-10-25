// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeSecurityGroupAttributeResponseBody : TeaModel {
        /// <summary>
        /// <para>The description of the security group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testDescription1</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Details about the rules.</para>
        /// </summary>
        [NameInMap("Permissions")]
        [Validation(Required=false)]
        public DescribeSecurityGroupAttributeResponseBodyPermissions Permissions { get; set; }
        public class DescribeSecurityGroupAttributeResponseBodyPermissions : TeaModel {
            [NameInMap("Permission")]
            [Validation(Required=false)]
            public List<DescribeSecurityGroupAttributeResponseBodyPermissionsPermission> Permission { get; set; }
            public class DescribeSecurityGroupAttributeResponseBodyPermissionsPermission : TeaModel {
                /// <summary>
                /// <para>The time at which the security group rule was created. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2018-12-12T07:28:38Z</para>
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// <para>The description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testDescription1</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The range of destination IP addresses for outbound access control.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.0.0.0/0</para>
                /// </summary>
                [NameInMap("DestCidrIp")]
                [Validation(Required=false)]
                public string DestCidrIp { get; set; }

                /// <summary>
                /// <para>The direction in which the security group rule is applied.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ingress</para>
                /// </summary>
                [NameInMap("Direction")]
                [Validation(Required=false)]
                public string Direction { get; set; }

                /// <summary>
                /// <para>The transport layer protocol.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TCP</para>
                /// </summary>
                [NameInMap("IpProtocol")]
                [Validation(Required=false)]
                public string IpProtocol { get; set; }

                /// <summary>
                /// <para>The policy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Accept</para>
                /// </summary>
                [NameInMap("Policy")]
                [Validation(Required=false)]
                public string Policy { get; set; }

                /// <summary>
                /// <para>The source port range.</para>
                /// 
                /// <b>Example:</b>
                /// <para>80/80</para>
                /// </summary>
                [NameInMap("PortRange")]
                [Validation(Required=false)]
                public string PortRange { get; set; }

                /// <summary>
                /// <para>The priority of the rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Priority")]
                [Validation(Required=false)]
                public int? Priority { get; set; }

                /// <summary>
                /// <para>The range of source IP addresses for inbound access control.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.0.0.0/0</para>
                /// </summary>
                [NameInMap("SourceCidrIp")]
                [Validation(Required=false)]
                public string SourceCidrIp { get; set; }

                /// <summary>
                /// <para>The source port number range for the security group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>22/22</para>
                /// </summary>
                [NameInMap("SourcePortRange")]
                [Validation(Required=false)]
                public string SourcePortRange { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the destination security group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sg-bp1gxw6bznjjvhu3****</para>
        /// </summary>
        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// <para>The name of the destination security group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testSecurityGroupName2</para>
        /// </summary>
        [NameInMap("SecurityGroupName")]
        [Validation(Required=false)]
        public string SecurityGroupName { get; set; }

    }

}
