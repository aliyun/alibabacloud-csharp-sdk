// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_controller20221215.Models
{
    public class CreateNodeGroupShrinkRequest : TeaModel {
        /// <summary>
        /// <para>Cluster ID</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i118191731740041623425</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>Node ID.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("NodeGroup")]
        [Validation(Required=false)]
        public string NodeGroupShrink { get; set; }

        /// <summary>
        /// <para>Node information</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;NodeUnitId\&quot;:\&quot;3c2999a8-2b95-4409-93c5-ad3985fc5c9f\&quot;,\&quot;ResourceGroupId\&quot;:\&quot;\&quot;,\&quot;MaxNodes\&quot;:0,\&quot;NodeUnitName\&quot;:\&quot;asi_cn-serverless-sale_e01-lingjun-psale\&quot;}</para>
        /// </summary>
        [NameInMap("NodeUnit")]
        [Validation(Required=false)]
        public string NodeUnitShrink { get; set; }

    }

}
