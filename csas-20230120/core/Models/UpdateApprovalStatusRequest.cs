// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class UpdateApprovalStatusRequest : TeaModel {
        /// <summary>
        /// <para>The approval instance ID. You can obtain this value from the following operations:</para>
        /// <list type="bullet">
        /// <item><description><a href="~~ListApprovals~~">ListApprovals</a>: Lists approval instances.</description></item>
        /// <item><description><a href="~~GetApproval~~">GetApproval</a>: Queries the details of an approval instance.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>approval-872b5e911b35****</para>
        /// </summary>
        [NameInMap("ApprovalId")]
        [Validation(Required=false)]
        public string ApprovalId { get; set; }

        /// <summary>
        /// <para>The approval instance status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Approved</b>: Approved.</description></item>
        /// <item><description><b>Rejected</b>: Rejected.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Approved</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
