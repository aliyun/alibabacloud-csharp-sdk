// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class CreateCodeSourceResponseBody : TeaModel {
        /// <summary>
        /// 创建的代码源配置的ID
        /// </summary>
        [NameInMap("CodeSourceId")]
        [Validation(Required=false)]
        public string CodeSourceId { get; set; }

        /// <summary>
        /// 请求ID
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
