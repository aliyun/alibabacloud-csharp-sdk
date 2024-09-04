// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Marketing_event20210101.Models
{
    public class SyncSignInInfoRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("ActivityId")]
        [Validation(Required=false)]
        public string ActivityId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("QRCode")]
        [Validation(Required=false)]
        public string QRCode { get; set; }

    }

}
