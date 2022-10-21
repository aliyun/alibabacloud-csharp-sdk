// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class ComponentInstanceSelector : TeaModel {
        [NameInMap("ActionScope")]
        [Validation(Required=false)]
        public string ActionScope { get; set; }

        [NameInMap("ApplicationNames")]
        [Validation(Required=false)]
        public List<string> ApplicationNames { get; set; }

        [NameInMap("ComponentInstances")]
        [Validation(Required=false)]
        public List<ComponentInstanceSelectorComponentInstances> ComponentInstances { get; set; }
        public class ComponentInstanceSelectorComponentInstances : TeaModel {
            [NameInMap("ApplicationName")]
            [Validation(Required=false)]
            public string ApplicationName { get; set; }

            [NameInMap("ComponentName")]
            [Validation(Required=false)]
            public string ComponentName { get; set; }

            [NameInMap("NodeId")]
            [Validation(Required=false)]
            public string NodeId { get; set; }

        }

        [NameInMap("Components")]
        [Validation(Required=false)]
        public List<ComponentInstanceSelectorComponents> Components { get; set; }
        public class ComponentInstanceSelectorComponents : TeaModel {
            [NameInMap("ApplicationName")]
            [Validation(Required=false)]
            public string ApplicationName { get; set; }

            [NameInMap("ComponentName")]
            [Validation(Required=false)]
            public string ComponentName { get; set; }

        }

        [NameInMap("NodeGroupIds")]
        [Validation(Required=false)]
        public List<string> NodeGroupIds { get; set; }

        [NameInMap("NodeIds")]
        [Validation(Required=false)]
        public List<string> NodeIds { get; set; }

        [NameInMap("RunActionScope")]
        [Validation(Required=false)]
        public string RunActionScope { get; set; }

    }

}
