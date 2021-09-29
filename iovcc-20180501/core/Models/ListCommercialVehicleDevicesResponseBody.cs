// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iovcc20180501.Models
{
    public class ListCommercialVehicleDevicesResponseBody : TeaModel {
        /// <summary>
        /// 请求ID
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 表示当前调用返回读取到的位置，空代表数据已经读取完毕
        /// </summary>
        [NameInMap("VehicleDevices")]
        [Validation(Required=false)]
        public ListCommercialVehicleDevicesResponseBodyVehicleDevices VehicleDevices { get; set; }
        public class ListCommercialVehicleDevicesResponseBodyVehicleDevices : TeaModel {
            [NameInMap("Pagination")]
            [Validation(Required=false)]
            public ListCommercialVehicleDevicesResponseBodyVehicleDevicesPagination Pagination { get; set; }
            public class ListCommercialVehicleDevicesResponseBodyVehicleDevicesPagination : TeaModel {
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
            public List<ListCommercialVehicleDevicesResponseBodyVehicleDevicesList> List { get; set; }
            public class ListCommercialVehicleDevicesResponseBodyVehicleDevicesList : TeaModel {
                public long? CreateTime { get; set; }
                public long? ModifiedTime { get; set; }
                public string HardwareId { get; set; }
                public long? ClientId { get; set; }
                public string DeviceModel { get; set; }
                public long? OnlineStatus { get; set; }
                public string PlateNumber { get; set; }
            }
        };

    }

}
