// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class GetQuotaUsageRequest : TeaModel {
        /// <summary>
        /// <para>The aggregation algorithm. For a better page experience, up to 60 points can be displayed for each metric. If you select a time range longer than 1 hour, the chart uses the average value within the range (minutes of the selected time range/60) to aggregate data by default. You can change the aggregation algorithm based on your business requirements.</para>
        /// 
        /// <b>Example:</b>
        /// <para>max</para>
        /// </summary>
        [NameInMap("aggMethod")]
        [Validation(Required=false)]
        public string AggMethod { get; set; }

        /// <summary>
        /// <para>The time when the query starts. The value is the log time that is specified when log data is written.</para>
        /// <list type="bullet">
        /// <item><description>The time range that is specified in this operation is a left-closed, right-open interval. The interval includes the start time specified by the <b>from</b> parameter, but does not include the end time specified by the <b>to</b> parameter. If you set the <b>from</b> and <b>to</b> parameters to the same value, the time range is invalid and an error message is returned.</description></item>
        /// <item><description>This value is a UNIX timestamp representing the number of seconds that have elapsed since January 1, 1970, 00:00:00 UTC.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1669081045</para>
        /// </summary>
        [NameInMap("from")]
        [Validation(Required=false)]
        public long? From { get; set; }

        /// <summary>
        /// <para>The types of the charts.</para>
        /// </summary>
        [NameInMap("plotTypes")]
        [Validation(Required=false)]
        public List<string> PlotTypes { get; set; }

        /// <summary>
        /// <para>The quota type. Default value: ODPS.</para>
        /// <list type="bullet">
        /// <item><description>ODPS: computing quota</description></item>
        /// <item><description>TUNNEL: Tunnel quota</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ODPS</para>
        /// </summary>
        [NameInMap("productId")]
        [Validation(Required=false)]
        public string ProductId { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-chengdu</para>
        /// </summary>
        [NameInMap("region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// <para>The alias of the level-2 quota.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ot_tunnel_quota</para>
        /// </summary>
        [NameInMap("subQuotaNickname")]
        [Validation(Required=false)]
        public string SubQuotaNickname { get; set; }

        /// <summary>
        /// <para>The ID of the tenant. You can log on to the MaxCompute console, and choose Tenants &gt; Tenant Property from the left-side navigation pane to view the tenant ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>478403690625249</para>
        /// </summary>
        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        /// <summary>
        /// <para>The time when the query ends. The value is the log time that is specified when log data is written.</para>
        /// <list type="bullet">
        /// <item><description>The time range that is specified in this operation is a left-closed, right-open interval. The interval includes the start time specified by the <b>from</b> parameter, but does not include the end time specified by the <b>to</b> parameter. If you set the <b>from</b> and <b>to</b> parameters to the same value, the time range is invalid and an error message is returned.</description></item>
        /// <item><description>This value is a UNIX timestamp representing the number of seconds that have elapsed since January 1, 1970, 00:00:00 UTC.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1669360870</para>
        /// </summary>
        [NameInMap("to")]
        [Validation(Required=false)]
        public long? To { get; set; }

        /// <summary>
        /// <para>The data metric fields.</para>
        /// </summary>
        [NameInMap("yAxisTypes")]
        [Validation(Required=false)]
        public List<string> YAxisTypes { get; set; }

    }

}
