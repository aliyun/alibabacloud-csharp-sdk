// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Nis20211216.Models
{
    public class GetTransitRouterFlowTopNRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of the member accounts.</para>
        /// </summary>
        [NameInMap("AccountIds")]
        [Validation(Required=false)]
        public List<long?> AccountIds { get; set; }

        /// <summary>
        /// <para>The ID of the CEN bandwidth plan.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cenbwp-ia8kw1zjv4hyal*****</para>
        /// </summary>
        [NameInMap("BandwithPackageId")]
        [Validation(Required=false)]
        public string BandwithPackageId { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC. The maximum time range that you can query is 24 hours.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1684373600099</para>
        /// </summary>
        [NameInMap("BeginTime")]
        [Validation(Required=false)]
        public long? BeginTime { get; set; }

        /// <summary>
        /// <para>The CEN instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cen-ia8kw1zjv4hyal****</para>
        /// </summary>
        [NameInMap("CenId")]
        [Validation(Required=false)]
        public string CenId { get; set; }

        /// <summary>
        /// <para>The direction of the inter-region traffic in the local regions or for the local IP addresses. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>in</b>: inbound traffic</description></item>
        /// <item><description><b>out</b>: outbound traffic</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>in</para>
        /// </summary>
        [NameInMap("Direction")]
        [Validation(Required=false)]
        public string Direction { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC. The maximum time range that you can query is 24 hours.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1638239093000</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The dimension for ranking inter-region traffic data. The value of this parameter is case-sensitive. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1Tuple</b>: queries the rankings of inter-region traffic data for the local regions, Cloud Enterprise Network (CEN) instances, and IP addresses.</description></item>
        /// <item><description><b>2Tuple</b>: queries the rankings of inter-region traffic data for the local and remote regions, and the local and remote IP addresses.</description></item>
        /// <item><description><b>5Tuple</b>: queries the rankings of inter-region traffic data for the local and remote IP addresses, local and remote ports, and protocols.</description></item>
        /// <item><description><b>Cen</b>: queries the rankings of inter-region traffic data for CEN instances.</description></item>
        /// <item><description><b>RegionPair</b>: queries the rankings of inter-region traffic data for the local and remote regions.</description></item>
        /// <item><description><b>Port</b>: queries the rankings of inter-region traffic data for the local and remote ports.</description></item>
        /// <item><description><b>Protocol</b>: queries the rankings of inter-region traffic data for the protocols.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1Tuple</para>
        /// </summary>
        [NameInMap("GroupBy")]
        [Validation(Required=false)]
        public string GroupBy { get; set; }

        /// <summary>
        /// <para>The metric for ranking inter-region traffic data. Default value: Bytes. This value specifies that inter-region traffic data is ranked by traffic volume.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Bytes</para>
        /// </summary>
        [NameInMap("OrderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        /// <summary>
        /// <para>The remote IP address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>122.112.XX.XX</para>
        /// </summary>
        [NameInMap("OtherIp")]
        [Validation(Required=false)]
        public string OtherIp { get; set; }

        /// <summary>
        /// <para>The remote port.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10869</para>
        /// </summary>
        [NameInMap("OtherPort")]
        [Validation(Required=false)]
        public string OtherPort { get; set; }

        /// <summary>
        /// <para>The remote region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ap-southeast-1</para>
        /// </summary>
        [NameInMap("OtherRegion")]
        [Validation(Required=false)]
        public string OtherRegion { get; set; }

        /// <summary>
        /// <para>The protocol number.</para>
        /// <remarks>
        /// <para> All protocols are supported. This parameter is required only if you set <b>GroupBy</b> to <b>5Tuple</b> or <b>Protocol</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("Protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

        /// <summary>
        /// <para>The order for ranking inter-region traffic data. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>desc</b>: descending order</description></item>
        /// <item><description><b>asc</b>: ascending order</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>desc</para>
        /// </summary>
        [NameInMap("Sort")]
        [Validation(Required=false)]
        public string Sort { get; set; }

        /// <summary>
        /// <para>The local IP address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.8.XX.XX</para>
        /// </summary>
        [NameInMap("ThisIp")]
        [Validation(Required=false)]
        public string ThisIp { get; set; }

        /// <summary>
        /// <para>The local port.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("ThisPort")]
        [Validation(Required=false)]
        public string ThisPort { get; set; }

        /// <summary>
        /// <para>The local region where the <b>local IP address</b> resides.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("ThisRegion")]
        [Validation(Required=false)]
        public string ThisRegion { get; set; }

        /// <summary>
        /// <para>Specifies the maximum number of data entries to display. Default value: <b>10</b>. Maximum value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("TopN")]
        [Validation(Required=false)]
        public int? TopN { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the multi-account management feature. Default value: <b>false</b>. This value specifies that the multi-account management feature is disabled.</para>
        /// <remarks>
        /// <para> By default, the multi-account management feature is not available. If you want to use this feature, contact your account manager to apply for permissions.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("UseMultiAccount")]
        [Validation(Required=false)]
        public bool? UseMultiAccount { get; set; }

    }

}
