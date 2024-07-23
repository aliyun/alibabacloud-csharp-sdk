// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class Logging : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>xml格式文本</para>
        /// </summary>
        [NameInMap("log4j2ConfigurationTemplate")]
        [Validation(Required=false)]
        public string Log4j2ConfigurationTemplate { get; set; }

        [NameInMap("log4jLoggers")]
        [Validation(Required=false)]
        public List<Log4jLogger> Log4jLoggers { get; set; }

        [NameInMap("logReservePolicy")]
        [Validation(Required=false)]
        public LogReservePolicy LogReservePolicy { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>oss</para>
        /// </summary>
        [NameInMap("loggingProfile")]
        [Validation(Required=false)]
        public string LoggingProfile { get; set; }

    }

}
