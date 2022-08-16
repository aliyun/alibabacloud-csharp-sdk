// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class AssumeRoleChain : TeaModel {
        [NameInMap("Chain")]
        [Validation(Required=false)]
        public List<AssumeRoleChainNode> Chain { get; set; }

        [NameInMap("Policy")]
        [Validation(Required=false)]
        public string Policy { get; set; }

    }

}
