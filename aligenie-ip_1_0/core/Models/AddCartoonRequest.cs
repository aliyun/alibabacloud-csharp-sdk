// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieip_1_0.Models
{
    public class AddCartoonRequest : TeaModel {
        [NameInMap("HotelId")]
        [Validation(Required=false)]
        public string HotelId { get; set; }

        [NameInMap("StartVideoMd5")]
        [Validation(Required=false)]
        public string StartVideoMd5 { get; set; }

        [NameInMap("StartVideoUrl")]
        [Validation(Required=false)]
        public string StartVideoUrl { get; set; }

    }

}
