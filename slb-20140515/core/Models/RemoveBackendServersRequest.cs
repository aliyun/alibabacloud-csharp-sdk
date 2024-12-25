// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class RemoveBackendServersRequest : TeaModel {
        /// <summary>
        /// <para>The backend servers that you want to remove.</para>
        /// <list type="bullet">
        /// <item><description><para><b>ServerId</b>: The IDs of the backend servers. Set the value to a string. This parameter is required.</para>
        /// </description></item>
        /// <item><description><para><b>Type</b>: the type of the backend server. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ecs</b> (default): Elastic Compute Service (ECS) instance</description></item>
        /// <item><description><b>eni</b>: elastic network interface (ENI)</description></item>
        /// <item><description><b>eci</b>: elastic container instance</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>Weight</b>: the weight of the backend server. Valid values: <b>0</b> to <b>100</b>. Set the value to an integer.</para>
        /// </description></item>
        /// </list>
        /// <para>You can specify at most 20 backend servers in each call. Examples:</para>
        /// <list type="bullet">
        /// <item><description>Remove ECS instances:</description></item>
        /// </list>
        /// <para><c>[{&quot;ServerId&quot;:&quot;i-bp1fq61enf4loa5i****&quot;, &quot;Type&quot;: &quot;ecs&quot;,&quot;Weight&quot;:&quot;100&quot;}]</c></para>
        /// <list type="bullet">
        /// <item><description>Remove ENIs:</description></item>
        /// </list>
        /// <para><c>[{&quot;ServerId&quot;:&quot;eni-2ze1sdp5****&quot;,&quot;Type&quot;: &quot;eni&quot;,&quot;Weight&quot;:&quot;100&quot;}]</c></para>
        /// <list type="bullet">
        /// <item><description>Remove elastic container instances:</description></item>
        /// </list>
        /// <para><c>[{&quot;ServerId&quot;:&quot;eci-2ze1sdp5****&quot;,&quot;Type&quot;: &quot;eci&quot;,&quot;Weight&quot;:&quot;100&quot;}]</c></para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;ServerId&quot;:&quot;i-bp1fq61enf4loa5i****&quot;, &quot;Type&quot;: &quot;ecs&quot;,&quot;Weight&quot;:&quot;100&quot;}]</para>
        /// </summary>
        [NameInMap("BackendServers")]
        [Validation(Required=false)]
        public string BackendServers { get; set; }

        /// <summary>
        /// <para>The ID of the CLB instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lb-bp15lbk8uja8rvm4a****</para>
        /// </summary>
        [NameInMap("LoadBalancerId")]
        [Validation(Required=false)]
        public string LoadBalancerId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the region where the CLB instance is deployed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
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

    }

}
