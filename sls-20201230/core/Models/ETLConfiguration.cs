// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class ETLConfiguration : TeaModel {
        [NameInMap("accessKeyId")]
        [Validation(Required=false)]
        [Obsolete]
        public string AccessKeyId { get; set; }

        [NameInMap("accessKeySecret")]
        [Validation(Required=false)]
        [Obsolete]
        public string AccessKeySecret { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("fromTime")]
        [Validation(Required=false)]
        public long? FromTime { get; set; }

        [NameInMap("lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("logstore")]
        [Validation(Required=false)]
        public string Logstore { get; set; }

        [NameInMap("parameters")]
        [Validation(Required=false)]
        public Dictionary<string, object> Parameters { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("roleArn")]
        [Validation(Required=false)]
        public string RoleArn { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("script")]
        [Validation(Required=false)]
        public string Script { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("sinks")]
        [Validation(Required=false)]
        public List<ETLConfigurationSink> Sinks { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("toTime")]
        [Validation(Required=false)]
        public long? ToTime { get; set; }

    }

}
