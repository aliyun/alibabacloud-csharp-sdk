// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieiap_1_0.Models
{
    public class CtripOrderPushRequest : TeaModel {
        [NameInMap("JourneyId")]
        [Validation(Required=false)]
        public string JourneyId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>&quot;scheduleItem&quot;</para>
        /// </summary>
        [NameInMap("ScheduleItem")]
        [Validation(Required=false)]
        public string ScheduleItem { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>&quot;123456789&quot;</para>
        /// </summary>
        [NameInMap("Uid")]
        [Validation(Required=false)]
        public string Uid { get; set; }

    }

}
