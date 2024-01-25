// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vdmeter20210425.Models
{
    public class DescribeMeterRtcUserCntDataResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeMeterRtcUserCntDataResponseBodyData> Data { get; set; }
        public class DescribeMeterRtcUserCntDataResponseBodyData : TeaModel {
            [NameInMap("ActiveUserCnt")]
            [Validation(Required=false)]
            public long? ActiveUserCnt { get; set; }

            [NameInMap("Timestamp")]
            [Validation(Required=false)]
            public long? Timestamp { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
