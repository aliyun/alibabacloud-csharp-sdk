// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class LogDestination : TeaModel {
        /// <summary>
        /// <para>阿里云日志服务（SLS）的日志目标配置</para>
        /// </summary>
        [NameInMap("slsLogDestination")]
        [Validation(Required=false)]
        public SLSLogDestination SlsLogDestination { get; set; }

    }

}
