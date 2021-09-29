// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iovcc20180501.Models
{
    public class ListHostDevicesResponseBody : TeaModel {
        /// <summary>
        /// 请求ID
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 表示当前调用返回读取到的位置，空代表数据已经读取完毕
        /// </summary>
        [NameInMap("HostDevices")]
        [Validation(Required=false)]
        public ListHostDevicesResponseBodyHostDevices HostDevices { get; set; }
        public class ListHostDevicesResponseBodyHostDevices : TeaModel {
            [NameInMap("Pagination")]
            [Validation(Required=false)]
            public ListHostDevicesResponseBodyHostDevicesPagination Pagination { get; set; }
            public class ListHostDevicesResponseBodyHostDevicesPagination : TeaModel {
                [NameInMap("TotalCount")]
                [Validation(Required=false)]
                public long? TotalCount { get; set; }

                [NameInMap("TotalPageCount")]
                [Validation(Required=false)]
                public long? TotalPageCount { get; set; }

                [NameInMap("PageIndex")]
                [Validation(Required=false)]
                public long? PageIndex { get; set; }

                [NameInMap("PageSize")]
                [Validation(Required=false)]
                public long? PageSize { get; set; }

            }
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<ListHostDevicesResponseBodyHostDevicesList> List { get; set; }
            public class ListHostDevicesResponseBodyHostDevicesList : TeaModel {
                public string DeviceId { get; set; }
                public string SerialNumber { get; set; }
                public string DeviceName { get; set; }
                public long? Status { get; set; }
                public string DeviceModel { get; set; }
                public string Ip { get; set; }
                public long? ActivateTime { get; set; }
            }
        };

    }

}
