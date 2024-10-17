// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class ComponentLayout : TeaModel {
        /// <summary>
        /// <para>应用名称。</para>
        /// 
        /// <b>Example:</b>
        /// <para>HDFS</para>
        /// </summary>
        [NameInMap("ApplicationName")]
        [Validation(Required=false)]
        public string ApplicationName { get; set; }

        /// <summary>
        /// <para>组件名称。</para>
        /// 
        /// <b>Example:</b>
        /// <para>DataNode</para>
        /// </summary>
        [NameInMap("ComponentName")]
        [Validation(Required=false)]
        public string ComponentName { get; set; }

        /// <summary>
        /// <para>节点选择器。</para>
        /// </summary>
        [NameInMap("NodeSelector")]
        [Validation(Required=false)]
        public ComponentLayoutNodeSelector NodeSelector { get; set; }
        public class ComponentLayoutNodeSelector : TeaModel {
            /// <summary>
            /// <para>节点结束编号，包含结束编号。</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("NodeEndIndex")]
            [Validation(Required=false)]
            public int? NodeEndIndex { get; set; }

            /// <summary>
            /// <para>节点组ID。</para>
            /// 
            /// <b>Example:</b>
            /// <para>G-F609686D45D4ABCD</para>
            /// </summary>
            [NameInMap("NodeGroupId")]
            [Validation(Required=false)]
            public string NodeGroupId { get; set; }

            /// <summary>
            /// <para>机器组下标编号。</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("NodeGroupIndex")]
            [Validation(Required=false)]
            public int? NodeGroupIndex { get; set; }

            /// <summary>
            /// <para>机器组名。</para>
            /// 
            /// <b>Example:</b>
            /// <para>master-1</para>
            /// </summary>
            [NameInMap("NodeGroupName")]
            [Validation(Required=false)]
            public string NodeGroupName { get; set; }

            /// <summary>
            /// <para>SelectType = NODE_GROUP 且 nodeGroupId 不存在时使用</para>
            /// 
            /// <b>Example:</b>
            /// <para>[null]</para>
            /// </summary>
            [NameInMap("NodeGroupTypes")]
            [Validation(Required=false)]
            public List<string> NodeGroupTypes { get; set; }

            /// <summary>
            /// <para>节点名称列表。</para>
            /// 
            /// <b>Example:</b>
            /// <para>[null]</para>
            /// </summary>
            [NameInMap("NodeNames")]
            [Validation(Required=false)]
            public List<string> NodeNames { get; set; }

            /// <summary>
            /// <para>节点选择类型。</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CLUSTER</para>
            /// </summary>
            [NameInMap("NodeSelectType")]
            [Validation(Required=false)]
            public string NodeSelectType { get; set; }

            /// <summary>
            /// <para>节点开始编号，包含开始编号。</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("NodeStartIndex")]
            [Validation(Required=false)]
            public int? NodeStartIndex { get; set; }

        }

    }

}
