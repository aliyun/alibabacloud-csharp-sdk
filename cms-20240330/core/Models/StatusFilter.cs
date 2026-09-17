// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class StatusFilter : TeaModel {
        /// <summary>
        /// <para>The exact match condition for the alert status. Only alert rules whose status equals the specified value are returned. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Alarm: The alert rule is in the alerting state.</description></item>
        /// <item><description>Ok: The alert rule is in the normal state.</description></item>
        /// <item><description>InsufficientData: Insufficient data is available.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Alarm</para>
        /// </summary>
        [NameInMap("eq")]
        [Validation(Required=false)]
        public string Eq { get; set; }

    }

}
