// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class BatchqueryODPJobsSqlbatchResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public BatchqueryODPJobsSqlbatchResponseBodyData Data { get; set; }
        public class BatchqueryODPJobsSqlbatchResponseBodyData : TeaModel {
            [NameInMap("PageNum")]
            [Validation(Required=false)]
            public long? PageNum { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }
            [NameInMap("Content")]
            [Validation(Required=false)]
            public List<BatchqueryODPJobsSqlbatchResponseBodyDataContent> Content { get; set; }
            public class BatchqueryODPJobsSqlbatchResponseBodyDataContent : TeaModel {
                public string Status { get; set; }
                public string Type { get; set; }
                public List<BatchqueryODPJobsSqlbatchResponseBodyDataContentSqlJobs> SqlJobs { get; set; }
                public class BatchqueryODPJobsSqlbatchResponseBodyDataContentSqlJobs : TeaModel {
                    public string Type { get; set; }
                    public string Status { get; set; }
                    public string CloudInstanceId { get; set; }
                    public string Variables { get; set; }
                    public string GmtModified { get; set; }
                    public string LastStartTime { get; set; }
                    public string GmtCreate { get; set; }
                    public string LastEndTime { get; set; }
                    public string ErrorMsg { get; set; }
                    public string Content { get; set; }
                    public long? SqlBatchJobId { get; set; }
                    public long? Id { get; set; }
                }
                public string SchemaName { get; set; }
                public string InstanceId { get; set; }
                public string GmtModified { get; set; }
                public string ZdalproxyInstanceId { get; set; }
                public string FinishedExecutions { get; set; }
                public string SqlJobMode { get; set; }
                public string Description { get; set; }
                public string GmtCreate { get; set; }
                public string LastStartTime { get; set; }
                public string LastEndTime { get; set; }
                public string ErrorMsg { get; set; }
                public string TotalExecutions { get; set; }
                public string Name { get; set; }
                public string UserName { get; set; }
                public string Content { get; set; }
                public long? Id { get; set; }
            }
        };

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

    }

}
