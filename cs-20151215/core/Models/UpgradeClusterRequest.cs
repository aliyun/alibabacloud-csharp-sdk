// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class UpgradeClusterRequest : TeaModel {
        /// <summary>
        /// 组件名称，集群升级时取值"k8s"。
        /// </summary>
        [NameInMap("component_name")]
        [Validation(Required=false)]
        public string ComponentName { get; set; }

        /// <summary>
        /// 当前版本。
        /// </summary>
        [NameInMap("version")]
        [Validation(Required=false)]
        public string Version { get; set; }

        /// <summary>
        /// 目标版本。
        /// </summary>
        [NameInMap("next_version")]
        [Validation(Required=false)]
        public string NextVersion { get; set; }

    }

}
