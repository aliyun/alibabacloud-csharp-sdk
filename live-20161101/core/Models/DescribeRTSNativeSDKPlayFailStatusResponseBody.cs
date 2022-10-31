// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeRTSNativeSDKPlayFailStatusResponseBody : TeaModel {
        [NameInMap("DataInterval")]
        [Validation(Required=false)]
        public string DataInterval { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("PlayFailStatus")]
        [Validation(Required=false)]
        public List<DescribeRTSNativeSDKPlayFailStatusResponseBodyPlayFailStatus> PlayFailStatus { get; set; }
        public class DescribeRTSNativeSDKPlayFailStatusResponseBodyPlayFailStatus : TeaModel {
            [NameInMap("TimeStamp")]
            [Validation(Required=false)]
            public string TimeStamp { get; set; }

            [NameInMap("V20001")]
            [Validation(Required=false)]
            public string V20001 { get; set; }

            [NameInMap("V20002")]
            [Validation(Required=false)]
            public string V20002 { get; set; }

            [NameInMap("V20011")]
            [Validation(Required=false)]
            public string V20011 { get; set; }

            [NameInMap("V20012")]
            [Validation(Required=false)]
            public string V20012 { get; set; }

            [NameInMap("V20013")]
            [Validation(Required=false)]
            public string V20013 { get; set; }

            [NameInMap("V20052")]
            [Validation(Required=false)]
            public string V20052 { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
