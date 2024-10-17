// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class AckNodePool : TeaModel {
        /// <summary>
        /// <para>节点池ID。</para>
        /// 
        /// <b>Example:</b>
        /// <para>npe76629caa1b14a73bf3e47c6d481****</para>
        /// </summary>
        [NameInMap("NodePoolId")]
        [Validation(Required=false)]
        public string NodePoolId { get; set; }

        /// <summary>
        /// <para>ACK节点选择器。</para>
        /// </summary>
        [NameInMap("NodeSelector")]
        [Validation(Required=false)]
        public AckNodeSelector NodeSelector { get; set; }

    }

}
