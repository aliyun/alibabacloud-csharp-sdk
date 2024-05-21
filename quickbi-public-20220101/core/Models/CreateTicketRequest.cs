// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class CreateTicketRequest : TeaModel {
        [NameInMap("AccountName")]
        [Validation(Required=false)]
        public string AccountName { get; set; }

        [NameInMap("AccountType")]
        [Validation(Required=false)]
        public int? AccountType { get; set; }

        [NameInMap("CmptId")]
        [Validation(Required=false)]
        public string CmptId { get; set; }

        [NameInMap("ExpireTime")]
        [Validation(Required=false)]
        public int? ExpireTime { get; set; }

        [NameInMap("GlobalParam")]
        [Validation(Required=false)]
        public string GlobalParam { get; set; }

        [NameInMap("TicketNum")]
        [Validation(Required=false)]
        public int? TicketNum { get; set; }

        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        [NameInMap("WatermarkParam")]
        [Validation(Required=false)]
        public string WatermarkParam { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("WorksId")]
        [Validation(Required=false)]
        public string WorksId { get; set; }

    }

}
