// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.UniMkt20181212.Models
{
    public class RegistDeviceRequest : TeaModel {
        [NameInMap("ChannelId")]
        [Validation(Required=false)]
        public string ChannelId { get; set; }

        [NameInMap("City")]
        [Validation(Required=false)]
        public string City { get; set; }

        [NameInMap("DetailAddr")]
        [Validation(Required=false)]
        public string DetailAddr { get; set; }

        [NameInMap("DeviceModelNumber")]
        [Validation(Required=false)]
        public string DeviceModelNumber { get; set; }

        [NameInMap("DeviceName")]
        [Validation(Required=false)]
        public string DeviceName { get; set; }

        [NameInMap("DeviceType")]
        [Validation(Required=false)]
        public string DeviceType { get; set; }

        [NameInMap("District")]
        [Validation(Required=false)]
        public string District { get; set; }

        [NameInMap("FirstScene")]
        [Validation(Required=false)]
        public string FirstScene { get; set; }

        [NameInMap("Floor")]
        [Validation(Required=false)]
        public string Floor { get; set; }

        [NameInMap("LocationName")]
        [Validation(Required=false)]
        public string LocationName { get; set; }

        [NameInMap("OuterCode")]
        [Validation(Required=false)]
        public string OuterCode { get; set; }

        [NameInMap("Province")]
        [Validation(Required=false)]
        public string Province { get; set; }

        [NameInMap("SecondScene")]
        [Validation(Required=false)]
        public string SecondScene { get; set; }

    }

}
