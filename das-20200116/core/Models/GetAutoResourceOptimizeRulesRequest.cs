// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class GetAutoResourceOptimizeRulesRequest : TeaModel {
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
        /// <item><description><para>Specify the parameter value as a JSON array, such as <c>[\\&quot;Database account 1\\&quot;,\\&quot;Database account 2\\&quot;]</c>. Separate database instance IDs with commas (,).</para>
        /// </description></item>
        /// <item><description><para>By default, if you leave this parameter empty, all database instances for which the automatic fragment recycling feature has been enabled within the current Alibaba Cloud account are returned. The following types of database instances are returned:</para>
        /// <list type="bullet">
        /// <item><description>Database instances for which the automatic fragment recycling feature is currently enabled.</description></item>
        /// <item><description>Database instances for which the automatic fragment recycling feature was once enabled but is currently disabled, including those for which DAS Enterprise Edition has been disabled but excluding those that have been released.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>[\&quot;rm-2ze8g2am97624****\&quot;,\&quot;rm-2vc54m2a6pd6p****\&quot;,\&quot;rm-2ze9xrhze0709****\&quot;,\&quot;rm-2ze8g2am97627****\&quot;]</para>
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public string InstanceIds { get; set; }

    }

}
