// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class UpgradeClusterAddonsRequest : TeaModel {
        /// <summary>
        /// The request parameters.
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public List<UpgradeClusterAddonsRequestBody> Body { get; set; }
        public class UpgradeClusterAddonsRequestBody : TeaModel {
            /// <summary>
            /// The name of the component.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("component_name")]
            [Validation(Required=false)]
            public string ComponentName { get; set; }

            /// <summary>
            /// The custom component settings that you want to use. The value is a JSON string.
            /// </summary>
            [NameInMap("config")]
            [Validation(Required=false)]
            public string Config { get; set; }

            /// <summary>
            /// The version to which the component can be updated. You can call the `DescribeClusterAddonsVersion` operation to query the version to which the component can be updated.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("next_version")]
            [Validation(Required=false)]
            public string NextVersion { get; set; }

            /// <summary>
            /// The update policy. Valid values:
            /// 
            /// *   overwrite
            /// *   canary
            /// </summary>
            [NameInMap("policy")]
            [Validation(Required=false)]
            public string Policy { get; set; }

            /// <summary>
            /// The current version of the component.
            /// </summary>
            [NameInMap("version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

    }

}
