// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class ListSmartJobsResponseBody : TeaModel {
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public string MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SmartJobList")]
        [Validation(Required=false)]
        public List<ListSmartJobsResponseBodySmartJobList> SmartJobList { get; set; }
        public class ListSmartJobsResponseBodySmartJobList : TeaModel {
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("EditingConfig")]
            [Validation(Required=false)]
            public string EditingConfig { get; set; }

            [NameInMap("InputConfig")]
            [Validation(Required=false)]
            public ListSmartJobsResponseBodySmartJobListInputConfig InputConfig { get; set; }
            public class ListSmartJobsResponseBodySmartJobListInputConfig : TeaModel {
                [NameInMap("InputFile")]
                [Validation(Required=false)]
                public string InputFile { get; set; }
                [NameInMap("Keyword")]
                [Validation(Required=false)]
                public string Keyword { get; set; }
            };

            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            [NameInMap("JobState")]
            [Validation(Required=false)]
            public string JobState { get; set; }

            [NameInMap("JobType")]
            [Validation(Required=false)]
            public string JobType { get; set; }

            [NameInMap("ModifiedTime")]
            [Validation(Required=false)]
            public string ModifiedTime { get; set; }

            [NameInMap("OutputConfig")]
            [Validation(Required=false)]
            public ListSmartJobsResponseBodySmartJobListOutputConfig OutputConfig { get; set; }
            public class ListSmartJobsResponseBodySmartJobListOutputConfig : TeaModel {
                [NameInMap("Bucket")]
                [Validation(Required=false)]
                public string Bucket { get; set; }
                [NameInMap("Object")]
                [Validation(Required=false)]
                public string Object { get; set; }
            };

            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            [NameInMap("UserData")]
            [Validation(Required=false)]
            public string UserData { get; set; }

            [NameInMap("UserId")]
            [Validation(Required=false)]
            public long? UserId { get; set; }

        }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
