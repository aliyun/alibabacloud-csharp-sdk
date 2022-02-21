// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class ListApplicationsWithTagRulesResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListApplicationsWithTagRulesResponseBodyData Data { get; set; }
        public class ListApplicationsWithTagRulesResponseBodyData : TeaModel {
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("Result")]
            [Validation(Required=false)]
            public List<ListApplicationsWithTagRulesResponseBodyDataResult> Result { get; set; }
            public class ListApplicationsWithTagRulesResponseBodyDataResult : TeaModel {
                public string AppId { get; set; }
                public string AppName { get; set; }
                public List<ListApplicationsWithTagRulesResponseBodyDataResultRouteRules> RouteRules { get; set; }
                public class ListApplicationsWithTagRulesResponseBodyDataResultRouteRules : TeaModel {
                    public bool? CarryData { get; set; }
                    public bool? Enable { get; set; }
                    public long? GmtModified { get; set; }
                    public long? Id { get; set; }
                    public int? InstanceNum { get; set; }
                    public string Name { get; set; }
                    public int? Rate { get; set; }
                    public bool? Remove { get; set; }
                    public string Rules { get; set; }
                    public int? Status { get; set; }
                    public string Tag { get; set; }
                }
                public long? RouteStatus { get; set; }
            }
            [NameInMap("TotalSize")]
            [Validation(Required=false)]
            public int? TotalSize { get; set; }
        };

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

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
