// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vcs20200515.Models
{
    public class ListDeviceGroupsResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=true)]
        public string Message { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public List<ListDeviceGroupsResponseData> Data { get; set; }
        public class ListDeviceGroupsResponseData : TeaModel {
            [NameInMap("TotalCount")]
            [Validation(Required=true)]
            public string TotalCount { get; set; }

            [NameInMap("List")]
            [Validation(Required=true)]
            public List<ListDeviceGroupsResponseDataList> List { get; set; }
            public class ListDeviceGroupsResponseDataList : TeaModel {
                [NameInMap("DeviceGroup")]
                [Validation(Required=true)]
                public string DeviceGroup { get; set; }

                [NameInMap("DeviceName")]
                [Validation(Required=true)]
                public string DeviceName { get; set; }

                [NameInMap("DeviceCode")]
                [Validation(Required=true)]
                public string DeviceCode { get; set; }

                [NameInMap("BitRate")]
                [Validation(Required=true)]
                public string BitRate { get; set; }

                [NameInMap("CodingFormat")]
                [Validation(Required=true)]
                public string CodingFormat { get; set; }

                [NameInMap("ResolvingPower")]
                [Validation(Required=true)]
                public string ResolvingPower { get; set; }

                [NameInMap("DataSourceType")]
                [Validation(Required=true)]
                public string DataSourceType { get; set; }

                [NameInMap("RegionName")]
                [Validation(Required=true)]
                public string RegionName { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=true)]
                public string RegionId { get; set; }

                [NameInMap("InstallAddress")]
                [Validation(Required=true)]
                public string InstallAddress { get; set; }

                [NameInMap("DeviceSn")]
                [Validation(Required=true)]
                public string DeviceSn { get; set; }

                [NameInMap("DeviceStatus")]
                [Validation(Required=true)]
                public string DeviceStatus { get; set; }

                [NameInMap("DeviceStreamStatus")]
                [Validation(Required=true)]
                public string DeviceStreamStatus { get; set; }

                [NameInMap("DeviceComputeStatus")]
                [Validation(Required=true)]
                public string DeviceComputeStatus { get; set; }

            }

        }

    }

}
