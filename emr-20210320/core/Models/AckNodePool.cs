// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class AckNodePool : TeaModel {
        /// <summary>
        /// 节点池ID。
        /// </summary>
        [NameInMap("NodePoolId")]
        [Validation(Required=false)]
        public string NodePoolId { get; set; }

        /// <summary>
        /// ACK节点选择器。
        /// </summary>
        [NameInMap("NodeSelector")]
        [Validation(Required=false)]
        public AckNodeSelector NodeSelector { get; set; }

    }

}
