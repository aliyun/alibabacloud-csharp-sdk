// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class ErrorInfo : TeaModel {
        /// <summary>
        /// 错误信息
        /// </summary>
        [NameInMap("errorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// 错误堆栈
        /// </summary>
        [NameInMap("stackTrace")]
        [Validation(Required=false)]
        public string StackTrace { get; set; }

    }

}
