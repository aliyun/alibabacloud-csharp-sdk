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
        /// <para>节点组ID。当NodeSelectType取值NodeGroup时，该参数生效。</para>
        /// 
        /// <b>Example:</b>
        /// <para>ng-869471354ecd****</para>
        /// </summary>
        [NameInMap("NodeGroupId")]
        [Validation(Required=false)]
        [Obsolete]
        public string NodeGroupId { get; set; }

        [NameInMap("NodeGroupIds")]
        [Validation(Required=false)]
        public List<string> NodeGroupIds { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>节点组名称。当NodeSelectType取值NodeGroup，且参数NodeGroupId为空时生效，该参数生效。</para>
        /// 
        /// <b>Example:</b>
        /// <para>master-1</para>
        /// </summary>
        [NameInMap("NodeGroupName")]
        [Validation(Required=false)]
        [Obsolete]
        public string NodeGroupName { get; set; }

        [NameInMap("NodeGroupNames")]
        [Validation(Required=false)]
        public List<string> NodeGroupNames { get; set; }

        /// <summary>
        /// <para>节点组类型。当NodeSelectType取值NodeGroup，且参数NodeGroupId为空时生效。数组元数个数N取值范围：0~10。</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;CORE&quot;,&quot;TASK&quot;]</para>
        /// </summary>
        [NameInMap("NodeGroupTypes")]
        [Validation(Required=false)]
        public List<string> NodeGroupTypes { get; set; }

        /// <summary>
        /// <para>节点名称列表。当NodeSelectType取值Node时，该参数生效。</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;core1-1&quot;]</para>
        /// </summary>
        [NameInMap("NodeNames")]
        [Validation(Required=false)]
        public List<string> NodeNames { get; set; }

        /// <summary>
        /// <para>节点选择类型。取值范围：</para>
        /// <list type="bullet">
        /// <item><description>CLUSTER：集群。</description></item>
        /// <item><description>NODE_GROUP：节点组。</description></item>
        /// <item><description>NODE：节点。</description></item>
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
