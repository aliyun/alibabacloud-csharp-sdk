// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class LoggingConfiguration : TeaModel {
        /// <summary>
        /// <para>日志输出的目标配置列表</para>
        /// </summary>
        [NameInMap("destinations")]
        [Validation(Required=false)]
        public List<LogDestination> Destinations { get; set; }

    }

}
