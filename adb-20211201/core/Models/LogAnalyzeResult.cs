// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class LogAnalyzeResult : TeaModel {
        [NameInMap("AppErrorAdvice")]
        [Validation(Required=false)]
        public string AppErrorAdvice { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>EXCEEDED_QUOTA</para>
        /// </summary>
        [NameInMap("AppErrorCode")]
        [Validation(Required=false)]
        public string AppErrorCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>exception: xxxx</para>
        /// </summary>
        [NameInMap("AppErrorLog")]
        [Validation(Required=false)]
        public string AppErrorLog { get; set; }

    }

}
