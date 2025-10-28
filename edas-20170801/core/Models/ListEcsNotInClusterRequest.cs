// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class ListEcsNotInClusterRequest : TeaModel {
        /// <summary>
        /// <para>The network type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: classic network</description></item>
        /// <item><description>2: virtual private cloud (VPC)</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("NetworkMode")]
        [Validation(Required=false)]
        public int? NetworkMode { get; set; }

        /// <summary>
        /// <para>The ID of the VPC. This parameter is required if the NetworkMode parameter is set to 2.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-2zef6ob8****v8x3q46kp</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
