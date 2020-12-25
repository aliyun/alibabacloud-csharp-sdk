// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class InstallClusterAddonsRequest : TeaModel {
        /// <summary>
        /// Addon列表。
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public List<InstallClusterAddonsRequestBody> Body { get; set; }
        public class InstallClusterAddonsRequestBody : TeaModel {
            /// <summary>
            /// 组件名称。
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// 组件版本号。
            /// </summary>
            [NameInMap("version")]
            [Validation(Required=false)]
            public string Version { get; set; }

            /// <summary>
            /// 组件配置信息。
            /// </summary>
            [NameInMap("config")]
            [Validation(Required=false)]
            public string Config { get; set; }

        }

    }

}
