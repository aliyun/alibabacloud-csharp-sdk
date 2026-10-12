// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class UpdateGatewayMaintenancePeriodRequest : TeaModel {
        /// <summary>
        /// <para>The O&amp;M window.</para>
        /// </summary>
        [NameInMap("maintenancePeriod")]
        [Validation(Required=false)]
        public UpdateGatewayMaintenancePeriodRequestMaintenancePeriod MaintenancePeriod { get; set; }
        public class UpdateGatewayMaintenancePeriodRequestMaintenancePeriod : TeaModel {
            /// <summary>
            /// <para>The O&amp;M end time (HH:mm).</para>
            /// 
            /// <b>Example:</b>
            /// <para>02:00</para>
            /// </summary>
            [NameInMap("endTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>The O&amp;M start time (HH:mm).</para>
            /// 
            /// <b>Example:</b>
            /// <para>02:00</para>
            /// </summary>
            [NameInMap("startTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

        }

    }

}
