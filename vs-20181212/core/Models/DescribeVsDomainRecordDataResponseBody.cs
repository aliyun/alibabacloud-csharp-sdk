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
                [NameInMap("RecordValue")]
                [Validation(Required=false)]
                public string RecordValue { get; set; }

                [NameInMap("StreamCountValue")]
                [Validation(Required=false)]
                public string StreamCountValue { get; set; }

                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
