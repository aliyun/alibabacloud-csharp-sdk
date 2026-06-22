// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class NodeSelector : TeaModel {
        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <remarks>
        /// <para>This parameter is deprecated. Use <c>NodeGroupIds</c> instead.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ng-869471354ecd****</para>
        /// </summary>
        [NameInMap("NodeGroupId")]
        [Validation(Required=false)]
        [Obsolete]
        public string NodeGroupId { get; set; }

        /// <summary>
        /// <para>The IDs of the node groups to select.</para>
        /// </summary>
        [NameInMap("NodeGroupIds")]
        [Validation(Required=false)]
        public List<string> NodeGroupIds { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <remarks>
        /// <para>This parameter is deprecated. Use <c>NodeGroupNames</c> instead.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>master-1</para>
        /// </summary>
        [NameInMap("NodeGroupName")]
        [Validation(Required=false)]
        [Obsolete]
        public string NodeGroupName { get; set; }

        /// <summary>
        /// <para>The names of the node groups to select.</para>
        /// </summary>
        [NameInMap("NodeGroupNames")]
        [Validation(Required=false)]
        public List<string> NodeGroupNames { get; set; }

        /// <summary>
        /// <para>The types of node groups to select. This parameter applies only when <c>NodeSelectType</c> is set to <c>NODE_GROUP</c> and <c>NodeGroupIds</c> is not specified. The array can contain up to 10 elements.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;CORE&quot;,&quot;TASK&quot;]</para>
        /// </summary>
        [NameInMap("NodeGroupTypes")]
        [Validation(Required=false)]
        public List<string> NodeGroupTypes { get; set; }

        /// <summary>
        /// <para>The names of the nodes to select. This parameter applies only when <c>NodeSelectType</c> is set to <c>NODE</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;core1-1&quot;]</para>
        /// </summary>
        [NameInMap("NodeNames")]
        [Validation(Required=false)]
        public List<string> NodeNames { get; set; }

        /// <summary>
        /// <para>The node selection type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>CLUSTER</c>: Selects all nodes in the cluster.</para>
        /// </description></item>
        /// <item><description><para><c>NODE_GROUP</c>: Selects nodes by their node group.</para>
        /// </description></item>
        /// <item><description><para><c>NODE</c>: Selects specific nodes by name.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CLUSTER</para>
        /// </summary>
        [NameInMap("NodeSelectType")]
        [Validation(Required=false)]
        public string NodeSelectType { get; set; }

    }

}
