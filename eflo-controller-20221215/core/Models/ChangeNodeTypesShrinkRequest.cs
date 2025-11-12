// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_controller20221215.Models
{
    public class ChangeNodeTypesShrinkRequest : TeaModel {
        [NameInMap("NodeIds")]
        [Validation(Required=false)]
        public string NodeIdsShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>standard</para>
        /// </summary>
        [NameInMap("NodeType")]
        [Validation(Required=false)]
        public string NodeType { get; set; }

    }

}
