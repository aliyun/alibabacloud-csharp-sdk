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
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("PushHotelMessageReq")]
        [Validation(Required=false)]
        public PushHotelMessageRequestPushHotelMessageReq PushHotelMessageReq { get; set; }
        public class PushHotelMessageRequestPushHotelMessageReq : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("HotelId")]
            [Validation(Required=false)]
            public string HotelId { get; set; }

            [NameInMap("ParamMap")]
            [Validation(Required=false)]
            public Dictionary<string, string> ParamMap { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("RoomNo")]
            [Validation(Required=false)]
            public string RoomNo { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public long? TemplateId { get; set; }

        }

    }

}
