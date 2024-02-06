// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class OSSIngestionConfigurationSource : TeaModel {
        [NameInMap("bucket")]
        [Validation(Required=false)]
        public string Bucket { get; set; }

        [NameInMap("compressionCodec")]
        [Validation(Required=false)]
        public string CompressionCodec { get; set; }

        [NameInMap("encoding")]
        [Validation(Required=false)]
        public string Encoding { get; set; }

        [NameInMap("endTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        [NameInMap("endpoint")]
        [Validation(Required=false)]
        public string Endpoint { get; set; }

        [NameInMap("format")]
        [Validation(Required=false)]
        public Dictionary<string, object> Format { get; set; }

        [NameInMap("interval")]
        [Validation(Required=false)]
        public string Interval { get; set; }

        [NameInMap("pattern")]
        [Validation(Required=false)]
        public string Pattern { get; set; }

        [NameInMap("prefix")]
        [Validation(Required=false)]
        public string Prefix { get; set; }

        [NameInMap("restoreObjectEnabled")]
        [Validation(Required=false)]
        public bool? RestoreObjectEnabled { get; set; }

        [NameInMap("roleARN")]
        [Validation(Required=false)]
        public string RoleARN { get; set; }

        [NameInMap("startTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        [NameInMap("timeField")]
        [Validation(Required=false)]
        public string TimeField { get; set; }

        [NameInMap("timeFormat")]
        [Validation(Required=false)]
        public string TimeFormat { get; set; }

        [NameInMap("timePattern")]
        [Validation(Required=false)]
        public string TimePattern { get; set; }

        [NameInMap("timeZone")]
        [Validation(Required=false)]
        public string TimeZone { get; set; }

        [NameInMap("useMetaIndex")]
        [Validation(Required=false)]
        public bool? UseMetaIndex { get; set; }

    }

}
