// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class ViewOncallScheduleResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>8FDE2569-626B-5176-9844-28877A*****</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;testName&quot;:[{&quot;contactId&quot;:&quot;testId&quot;,&quot;contactName&quot;:&quot;张三&quot;,&quot;start&quot;:&quot;2024-10-10 09:00&quot;,&quot;end&quot;:&quot;2024-10-15 18:00&quot;}]}</para>
        /// </summary>
        [NameInMap("schedule")]
        [Validation(Required=false)]
        public Dictionary<string, List<ScheduleValue>> Schedule { get; set; }

    }

}
