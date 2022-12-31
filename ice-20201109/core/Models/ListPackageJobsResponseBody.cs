// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class ListPackageJobsResponseBody : TeaModel {
        [NameInMap("PackageJobList")]
        [Validation(Required=false)]
        public ListPackageJobsResponseBodyPackageJobList PackageJobList { get; set; }
        public class ListPackageJobsResponseBodyPackageJobList : TeaModel {
            [NameInMap("NextPageToken")]
            [Validation(Required=false)]
            public string NextPageToken { get; set; }

            [NameInMap("PackageJobs")]
            [Validation(Required=false)]
            public List<ListPackageJobsResponseBodyPackageJobListPackageJobs> PackageJobs { get; set; }
            public class ListPackageJobsResponseBodyPackageJobListPackageJobs : TeaModel {
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("FinishTime")]
                [Validation(Required=false)]
                public string FinishTime { get; set; }

                [NameInMap("Inputs")]
                [Validation(Required=false)]
                public List<ListPackageJobsResponseBodyPackageJobListPackageJobsInputs> Inputs { get; set; }
                public class ListPackageJobsResponseBodyPackageJobListPackageJobsInputs : TeaModel {
                    [NameInMap("Input")]
                    [Validation(Required=false)]
                    public ListPackageJobsResponseBodyPackageJobListPackageJobsInputsInput Input { get; set; }
                    public class ListPackageJobsResponseBodyPackageJobListPackageJobsInputsInput : TeaModel {
                        [NameInMap("Media")]
                        [Validation(Required=false)]
                        public string Media { get; set; }

                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                    }

                }

                [NameInMap("JobId")]
                [Validation(Required=false)]
                public string JobId { get; set; }

                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                [NameInMap("ModifiedTime")]
                [Validation(Required=false)]
                public string ModifiedTime { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Output")]
                [Validation(Required=false)]
                public ListPackageJobsResponseBodyPackageJobListPackageJobsOutput Output { get; set; }
                public class ListPackageJobsResponseBodyPackageJobListPackageJobsOutput : TeaModel {
                    [NameInMap("Media")]
                    [Validation(Required=false)]
                    public string Media { get; set; }

                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                [NameInMap("PipelineId")]
                [Validation(Required=false)]
                public string PipelineId { get; set; }

                [NameInMap("Priority")]
                [Validation(Required=false)]
                public int? Priority { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("SubmitTime")]
                [Validation(Required=false)]
                public string SubmitTime { get; set; }

                [NameInMap("TriggerSource")]
                [Validation(Required=false)]
                public string TriggerSource { get; set; }

                [NameInMap("UserData")]
                [Validation(Required=false)]
                public string UserData { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
