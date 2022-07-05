// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class Logging : TeaModel {
        /// <summary>
        /// logging 配置项
        /// </summary>
        [NameInMap("loggingDetails")]
        [Validation(Required=false)]
        public List<LoggingLoggingDetails> LoggingDetails { get; set; }
        public class LoggingLoggingDetails : TeaModel {
            /// <summary>
            /// logstore 名称。
            /// </summary>
            [NameInMap("logstore")]
            [Validation(Required=false)]
            public string Logstore { get; set; }

            /// <summary>
            /// logging 类型。
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// project 名称。
        /// </summary>
        [NameInMap("loggingProject")]
        [Validation(Required=false)]
        public string LoggingProject { get; set; }

    }

}
