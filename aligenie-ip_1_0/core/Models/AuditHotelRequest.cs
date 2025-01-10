// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieip_1_0.Models
{
    public class AuditHotelRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("AuditHotelReq")]
        [Validation(Required=false)]
        public AuditHotelRequestAuditHotelReq AuditHotelReq { get; set; }
        public class AuditHotelRequestAuditHotelReq : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>同意</para>
            /// </summary>
            [NameInMap("AuditOpinion")]
            [Validation(Required=false)]
            public string AuditOpinion { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80d84ea8ed9e422fbad52715c8fc56f1</para>
            /// </summary>
            [NameInMap("HotelId")]
            [Validation(Required=false)]
            public string HotelId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

        }

    }

}
