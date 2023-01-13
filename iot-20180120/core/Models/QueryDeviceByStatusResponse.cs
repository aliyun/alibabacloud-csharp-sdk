// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryDeviceByStatusResponse : TeaModel {
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
        public QueryDeviceByStatusResponseData Data { get; set; }
        public class QueryDeviceByStatusResponseData : TeaModel {
            [NameInMap("SimpleDeviceInfo")]
            [Validation(Required=true)]
            public List<QueryDeviceByStatusResponseDataSimpleDeviceInfo> SimpleDeviceInfo { get; set; }
            public class QueryDeviceByStatusResponseDataSimpleDeviceInfo : TeaModel {
                [NameInMap("DeviceName")]
                [Validation(Required=true)]
                public string DeviceName { get; set; }

                [NameInMap("DeviceSecret")]
                [Validation(Required=true)]
                public string DeviceSecret { get; set; }

                [NameInMap("GmtCreate")]
                [Validation(Required=true)]
                public string GmtCreate { get; set; }

                [NameInMap("GmtModified")]
                [Validation(Required=true)]
                public string GmtModified { get; set; }

                [NameInMap("IotId")]
                [Validation(Required=true)]
                public string IotId { get; set; }

                [NameInMap("Nickname")]
                [Validation(Required=true)]
                public string Nickname { get; set; }

                [NameInMap("ProductKey")]
                [Validation(Required=true)]
                public string ProductKey { get; set; }

                [NameInMap("Status")]
                [Validation(Required=true)]
                public string Status { get; set; }

                [NameInMap("UtcCreate")]
                [Validation(Required=true)]
                public string UtcCreate { get; set; }

                [NameInMap("UtcModified")]
                [Validation(Required=true)]
                public string UtcModified { get; set; }

            }

        }

    }

}
