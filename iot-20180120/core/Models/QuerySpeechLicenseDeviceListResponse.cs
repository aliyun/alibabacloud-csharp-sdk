// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QuerySpeechLicenseDeviceListResponse : TeaModel {
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
        public QuerySpeechLicenseDeviceListResponseData Data { get; set; }
        public class QuerySpeechLicenseDeviceListResponseData : TeaModel {
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
            public QuerySpeechLicenseDeviceListResponseDataDeviceList DeviceList { get; set; }
            public class QuerySpeechLicenseDeviceListResponseDataDeviceList : TeaModel {
                [NameInMap("item")]
                [Validation(Required=true)]
                public List<QuerySpeechLicenseDeviceListResponseDataDeviceListItem> Item { get; set; }
                public class QuerySpeechLicenseDeviceListResponseDataDeviceListItem : TeaModel {
                    [NameInMap("DeviceName")]
                    [Validation(Required=true)]
                    public string DeviceName { get; set; }

                    [NameInMap("DeviceStatus")]
                    [Validation(Required=true)]
                    public string DeviceStatus { get; set; }

                    [NameInMap("ExpiryTime")]
                    [Validation(Required=true)]
                    public long? ExpiryTime { get; set; }

                    [NameInMap("InSpecifiedGroup")]
                    [Validation(Required=true)]
                    public bool? InSpecifiedGroup { get; set; }

                    [NameInMap("IotId")]
                    [Validation(Required=true)]
                    public string IotId { get; set; }

                    [NameInMap("LicenseStatus")]
                    [Validation(Required=true)]
                    public string LicenseStatus { get; set; }

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
