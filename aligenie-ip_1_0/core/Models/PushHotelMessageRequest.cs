// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieip_1_0.Models
{
    public class PushHotelMessageRequest : TeaModel {
        /// <summary>
        /// pushHotelMessageReq
        /// </summary>
        [NameInMap("PushHotelMessageReq")]
        [Validation(Required=false)]
        public PushHotelMessageRequestPushHotelMessageReq PushHotelMessageReq { get; set; }
        public class PushHotelMessageRequestPushHotelMessageReq : TeaModel {
            [NameInMap("HotelId")]
            [Validation(Required=false)]
            public string HotelId { get; set; }

            [NameInMap("ParamMap")]
            [Validation(Required=false)]
            public Dictionary<string, string> ParamMap { get; set; }

            [NameInMap("RoomNo")]
            [Validation(Required=false)]
            public string RoomNo { get; set; }

            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public long? TemplateId { get; set; }

        }

    }

}
