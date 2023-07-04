// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CreateRouteTableRequest : TeaModel {
        /// <summary>
        /// The type of the route table. Valid values:
        /// 
        /// *   **VSwitch** (default): vSwitch route table
        /// *   **Gateway**: gateway route table
        /// </summary>
        [NameInMap("AssociateType")]
        [Validation(Required=false)]
        public string AssociateType { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request.
        /// 
        /// You can use the client to generate the value, but you must make sure that it is unique among different requests. The token can contain only ASCII characters.
        /// 
        /// >  If you do not specify this parameter, **ClientToken** is set to the value of **RequestId**. The value of **RequestId** in each API request may be different.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The description of the route table.
        /// 
        /// The description must be 1 to 256 characters in length, and cannot start with `http://` or `https://`.
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
        /// The region ID of the virtual private cloud (VPC) to which the custom route table belongs.
        /// 
        /// You can call the [DescribeRegions](~~36063~~) operation to query the most recent region list.
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
        /// The name of the route table.
        /// 
        /// The name must be 1 to 128 characters in length, and cannot start with `http://` or `https://`.
        /// </summary>
        [NameInMap("RouteTableName")]
        [Validation(Required=false)]
        public string RouteTableName { get; set; }

        /// <summary>
        /// The ID of the VPC to which the custom route table belongs.
        /// 
        /// If a VPC contains an Elastic Compute Service (ECS) instance that belongs to one of the following instance families, you cannot create a custom route table for the VPC:
        /// 
        /// ecs.c1, ecs.c2, ecs.c4, ecs.ce4, ecs.cm4, ecs.d1, ecs.e3, ecs.e4, ecs.ga1, ecs.gn4, ecs.gn5, ecs.i1, ecs.m1, ecs.m2, ecs.mn4, ecs.n1, ecs.n2, ecs.n4, ecs.s1, ecs.s2, ecs.s3, ecs.se1, ecs.sn1, ecs.sn2, ecs.t1, and ecs.xn4
        /// 
        /// You must upgrade or release the ECS instance before you can create a custom route table for the VPC.
        /// 
        /// *   For more information about how to upgrade an ECS instance, see [Upgrade subscription instances](~~25438~~) and [Change specifications of pay-as-you-go instances](~~60051~~).
        /// *   For more information about how to release an ECS instance, see [Release an ECS instance](~~25442~~).
        /// 
        /// >  If a custom route table is created for a VPC that contains an ECS instance from one of the preceding instance families, you must upgrade or release the ECS instance. Otherwise, the custom route table cannot work as expected.
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
