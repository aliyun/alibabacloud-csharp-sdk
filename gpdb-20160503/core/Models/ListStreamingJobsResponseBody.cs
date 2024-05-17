// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class ListStreamingJobsResponseBody : TeaModel {
        [NameInMap("JobItems")]
        [Validation(Required=false)]
        public List<ListStreamingJobsResponseBodyJobItems> JobItems { get; set; }
        public class ListStreamingJobsResponseBodyJobItems : TeaModel {
            [NameInMap("Account")]
            [Validation(Required=false)]
            public string Account { get; set; }

            [NameInMap("Consistency")]
            [Validation(Required=false)]
            public string Consistency { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("DataSourceId")]
            [Validation(Required=false)]
            public string DataSourceId { get; set; }

            [NameInMap("DataSourceName")]
            [Validation(Required=false)]
            public string DataSourceName { get; set; }

            [NameInMap("DestColumns")]
            [Validation(Required=false)]
            public List<string> DestColumns { get; set; }

            [NameInMap("DestDatabase")]
            [Validation(Required=false)]
            public string DestDatabase { get; set; }

            [NameInMap("DestSchema")]
            [Validation(Required=false)]
            public string DestSchema { get; set; }

            [NameInMap("DestTable")]
            [Validation(Required=false)]
            public string DestTable { get; set; }

            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            [NameInMap("FallbackOffset")]
            [Validation(Required=false)]
            public string FallbackOffset { get; set; }

            [NameInMap("JobDescription")]
            [Validation(Required=false)]
            public string JobDescription { get; set; }

            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            [NameInMap("JobName")]
            [Validation(Required=false)]
            public string JobName { get; set; }

            [NameInMap("MatchColumns")]
            [Validation(Required=false)]
            public List<string> MatchColumns { get; set; }

            [NameInMap("Mode")]
            [Validation(Required=false)]
            public string Mode { get; set; }

            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

            [NameInMap("Password")]
            [Validation(Required=false)]
            public string Password { get; set; }

            [NameInMap("SrcColumns")]
            [Validation(Required=false)]
            public List<string> SrcColumns { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("UpdateColumns")]
            [Validation(Required=false)]
            public List<string> UpdateColumns { get; set; }

            [NameInMap("WriteMode")]
            [Validation(Required=false)]
            public string WriteMode { get; set; }

        }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
