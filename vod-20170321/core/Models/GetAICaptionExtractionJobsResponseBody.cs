// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetAICaptionExtractionJobsResponseBody : TeaModel {
        [NameInMap("AICaptionExtractionJobList")]
        [Validation(Required=false)]
        public List<GetAICaptionExtractionJobsResponseBodyAICaptionExtractionJobList> AICaptionExtractionJobList { get; set; }
        public class GetAICaptionExtractionJobsResponseBodyAICaptionExtractionJobList : TeaModel {
            [NameInMap("AICaptionExtractionResult")]
            [Validation(Required=false)]
            public string AICaptionExtractionResult { get; set; }

            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("TemplateConfig")]
            [Validation(Required=false)]
            public string TemplateConfig { get; set; }

            [NameInMap("UserData")]
            [Validation(Required=false)]
            public string UserData { get; set; }

            [NameInMap("VideoId")]
            [Validation(Required=false)]
            public string VideoId { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
