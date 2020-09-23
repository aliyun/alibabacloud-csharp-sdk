// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class UpgradeClusterAddonsRequest : TeaModel {
        /// <summary>
        /// Request body，类型是对象数组。
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public List<UpgradeClusterAddonsRequestBody> Body { get; set; }
        public class UpgradeClusterAddonsRequestBody : TeaModel {
            /// <summary>
            /// 组件名称。
            /// </summary>
            [NameInMap("component_name")]
            [Validation(Required=false)]
            public string ComponentName { get; set; }

            /// <summary>
            /// 可升级版本。
            /// </summary>
            [NameInMap("next_version")]
            [Validation(Required=false)]
            public string NextVersion { get; set; }

            /// <summary>
            /// 当前版本。
            /// </summary>
            [NameInMap("version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

    }

}
