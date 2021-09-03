// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class AssumeRoleChain : TeaModel {
        /// <summary>
        /// 当前用户 policy
        /// </summary>
        [NameInMap("Policy")]
        [Validation(Required=false)]
        public string Policy { get; set; }

        /// <summary>
        /// 链式授权节点
        /// </summary>
        [NameInMap("Chain")]
        [Validation(Required=false)]
        public List<AssumeRoleChainNode> Chain { get; set; }

    }

}
