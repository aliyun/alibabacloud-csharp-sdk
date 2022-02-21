// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class DescribeNodeDevicesInfoResponseBody : TeaModel {
        [NameInMap("NodeDevices")]
        [Validation(Required=false)]
        public List<DescribeNodeDevicesInfoResponseBodyNodeDevices> NodeDevices { get; set; }
        public class DescribeNodeDevicesInfoResponseBodyNodeDevices : TeaModel {
            [NameInMap("DeviceInfos")]
            [Validation(Required=false)]
            public List<DescribeNodeDevicesInfoResponseBodyNodeDevicesDeviceInfos> DeviceInfos { get; set; }
            public class DescribeNodeDevicesInfoResponseBodyNodeDevicesDeviceInfos : TeaModel {
                [NameInMap("IP")]
                [Validation(Required=false)]
                public string IP { get; set; }

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Server")]
                [Validation(Required=false)]
                public string Server { get; set; }

            }

            [NameInMap("NodeName")]
            [Validation(Required=false)]
            public string NodeName { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
