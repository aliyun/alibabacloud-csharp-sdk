// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class DescribeLivePubListResponseBody : TeaModel {
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public long? PageNo { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("PubInfoList")]
        [Validation(Required=false)]
        public List<DescribeLivePubListResponseBodyPubInfoList> PubInfoList { get; set; }
        public class DescribeLivePubListResponseBodyPubInfoList : TeaModel {
            [NameInMap("Area")]
            [Validation(Required=false)]
            public string Area { get; set; }

            [NameInMap("CpuUsageRate")]
            [Validation(Required=false)]
            public string CpuUsageRate { get; set; }

            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            [NameInMap("EndTs")]
            [Validation(Required=false)]
            public string EndTs { get; set; }

            [NameInMap("Fps")]
            [Validation(Required=false)]
            public string Fps { get; set; }

            [NameInMap("Kbps")]
            [Validation(Required=false)]
            public string Kbps { get; set; }

            [NameInMap("PubHeapUpDuration")]
            [Validation(Required=false)]
            public string PubHeapUpDuration { get; set; }

            [NameInMap("PubMachineType")]
            [Validation(Required=false)]
            public string PubMachineType { get; set; }

            [NameInMap("SecondPlayRate")]
            [Validation(Required=false)]
            public string SecondPlayRate { get; set; }

            [NameInMap("StartTs")]
            [Validation(Required=false)]
            public string StartTs { get; set; }

            [NameInMap("StreamName")]
            [Validation(Required=false)]
            public string StreamName { get; set; }

        }

        /// <summary>
        /// Id
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
