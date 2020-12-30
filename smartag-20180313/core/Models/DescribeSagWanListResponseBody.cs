// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class DescribeSagWanListResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Wans")]
        [Validation(Required=false)]
        public List<DescribeSagWanListResponseBodyWans> Wans { get; set; }
        public class DescribeSagWanListResponseBodyWans : TeaModel {
            [NameInMap("Weight")]
            [Validation(Required=false)]
            public int? Weight { get; set; }

            [NameInMap("Mask")]
            [Validation(Required=false)]
            public string Mask { get; set; }

            [NameInMap("Gateway")]
            [Validation(Required=false)]
            public string Gateway { get; set; }

            [NameInMap("PortName")]
            [Validation(Required=false)]
            public string PortName { get; set; }

            [NameInMap("IPType")]
            [Validation(Required=false)]
            public string IPType { get; set; }

            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            [NameInMap("BandWidth")]
            [Validation(Required=false)]
            public int? BandWidth { get; set; }

            [NameInMap("TrafficState")]
            [Validation(Required=false)]
            public string TrafficState { get; set; }

            [NameInMap("IP")]
            [Validation(Required=false)]
            public string IP { get; set; }

            [NameInMap("ISP")]
            [Validation(Required=false)]
            public string ISP { get; set; }

            [NameInMap("Username")]
            [Validation(Required=false)]
            public string Username { get; set; }

        }

        [NameInMap("TaskStates")]
        [Validation(Required=false)]
        public List<DescribeSagWanListResponseBodyTaskStates> TaskStates { get; set; }
        public class DescribeSagWanListResponseBodyTaskStates : TeaModel {
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

        }

    }

}
