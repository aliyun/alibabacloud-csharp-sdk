// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class CreatePlanMaintenanceWindowResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the created O&amp;M window.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pw-bp1a9yavgq3dgttvowun</para>
        /// </summary>
        [NameInMap("PlanWindowId")]
        [Validation(Required=false)]
        public string PlanWindowId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7D5B1188-3F08-56D1-A6B2-91B267452633</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
