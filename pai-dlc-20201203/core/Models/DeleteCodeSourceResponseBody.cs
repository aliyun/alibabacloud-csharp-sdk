// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class DeleteCodeSourceResponseBody : TeaModel {
        /// <summary>
        /// 被删除的代码源配置ID
        /// </summary>
        [NameInMap("CodeSourceId")]
        [Validation(Required=false)]
        public string CodeSourceId { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
