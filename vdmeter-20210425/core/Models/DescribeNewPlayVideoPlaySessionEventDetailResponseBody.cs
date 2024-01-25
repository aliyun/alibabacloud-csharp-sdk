// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vdmeter20210425.Models
{
    public class DescribeNewPlayVideoPlaySessionEventDetailResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeNewPlayVideoPlaySessionEventDetailResponseBodyData> Data { get; set; }
        public class DescribeNewPlayVideoPlaySessionEventDetailResponseBodyData : TeaModel {
            [NameInMap("BizTime")]
            [Validation(Required=false)]
            public string BizTime { get; set; }

            [NameInMap("Cost")]
            [Validation(Required=false)]
            public string Cost { get; set; }

            [NameInMap("Details")]
            [Validation(Required=false)]
            public string Details { get; set; }

            [NameInMap("EventName")]
            [Validation(Required=false)]
            public string EventName { get; set; }

            [NameInMap("IP")]
            [Validation(Required=false)]
            public string IP { get; set; }

            [NameInMap("ISP")]
            [Validation(Required=false)]
            public string ISP { get; set; }

            [NameInMap("IsNormal")]
            [Validation(Required=false)]
            public int? IsNormal { get; set; }

            [NameInMap("NetworkType")]
            [Validation(Required=false)]
            public string NetworkType { get; set; }

            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            [NameInMap("Subject")]
            [Validation(Required=false)]
            public string Subject { get; set; }

        }

        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public long? PageNum { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("ReadyTs")]
        [Validation(Required=false)]
        public long? ReadyTs { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalNum")]
        [Validation(Required=false)]
        public long? TotalNum { get; set; }

    }

}
