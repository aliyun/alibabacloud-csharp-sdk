// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class ComponentInstanceSelector : TeaModel {
        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The action scope. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>APPLICATION: The application level.</para>
        /// </description></item>
        /// <item><description><para>COMPONENT: The component level.</para>
        /// </description></item>
        /// <item><description><para>COMPONENT_INSTANCE: The component instance level.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>APPLICATION</para>
        /// </summary>
        [NameInMap("ActionScope")]
        [Validation(Required=false)]
        [Obsolete]
        public string ActionScope { get; set; }

        /// <summary>
        /// <para>The application name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>HDFS</para>
        /// </summary>
        [NameInMap("ApplicationName")]
        [Validation(Required=false)]
        public string ApplicationName { get; set; }

        /// <summary>
        /// <para>A list of component instances. This parameter is used when <c>RunActionScope</c> is set to <c>COMPONENT_INSTANCE</c>.</para>
        /// </summary>
        [NameInMap("ComponentInstances")]
        [Validation(Required=false)]
        public List<ComponentInstanceSelectorComponentInstances> ComponentInstances { get; set; }
        public class ComponentInstanceSelectorComponentInstances : TeaModel {
            /// <summary>
            /// <para>The application name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>HDFS</para>
            /// </summary>
            [NameInMap("ApplicationName")]
            [Validation(Required=false)]
            public string ApplicationName { get; set; }

            /// <summary>
            /// <para>The component name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DataNode</para>
            /// </summary>
            [NameInMap("ComponentName")]
            [Validation(Required=false)]
            public string ComponentName { get; set; }

            /// <summary>
            /// <para>The node ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-bp1cudc25w2bfwl5****</para>
            /// </summary>
            [NameInMap("NodeId")]
            [Validation(Required=false)]
            public string NodeId { get; set; }

        }

        /// <summary>
        /// <para>A list of components. This parameter is used when <c>RunActionScope</c> is set to <c>COMPONENT</c>.</para>
        /// </summary>
        [NameInMap("Components")]
        [Validation(Required=false)]
        public List<ComponentInstanceSelectorComponents> Components { get; set; }
        public class ComponentInstanceSelectorComponents : TeaModel {
            /// <summary>
            /// <para>The application name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>HDFS</para>
            /// </summary>
            [NameInMap("ApplicationName")]
            [Validation(Required=false)]
            public string ApplicationName { get; set; }

            /// <summary>
            /// <para>The component name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DataNode</para>
            /// </summary>
            [NameInMap("ComponentName")]
            [Validation(Required=false)]
            public string ComponentName { get; set; }

        }

        /// <summary>
        /// <para>The action scope. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>APPLICATION: The application level.</para>
        /// </description></item>
        /// <item><description><para>COMPONENT: The component level.</para>
        /// </description></item>
        /// <item><description><para>COMPONENT_INSTANCE: The component instance level.</para>
        /// </description></item>
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
