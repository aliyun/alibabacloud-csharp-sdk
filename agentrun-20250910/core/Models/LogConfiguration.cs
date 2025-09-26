// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class LogConfiguration : TeaModel {
        /// <summary>
        /// <para>SLS日志库名称</para>
        /// </summary>
        [NameInMap("logstore")]
        [Validation(Required=false)]
        public string Logstore { get; set; }

        /// <summary>
        /// <para>SLS项目名称</para>
        /// </summary>
        [NameInMap("project")]
        [Validation(Required=false)]
        public string Project { get; set; }

    }

}
