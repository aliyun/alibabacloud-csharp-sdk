// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageaudit20191230.Models
{
    public class ScanImageAdvanceRequest : TeaModel {
        [NameInMap("Scene")]
        [Validation(Required=false)]
        public List<string> Scene { get; set; }

        [NameInMap("Task")]
        [Validation(Required=false)]
        public List<ScanImageAdvanceRequestTask> Task { get; set; }
        public class ScanImageAdvanceRequestTask : TeaModel {
            [NameInMap("DataId")]
            [Validation(Required=false)]
            public string DataId { get; set; }

            [NameInMap("ImageTimeMillisecond")]
            [Validation(Required=false)]
            public long? ImageTimeMillisecond { get; set; }

            [NameInMap("ImageURL")]
            [Validation(Required=false)]
            public Stream ImageURLObject { get; set; }

            [NameInMap("Interval")]
            [Validation(Required=false)]
            public int? Interval { get; set; }

            [NameInMap("MaxFrames")]
            [Validation(Required=false)]
            public int? MaxFrames { get; set; }

        }

    }

}
