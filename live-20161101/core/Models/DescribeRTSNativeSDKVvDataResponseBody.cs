// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeRTSNativeSDKVvDataResponseBody : TeaModel {
        [NameInMap("DataInterval")]
        [Validation(Required=false)]
        public string DataInterval { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        [NameInMap("VvData")]
        [Validation(Required=false)]
        public List<DescribeRTSNativeSDKVvDataResponseBodyVvData> VvData { get; set; }
        public class DescribeRTSNativeSDKVvDataResponseBodyVvData : TeaModel {
            [NameInMap("TimeStamp")]
            [Validation(Required=false)]
            public string TimeStamp { get; set; }

            [NameInMap("VvSuccess")]
            [Validation(Required=false)]
            public string VvSuccess { get; set; }

            [NameInMap("VvTotal")]
            [Validation(Required=false)]
            public string VvTotal { get; set; }

        }

    }

}
