// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class LogtailConfig : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("configName")]
        [Validation(Required=false)]
        public string ConfigName { get; set; }

        [NameInMap("createTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("inputDetail")]
        [Validation(Required=false)]
        public Dictionary<string, object> InputDetail { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("inputType")]
        [Validation(Required=false)]
        public string InputType { get; set; }

        [NameInMap("lastModifyTime")]
        [Validation(Required=false)]
        public long? LastModifyTime { get; set; }

        [NameInMap("logSample")]
        [Validation(Required=false)]
        public string LogSample { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("outputDetail")]
        [Validation(Required=false)]
        public LogtailConfigOutputDetail OutputDetail { get; set; }
        public class LogtailConfigOutputDetail : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("endpoint")]
            [Validation(Required=false)]
            public string Endpoint { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("logstoreName")]
            [Validation(Required=false)]
            public string LogstoreName { get; set; }

            [NameInMap("region")]
            [Validation(Required=false)]
            public string Region { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("outputType")]
        [Validation(Required=false)]
        public string OutputType { get; set; }

    }

}
