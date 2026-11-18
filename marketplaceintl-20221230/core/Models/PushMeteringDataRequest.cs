// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MarketplaceIntl20221230.Models
{
    public class PushMeteringDataRequest : TeaModel {
        [NameInMap("GmtCreate")]
        [Validation(Required=false)]
        public string GmtCreate { get; set; }

        [NameInMap("Metering")]
        [Validation(Required=false)]
        public string Metering { get; set; }

        [NameInMap("MeteringData")]
        [Validation(Required=false)]
        public List<PushMeteringDataRequestMeteringData> MeteringData { get; set; }
        public class PushMeteringDataRequestMeteringData : TeaModel {
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("MeteringAssist")]
            [Validation(Required=false)]
            public string MeteringAssist { get; set; }

            [NameInMap("MeteringEntity")]
            [Validation(Required=false)]
            public string MeteringEntity { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ORDER20231001</para>
            /// </summary>
            [NameInMap("PushOrderBizId")]
            [Validation(Required=false)]
            public string PushOrderBizId { get; set; }

            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

        }

    }

}
