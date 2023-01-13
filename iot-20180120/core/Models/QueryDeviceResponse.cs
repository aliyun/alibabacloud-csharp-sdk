// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryDeviceResponse : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=true)]
        public string ErrorMessage { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=true)]
        public string NextToken { get; set; }

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
        public QueryDeviceResponseData Data { get; set; }
        public class QueryDeviceResponseData : TeaModel {
            [NameInMap("DeviceInfo")]
            [Validation(Required=true)]
            public List<QueryDeviceResponseDataDeviceInfo> DeviceInfo { get; set; }
            public class QueryDeviceResponseDataDeviceInfo : TeaModel {
                [NameInMap("DeviceId")]
                [Validation(Required=true)]
                public string DeviceId { get; set; }

                [NameInMap("DeviceName")]
                [Validation(Required=true)]
                public string DeviceName { get; set; }

                [NameInMap("DeviceSecret")]
                [Validation(Required=true)]
                public string DeviceSecret { get; set; }

                [NameInMap("DeviceStatus")]
                [Validation(Required=true)]
                public string DeviceStatus { get; set; }

                [NameInMap("DeviceType")]
                [Validation(Required=true)]
                public string DeviceType { get; set; }

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
