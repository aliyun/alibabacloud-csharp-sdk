// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicecatalog20210901.Models
{
    public class ApproveProvisionedProductPlanRequest : TeaModel {
        /// <summary>
        /// <para>The review action. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Approve</description></item>
        /// <item><description>Reject</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Approve</para>
        /// </summary>
        [NameInMap("ApprovalAction")]
        [Validation(Required=false)]
        public string ApprovalAction { get; set; }

        /// <summary>
        /// <para>The review description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Approved. You can create a resource.</para>
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <para>The ID of the plan.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>plan-bp1jvmdk2k****</para>
        /// </summary>
        [NameInMap("PlanId")]
        [Validation(Required=false)]
        public string PlanId { get; set; }

    }

}
