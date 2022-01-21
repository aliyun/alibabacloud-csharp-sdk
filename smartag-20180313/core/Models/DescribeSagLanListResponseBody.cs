// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class DescribeSagLanListResponseBody : TeaModel {
        [NameInMap("Lans")]
        [Validation(Required=false)]
        public List<DescribeSagLanListResponseBodyLans> Lans { get; set; }
        public class DescribeSagLanListResponseBodyLans : TeaModel {
            [NameInMap("EndIp")]
            [Validation(Required=false)]
            public string EndIp { get; set; }

            [NameInMap("IP")]
            [Validation(Required=false)]
            public string IP { get; set; }

            [NameInMap("IPType")]
            [Validation(Required=false)]
            public string IPType { get; set; }

            [NameInMap("Lease")]
            [Validation(Required=false)]
            public string Lease { get; set; }

            [NameInMap("Mask")]
            [Validation(Required=false)]
            public string Mask { get; set; }

            [NameInMap("PortName")]
            [Validation(Required=false)]
            public string PortName { get; set; }

            [NameInMap("StartIp")]
            [Validation(Required=false)]
            public string StartIp { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TaskStates")]
        [Validation(Required=false)]
        public List<DescribeSagLanListResponseBodyTaskStates> TaskStates { get; set; }
        public class DescribeSagLanListResponseBodyTaskStates : TeaModel {
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

        }

    }

}
