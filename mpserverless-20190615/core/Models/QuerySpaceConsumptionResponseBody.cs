// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MPServerless20190615.Models
{
    public class QuerySpaceConsumptionResponseBody : TeaModel {
        [NameInMap("CsUsage")]
        [Validation(Required=false)]
        public QuerySpaceConsumptionResponseBodyCsUsage CsUsage { get; set; }
        public class QuerySpaceConsumptionResponseBodyCsUsage : TeaModel {
            [NameInMap("CdnTraffic")]
            [Validation(Required=false)]
            public long? CdnTraffic { get; set; }

            [NameInMap("DownloadCount")]
            [Validation(Required=false)]
            public long? DownloadCount { get; set; }

            [NameInMap("StorageSize")]
            [Validation(Required=false)]
            public long? StorageSize { get; set; }

            [NameInMap("UploadCount")]
            [Validation(Required=false)]
            public long? UploadCount { get; set; }

        }

        [NameInMap("CycleEndTime")]
        [Validation(Required=false)]
        public long? CycleEndTime { get; set; }

        [NameInMap("CycleStartTime")]
        [Validation(Required=false)]
        public long? CycleStartTime { get; set; }

        [NameInMap("DbUsage")]
        [Validation(Required=false)]
        public QuerySpaceConsumptionResponseBodyDbUsage DbUsage { get; set; }
        public class QuerySpaceConsumptionResponseBodyDbUsage : TeaModel {
            [NameInMap("ReadCount")]
            [Validation(Required=false)]
            public long? ReadCount { get; set; }

            [NameInMap("StorageSize")]
            [Validation(Required=false)]
            public long? StorageSize { get; set; }

            [NameInMap("WriteCount")]
            [Validation(Required=false)]
            public long? WriteCount { get; set; }

        }

        [NameInMap("FcUsage")]
        [Validation(Required=false)]
        public QuerySpaceConsumptionResponseBodyFcUsage FcUsage { get; set; }
        public class QuerySpaceConsumptionResponseBodyFcUsage : TeaModel {
            [NameInMap("Cost")]
            [Validation(Required=false)]
            public long? Cost { get; set; }

            [NameInMap("RequestCount")]
            [Validation(Required=false)]
            public long? RequestCount { get; set; }

            [NameInMap("TxTraffic")]
            [Validation(Required=false)]
            public long? TxTraffic { get; set; }

        }

        [NameInMap("GmtCreate")]
        [Validation(Required=false)]
        public string GmtCreate { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SpaceId")]
        [Validation(Required=false)]
        public string SpaceId { get; set; }

        [NameInMap("SpecCode")]
        [Validation(Required=false)]
        public string SpecCode { get; set; }

        [NameInMap("WhUsage")]
        [Validation(Required=false)]
        public QuerySpaceConsumptionResponseBodyWhUsage WhUsage { get; set; }
        public class QuerySpaceConsumptionResponseBodyWhUsage : TeaModel {
            [NameInMap("CdnTraffic")]
            [Validation(Required=false)]
            public long? CdnTraffic { get; set; }

            [NameInMap("StorageSize")]
            [Validation(Required=false)]
            public long? StorageSize { get; set; }

        }

    }

}
