// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class Logging : TeaModel {
        /// <summary>
        /// <para>Custom log templates.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xml格式文本</para>
        /// </summary>
        [NameInMap("log4j2ConfigurationTemplate")]
        [Validation(Required=false)]
        public string Log4j2ConfigurationTemplate { get; set; }

        /// <summary>
        /// <para>The Log4j configuration.</para>
        /// </summary>
        [NameInMap("log4jLoggers")]
        [Validation(Required=false)]
        public List<Log4jLogger> Log4jLoggers { get; set; }

        /// <summary>
        /// <para>The log retention policy.</para>
        /// </summary>
        [NameInMap("logReservePolicy")]
        [Validation(Required=false)]
        public LogReservePolicy LogReservePolicy { get; set; }

        /// <summary>
        /// <para>The type of the system log template.</para>
        /// <list type="bullet">
        /// <item><description><para>default: The default template is used.</para>
        /// </description></item>
        /// <item><description><para>oss: Logs are delivered to Object Storage Service (OSS).</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("loggingProfile")]
        [Validation(Required=false)]
        public string LoggingProfile { get; set; }

    }

}
