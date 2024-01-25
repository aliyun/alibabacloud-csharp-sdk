// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class UpdateResourceRequest : TeaModel {
        /// <summary>
        /// The new name of the resource group after the update. The name can be up to 27 characters in length.
        /// </summary>
        [NameInMap("ResourceName")]
        [Validation(Required=false)]
        public string ResourceName { get; set; }

        /// <summary>
        /// The configurable options for self managed resource group.
        /// </summary>
        [NameInMap("SelfManagedResourceOptions")]
        [Validation(Required=false)]
        public UpdateResourceRequestSelfManagedResourceOptions SelfManagedResourceOptions { get; set; }
        public class UpdateResourceRequestSelfManagedResourceOptions : TeaModel {
            /// <summary>
            /// The key-value pairs for matched nodes.
            /// </summary>
            [NameInMap("NodeMatchLabels")]
            [Validation(Required=false)]
            public Dictionary<string, string> NodeMatchLabels { get; set; }

            /// <summary>
            /// Tolerations for nodes.
            /// </summary>
            [NameInMap("NodeTolerations")]
            [Validation(Required=false)]
            public List<UpdateResourceRequestSelfManagedResourceOptionsNodeTolerations> NodeTolerations { get; set; }
            public class UpdateResourceRequestSelfManagedResourceOptionsNodeTolerations : TeaModel {
                /// <summary>
                /// The effect.
                /// 
                /// Valid values:
                /// - PreferNoSchedule
                /// - NoSchedule
                /// - NoExecute
                /// </summary>
                [NameInMap("effect")]
                [Validation(Required=false)]
                public string Effect { get; set; }

                /// <summary>
                /// The name of the key.
                /// </summary>
                [NameInMap("key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// Relationship between key names and key values.
                /// Valid values:
                /// - Equal
                /// - Exists
                /// </summary>
                [NameInMap("operator")]
                [Validation(Required=false)]
                public string Operator { get; set; }

                /// <summary>
                /// The name of the value.
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

    }

}
