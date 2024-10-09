// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class ScheduledPlanExecutedStatus : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>HOT_UPDATE</para>
        /// </summary>
        [NameInMap("restartType")]
        [Validation(Required=false)]
        public string RestartType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>UPGRADED</para>
        /// </summary>
        [NameInMap("statusState")]
        [Validation(Required=false)]
        public string StatusState { get; set; }

    }

}
