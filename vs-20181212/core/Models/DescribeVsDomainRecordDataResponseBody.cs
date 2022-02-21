// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class DescribeVsDomainRecordDataResponseBody : TeaModel {
        [NameInMap("RecordDataPerInterval")]
        [Validation(Required=false)]
        public DescribeVsDomainRecordDataResponseBodyRecordDataPerInterval RecordDataPerInterval { get; set; }
        public class DescribeVsDomainRecordDataResponseBodyRecordDataPerInterval : TeaModel {
            [NameInMap("DataModule")]
            [Validation(Required=false)]
            public List<DescribeVsDomainRecordDataResponseBodyRecordDataPerIntervalDataModule> DataModule { get; set; }
            public class DescribeVsDomainRecordDataResponseBodyRecordDataPerIntervalDataModule : TeaModel {
                public string RecordValue { get; set; }
                public string StreamCountValue { get; set; }
                public string TimeStamp { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
