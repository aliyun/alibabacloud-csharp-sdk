// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Starrocks20221019.Models
{
    public class RestartNodeGroupRequest : TeaModel {
        /// <summary>
        /// <para>Whether to restart in fast mode. Default value: false.</para>
        /// <list type="bullet">
        /// <item><description><para>true: Restart compute nodes in fast mode. Nodes restart in batches. Within each batch, nodes restart in parallel. Between batches, restarts run sequentially.</para>
        /// </description></item>
        /// <item><description><para>false: Restart compute nodes using rolling restart.</para>
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
        /// <para>The ID of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c-b25e21e24388****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the compute group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ng-3d5ce6454354****</para>
        /// </summary>
        [NameInMap("NodeGroupId")]
        [Validation(Required=false)]
        public string NodeGroupId { get; set; }

    }

}
