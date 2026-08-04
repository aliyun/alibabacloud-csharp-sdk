// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class GetApprovalRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the approval instance. You can obtain the ID from the following sources:</para>
        /// <list type="bullet">
        /// <item><description><para><a href="~~ListApprovals~~">ListApprovals</a>: Queries a list of approval instances.</para>
        /// </description></item>
        /// <item><description><para><a href="~~GetApproval~~">GetApproval</a>: Queries the details of an approval instance.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>approval-872b5e911b35****</para>
        /// </summary>
        [NameInMap("ApprovalId")]
        [Validation(Required=false)]
        public string ApprovalId { get; set; }

    }

}
