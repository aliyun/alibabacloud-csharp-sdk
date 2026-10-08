// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class AssumeRoleChain : TeaModel {
        /// <summary>
        /// <para>The authorization chains.</para>
        /// </summary>
        [NameInMap("Chain")]
        [Validation(Required=false)]
        public List<AssumeRoleChainNode> Chain { get; set; }

        /// <summary>
        /// <para>The policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Policy")]
        [Validation(Required=false)]
        public string Policy { get; set; }

    }

}
