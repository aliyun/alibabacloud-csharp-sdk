// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveDomainPvUvDataResponseBody : TeaModel {
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        [NameInMap("DataInterval")]
        [Validation(Required=false)]
        public string DataInterval { get; set; }

        [NameInMap("PvUvDataInfos")]
        [Validation(Required=false)]
        public DescribeLiveDomainPvUvDataResponseBodyPvUvDataInfos PvUvDataInfos { get; set; }
        public class DescribeLiveDomainPvUvDataResponseBodyPvUvDataInfos : TeaModel {
            [NameInMap("PvUvDataInfo")]
            [Validation(Required=false)]
            public List<DescribeLiveDomainPvUvDataResponseBodyPvUvDataInfosPvUvDataInfo> PvUvDataInfo { get; set; }
            public class DescribeLiveDomainPvUvDataResponseBodyPvUvDataInfosPvUvDataInfo : TeaModel {
                public string PV { get; set; }
                public string TimeStamp { get; set; }
                public string UV { get; set; }
            }
        };

    }

}
