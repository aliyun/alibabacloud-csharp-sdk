// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class Logging : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("loggingDetails")]
        [Validation(Required=false)]
        public List<LoggingLoggingDetails> LoggingDetails { get; set; }
        public class LoggingLoggingDetails : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>my-logstore</para>
            /// </summary>
            [NameInMap("logstore")]
            [Validation(Required=false)]
            public string Logstore { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>consumergroup_log</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-project</para>
        /// </summary>
        [NameInMap("loggingProject")]
        [Validation(Required=false)]
        public string LoggingProject { get; set; }

    }

}
