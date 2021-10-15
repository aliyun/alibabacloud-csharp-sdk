// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class CreateProjectResponseBody : TeaModel {
        [NameInMap("Project")]
        [Validation(Required=false)]
        public Project Project { get; set; }

        /// <summary>
        /// 本次请求的唯一 ID
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
