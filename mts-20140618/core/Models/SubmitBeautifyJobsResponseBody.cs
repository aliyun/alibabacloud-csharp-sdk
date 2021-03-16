// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class SubmitBeautifyJobsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("JobList")]
        [Validation(Required=false)]
        public SubmitBeautifyJobsResponseBodyJobList JobList { get; set; }
        public class SubmitBeautifyJobsResponseBodyJobList : TeaModel {
            [NameInMap("Job")]
            [Validation(Required=false)]
            public List<SubmitBeautifyJobsResponseBodyJobListJob> Job { get; set; }
            public class SubmitBeautifyJobsResponseBodyJobListJob : TeaModel {
                public string CreationTime { get; set; }
                public SubmitBeautifyJobsResponseBodyJobListJobBeautifyConfig BeautifyConfig { get; set; }
                public class SubmitBeautifyJobsResponseBodyJobListJobBeautifyConfig : TeaModel {
                    [NameInMap("OutputFile")]
                    [Validation(Required=false)]
                    public SubmitBeautifyJobsResponseBodyJobListJobBeautifyConfigOutputFile OutputFile { get; set; }
                    public class SubmitBeautifyJobsResponseBodyJobListJobBeautifyConfigOutputFile : TeaModel {
                        [NameInMap("RoleArn")]
                        [Validation(Required=false)]
                        public string RoleArn { get; set; }
                        [NameInMap("Object")]
                        [Validation(Required=false)]
                        public string Object { get; set; }
                        [NameInMap("Location")]
                        [Validation(Required=false)]
                        public string Location { get; set; }
                        [NameInMap("Bucket")]
                        [Validation(Required=false)]
                        public string Bucket { get; set; }
                    };

                }
                public string State { get; set; }
                public string UserData { get; set; }
                public string Code { get; set; }
                public string Message { get; set; }
                public string PipelineId { get; set; }
                public SubmitBeautifyJobsResponseBodyJobListJobInput Input { get; set; }
                public class SubmitBeautifyJobsResponseBodyJobListJobInput : TeaModel {
                    [NameInMap("RoleArn")]
                    [Validation(Required=false)]
                    public string RoleArn { get; set; }

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
                public SubmitBeautifyJobsResponseBodyJobListJobMNSMessageResult MNSMessageResult { get; set; }
                public class SubmitBeautifyJobsResponseBodyJobListJobMNSMessageResult : TeaModel {
                    [NameInMap("MessageId")]
                    [Validation(Required=false)]
                    public string MessageId { get; set; }

                    [NameInMap("ErrorMessage")]
                    [Validation(Required=false)]
                    public string ErrorMessage { get; set; }

                    [NameInMap("ErrorCode")]
                    [Validation(Required=false)]
                    public string ErrorCode { get; set; }

                }
                public string Id { get; set; }
            }
        };

    }

}
