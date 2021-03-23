// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iovcc20180501.Models
{
    public class CountActivatedOrNewRegistrationDeviceRequest : TeaModel {
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        [NameInMap("DeviceType")]
        [Validation(Required=false)]
        public string DeviceType { get; set; }

        [NameInMap("DeviceBrandId")]
        [Validation(Required=false)]
        public string DeviceBrandId { get; set; }

        [NameInMap("DeviceBrand")]
        [Validation(Required=false)]
        public string DeviceBrand { get; set; }

        [NameInMap("DeviceModelId")]
        [Validation(Required=false)]
        public string DeviceModelId { get; set; }

        [NameInMap("DeviceModel")]
        [Validation(Required=false)]
        public string DeviceModel { get; set; }

        [NameInMap("DeviceCountStatType")]
        [Validation(Required=false)]
        public string DeviceCountStatType { get; set; }

        [NameInMap("IsQueryNewRegistrationDevice")]
        [Validation(Required=false)]
        public string IsQueryNewRegistrationDevice { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("IsQueryYearlyActivate")]
        [Validation(Required=false)]
        public string IsQueryYearlyActivate { get; set; }

    }

}
