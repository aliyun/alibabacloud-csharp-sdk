// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class DescribeVsDomainPvUvDataResponseBody : TeaModel {
        [NameInMap("DataInterval")]
        [Validation(Required=false)]
        public string DataInterval { get; set; }

        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("PvUvDataInfos")]
        [Validation(Required=false)]
        public DescribeVsDomainPvUvDataResponseBodyPvUvDataInfos PvUvDataInfos { get; set; }
        public class DescribeVsDomainPvUvDataResponseBodyPvUvDataInfos : TeaModel {
            [NameInMap("PvUvDataInfo")]
            [Validation(Required=false)]
            public List<DescribeVsDomainPvUvDataResponseBodyPvUvDataInfosPvUvDataInfo> PvUvDataInfo { get; set; }
            public class DescribeVsDomainPvUvDataResponseBodyPvUvDataInfosPvUvDataInfo : TeaModel {
                public string PV { get; set; }
                public string TimeStamp { get; set; }
                public string UV { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
