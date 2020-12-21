// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vcs20200515.Models
{
    public class ListDeviceGroupsResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListDeviceGroupsResponseBodyData> Data { get; set; }
        public class ListDeviceGroupsResponseBodyData : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<ListDeviceGroupsResponseBodyDataList> List { get; set; }
            public class ListDeviceGroupsResponseBodyDataList : TeaModel {
                [NameInMap("DeviceStreamStatus")]
                [Validation(Required=false)]
                public string DeviceStreamStatus { get; set; }

                [NameInMap("DeviceName")]
                [Validation(Required=false)]
                public string DeviceName { get; set; }

                [NameInMap("DeviceStatus")]
                [Validation(Required=false)]
                public string DeviceStatus { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("DeviceSn")]
                [Validation(Required=false)]
                public string DeviceSn { get; set; }

                [NameInMap("DeviceComputeStatus")]
                [Validation(Required=false)]
                public string DeviceComputeStatus { get; set; }

                [NameInMap("InstallAddress")]
                [Validation(Required=false)]
                public string InstallAddress { get; set; }

                [NameInMap("DeviceGroup")]
                [Validation(Required=false)]
                public string DeviceGroup { get; set; }

                [NameInMap("RegionName")]
                [Validation(Required=false)]
                public string RegionName { get; set; }

                [NameInMap("DataSourceType")]
                [Validation(Required=false)]
                public string DataSourceType { get; set; }

                [NameInMap("ResolvingPower")]
                [Validation(Required=false)]
                public string ResolvingPower { get; set; }

                [NameInMap("DeviceCode")]
                [Validation(Required=false)]
                public string DeviceCode { get; set; }

                [NameInMap("BitRate")]
                [Validation(Required=false)]
                public string BitRate { get; set; }

                [NameInMap("CodingFormat")]
                [Validation(Required=false)]
                public string CodingFormat { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public string TotalCount { get; set; }

        }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

    }

}
