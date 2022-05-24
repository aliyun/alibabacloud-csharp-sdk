// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class FixNodePoolVulsRequest : TeaModel {
        /// <summary>
        /// 待修复的节点名称列表
        /// </summary>
        [NameInMap("nodes")]
        [Validation(Required=false)]
        public List<string> Nodes { get; set; }

        /// <summary>
        /// 轮转修复策略
        /// </summary>
        [NameInMap("rollout_policy")]
        [Validation(Required=false)]
        public FixNodePoolVulsRequestRolloutPolicy RolloutPolicy { get; set; }
        public class FixNodePoolVulsRequestRolloutPolicy : TeaModel {
            [NameInMap("max_parallelism")]
            [Validation(Required=false)]
            public long? MaxParallelism { get; set; }
        };

        /// <summary>
        /// 待修复的漏洞名称列表
        /// </summary>
        [NameInMap("vul_list")]
        [Validation(Required=false)]
        public List<string> VulList { get; set; }

    }

}
