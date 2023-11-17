// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkvisual20230630.Models
{
    public class ListBindingDeviceByAccountResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListBindingDeviceByAccountResponseBodyData Data { get; set; }
        public class ListBindingDeviceByAccountResponseBodyData : TeaModel {
            [NameInMap("DeviceList")]
            [Validation(Required=false)]
            public List<ListBindingDeviceByAccountResponseBodyDataDeviceList> DeviceList { get; set; }
            public class ListBindingDeviceByAccountResponseBodyDataDeviceList : TeaModel {
                [NameInMap("BindTime")]
                [Validation(Required=false)]
                public long? BindTime { get; set; }

                [NameInMap("DeviceName")]
                [Validation(Required=false)]
                public string DeviceName { get; set; }

                [NameInMap("IotId")]
                [Validation(Required=false)]
                public string IotId { get; set; }

                [NameInMap("NodeType")]
                [Validation(Required=false)]
                public string NodeType { get; set; }

                [NameInMap("Owned")]
                [Validation(Required=false)]
                public int? Owned { get; set; }

                [NameInMap("ProductKey")]
                [Validation(Required=false)]
                public string ProductKey { get; set; }

            }

            [NameInMap("PageCount")]
            [Validation(Required=false)]
            public int? PageCount { get; set; }

            [NameInMap("PageNo")]
            [Validation(Required=false)]
            public int? PageNo { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
