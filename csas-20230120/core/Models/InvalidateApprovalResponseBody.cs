// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class InvalidateApprovalResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the invalidated approval instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>approval-6b5188a28634****</para>
        /// </summary>
        [NameInMap("ApprovalId")]
        [Validation(Required=false)]
        public string ApprovalId { get; set; }

        /// <summary>
        /// <para>The effective status of the approval. When the invalidation succeeds, the value is fixed as Expired, which indicates that the approval has been invalidated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Expired</para>
        /// </summary>
        [NameInMap("EffectStatus")]
        [Validation(Required=false)]
        public string EffectStatus { get; set; }

        /// <summary>
        /// <para>The approval type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ApprovalReport: approval.</description></item>
        /// <item><description>BackendReport: backend approval.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>BackendReport</para>
        /// </summary>
        [NameInMap("ReportType")]
        [Validation(Required=false)]
        public string ReportType { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>D6707286-A50E-57B1-B2CF-EFAC59E8****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
