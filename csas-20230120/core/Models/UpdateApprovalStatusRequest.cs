// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class UpdateApprovalStatusRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the approval instance. Obtain the value from:</para>
        /// <list type="bullet">
        /// <item><description><para><a href="~~ListApprovals~~">ListApprovals</a>: Query a list of approval instances in batches.</para>
        /// </description></item>
        /// <item><description><para><a href="~~GetApproval~~">GetApproval</a>: Query the details of an approval instance.</para>
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

        /// <summary>
        /// <para>The status of the approval instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Approved</b>: Approved.</para>
        /// </description></item>
        /// <item><description><para><b>Rejected</b>: Rejected.</para>
        /// </description></item>
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
