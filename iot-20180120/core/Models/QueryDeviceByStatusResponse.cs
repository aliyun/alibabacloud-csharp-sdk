// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryDeviceByStatusResponse : TeaModel {
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

        [NameInMap("Page")]
        [Validation(Required=true)]
        public int? Page { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=true)]
        public int? PageSize { get; set; }

        [NameInMap("PageCount")]
        [Validation(Required=true)]
        public int? PageCount { get; set; }

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
                public string ProductKey { get; set; }
                public string DeviceName { get; set; }
                public string Status { get; set; }
                public string IotId { get; set; }
                public string Nickname { get; set; }
                public string GmtCreate { get; set; }
                public string GmtModified { get; set; }
                public string UtcCreate { get; set; }
                public string UtcModified { get; set; }
                public string DeviceSecret { get; set; }
            }
        };

    }

}
