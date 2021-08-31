// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class ListRepoTriggerRecordResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("IsSuccess")]
        [Validation(Required=false)]
        public bool? IsSuccess { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("RepoTriggerRecords")]
        [Validation(Required=false)]
        public List<ListRepoTriggerRecordResponseBodyRepoTriggerRecords> RepoTriggerRecords { get; set; }
        public class ListRepoTriggerRecordResponseBodyRepoTriggerRecords : TeaModel {
            [NameInMap("RequestHeaders")]
            [Validation(Required=false)]
            public string RequestHeaders { get; set; }

            [NameInMap("TriggerName")]
            [Validation(Required=false)]
            public string TriggerName { get; set; }

            [NameInMap("ResponseHeaders")]
            [Validation(Required=false)]
            public string ResponseHeaders { get; set; }

            [NameInMap("TriggerLogId")]
            [Validation(Required=false)]
            public string TriggerLogId { get; set; }

            [NameInMap("ResponseBody")]
            [Validation(Required=false)]
            public string ResponseBody { get; set; }

            [NameInMap("TriggerUrl")]
            [Validation(Required=false)]
            public string TriggerUrl { get; set; }

            [NameInMap("RequestBody")]
            [Validation(Required=false)]
            public string RequestBody { get; set; }

            [NameInMap("TriggerType")]
            [Validation(Required=false)]
            public string TriggerType { get; set; }

            [NameInMap("TriggerTag")]
            [Validation(Required=false)]
            public string TriggerTag { get; set; }

            [NameInMap("StatusCode")]
            [Validation(Required=false)]
            public string StatusCode { get; set; }

            [NameInMap("RepoEvent")]
            [Validation(Required=false)]
            public string RepoEvent { get; set; }

            [NameInMap("TriggerId")]
            [Validation(Required=false)]
            public string TriggerId { get; set; }

            [NameInMap("RequestTime")]
            [Validation(Required=false)]
            public long? RequestTime { get; set; }

        }

    }

}
