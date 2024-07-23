// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ListTagResourcesResponseBody : TeaModel {
        /// <summary>
        /// <para>A pagination token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>caeba0bbb2be03f84eb48b699f0a4883</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>484256DA-D816-44D2-9D86-B6EE4D5BA78C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information about the resource and its tags, including the resource ID, the resource type, and the keys and values of the tags.</para>
        /// </summary>
        [NameInMap("TagResources")]
        [Validation(Required=false)]
        public ListTagResourcesResponseBodyTagResources TagResources { get; set; }
        public class ListTagResourcesResponseBodyTagResources : TeaModel {
            [NameInMap("TagResource")]
            [Validation(Required=false)]
            public List<ListTagResourcesResponseBodyTagResourcesTagResource> TagResource { get; set; }
            public class ListTagResourcesResponseBodyTagResourcesTagResource : TeaModel {
                /// <summary>
                /// <para>The resource ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>i-bp1j6qtvdm8w0z1o****</para>
                /// </summary>
                [NameInMap("ResourceId")]
                [Validation(Required=false)]
                public string ResourceId { get; set; }

                /// <summary>
                /// <para>The resource type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>instance: ECS instance</description></item>
                /// <item><description>disk: disk</description></item>
                /// <item><description>snapshot: snapshot</description></item>
                /// <item><description>image: image</description></item>
                /// <item><description>securitygroup: security group</description></item>
                /// <item><description>volume: storage volume</description></item>
                /// <item><description>eni: ENI</description></item>
                /// <item><description>ddh: dedicated host</description></item>
                /// <item><description>ddhcluster: dedicated host cluster</description></item>
                /// <item><description>keypair: SSH key pair</description></item>
                /// <item><description>launchtemplate: launch template</description></item>
                /// <item><description>reservedinstance: reserved instance</description></item>
                /// <item><description>snapshotpolicy: automatic snapshot policy</description></item>
                /// <item><description>elasticityassurance: elasticity assurance</description></item>
                /// <item><description>capacityreservation: capacity reservation</description></item>
                /// <item><description>command: Cloud Assistant command</description></item>
                /// <item><description>invocation: Cloud Assistant command execution result</description></item>
                /// <item><description>activation: activation code for a Cloud Assistant managed instance</description></item>
                /// <item><description>managedinstance: Cloud Assistant managed instance</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>instance</para>
                /// </summary>
                [NameInMap("ResourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

                /// <summary>
                /// <para>The tag key of the resource.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TestKey</para>
                /// </summary>
                [NameInMap("TagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                /// <summary>
                /// <para>The tag value of the resource.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TestValue</para>
                /// </summary>
                [NameInMap("TagValue")]
                [Validation(Required=false)]
                public string TagValue { get; set; }

            }

        }

    }

}
