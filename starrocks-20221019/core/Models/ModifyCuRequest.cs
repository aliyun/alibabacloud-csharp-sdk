// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Starrocks20221019.Models
{
    public class ModifyCuRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to restart the instance in fast restart mode. The default value is false.</para>
        /// <list type="bullet">
        /// <item><description><para>true: Restarts the compute nodes in fast restart mode. The compute nodes are restarted in batches. Nodes within a batch are restarted in parallel, and batches are processed sequentially.</para>
        /// </description></item>
        /// <item><description><para>false: Restarts the compute nodes in rolling restart mode.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("FastMode")]
        [Validation(Required=false)]
        public bool? FastMode { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c-b25e21e24388****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The compute group ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ng-3d5ce6454354****</para>
        /// </summary>
        [NameInMap("NodeGroupId")]
        [Validation(Required=false)]
        public string NodeGroupId { get; set; }

        [NameInMap("PromotionOptionNo")]
        [Validation(Required=false)]
        public string PromotionOptionNo { get; set; }

        /// <summary>
        /// <para>The target number of CUs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("Target")]
        [Validation(Required=false)]
        public int? Target { get; set; }

    }

}
