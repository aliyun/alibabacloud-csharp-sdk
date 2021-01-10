// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iovcc20180501.Models
{
    public class ListDevicesRequest : TeaModel {
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        [NameInMap("DeviceModelId")]
        [Validation(Required=false)]
        public int? DeviceModelId { get; set; }

        [NameInMap("DeviceModel")]
        [Validation(Required=false)]
        public string DeviceModel { get; set; }

        [NameInMap("Start")]
        [Validation(Required=false)]
        public string Start { get; set; }

        [NameInMap("Length")]
        [Validation(Required=false)]
        public string Length { get; set; }

    }

}
