// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryDeviceListByDeviceGroupResponse : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=true)]
        public string ErrorMessage { get; set; }

        [NameInMap("Page")]
        [Validation(Required=true)]
        public int? Page { get; set; }

        [NameInMap("PageCount")]
        [Validation(Required=true)]
        public int? PageCount { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=true)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=true)]
        public bool? Success { get; set; }

        [NameInMap("Total")]
        [Validation(Required=true)]
        public int? Total { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public QueryDeviceListByDeviceGroupResponseData Data { get; set; }
        public class QueryDeviceListByDeviceGroupResponseData : TeaModel {
            [NameInMap("SimpleDeviceInfo")]
            [Validation(Required=true)]
            public List<QueryDeviceListByDeviceGroupResponseDataSimpleDeviceInfo> SimpleDeviceInfo { get; set; }
            public class QueryDeviceListByDeviceGroupResponseDataSimpleDeviceInfo : TeaModel {
                [NameInMap("DeviceName")]
                [Validation(Required=true)]
                public string DeviceName { get; set; }

                [NameInMap("IotId")]
                [Validation(Required=true)]
                public string IotId { get; set; }

                [NameInMap("ProductKey")]
                [Validation(Required=true)]
                public string ProductKey { get; set; }

                [NameInMap("ProductName")]
                [Validation(Required=true)]
                public string ProductName { get; set; }

            }

        }

    }

}
