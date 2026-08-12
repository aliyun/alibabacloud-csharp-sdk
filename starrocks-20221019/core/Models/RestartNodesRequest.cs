// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Starrocks20221019.Models
{
    public class RestartNodesRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c-b25e21e24388****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Information about compute group nodes to restart.</para>
        /// </summary>
        [NameInMap("RestartNodeGroups")]
        [Validation(Required=false)]
        public List<RestartNodesRequestRestartNodeGroups> RestartNodeGroups { get; set; }
        public class RestartNodesRequestRestartNodeGroups : TeaModel {
            /// <summary>
            /// <para>Whether to use fast restart mode. Default is false.</para>
            /// <list type="bullet">
            /// <item><description><para>true: Restart compute nodes in fast mode. Nodes restart in multiple batches. Within each batch, nodes restart in parallel. Batches execute sequentially.</para>
            /// </description></item>
            /// <item><description><para>false: Restart compute nodes using rolling restart.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("FastMode")]
            [Validation(Required=false)]
            public bool? FastMode { get; set; }

            /// <summary>
            /// <para>The compute group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ng-dcc7450e06a271b9</para>
            /// </summary>
            [NameInMap("NodeGroupId")]
            [Validation(Required=false)]
            public string NodeGroupId { get; set; }

            /// <summary>
            /// <para>List of node IDs.</para>
            /// </summary>
            [NameInMap("NodeIds")]
            [Validation(Required=false)]
            public List<string> NodeIds { get; set; }

        }

    }

}
