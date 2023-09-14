// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class QueryCrossBorderApprovalStatusResponseBody : TeaModel {
        /// <summary>
        /// Cross border permissions of Alibaba Cloud account (main account).
        /// 
        /// -  UNAPPLIED : No cross-border permission application has been submitted or application records cannot be found.
        /// -  APPLIED : Cross-border permission review in progress.
        /// -  REJECTED : Cross-border permission review failed.
        /// -  PASSED : Cross-border permission review passed.
        /// </summary>
        [NameInMap("ApprovalStatus")]
        [Validation(Required=false)]
        public string ApprovalStatus { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
