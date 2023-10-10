// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class InstallClusterAddonsRequest : TeaModel {
        /// <summary>
        /// The request body.
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public List<InstallClusterAddonsRequestBody> Body { get; set; }
        public class InstallClusterAddonsRequestBody : TeaModel {
            /// <summary>
            /// The custom component settings that you want to use. The value is a JSON string.
            /// </summary>
            [NameInMap("config")]
            [Validation(Required=false)]
            public string Config { get; set; }

            /// <summary>
            /// The component name.
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The component version.
            /// 
            /// >  You can call the [DescribeClusterAddonsVersion](~~197434~~) operation to query the version of a component.
            /// </summary>
            [NameInMap("version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

    }

}
