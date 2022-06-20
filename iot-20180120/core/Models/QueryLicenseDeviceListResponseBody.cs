// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryLicenseDeviceListResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryLicenseDeviceListResponseBodyData Data { get; set; }
        public class QueryLicenseDeviceListResponseBodyData : TeaModel {
            [NameInMap("DeviceList")]
            [Validation(Required=false)]
            public QueryLicenseDeviceListResponseBodyDataDeviceList DeviceList { get; set; }
            public class QueryLicenseDeviceListResponseBodyDataDeviceList : TeaModel {
                [NameInMap("item")]
                [Validation(Required=false)]
                public List<QueryLicenseDeviceListResponseBodyDataDeviceListItem> Item { get; set; }
                public class QueryLicenseDeviceListResponseBodyDataDeviceListItem : TeaModel {
                    [NameInMap("DeviceName")]
                    [Validation(Required=false)]
                    public string DeviceName { get; set; }

                    [NameInMap("ExpiryTime")]
                    [Validation(Required=false)]
                    public long? ExpiryTime { get; set; }

                    [NameInMap("GmtCreate")]
                    [Validation(Required=false)]
                    public long? GmtCreate { get; set; }

                    [NameInMap("IotId")]
                    [Validation(Required=false)]
                    public string IotId { get; set; }

                    [NameInMap("LicenseCode")]
                    [Validation(Required=false)]
                    public string LicenseCode { get; set; }

                    [NameInMap("ProductKey")]
                    [Validation(Required=false)]
                    public string ProductKey { get; set; }

                    [NameInMap("ProductName")]
                    [Validation(Required=false)]
                    public string ProductName { get; set; }

                }

            }
            [NameInMap("PageId")]
            [Validation(Required=false)]
            public int? PageId { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }
        };

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
