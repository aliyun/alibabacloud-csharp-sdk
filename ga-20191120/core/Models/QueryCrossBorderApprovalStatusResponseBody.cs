// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class QueryCrossBorderApprovalStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>Cross border permissions of Alibaba Cloud account (main account).</para>
        /// <list type="bullet">
        /// <item><description>UNAPPLIED : No cross-border permission application has been submitted or application records cannot be found.</description></item>
        /// <item><description>APPLIED : Cross-border permission review in progress.</description></item>
        /// <item><description>REJECTED : Cross-border permission review failed.</description></item>
        /// <item><description>PASSED : Cross-border permission review passed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>UNAPPLIED</para>
        /// </summary>
        [NameInMap("ApprovalStatus")]
        [Validation(Required=false)]
        public string ApprovalStatus { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F96E634B-A523-587F-9A09-AE8B2FD04B9C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
