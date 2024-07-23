// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class GetAutoIncrementUsageStatisticRequest : TeaModel {
        /// <summary>
        /// <para>The database name. If you specify a database, the operation queries the usage of auto-increment table IDs in the specified database. Otherwise, the operation queries the usage of auto-increment table IDs in all databases on the instance.</para>
        /// <remarks>
        /// <para> Specify the parameter value as a JSON array, such as [\&quot;db1\&quot;,\&quot;db2\&quot;]. Separate multiple database names with commas (,).</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[\&quot;db1\&quot;,\&quot;db2\&quot;]</para>
        /// </summary>
        [NameInMap("DbNames")]
        [Validation(Required=false)]
        public string DbNames { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-2ze8g2am97624****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The usage threshold of auto-increment IDs. Only usage that exceeds the threshold can be returned. Valid values are decimals that range from 0 to 1.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.9</para>
        /// </summary>
        [NameInMap("RatioFilter")]
        [Validation(Required=false)]
        public double? RatioFilter { get; set; }

        /// <summary>
        /// <para>Specifies whether to query real-time data. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: queries data in real time except for data generated in the last 10 minutes.****</description></item>
        /// <item><description><b>false</b>: queries data generated in the last 2 hours. If no such data exists, queries the latest data.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("RealTime")]
        [Validation(Required=false)]
        public bool? RealTime { get; set; }

    }

}
