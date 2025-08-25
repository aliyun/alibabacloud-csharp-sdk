// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MPaaS20200710.Models
{
    public class QueryMpsSchedulerListResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultContent")]
        [Validation(Required=false)]
        public QueryMpsSchedulerListResponseBodyResultContent ResultContent { get; set; }
        public class QueryMpsSchedulerListResponseBodyResultContent : TeaModel {
            [NameInMap("Data")]
            [Validation(Required=false)]
            public QueryMpsSchedulerListResponseBodyResultContentData Data { get; set; }
            public class QueryMpsSchedulerListResponseBodyResultContentData : TeaModel {
                [NameInMap("List")]
                [Validation(Required=false)]
                public List<QueryMpsSchedulerListResponseBodyResultContentDataList> List { get; set; }
                public class QueryMpsSchedulerListResponseBodyResultContentDataList : TeaModel {
                    [NameInMap("CreateType")]
                    [Validation(Required=false)]
                    public int? CreateType { get; set; }

                    [NameInMap("DeliveryType")]
                    [Validation(Required=false)]
                    public int? DeliveryType { get; set; }

                    [NameInMap("ExecutedStatus")]
                    [Validation(Required=false)]
                    public string ExecutedStatus { get; set; }

                    [NameInMap("GmtCreate")]
                    [Validation(Required=false)]
                    public long? GmtCreate { get; set; }

                    [NameInMap("ParentId")]
                    [Validation(Required=false)]
                    public string ParentId { get; set; }

                    [NameInMap("PushContent")]
                    [Validation(Required=false)]
                    public string PushContent { get; set; }

                    [NameInMap("PushTime")]
                    [Validation(Required=false)]
                    public long? PushTime { get; set; }

                    [NameInMap("PushTitle")]
                    [Validation(Required=false)]
                    public string PushTitle { get; set; }

                    [NameInMap("StrategyType")]
                    [Validation(Required=false)]
                    public int? StrategyType { get; set; }

                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public int? Type { get; set; }

                    [NameInMap("UniqueId")]
                    [Validation(Required=false)]
                    public string UniqueId { get; set; }

                }

                [NameInMap("TotalCount")]
                [Validation(Required=false)]
                public int? TotalCount { get; set; }

            }

        }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

    }

}
