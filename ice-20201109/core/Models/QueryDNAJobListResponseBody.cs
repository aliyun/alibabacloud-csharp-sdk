// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class QueryDNAJobListResponseBody : TeaModel {
        [NameInMap("JobList")]
        [Validation(Required=false)]
        public List<QueryDNAJobListResponseBodyJobList> JobList { get; set; }
        public class QueryDNAJobListResponseBodyJobList : TeaModel {
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            [NameInMap("Config")]
            [Validation(Required=false)]
            public string Config { get; set; }

            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            [NameInMap("DBId")]
            [Validation(Required=false)]
            public string DBId { get; set; }

            [NameInMap("DNAResult")]
            [Validation(Required=false)]
            public string DNAResult { get; set; }

            [NameInMap("FinishTime")]
            [Validation(Required=false)]
            public string FinishTime { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("Input")]
            [Validation(Required=false)]
            public QueryDNAJobListResponseBodyJobListInput Input { get; set; }
            public class QueryDNAJobListResponseBodyJobListInput : TeaModel {
                [NameInMap("Media")]
                [Validation(Required=false)]
                public string Media { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            [NameInMap("PrimaryKey")]
            [Validation(Required=false)]
            public string PrimaryKey { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("UserData")]
            [Validation(Required=false)]
            public string UserData { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
