// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryPageByApplyIdResponseBody : TeaModel {
        [NameInMap("ApplyDeviceList")]
        [Validation(Required=false)]
        public QueryPageByApplyIdResponseBodyApplyDeviceList ApplyDeviceList { get; set; }
        public class QueryPageByApplyIdResponseBodyApplyDeviceList : TeaModel {
            [NameInMap("ApplyDeviceInfo")]
            [Validation(Required=false)]
            public List<QueryPageByApplyIdResponseBodyApplyDeviceListApplyDeviceInfo> ApplyDeviceInfo { get; set; }
            public class QueryPageByApplyIdResponseBodyApplyDeviceListApplyDeviceInfo : TeaModel {
                [NameInMap("DeviceId")]
                [Validation(Required=false)]
                public string DeviceId { get; set; }

                [NameInMap("DeviceName")]
                [Validation(Required=false)]
                public string DeviceName { get; set; }

                [NameInMap("DeviceSecret")]
                [Validation(Required=false)]
                public string DeviceSecret { get; set; }

                [NameInMap("IotId")]
                [Validation(Required=false)]
                public string IotId { get; set; }

            }

        }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("Page")]
        [Validation(Required=false)]
        public int? Page { get; set; }

        [NameInMap("PageCount")]
        [Validation(Required=false)]
        public int? PageCount { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
