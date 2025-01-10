// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieip_1_0.Models
{
    public class PushHotelMessageRequest : TeaModel {
        /// <summary>
        /// <para>pushHotelMessageReq</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("PushHotelMessageReq")]
        [Validation(Required=false)]
        public PushHotelMessageRequestPushHotelMessageReq PushHotelMessageReq { get; set; }
        public class PushHotelMessageRequestPushHotelMessageReq : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>e6dd44fd16084db8a60d69fd625d9f0f</para>
            /// </summary>
            [NameInMap("HotelId")]
            [Validation(Required=false)]
            public string HotelId { get; set; }

            [NameInMap("ParamMap")]
            [Validation(Required=false)]
            public Dictionary<string, string> ParamMap { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>102</para>
            /// </summary>
            [NameInMap("RoomNo")]
            [Validation(Required=false)]
            public string RoomNo { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public long? TemplateId { get; set; }

        }

    }

}
