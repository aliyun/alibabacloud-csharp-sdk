// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class Logging : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("loggingDetails")]
        [Validation(Required=false)]
        public List<LoggingLoggingDetails> LoggingDetails { get; set; }
        public class LoggingLoggingDetails : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("logstore")]
            [Validation(Required=false)]
            public string Logstore { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("loggingProject")]
        [Validation(Required=false)]
        public string LoggingProject { get; set; }

    }

}
