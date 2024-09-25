// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CreateRouteTableRequest : TeaModel {
        /// <summary>
        /// <para>The type of the route table. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>VSwitch</b> (default): vSwitch route table</description></item>
        /// <item><description><b>Gateway</b>: gateway route table</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>VSwitch</para>
        /// </summary>
        [NameInMap("AssociateType")]
        [Validation(Required=false)]
        public string AssociateType { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate the value, but you must make sure that it is unique among different requests. The token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para> If you do not specify this parameter, <b>ClientToken</b> is set to the value of <b>RequestId</b>. The value of <b>RequestId</b> in each API request may be different.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>02fb3da4-130e-11e9-8e44-0016e04</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The description of the route table.</para>
        /// <para>The description must be 1 to 256 characters in length, and cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>abc</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID of the virtual private cloud (VPC) to which the custom route table belongs.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-zhangjiakou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The name of the route table.</para>
        /// <para>The name must be 1 to 128 characters in length, and cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>myRouteTable</para>
        /// </summary>
        [NameInMap("RouteTableName")]
        [Validation(Required=false)]
        public string RouteTableName { get; set; }

        /// <summary>
        /// <para>The tags of the resource.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateRouteTableRequestTag> Tag { get; set; }
        public class CreateRouteTableRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key. You can specify up to 20 tag keys. The tag key cannot be an empty string.</para>
            /// <para>The tag key can be up to 128 characters in length. It cannot start with <c>aliyun</c> or <c>acs:</c>, and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FinanceDept</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value. You can specify at most 20 tag values. The tag value can be an empty string.</para>
            /// <para>The tag value can be up to 128 characters in length and cannot contain <c>http://</c> or <c>https://</c>. The tag value cannot start with <c>aliyun</c> or <c>acs:</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FinanceJoshua</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The ID of the VPC to which the custom route table belongs.</para>
        /// <para>If a VPC contains an Elastic Compute Service (ECS) instance that belongs to one of the following instance families, you cannot create a custom route table for the VPC:</para>
        /// <para>ecs.c1, ecs.c2, ecs.c4, ecs.ce4, ecs.cm4, ecs.d1, ecs.e3, ecs.e4, ecs.ga1, ecs.gn4, ecs.gn5, ecs.i1, ecs.m1, ecs.m2, ecs.mn4, ecs.n1, ecs.n2, ecs.n4, ecs.s1, ecs.s2, ecs.s3, ecs.se1, ecs.sn1, ecs.sn2, ecs.t1, and ecs.xn4</para>
        /// <para>You must upgrade or release the ECS instance before you can create a custom route table for the VPC.</para>
        /// <list type="bullet">
        /// <item><description>For more information about how to upgrade an ECS instance, see <a href="https://help.aliyun.com/document_detail/25438.html">Upgrade subscription instances</a> and <a href="https://help.aliyun.com/document_detail/60051.html">Change specifications of pay-as-you-go instances</a>.</description></item>
        /// <item><description>For more information about how to release an ECS instance, see <a href="https://help.aliyun.com/document_detail/25442.html">Release an ECS instance</a>.</description></item>
        /// </list>
        /// <remarks>
        /// <para> If a custom route table is created for a VPC that contains an ECS instance from one of the preceding instance families, you must upgrade or release the ECS instance. Otherwise, the custom route table cannot work as expected.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp1qpo0kug3a20qqe****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
