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
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                [NameInMap("RouteRules")]
                [Validation(Required=false)]
                public List<ListApplicationsWithTagRulesResponseBodyDataResultRouteRules> RouteRules { get; set; }
                public class ListApplicationsWithTagRulesResponseBodyDataResultRouteRules : TeaModel {
                    [NameInMap("CarryData")]
                    [Validation(Required=false)]
                    public bool? CarryData { get; set; }

                    [NameInMap("Enable")]
                    [Validation(Required=false)]
                    public bool? Enable { get; set; }

                    [NameInMap("GmtModified")]
                    [Validation(Required=false)]
                    public string GmtModified { get; set; }

                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    [NameInMap("InstanceNum")]
                    [Validation(Required=false)]
                    public int? InstanceNum { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("Rate")]
                    [Validation(Required=false)]
                    public int? Rate { get; set; }

                    [NameInMap("Remove")]
                    [Validation(Required=false)]
                    public bool? Remove { get; set; }

                    [NameInMap("Rules")]
                    [Validation(Required=false)]
                    public string Rules { get; set; }

                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public int? Status { get; set; }

                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public string Tag { get; set; }

                }

                [NameInMap("RouteStatus")]
                [Validation(Required=false)]
                public long? RouteStatus { get; set; }

            }

            [NameInMap("TotalSize")]
            [Validation(Required=false)]
            public int? TotalSize { get; set; }

        }

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
