// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class ModifyOTAFirmwareRequest : TeaModel {
        [NameInMap("FirmwareDesc")]
        [Validation(Required=false)]
        public string FirmwareDesc { get; set; }

        [NameInMap("FirmwareId")]
        [Validation(Required=false)]
        public string FirmwareId { get; set; }

        [NameInMap("FirmwareName")]
        [Validation(Required=false)]
        public string FirmwareName { get; set; }

        [NameInMap("FirmwareUdi")]
        [Validation(Required=false)]
        public string FirmwareUdi { get; set; }

        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        [NameInMap("ProductKey")]
        [Validation(Required=false)]
        public string ProductKey { get; set; }

    }

}
