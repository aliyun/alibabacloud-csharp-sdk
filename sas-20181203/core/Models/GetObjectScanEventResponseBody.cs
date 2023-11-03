// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetObjectScanEventResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetObjectScanEventResponseBodyData Data { get; set; }
        public class GetObjectScanEventResponseBodyData : TeaModel {
            [NameInMap("Details")]
            [Validation(Required=false)]
            public List<GetObjectScanEventResponseBodyDataDetails> Details { get; set; }
            public class GetObjectScanEventResponseBodyDataDetails : TeaModel {
                [NameInMap("InfoType")]
                [Validation(Required=false)]
                public string InfoType { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("NameDisplay")]
                [Validation(Required=false)]
                public string NameDisplay { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

                [NameInMap("ValueDisplay")]
                [Validation(Required=false)]
                public string ValueDisplay { get; set; }

            }

            [NameInMap("EventName")]
            [Validation(Required=false)]
            public string EventName { get; set; }

            [NameInMap("FileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            [NameInMap("Md5")]
            [Validation(Required=false)]
            public string Md5 { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
