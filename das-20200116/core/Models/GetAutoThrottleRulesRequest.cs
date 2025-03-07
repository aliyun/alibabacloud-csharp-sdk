// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class GetAutoThrottleRulesRequest : TeaModel {
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
        /// <list type="bullet">
        /// <item><description><para>Set this parameter to a JSON array that consists of multiple instance IDs. Separate instance IDs with commas (,). Example: <c>[\\&quot;Instance ID1\\&quot;,\\&quot;Instance ID2\\&quot;]</c>.</para>
        /// </description></item>
        /// <item><description><para>By default, if you leave this parameter empty, all database instances for which the automatic SQL throttling feature has been enabled within the current Alibaba Cloud account are returned. The following types of database instances are returned:</para>
        /// <list type="bullet">
        /// <item><description>Database instances for which the automatic SQL throttling feature is currently enabled.</description></item>
        /// <item><description>Database instances for which the automatic SQL throttling feature was once enabled but is currently disabled. Released database instances are not included.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>[\&quot;rm-2ze8g2am97624****\&quot;,\&quot;rm-2vc54m2a6pd6p****\&quot;,\&quot;rm-2ze9xrhze0709****\&quot;]</para>
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public string InstanceIds { get; set; }

    }

}
