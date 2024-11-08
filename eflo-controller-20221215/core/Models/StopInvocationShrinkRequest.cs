// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_controller20221215.Models
{
    public class StopInvocationShrinkRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>f-hz044748dzepds0</para>
        /// </summary>
        [NameInMap("InvokeId")]
        [Validation(Required=false)]
        public string InvokeId { get; set; }

        [NameInMap("NodeIdList")]
        [Validation(Required=false)]
        public string NodeIdListShrink { get; set; }

    }

}
