// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class DescribeVsDomainRecordDataResponseBody : TeaModel {
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        [NameInMap("RecordDataPerInterval")]
        [Validation(Required=false)]
        public DescribeVsDomainRecordDataResponseBodyRecordDataPerInterval RecordDataPerInterval { get; set; }
        public class DescribeVsDomainRecordDataResponseBodyRecordDataPerInterval : TeaModel {
            [NameInMap("DataModule")]
            [Validation(Required=false)]
            public List<DescribeVsDomainRecordDataResponseBodyRecordDataPerIntervalDataModule> DataModule { get; set; }
            public class DescribeVsDomainRecordDataResponseBodyRecordDataPerIntervalDataModule : TeaModel {
                public string TimeStamp { get; set; }
                public string RecordValue { get; set; }
            }
        };

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
