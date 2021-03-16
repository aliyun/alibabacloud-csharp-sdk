// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class SubmitImageQualityJobResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ImageQualityJob")]
        [Validation(Required=false)]
        public SubmitImageQualityJobResponseBodyImageQualityJob ImageQualityJob { get; set; }
        public class SubmitImageQualityJobResponseBodyImageQualityJob : TeaModel {
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }
            [NameInMap("Result")]
            [Validation(Required=false)]
            public SubmitImageQualityJobResponseBodyImageQualityJobResult Result { get; set; }
            public class SubmitImageQualityJobResponseBodyImageQualityJobResult : TeaModel {
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                [NameInMap("Score")]
                [Validation(Required=false)]
                public string Score { get; set; }

            }
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }
            [NameInMap("UserData")]
            [Validation(Required=false)]
            public string UserData { get; set; }
            [NameInMap("PipelineId")]
            [Validation(Required=false)]
            public string PipelineId { get; set; }
            [NameInMap("Input")]
            [Validation(Required=false)]
            public SubmitImageQualityJobResponseBodyImageQualityJobInput Input { get; set; }
            public class SubmitImageQualityJobResponseBodyImageQualityJobInput : TeaModel {
                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

                [NameInMap("Object")]
                [Validation(Required=false)]
                public string Object { get; set; }

                [NameInMap("Location")]
                [Validation(Required=false)]
                public string Location { get; set; }

                [NameInMap("Bucket")]
                [Validation(Required=false)]
                public string Bucket { get; set; }

            }
        };

    }

}
