// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class SubmitPreprocessJobsResponseBody : TeaModel {
        [NameInMap("PreprocessJobs")]
        [Validation(Required=false)]
        public SubmitPreprocessJobsResponseBodyPreprocessJobs PreprocessJobs { get; set; }
        public class SubmitPreprocessJobsResponseBodyPreprocessJobs : TeaModel {
            [NameInMap("PreprocessJob")]
            [Validation(Required=false)]
            public List<SubmitPreprocessJobsResponseBodyPreprocessJobsPreprocessJob> PreprocessJob { get; set; }
            public class SubmitPreprocessJobsResponseBodyPreprocessJobsPreprocessJob : TeaModel {
                public string JobId { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
