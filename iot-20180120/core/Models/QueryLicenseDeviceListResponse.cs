// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryLicenseDeviceListResponse : TeaModel {
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
        public QueryLicenseDeviceListResponseData Data { get; set; }
        public class QueryLicenseDeviceListResponseData : TeaModel {
            [NameInMap("PageId")]
            [Validation(Required=true)]
            public int? PageId { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=true)]
            public int? PageSize { get; set; }

            [NameInMap("Total")]
            [Validation(Required=true)]
            public int? Total { get; set; }

            [NameInMap("DeviceList")]
            [Validation(Required=true)]
            public QueryLicenseDeviceListResponseDataDeviceList DeviceList { get; set; }
            public class QueryLicenseDeviceListResponseDataDeviceList : TeaModel {
                [NameInMap("item")]
                [Validation(Required=true)]
                public List<QueryLicenseDeviceListResponseDataDeviceListItem> Item { get; set; }
                public class QueryLicenseDeviceListResponseDataDeviceListItem : TeaModel {
                    [NameInMap("DeviceName")]
                    [Validation(Required=true)]
                    public string DeviceName { get; set; }

                    [NameInMap("ExpiryTime")]
                    [Validation(Required=true)]
                    public long? ExpiryTime { get; set; }

                    [NameInMap("GmtCreate")]
                    [Validation(Required=true)]
                    public long? GmtCreate { get; set; }

                    [NameInMap("IotId")]
                    [Validation(Required=true)]
                    public string IotId { get; set; }

                    [NameInMap("LicenseCode")]
                    [Validation(Required=true)]
                    public string LicenseCode { get; set; }

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

}
