// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeInstanceRamRoleResponseBody : TeaModel {
        /// <summary>
        /// <para>Details about the instance RAM roles.</para>
        /// </summary>
        [NameInMap("InstanceRamRoleSets")]
        [Validation(Required=false)]
        public DescribeInstanceRamRoleResponseBodyInstanceRamRoleSets InstanceRamRoleSets { get; set; }
        public class DescribeInstanceRamRoleResponseBodyInstanceRamRoleSets : TeaModel {
            [NameInMap("InstanceRamRoleSet")]
            [Validation(Required=false)]
            public List<DescribeInstanceRamRoleResponseBodyInstanceRamRoleSetsInstanceRamRoleSet> InstanceRamRoleSet { get; set; }
            public class DescribeInstanceRamRoleResponseBodyInstanceRamRoleSetsInstanceRamRoleSet : TeaModel {
                /// <summary>
                /// <para>The ID of the instance</para>
                /// 
                /// <b>Example:</b>
                /// <para>i-bp67acfmxazb4p****</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The name of the instance RAM role.</para>
                /// 
                /// <b>Example:</b>
                /// <para>EcsServiceRole-EcsDocGuideTest</para>
                /// </summary>
                [NameInMap("RamRoleName")]
                [Validation(Required=false)]
                public string RamRoleName { get; set; }

            }

        }

        /// <summary>
        /// <para>The region ID of the instance RAM role.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of instance RAM roles returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
