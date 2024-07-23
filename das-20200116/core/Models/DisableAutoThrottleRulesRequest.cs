// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class DisableAutoThrottleRulesRequest : TeaModel {
        /// <summary>
        /// <para>The reserved parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("ConsoleContext")]
        [Validation(Required=false)]
        public string ConsoleContext { get; set; }

        /// <summary>
        /// <para>The database instance IDs.</para>
        /// <remarks>
        /// <para> Set this parameter to a JSON array that consists of multiple instance IDs. Separate instance IDs with commas (,). Example: <c>[\\&quot;Instance ID1\\&quot;,\\&quot;Instance ID2\\&quot;]</c>.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[\&quot;rm-2ze8g2am97624****\&quot;,\&quot;rm-2ze9xrhze0709****\&quot;]</para>
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public string InstanceIds { get; set; }

    }

}
