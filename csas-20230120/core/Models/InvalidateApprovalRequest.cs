// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class InvalidateApprovalRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the approval instance to be immediately invalidated. You can obtain the ID by calling the ListApprovals operation. You can specify only one approval instance ID under the current Alibaba Cloud account at a time.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>approval-6b5188a28634****</para>
        /// </summary>
        [NameInMap("ApprovalId")]
        [Validation(Required=false)]
        public string ApprovalId { get; set; }

    }

}
