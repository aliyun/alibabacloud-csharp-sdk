// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class AddLiveAppRecordConfigRequest : TeaModel {
        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        [NameInMap("DomainName")]
        [Validation(Required=true)]
        public string DomainName { get; set; }

        [NameInMap("AppName")]
        [Validation(Required=true)]
        public string AppName { get; set; }

        [NameInMap("OssEndpoint")]
        [Validation(Required=true)]
        public string OssEndpoint { get; set; }

        [NameInMap("OssBucket")]
        [Validation(Required=true)]
        public string OssBucket { get; set; }

        [NameInMap("RecordFormat")]
        [Validation(Required=true)]
        public List<AddLiveAppRecordConfigRequestRecordFormat> RecordFormat { get; set; }
        public class AddLiveAppRecordConfigRequestRecordFormat : TeaModel {
            [NameInMap("Format")]
            [Validation(Required=false)]
            public string Format { get; set; }

            [NameInMap("OssObjectPrefix")]
            [Validation(Required=false)]
            public string OssObjectPrefix { get; set; }

            [NameInMap("SliceOssObjectPrefix")]
            [Validation(Required=false)]
            public string SliceOssObjectPrefix { get; set; }

            [NameInMap("CycleDuration")]
            [Validation(Required=false)]
            public int? CycleDuration { get; set; }

        }

        [NameInMap("StreamName")]
        [Validation(Required=false)]
        public string StreamName { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("OnDemand")]
        [Validation(Required=false)]
        public int? OnDemand { get; set; }

    }

}
