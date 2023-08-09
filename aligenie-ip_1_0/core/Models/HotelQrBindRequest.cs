// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieip_1_0.Models
{
    public class HotelQrBindRequest : TeaModel {
        [NameInMap("ClientId")]
        [Validation(Required=false)]
        public string ClientId { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("ExtInfo")]
        [Validation(Required=false)]
        public string ExtInfo { get; set; }

        [NameInMap("HotelId")]
        [Validation(Required=false)]
        public string HotelId { get; set; }

        [NameInMap("RoomNo")]
        [Validation(Required=false)]
        public string RoomNo { get; set; }

    }

}
