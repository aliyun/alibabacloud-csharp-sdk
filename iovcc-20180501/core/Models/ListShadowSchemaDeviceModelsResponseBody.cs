// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iovcc20180501.Models
{
    public class ListShadowSchemaDeviceModelsResponseBody : TeaModel {
        [NameInMap("ModelList")]
        [Validation(Required=false)]
        public List<ListShadowSchemaDeviceModelsResponseBodyModelList> ModelList { get; set; }
        public class ListShadowSchemaDeviceModelsResponseBodyModelList : TeaModel {
            [NameInMap("DeviceModelId")]
            [Validation(Required=false)]
            public long? DeviceModelId { get; set; }

            [NameInMap("HardwareType")]
            [Validation(Required=false)]
            public string HardwareType { get; set; }

            [NameInMap("DeviceType")]
            [Validation(Required=false)]
            public string DeviceType { get; set; }

            [NameInMap("CanCreateDeviceId")]
            [Validation(Required=false)]
            public int? CanCreateDeviceId { get; set; }

            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public string ProjectId { get; set; }

            [NameInMap("OsPlatform")]
            [Validation(Required=false)]
            public string OsPlatform { get; set; }

            [NameInMap("DeviceModel")]
            [Validation(Required=false)]
            public string DeviceModel { get; set; }

            [NameInMap("SecurityChip")]
            [Validation(Required=false)]
            public int? SecurityChip { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("InitUsageTypeDesc")]
            [Validation(Required=false)]
            public string InitUsageTypeDesc { get; set; }

            [NameInMap("InitUsageType")]
            [Validation(Required=false)]
            public int? InitUsageType { get; set; }

            [NameInMap("DeviceBrand")]
            [Validation(Required=false)]
            public string DeviceBrand { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
