// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class CreateResellerUserQuotaRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Amount")]
        [Validation(Required=false)]
        public string Amount { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Currency")]
        [Validation(Required=false)]
        public string Currency { get; set; }

        [NameInMap("OutBizId")]
        [Validation(Required=false)]
        public string OutBizId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

    }

}
