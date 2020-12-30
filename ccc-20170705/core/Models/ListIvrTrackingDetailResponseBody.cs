// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20170705.Models
{
    public class ListIvrTrackingDetailResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("IvrTrackingDetails")]
        [Validation(Required=false)]
        public ListIvrTrackingDetailResponseBodyIvrTrackingDetails IvrTrackingDetails { get; set; }
        public class ListIvrTrackingDetailResponseBodyIvrTrackingDetails : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public ListIvrTrackingDetailResponseBodyIvrTrackingDetailsList List { get; set; }
            public class ListIvrTrackingDetailResponseBodyIvrTrackingDetailsList : TeaModel {
                [NameInMap("IvrTrackingDetail")]
                [Validation(Required=false)]
                public List<ListIvrTrackingDetailResponseBodyIvrTrackingDetailsListIvrTrackingDetail> IvrTrackingDetail { get; set; }
                public class ListIvrTrackingDetailResponseBodyIvrTrackingDetailsListIvrTrackingDetail : TeaModel {
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    [NameInMap("DeviceID")]
                    [Validation(Required=false)]
                    public string DeviceID { get; set; }

                    [NameInMap("InputData")]
                    [Validation(Required=false)]
                    public string InputData { get; set; }

                    [NameInMap("FlowName")]
                    [Validation(Required=false)]
                    public string FlowName { get; set; }

                    [NameInMap("StopTime")]
                    [Validation(Required=false)]
                    public long? StopTime { get; set; }

                    [NameInMap("CalledNumber")]
                    [Validation(Required=false)]
                    public string CalledNumber { get; set; }

                    [NameInMap("StartTime")]
                    [Validation(Required=false)]
                    public long? StartTime { get; set; }

                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    [NameInMap("NodeType")]
                    [Validation(Required=false)]
                    public string NodeType { get; set; }

                    [NameInMap("ContactId")]
                    [Validation(Required=false)]
                    public string ContactId { get; set; }

                    [NameInMap("NodeName")]
                    [Validation(Required=false)]
                    public string NodeName { get; set; }

                    [NameInMap("CallingNumber")]
                    [Validation(Required=false)]
                    public string CallingNumber { get; set; }

                    [NameInMap("OutputData")]
                    [Validation(Required=false)]
                    public string OutputData { get; set; }

                    [NameInMap("TenantId")]
                    [Validation(Required=false)]
                    public string TenantId { get; set; }

                }

            }
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
