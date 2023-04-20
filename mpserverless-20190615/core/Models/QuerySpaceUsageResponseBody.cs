// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MPServerless20190615.Models
{
    public class QuerySpaceUsageResponseBody : TeaModel {
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SpaceId")]
        [Validation(Required=false)]
        public string SpaceId { get; set; }

        [NameInMap("SpaceUsageDataList")]
        [Validation(Required=false)]
        public List<QuerySpaceUsageResponseBodySpaceUsageDataList> SpaceUsageDataList { get; set; }
        public class QuerySpaceUsageResponseBodySpaceUsageDataList : TeaModel {
            [NameInMap("CsUsage")]
            [Validation(Required=false)]
            public QuerySpaceUsageResponseBodySpaceUsageDataListCsUsage CsUsage { get; set; }
            public class QuerySpaceUsageResponseBodySpaceUsageDataListCsUsage : TeaModel {
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

            [NameInMap("DbUsage")]
            [Validation(Required=false)]
            public QuerySpaceUsageResponseBodySpaceUsageDataListDbUsage DbUsage { get; set; }
            public class QuerySpaceUsageResponseBodySpaceUsageDataListDbUsage : TeaModel {
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

            [NameInMap("EffectiveBillFlag")]
            [Validation(Required=false)]
            public bool? EffectiveBillFlag { get; set; }

            [NameInMap("FcUsage")]
            [Validation(Required=false)]
            public QuerySpaceUsageResponseBodySpaceUsageDataListFcUsage FcUsage { get; set; }
            public class QuerySpaceUsageResponseBodySpaceUsageDataListFcUsage : TeaModel {
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

            [NameInMap("Timestamp")]
            [Validation(Required=false)]
            public string Timestamp { get; set; }

            [NameInMap("WhUsage")]
            [Validation(Required=false)]
            public QuerySpaceUsageResponseBodySpaceUsageDataListWhUsage WhUsage { get; set; }
            public class QuerySpaceUsageResponseBodySpaceUsageDataListWhUsage : TeaModel {
                [NameInMap("CdnTraffic")]
                [Validation(Required=false)]
                public long? CdnTraffic { get; set; }

                [NameInMap("StorageSize")]
                [Validation(Required=false)]
                public long? StorageSize { get; set; }

            }

        }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
