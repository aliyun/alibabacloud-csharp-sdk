// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class TensorboardSpec : TeaModel {
        /// <summary>
        /// <para>The specifications of the ECS instance configured for the pay-as-you-go Tensorboard task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs.g6.large</para>
        /// </summary>
        [NameInMap("EcsType")]
        [Validation(Required=false)]
        public string EcsType { get; set; }

        /// <summary>
        /// <para>The ID of the security group configured for the pay-as-you-go Tensorboard task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sg-xxxxx</para>
        /// </summary>
        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// <para>The ID of the vSwitch configured for the pay-as-you-go Tensorboard task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-xxxx</para>
        /// </summary>
        [NameInMap("SwitchId")]
        [Validation(Required=false)]
        public string SwitchId { get; set; }

        /// <summary>
        /// <para>The ID of the virtual private cloud (VPC) configured for the pay-as-you-go Tensorboard task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-xxxx</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
