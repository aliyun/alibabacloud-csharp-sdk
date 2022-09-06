// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryProjectShareDeviceListResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryProjectShareDeviceListResponseBodyData Data { get; set; }
        public class QueryProjectShareDeviceListResponseBodyData : TeaModel {
            [NameInMap("DeviceList")]
            [Validation(Required=false)]
            public QueryProjectShareDeviceListResponseBodyDataDeviceList DeviceList { get; set; }
            public class QueryProjectShareDeviceListResponseBodyDataDeviceList : TeaModel {
                [NameInMap("items")]
                [Validation(Required=false)]
                public List<QueryProjectShareDeviceListResponseBodyDataDeviceListItems> Items { get; set; }
                public class QueryProjectShareDeviceListResponseBodyDataDeviceListItems : TeaModel {
                    [NameInMap("DeviceName")]
                    [Validation(Required=false)]
                    public string DeviceName { get; set; }

                    [NameInMap("IotId")]
                    [Validation(Required=false)]
                    public string IotId { get; set; }

                    [NameInMap("ProductKey")]
                    [Validation(Required=false)]
                    public string ProductKey { get; set; }

                    [NameInMap("Sharable")]
                    [Validation(Required=false)]
                    public long? Sharable { get; set; }

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
