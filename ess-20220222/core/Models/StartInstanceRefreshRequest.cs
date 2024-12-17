// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class StartInstanceRefreshRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25965.html">Ensure idempotence</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-42665544****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The desired configurations of the instance refresh task.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>When you call this operation, you must specify one of the following parameters: ScalingConfigurationId and ImageId.</para>
        /// </description></item>
        /// <item><description><para>Instances whose configurations match the desired configurations of the task are ignored during instance refresh.</para>
        /// </description></item>
        /// </list>
        /// </summary>
        [NameInMap("DesiredConfiguration")]
        [Validation(Required=false)]
        public StartInstanceRefreshRequestDesiredConfiguration DesiredConfiguration { get; set; }
        public class StartInstanceRefreshRequestDesiredConfiguration : TeaModel {
            /// <summary>
            /// <para>The image ID.</para>
            /// <remarks>
            /// </remarks>
            /// <list type="bullet">
            /// <item><description><para>After the instance refresh task is complete, the active scaling configuration uses the image specified by this parameter.</para>
            /// </description></item>
            /// <item><description><para>If the instance configuration source of the scaling group is a launch template, you cannot specify this parameter.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>m-2ze8cqacj7opnf***</para>
            /// </summary>
            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// <para>The ID of the scaling configuration.</para>
            /// <remarks>
            /// <para> After the instance refresh task is complete, the scaling group uses the scaling configuration specified by this parameter.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>asc-2zed7lqn4ts4****</para>
            /// </summary>
            [NameInMap("ScalingConfigurationId")]
            [Validation(Required=false)]
            public string ScalingConfigurationId { get; set; }

        }

        /// <summary>
        /// <para>The ratio of instances that can exceed the upper limit of the scaling group capacity to all instances in the scaling group during instance refresh. Valid values: 100 to 200. Default value: 120.</para>
        /// <remarks>
        /// <para> If you set MinHealthyPercentage and MaxHealthyPercentage to 100, Auto Scaling refreshes the configurations of one instance each time the instance refresh task starts.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("MaxHealthyPercentage")]
        [Validation(Required=false)]
        public int? MaxHealthyPercentage { get; set; }

        /// <summary>
        /// <para>The ratio of instances that are in the In Service state to all instances in the scaling group during instance refresh. Valid values: 0 to 100. Default value: 80.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("MinHealthyPercentage")]
        [Validation(Required=false)]
        public int? MinHealthyPercentage { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID of the scaling group.</para>
        /// <para>This parameter is required.</para>
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

        /// <summary>
        /// <para>The ID of the scaling group.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>asg-bp18p2yfxow2dloq****</para>
        /// </summary>
        [NameInMap("ScalingGroupId")]
        [Validation(Required=false)]
        public string ScalingGroupId { get; set; }

        [NameInMap("SkipMatching")]
        [Validation(Required=false)]
        public bool? SkipMatching { get; set; }

    }

}
