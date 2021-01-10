// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryODPJobsSqlbatchResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryODPJobsSqlbatchResponseBodyData Data { get; set; }
        public class QueryODPJobsSqlbatchResponseBodyData : TeaModel {
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }
            [NameInMap("ErrorMsg")]
            [Validation(Required=false)]
            public string ErrorMsg { get; set; }
            [NameInMap("FinishedExecutions")]
            [Validation(Required=false)]
            public string FinishedExecutions { get; set; }
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }
            [NameInMap("LastEndTime")]
            [Validation(Required=false)]
            public string LastEndTime { get; set; }
            [NameInMap("LastStartTime")]
            [Validation(Required=false)]
            public string LastStartTime { get; set; }
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("SchemaName")]
            [Validation(Required=false)]
            public string SchemaName { get; set; }
            [NameInMap("SqlJobMode")]
            [Validation(Required=false)]
            public string SqlJobMode { get; set; }
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }
            [NameInMap("TotalExecutions")]
            [Validation(Required=false)]
            public string TotalExecutions { get; set; }
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }
            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }
            [NameInMap("ZdalproxyInstanceId")]
            [Validation(Required=false)]
            public string ZdalproxyInstanceId { get; set; }
            [NameInMap("SqlJobs")]
            [Validation(Required=false)]
            public List<QueryODPJobsSqlbatchResponseBodyDataSqlJobs> SqlJobs { get; set; }
            public class QueryODPJobsSqlbatchResponseBodyDataSqlJobs : TeaModel {
                public string CloudInstanceId { get; set; }
                public string Content { get; set; }
                public string ErrorMsg { get; set; }
                public string GmtCreate { get; set; }
                public string GmtModified { get; set; }
                public long? Id { get; set; }
                public string LastEndTime { get; set; }
                public string LastStartTime { get; set; }
                public long? SqlBatchJobId { get; set; }
                public string Status { get; set; }
                public string Type { get; set; }
                public string Variables { get; set; }
            }
        };

    }

}
