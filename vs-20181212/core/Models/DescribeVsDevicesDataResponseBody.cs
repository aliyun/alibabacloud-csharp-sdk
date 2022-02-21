// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class DescribeVsDevicesDataResponseBody : TeaModel {
        [NameInMap("DevicesDataPerInterval")]
        [Validation(Required=false)]
        public DescribeVsDevicesDataResponseBodyDevicesDataPerInterval DevicesDataPerInterval { get; set; }
        public class DescribeVsDevicesDataResponseBodyDevicesDataPerInterval : TeaModel {
            [NameInMap("DataModule")]
            [Validation(Required=false)]
            public List<DescribeVsDevicesDataResponseBodyDevicesDataPerIntervalDataModule> DataModule { get; set; }
            public class DescribeVsDevicesDataResponseBodyDevicesDataPerIntervalDataModule : TeaModel {
                public string DevicesDataValue { get; set; }
                public string TimeStamp { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
