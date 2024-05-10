// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class OSSExportConfiguration : TeaModel {
        [NameInMap("fromTime")]
        [Validation(Required=false)]
        public long? FromTime { get; set; }

        [NameInMap("logstore")]
        [Validation(Required=false)]
        public string Logstore { get; set; }

        [NameInMap("roleArn")]
        [Validation(Required=false)]
        public string RoleArn { get; set; }

        [NameInMap("sink")]
        [Validation(Required=false)]
        public OSSExportConfigurationSink Sink { get; set; }
        public class OSSExportConfigurationSink : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("bucket")]
            [Validation(Required=false)]
            public string Bucket { get; set; }

            [NameInMap("bufferInterval")]
            [Validation(Required=false)]
            public long? BufferInterval { get; set; }

            [NameInMap("bufferSize")]
            [Validation(Required=false)]
            public long? BufferSize { get; set; }

            [NameInMap("compressionType")]
            [Validation(Required=false)]
            public string CompressionType { get; set; }

            [NameInMap("contentDetail")]
            [Validation(Required=false)]
            public Dictionary<string, object> ContentDetail { get; set; }

            [NameInMap("contentType")]
            [Validation(Required=false)]
            public string ContentType { get; set; }

            [NameInMap("delaySec")]
            [Validation(Required=false)]
            [Obsolete]
            public long? DelaySec { get; set; }

            [NameInMap("delaySeconds")]
            [Validation(Required=false)]
            public long? DelaySeconds { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("endpoint")]
            [Validation(Required=false)]
            public string Endpoint { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("pathFormat")]
            [Validation(Required=false)]
            public string PathFormat { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("pathFormatType")]
            [Validation(Required=false)]
            public string PathFormatType { get; set; }

            [NameInMap("prefix")]
            [Validation(Required=false)]
            public string Prefix { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("roleArn")]
            [Validation(Required=false)]
            public string RoleArn { get; set; }

            [NameInMap("suffix")]
            [Validation(Required=false)]
            public string Suffix { get; set; }

            [NameInMap("timeZone")]
            [Validation(Required=false)]
            public string TimeZone { get; set; }

        }

        [NameInMap("toTime")]
        [Validation(Required=false)]
        public long? ToTime { get; set; }

    }

}
