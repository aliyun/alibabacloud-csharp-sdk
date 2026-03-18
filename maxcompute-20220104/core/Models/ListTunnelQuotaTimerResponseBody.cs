// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class ListTunnelQuotaTimerResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<ListTunnelQuotaTimerResponseBodyData> Data { get; set; }
        public class ListTunnelQuotaTimerResponseBodyData : TeaModel {
            [NameInMap("beginTime")]
            [Validation(Required=false)]
            public string BeginTime { get; set; }

            [NameInMap("endTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            [NameInMap("timezone")]
            [Validation(Required=false)]
            public string Timezone { get; set; }

            [NameInMap("tunnelQuotaParameter")]
            [Validation(Required=false)]
            public ListTunnelQuotaTimerResponseBodyDataTunnelQuotaParameter TunnelQuotaParameter { get; set; }
            public class ListTunnelQuotaTimerResponseBodyDataTunnelQuotaParameter : TeaModel {
                [NameInMap("elasticReservedSlotNum")]
                [Validation(Required=false)]
                public long? ElasticReservedSlotNum { get; set; }

                [NameInMap("slotNum")]
                [Validation(Required=false)]
                public long? SlotNum { get; set; }

            }

        }

        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("errorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        [NameInMap("httpCode")]
        [Validation(Required=false)]
        public int? HttpCode { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
