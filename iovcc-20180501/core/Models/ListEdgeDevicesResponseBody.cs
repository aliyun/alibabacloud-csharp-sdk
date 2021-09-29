// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iovcc20180501.Models
{
    public class ListEdgeDevicesResponseBody : TeaModel {
        /// <summary>
        /// 请求ID
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 表示当前调用返回读取到的位置，空代表数据已经读取完毕
        /// </summary>
        [NameInMap("EdgeDevices")]
        [Validation(Required=false)]
        public ListEdgeDevicesResponseBodyEdgeDevices EdgeDevices { get; set; }
        public class ListEdgeDevicesResponseBodyEdgeDevices : TeaModel {
            [NameInMap("Pagination")]
            [Validation(Required=false)]
            public ListEdgeDevicesResponseBodyEdgeDevicesPagination Pagination { get; set; }
            public class ListEdgeDevicesResponseBodyEdgeDevicesPagination : TeaModel {
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
            public List<ListEdgeDevicesResponseBodyEdgeDevicesList> List { get; set; }
            public class ListEdgeDevicesResponseBodyEdgeDevicesList : TeaModel {
                public string EdgeDeviceId { get; set; }
                public long? EdgeDeviceType { get; set; }
                public string EdgeDeviceName { get; set; }
                public long? OnlineStatus { get; set; }
                public long? ActivateTime { get; set; }
                public long? LastOnlineTime { get; set; }
            }
        };

    }

}
