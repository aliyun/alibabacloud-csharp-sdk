// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class ComponentInstanceSelector : TeaModel {
        /// <summary>
        /// 应用名称。
        /// </summary>
        [NameInMap("ApplicationName")]
        [Validation(Required=false)]
        public string ApplicationName { get; set; }

        /// <summary>
        /// 组件实例列表。actionScope为COPONENT_INSTANCE时使用。
        /// </summary>
        [NameInMap("ComponentInstances")]
        [Validation(Required=false)]
        public List<ComponentInstanceSelectorComponentInstances> ComponentInstances { get; set; }
        public class ComponentInstanceSelectorComponentInstances : TeaModel {
            /// <summary>
            /// 应用名称。
            /// </summary>
            [NameInMap("ApplicationName")]
            [Validation(Required=false)]
            public string ApplicationName { get; set; }

            /// <summary>
            /// 组件名称。
            /// </summary>
            [NameInMap("ComponentName")]
            [Validation(Required=false)]
            public string ComponentName { get; set; }

            /// <summary>
            /// 节点ID。
            /// </summary>
            [NameInMap("NodeId")]
            [Validation(Required=false)]
            public string NodeId { get; set; }

        }

        /// <summary>
        /// 组件列表。
        /// actionScope为COPONENT时使用。
        /// </summary>
        [NameInMap("Components")]
        [Validation(Required=false)]
        public List<ComponentInstanceSelectorComponents> Components { get; set; }
        public class ComponentInstanceSelectorComponents : TeaModel {
            /// <summary>
            /// 应用名称。
            /// </summary>
            [NameInMap("ApplicationName")]
            [Validation(Required=false)]
            public string ApplicationName { get; set; }

            /// <summary>
            /// 组件名称。
            /// </summary>
            [NameInMap("ComponentName")]
            [Validation(Required=false)]
            public string ComponentName { get; set; }

        }

        /// <summary>
        /// 执行范围。
        /// </summary>
        [NameInMap("RunActionScope")]
        [Validation(Required=false)]
        public string RunActionScope { get; set; }

    }

}
