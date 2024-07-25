// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class ListDynamicImageJobsResponseBody : TeaModel {
        [NameInMap("Jobs")]
        [Validation(Required=false)]
        public List<ListDynamicImageJobsResponseBodyJobs> Jobs { get; set; }
        public class ListDynamicImageJobsResponseBodyJobs : TeaModel {
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("FinishTime")]
            [Validation(Required=false)]
            public string FinishTime { get; set; }

            [NameInMap("Input")]
            [Validation(Required=false)]
            public ListDynamicImageJobsResponseBodyJobsInput Input { get; set; }
            public class ListDynamicImageJobsResponseBodyJobsInput : TeaModel {
                [NameInMap("Media")]
                [Validation(Required=false)]
                public string Media { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            [NameInMap("ModifiedTime")]
            [Validation(Required=false)]
            public string ModifiedTime { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Output")]
            [Validation(Required=false)]
            public ListDynamicImageJobsResponseBodyJobsOutput Output { get; set; }
            public class ListDynamicImageJobsResponseBodyJobsOutput : TeaModel {
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

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("SubmitTime")]
            [Validation(Required=false)]
            public string SubmitTime { get; set; }

            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

            [NameInMap("TriggerSource")]
            [Validation(Required=false)]
            public string TriggerSource { get; set; }

        }

        [NameInMap("NextPageToken")]
        [Validation(Required=false)]
        public string NextPageToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
