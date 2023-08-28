// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieip_1_0.Models
{
    public class PushWelcomeRequest : TeaModel {
        [NameInMap("HotelId")]
        [Validation(Required=false)]
        public string HotelId { get; set; }

        [NameInMap("RoomNo")]
        [Validation(Required=false)]
        public string RoomNo { get; set; }

        [NameInMap("WelcomeMusicUrl")]
        [Validation(Required=false)]
        public string WelcomeMusicUrl { get; set; }

        [NameInMap("WelcomeText")]
        [Validation(Required=false)]
        public string WelcomeText { get; set; }

    }

}
