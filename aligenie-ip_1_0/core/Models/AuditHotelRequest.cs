// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieip_1_0.Models
{
    public class AuditHotelRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("AuditHotelReq")]
        [Validation(Required=false)]
        public AuditHotelRequestAuditHotelReq AuditHotelReq { get; set; }
        public class AuditHotelRequestAuditHotelReq : TeaModel {
            [NameInMap("AuditOpinion")]
            [Validation(Required=false)]
            public string AuditOpinion { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("HotelId")]
            [Validation(Required=false)]
            public string HotelId { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

        }

    }

}
