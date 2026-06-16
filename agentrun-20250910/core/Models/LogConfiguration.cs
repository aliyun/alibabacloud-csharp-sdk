// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class LogConfiguration : TeaModel {
        /// <summary>
        /// <para>The name of the SLS logstore.</para>
        /// 
        /// <b>Example:</b>
        /// <para>agent-runtime-logs</para>
        /// </summary>
        [NameInMap("logstore")]
        [Validation(Required=false)]
        public string Logstore { get; set; }

        /// <summary>
        /// <para>The name of the SLS project.</para>
        /// 
        /// <b>Example:</b>
        /// <para>agent-runtime-logs</para>
        /// </summary>
        [NameInMap("project")]
        [Validation(Required=false)]
        public string Project { get; set; }

    }

}
