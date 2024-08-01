// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class Personalizedtxt2imgAddInferenceJobResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public Personalizedtxt2imgAddInferenceJobResponseBodyData Data { get; set; }
        public class Personalizedtxt2imgAddInferenceJobResponseBodyData : TeaModel {
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("jobStatus")]
            [Validation(Required=false)]
            public string JobStatus { get; set; }

            [NameInMap("jobTrainProgress")]
            [Validation(Required=false)]
            public double? JobTrainProgress { get; set; }

            [NameInMap("modelId")]
            [Validation(Required=false)]
            public string ModelId { get; set; }

            [NameInMap("promptId")]
            [Validation(Required=false)]
            public string PromptId { get; set; }

            [NameInMap("resultImageUrl")]
            [Validation(Required=false)]
            public List<string> ResultImageUrl { get; set; }

        }

        [NameInMap("errCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        [NameInMap("errMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
