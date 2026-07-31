// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class LogAnalyzeResult : TeaModel {
        /// <summary>
        /// <para>The solution for the error log.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Please increase cpu quota for your resource group</para>
        /// </summary>
        [NameInMap("AppErrorAdvice")]
        [Validation(Required=false)]
        public string AppErrorAdvice { get; set; }

        /// <summary>
        /// <para>The error type if an analysis error occurs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EXCEEDED_QUOTA</para>
        /// </summary>
        [NameInMap("AppErrorCode")]
        [Validation(Required=false)]
        public string AppErrorCode { get; set; }

        /// <summary>
        /// <para>The error log of the Spark log analysis task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>exception: cpu is exceeded limits 12/10</para>
        /// </summary>
        [NameInMap("AppErrorLog")]
        [Validation(Required=false)]
        public string AppErrorLog { get; set; }

    }

}
