// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryDeviceResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PageCount")]
        [Validation(Required=false)]
        public int? PageCount { get; set; }

        [NameInMap("Page")]
        [Validation(Required=false)]
        public int? Page { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryDeviceResponseBodyData Data { get; set; }
        public class QueryDeviceResponseBodyData : TeaModel {
            [NameInMap("DeviceInfo")]
            [Validation(Required=false)]
            public List<QueryDeviceResponseBodyDataDeviceInfo> DeviceInfo { get; set; }
            public class QueryDeviceResponseBodyDataDeviceInfo : TeaModel {
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
