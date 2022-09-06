// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryShareTaskDeviceListResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryShareTaskDeviceListResponseBodyData Data { get; set; }
        public class QueryShareTaskDeviceListResponseBodyData : TeaModel {
            [NameInMap("DeviceList")]
            [Validation(Required=false)]
            public QueryShareTaskDeviceListResponseBodyDataDeviceList DeviceList { get; set; }
            public class QueryShareTaskDeviceListResponseBodyDataDeviceList : TeaModel {
                [NameInMap("items")]
                [Validation(Required=false)]
                public List<QueryShareTaskDeviceListResponseBodyDataDeviceListItems> Items { get; set; }
                public class QueryShareTaskDeviceListResponseBodyDataDeviceListItems : TeaModel {
                    [NameInMap("DeviceName")]
                    [Validation(Required=false)]
                    public string DeviceName { get; set; }

                    [NameInMap("GmtAdded")]
                    [Validation(Required=false)]
                    public long? GmtAdded { get; set; }

                    [NameInMap("IotId")]
                    [Validation(Required=false)]
                    public string IotId { get; set; }

                    [NameInMap("ProductKey")]
                    [Validation(Required=false)]
                    public string ProductKey { get; set; }

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

        }

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
