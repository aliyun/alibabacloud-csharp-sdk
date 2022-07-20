// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class CreatePipelineRequest : TeaModel {
        /// <summary>
        /// 管道名称
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// 优先级，1-10，默认6。数值越大，优先级越高
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        /// <summary>
        /// 管道类型。
        /// </summary>
        [NameInMap("Speed")]
        [Validation(Required=false)]
        public string Speed { get; set; }

    }

}
