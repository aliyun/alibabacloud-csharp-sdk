// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetPagedInstanceResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetPagedInstanceResponseBodyData Data { get; set; }
        public class GetPagedInstanceResponseBodyData : TeaModel {
            [NameInMap("Instance")]
            [Validation(Required=false)]
            public List<GetPagedInstanceResponseBodyDataInstance> Instance { get; set; }
            public class GetPagedInstanceResponseBodyDataInstance : TeaModel {
                [NameInMap("BusinessTime")]
                [Validation(Required=false)]
                public string BusinessTime { get; set; }

                [NameInMap("CheckStatus")]
                [Validation(Required=false)]
                public long? CheckStatus { get; set; }

                [NameInMap("DagId")]
                [Validation(Required=false)]
                public long? DagId { get; set; }

                [NameInMap("Delete")]
                [Validation(Required=false)]
                public string Delete { get; set; }

                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                [NameInMap("HistoryDagId")]
                [Validation(Required=false)]
                public long? HistoryDagId { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("LastRunningContext")]
                [Validation(Required=false)]
                public string LastRunningContext { get; set; }

                [NameInMap("Msg")]
                [Validation(Required=false)]
                public string Msg { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public long? Status { get; set; }

                [NameInMap("TaskType")]
                [Validation(Required=false)]
                public long? TaskType { get; set; }

                [NameInMap("TenantId")]
                [Validation(Required=false)]
                public string TenantId { get; set; }

                [NameInMap("TriggerType")]
                [Validation(Required=false)]
                public long? TriggerType { get; set; }

                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

        }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("PageIndex")]
        [Validation(Required=false)]
        public long? PageIndex { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
