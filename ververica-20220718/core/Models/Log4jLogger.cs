// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class Log4jLogger : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>ERROR</para>
        /// </summary>
        [NameInMap("loggerLevel")]
        [Validation(Required=false)]
        public string LoggerLevel { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>StdOutErrConsoleAppender</para>
        /// </summary>
        [NameInMap("loggerName")]
        [Validation(Required=false)]
        public string LoggerName { get; set; }

    }

}
