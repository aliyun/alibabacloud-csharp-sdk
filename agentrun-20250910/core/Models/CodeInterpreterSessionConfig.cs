// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class CodeInterpreterSessionConfig : TeaModel {
        /// <summary>
        /// <para>The environment variables for the session, specified as key-value pairs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PYTHONPATH=/app,DEBUG=true</para>
        /// </summary>
        [NameInMap("environment")]
        [Validation(Required=false)]
        public Dictionary<string, string> Environment { get; set; }

        /// <summary>
        /// <para>The timeout for the session, in seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3600</para>
        /// </summary>
        [NameInMap("timeout")]
        [Validation(Required=false)]
        public int? Timeout { get; set; }

        /// <summary>
        /// <para>The working directory path for the session.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/app</para>
        /// </summary>
        [NameInMap("workingDirectory")]
        [Validation(Required=false)]
        public string WorkingDirectory { get; set; }

    }

}
