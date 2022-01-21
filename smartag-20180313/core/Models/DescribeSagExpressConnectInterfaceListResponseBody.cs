// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class DescribeSagExpressConnectInterfaceListResponseBody : TeaModel {
        [NameInMap("Interfaces")]
        [Validation(Required=false)]
        public List<DescribeSagExpressConnectInterfaceListResponseBodyInterfaces> Interfaces { get; set; }
        public class DescribeSagExpressConnectInterfaceListResponseBodyInterfaces : TeaModel {
            [NameInMap("IP")]
            [Validation(Required=false)]
            public string IP { get; set; }

            [NameInMap("Mask")]
            [Validation(Required=false)]
            public string Mask { get; set; }

            [NameInMap("Vlan")]
            [Validation(Required=false)]
            public string Vlan { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TaskStates")]
        [Validation(Required=false)]
        public List<DescribeSagExpressConnectInterfaceListResponseBodyTaskStates> TaskStates { get; set; }
        public class DescribeSagExpressConnectInterfaceListResponseBodyTaskStates : TeaModel {
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
