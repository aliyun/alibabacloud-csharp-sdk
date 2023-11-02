// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class ListDisposeStrategyResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListDisposeStrategyResponseBodyData Data { get; set; }
        public class ListDisposeStrategyResponseBodyData : TeaModel {
            [NameInMap("PageInfo")]
            [Validation(Required=false)]
            public ListDisposeStrategyResponseBodyDataPageInfo PageInfo { get; set; }
            public class ListDisposeStrategyResponseBodyDataPageInfo : TeaModel {
                [NameInMap("CurrentPage")]
                [Validation(Required=false)]
                public int? CurrentPage { get; set; }

                [NameInMap("PageSize")]
                [Validation(Required=false)]
                public int? PageSize { get; set; }

                [NameInMap("TotalCount")]
                [Validation(Required=false)]
                public long? TotalCount { get; set; }

            }

            [NameInMap("ResponseData")]
            [Validation(Required=false)]
            public List<ListDisposeStrategyResponseBodyDataResponseData> ResponseData { get; set; }
            public class ListDisposeStrategyResponseBodyDataResponseData : TeaModel {
                [NameInMap("AlertUuid")]
                [Validation(Required=false)]
                public string AlertUuid { get; set; }

                [NameInMap("Aliuid")]
                [Validation(Required=false)]
                public long? Aliuid { get; set; }

                [NameInMap("EffectiveStatus")]
                [Validation(Required=false)]
                public int? EffectiveStatus { get; set; }

                [NameInMap("Entity")]
                [Validation(Required=false)]
                public List<object> Entity { get; set; }

                [NameInMap("EntityId")]
                [Validation(Required=false)]
                public long? EntityId { get; set; }

                [NameInMap("EntityType")]
                [Validation(Required=false)]
                public string EntityType { get; set; }

                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

                [NameInMap("FinishTime")]
                [Validation(Required=false)]
                public string FinishTime { get; set; }

                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("IncidentName")]
                [Validation(Required=false)]
                public string IncidentName { get; set; }

                [NameInMap("IncidentUuid")]
                [Validation(Required=false)]
                public string IncidentUuid { get; set; }

                [NameInMap("PlaybookName")]
                [Validation(Required=false)]
                public string PlaybookName { get; set; }

                [NameInMap("PlaybookType")]
                [Validation(Required=false)]
                public string PlaybookType { get; set; }

                [NameInMap("PlaybookUuid")]
                [Validation(Required=false)]
                public string PlaybookUuid { get; set; }

                [NameInMap("Scope")]
                [Validation(Required=false)]
                public List<object> Scope { get; set; }

                [NameInMap("SophonTaskId")]
                [Validation(Required=false)]
                public string SophonTaskId { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                [NameInMap("SubAliuid")]
                [Validation(Required=false)]
                public long? SubAliuid { get; set; }

                [NameInMap("TaskParam")]
                [Validation(Required=false)]
                public string TaskParam { get; set; }

            }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
