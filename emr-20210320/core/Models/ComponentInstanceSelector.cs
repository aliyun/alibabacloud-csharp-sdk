// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class ComponentInstanceSelector : TeaModel {
        /// <term><b>Obsolete</b></term>
        [NameInMap("ActionScope")]
        [Validation(Required=false)]
        [Obsolete]
        public string ActionScope { get; set; }

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
        /// <para>组件实例列表。actionScope为COPONENT_INSTANCE时使用。</para>
        /// </summary>
        [NameInMap("ComponentInstances")]
        [Validation(Required=false)]
        public List<ComponentInstanceSelectorComponentInstances> ComponentInstances { get; set; }
        public class ComponentInstanceSelectorComponentInstances : TeaModel {
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
            /// <para>节点ID。</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-bp1cudc25w2bfwl5****</para>
            /// </summary>
            [NameInMap("NodeId")]
            [Validation(Required=false)]
            public string NodeId { get; set; }

        }

        /// <summary>
        /// <para>组件列表。
        /// actionScope为COPONENT时使用。</para>
        /// </summary>
        [NameInMap("Components")]
        [Validation(Required=false)]
        public List<ComponentInstanceSelectorComponents> Components { get; set; }
        public class ComponentInstanceSelectorComponents : TeaModel {
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

        }

        /// <summary>
        /// <para>动作执行范围。取值范围：</para>
        /// <list type="bullet">
        /// <item><description>APPLICATION：应用级别。</description></item>
        /// <item><description>COMPONENT：组件级别。</description></item>
        /// <item><description>COMPONENT_INSTANCE：组件实例级别。</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>APPLICATION</para>
        /// </summary>
        [NameInMap("RunActionScope")]
        [Validation(Required=false)]
        public string RunActionScope { get; set; }

    }

}
