// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryEdgeInstanceDeviceResponse : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=true)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=true)]
        public bool? Success { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public QueryEdgeInstanceDeviceResponseData Data { get; set; }
        public class QueryEdgeInstanceDeviceResponseData : TeaModel {
            [NameInMap("CurrentPage")]
            [Validation(Required=true)]
            public int? CurrentPage { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=true)]
            public int? PageSize { get; set; }

            [NameInMap("Total")]
            [Validation(Required=true)]
            public int? Total { get; set; }

            [NameInMap("DeviceList")]
            [Validation(Required=true)]
            public List<QueryEdgeInstanceDeviceResponseDataDeviceList> DeviceList { get; set; }
            public class QueryEdgeInstanceDeviceResponseDataDeviceList : TeaModel {
                [NameInMap("DeviceName")]
                [Validation(Required=true)]
                public string DeviceName { get; set; }

                [NameInMap("DriverId")]
                [Validation(Required=true)]
                public string DriverId { get; set; }

                [NameInMap("IotId")]
                [Validation(Required=true)]
                public string IotId { get; set; }

                [NameInMap("ProductKey")]
                [Validation(Required=true)]
                public string ProductKey { get; set; }

            }

        }

    }

}
