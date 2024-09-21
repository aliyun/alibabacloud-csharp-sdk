// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EnergyExpertExternal20220923.Models
{
    public class EditProhibitedDevicesRequest : TeaModel {
        [NameInMap("factoryId")]
        [Validation(Required=false)]
        public string FactoryId { get; set; }

        [NameInMap("hvacDeviceConfigVOList")]
        [Validation(Required=false)]
        public List<EditProhibitedDevicesRequestHvacDeviceConfigVOList> HvacDeviceConfigVOList { get; set; }
        public class EditProhibitedDevicesRequestHvacDeviceConfigVOList : TeaModel {
            [NameInMap("buildingId")]
            [Validation(Required=false)]
            public string BuildingId { get; set; }

            [NameInMap("deviceId")]
            [Validation(Required=false)]
            public string DeviceId { get; set; }

            [NameInMap("deviceName")]
            [Validation(Required=false)]
            public string DeviceName { get; set; }

            [NameInMap("deviceType")]
            [Validation(Required=false)]
            public string DeviceType { get; set; }

            [NameInMap("fenceId")]
            [Validation(Required=false)]
            public string FenceId { get; set; }

            [NameInMap("floorId")]
            [Validation(Required=false)]
            public string FloorId { get; set; }

            [NameInMap("isForbidden")]
            [Validation(Required=false)]
            public int? IsForbidden { get; set; }

            [NameInMap("isUnfavorableArea")]
            [Validation(Required=false)]
            public int? IsUnfavorableArea { get; set; }

        }

        [NameInMap("systemId")]
        [Validation(Required=false)]
        public string SystemId { get; set; }

    }

}
