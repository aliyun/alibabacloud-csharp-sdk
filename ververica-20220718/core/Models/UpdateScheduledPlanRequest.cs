// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class UpdateScheduledPlanRequest : TeaModel {
        /// <summary>
        /// <para>The data structure of the scheduled plan to be updated.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public ScheduledPlan Body { get; set; }

    }

}
