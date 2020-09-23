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
            /// Addon配置信息。
            /// </summary>
            [NameInMap("config")]
            [Validation(Required=false)]
            public string Config { get; set; }

            /// <summary>
            /// 是否禁止默认安装。
            /// </summary>
            [NameInMap("disabled")]
            [Validation(Required=false)]
            public bool? Disabled { get; set; }

            /// <summary>
            /// Addon名称。
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// 是否默认安装。
            /// </summary>
            [NameInMap("required")]
            [Validation(Required=false)]
            public string Required { get; set; }

            /// <summary>
            /// Addon版本号。
            /// </summary>
            [NameInMap("version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

    }

}
