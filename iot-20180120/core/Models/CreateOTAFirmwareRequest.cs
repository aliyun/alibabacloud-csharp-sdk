// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class CreateOTAFirmwareRequest : TeaModel {
        [NameInMap("DestVersion")]
        [Validation(Required=false)]
        public string DestVersion { get; set; }

        [NameInMap("FirmwareDesc")]
        [Validation(Required=false)]
        public string FirmwareDesc { get; set; }

        [NameInMap("FirmwareName")]
        [Validation(Required=false)]
        public string FirmwareName { get; set; }

        [NameInMap("FirmwareSign")]
        [Validation(Required=false)]
        public string FirmwareSign { get; set; }

        [NameInMap("FirmwareSize")]
        [Validation(Required=false)]
        public int? FirmwareSize { get; set; }

        [NameInMap("FirmwareUrl")]
        [Validation(Required=false)]
        public string FirmwareUrl { get; set; }

        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        [NameInMap("ModuleName")]
        [Validation(Required=false)]
        public string ModuleName { get; set; }

        [NameInMap("NeedToVerify")]
        [Validation(Required=false)]
        public bool? NeedToVerify { get; set; }

        [NameInMap("ProductKey")]
        [Validation(Required=false)]
        public string ProductKey { get; set; }

        [NameInMap("SignMethod")]
        [Validation(Required=false)]
        public string SignMethod { get; set; }

        [NameInMap("SrcVersion")]
        [Validation(Required=false)]
        public string SrcVersion { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public int? Type { get; set; }

        [NameInMap("Udi")]
        [Validation(Required=false)]
        public string Udi { get; set; }

    }

}
