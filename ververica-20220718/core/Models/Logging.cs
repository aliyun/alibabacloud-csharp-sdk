// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class Logging : TeaModel {
        [NameInMap("log4j2ConfigurationTemplate")]
        [Validation(Required=false)]
        public string Log4j2ConfigurationTemplate { get; set; }

        [NameInMap("log4jLoggers")]
        [Validation(Required=false)]
        public List<Log4jLogger> Log4jLoggers { get; set; }

        [NameInMap("logReservePolicy")]
        [Validation(Required=false)]
        public LogReservePolicy LogReservePolicy { get; set; }

        [NameInMap("loggingProfile")]
        [Validation(Required=false)]
        public string LoggingProfile { get; set; }

    }

}
