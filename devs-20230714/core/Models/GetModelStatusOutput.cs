// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devs20230714.Models
{
    public class GetModelStatusOutput : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetModelStatusOutputData Data { get; set; }
        public class GetModelStatusOutputData : TeaModel {
            [NameInMap("currentBytes")]
            [Validation(Required=false)]
            public long? CurrentBytes { get; set; }

            [NameInMap("errMessage")]
            [Validation(Required=false)]
            public string ErrMessage { get; set; }

            [NameInMap("fileSize")]
            [Validation(Required=false)]
            public long? FileSize { get; set; }

            [NameInMap("finished")]
            [Validation(Required=false)]
            public bool? Finished { get; set; }

            [NameInMap("finishedTime")]
            [Validation(Required=false)]
            public long? FinishedTime { get; set; }

            [NameInMap("speed")]
            [Validation(Required=false)]
            public long? Speed { get; set; }

            [NameInMap("startTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            [NameInMap("total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        [NameInMap("errCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        [NameInMap("errMsg")]
        [Validation(Required=false)]
        public string ErrMsg { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
