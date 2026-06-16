// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RiskManagement20260424.Models
{
    public class GetCanTrySasResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetCanTrySasResponseBodyData Data { get; set; }
        public class GetCanTrySasResponseBodyData : TeaModel {
            [NameInMap("Body")]
            [Validation(Required=false)]
            public GetCanTrySasResponseBodyDataBody Body { get; set; }
            public class GetCanTrySasResponseBodyDataBody : TeaModel {
                [NameInMap("Data")]
                [Validation(Required=false)]
                public GetCanTrySasResponseBodyDataBodyData Data { get; set; }
                public class GetCanTrySasResponseBodyDataBodyData : TeaModel {
                    [NameInMap("CanTry")]
                    [Validation(Required=false)]
                    public int? CanTry { get; set; }

                    [NameInMap("CanTryVersions")]
                    [Validation(Required=false)]
                    public List<int?> CanTryVersions { get; set; }

                    [NameInMap("TryType")]
                    [Validation(Required=false)]
                    public int? TryType { get; set; }

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
