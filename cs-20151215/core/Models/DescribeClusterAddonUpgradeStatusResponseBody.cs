// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeClusterAddonUpgradeStatusResponseBody : TeaModel {
        /// <summary>
        /// 组件信息。
        /// </summary>
        [NameInMap("addon_info")]
        [Validation(Required=false)]
        public DescribeClusterAddonUpgradeStatusResponseBodyAddonInfo AddonInfo { get; set; }
        public class DescribeClusterAddonUpgradeStatusResponseBodyAddonInfo : TeaModel {
            [NameInMap("category")]
            [Validation(Required=false)]
            public string Category { get; set; }
            [NameInMap("component_name")]
            [Validation(Required=false)]
            public string ComponentName { get; set; }
            [NameInMap("message")]
            [Validation(Required=false)]
            public string Message { get; set; }
            [NameInMap("version")]
            [Validation(Required=false)]
            public string Version { get; set; }
            [NameInMap("yaml")]
            [Validation(Required=false)]
            public string Yaml { get; set; }
        };

        /// <summary>
        /// 是否能够升级。
        /// </summary>
        [NameInMap("can_upgrade")]
        [Validation(Required=false)]
        public bool? CanUpgrade { get; set; }

        /// <summary>
        /// 模板信息，采用base64加密。
        /// </summary>
        [NameInMap("template")]
        [Validation(Required=false)]
        public string Template { get; set; }

    }

}
