// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class AckNode : TeaModel {
        /// <summary>
        /// <para>节点ID。</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-bp1cudc25w2bfwl5****</para>
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

        /// <summary>
        /// <para>ACK节点选择器。</para>
        /// </summary>
        [NameInMap("NodeSelector")]
        [Validation(Required=false)]
        public AckNodeSelector NodeSelector { get; set; }

    }

}
