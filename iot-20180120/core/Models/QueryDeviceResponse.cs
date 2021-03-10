// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryDeviceResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=true)]
        public bool? Success { get; set; }

        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=true)]
        public string ErrorMessage { get; set; }

        [NameInMap("Total")]
        [Validation(Required=true)]
        public int? Total { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=true)]
        public int? PageSize { get; set; }

        [NameInMap("PageCount")]
        [Validation(Required=true)]
        public int? PageCount { get; set; }

        [NameInMap("Page")]
        [Validation(Required=true)]
        public int? Page { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public QueryDeviceResponseData Data { get; set; }
        public class QueryDeviceResponseData : TeaModel {
            [NameInMap("DeviceInfo")]
            [Validation(Required=true)]
            public List<QueryDeviceResponseDataDeviceInfo> DeviceInfo { get; set; }
            public class QueryDeviceResponseDataDeviceInfo : TeaModel {
                public string DeviceId { get; set; }
                public string DeviceSecret { get; set; }
                public string ProductKey { get; set; }
                public string DeviceStatus { get; set; }
                public string DeviceName { get; set; }
                public string DeviceType { get; set; }
                public string GmtCreate { get; set; }
                public string GmtModified { get; set; }
                public string UtcCreate { get; set; }
                public string UtcModified { get; set; }
                public string IotId { get; set; }
                public string Nickname { get; set; }
            }
        };

    }

}
