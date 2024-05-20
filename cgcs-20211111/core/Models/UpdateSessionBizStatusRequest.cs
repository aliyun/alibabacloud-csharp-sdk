// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CGCS20211111.Models
{
    public class UpdateSessionBizStatusRequest : TeaModel {
        [NameInMap("BizStatus")]
        [Validation(Required=false)]
        public string BizStatus { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("PlatformSessionId")]
        [Validation(Required=false)]
        public string PlatformSessionId { get; set; }

    }

}
