// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RiskManagement20260424.Models
{
    public class GetValidDeductInstancesResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetValidDeductInstancesResponseBodyData Data { get; set; }
        public class GetValidDeductInstancesResponseBodyData : TeaModel {
            [NameInMap("Body")]
            [Validation(Required=false)]
            public GetValidDeductInstancesResponseBodyDataBody Body { get; set; }
            public class GetValidDeductInstancesResponseBodyDataBody : TeaModel {
                [NameInMap("Data")]
                [Validation(Required=false)]
                public GetValidDeductInstancesResponseBodyDataBodyData Data { get; set; }
                public class GetValidDeductInstancesResponseBodyDataBodyData : TeaModel {
                    [NameInMap("CanTry")]
                    [Validation(Required=false)]
                    public bool? CanTry { get; set; }

                    [NameInMap("DeductPackageList")]
                    [Validation(Required=false)]
                    public List<GetValidDeductInstancesResponseBodyDataBodyDataDeductPackageList> DeductPackageList { get; set; }
                    public class GetValidDeductInstancesResponseBodyDataBodyDataDeductPackageList : TeaModel {
                        [NameInMap("CurrentPeriodUsed")]
                        [Validation(Required=false)]
                        public long? CurrentPeriodUsed { get; set; }

                        [NameInMap("EndTime")]
                        [Validation(Required=false)]
                        public long? EndTime { get; set; }

                        [NameInMap("InitCapacity")]
                        [Validation(Required=false)]
                        public double? InitCapacity { get; set; }

                        [NameInMap("InstanceId")]
                        [Validation(Required=false)]
                        public string InstanceId { get; set; }

                        [NameInMap("Module")]
                        [Validation(Required=false)]
                        public string Module { get; set; }

                        [NameInMap("PeriodCapacity")]
                        [Validation(Required=false)]
                        public double? PeriodCapacity { get; set; }

                        [NameInMap("StartTime")]
                        [Validation(Required=false)]
                        public long? StartTime { get; set; }

                        [NameInMap("Status")]
                        [Validation(Required=false)]
                        public string Status { get; set; }

                    }

                }

                [NameInMap("RequestId")]
                [Validation(Required=false)]
                public string RequestId { get; set; }

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
