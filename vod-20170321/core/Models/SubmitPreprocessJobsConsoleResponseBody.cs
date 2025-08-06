// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class SubmitPreprocessJobsConsoleResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TranscodeJobs")]
        [Validation(Required=false)]
        public SubmitPreprocessJobsConsoleResponseBodyTranscodeJobs TranscodeJobs { get; set; }
        public class SubmitPreprocessJobsConsoleResponseBodyTranscodeJobs : TeaModel {
            [NameInMap("TranscodeJob")]
            [Validation(Required=false)]
            public List<SubmitPreprocessJobsConsoleResponseBodyTranscodeJobsTranscodeJob> TranscodeJob { get; set; }
            public class SubmitPreprocessJobsConsoleResponseBodyTranscodeJobsTranscodeJob : TeaModel {
                [NameInMap("JobId")]
                [Validation(Required=false)]
                public string JobId { get; set; }

            }

        }

    }

}
