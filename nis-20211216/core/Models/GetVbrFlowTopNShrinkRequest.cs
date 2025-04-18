// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Nis20211216.Models
{
    public class GetVbrFlowTopNShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of member accounts.</para>
        /// </summary>
        [NameInMap("AccountIds")]
        [Validation(Required=false)]
        public string AccountIdsShrink { get; set; }

        /// <summary>
        /// <para>The CEN connection ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tr-attach-dnv870gmqzmb5u****</para>
        /// </summary>
        [NameInMap("AttachmentId")]
        [Validation(Required=false)]
        public string AttachmentId { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC. The maximum time range that you can query is 24 hours.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1638239092000</para>
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
        /// <para>The local IP address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>112.74.XX.XX</para>
        /// </summary>
        [NameInMap("CloudIp")]
        [Validation(Required=false)]
        public string CloudIp { get; set; }

        /// <summary>
        /// <para>The local port.</para>
        /// <remarks>
        /// <para> This parameter is required only if you set <b>GroupBy</b> to <b>CloudPort</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>443</para>
        /// </summary>
        [NameInMap("CloudPort")]
        [Validation(Required=false)]
        public string CloudPort { get; set; }

        /// <summary>
        /// <para>The direction of the hybrid cloud traffic in the local regions or for the local IP addresses. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>in</b>: traffic from a data center to Alibaba Cloud</description></item>
        /// <item><description><b>out</b>: traffic from Alibaba Cloud to a data center</description></item>
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
        /// <para>The dimension for ranking hybrid cloud traffic data. The value of this parameter is case-sensitive. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1Tuple</b>: queries the rankings of hybrid cloud traffic data for the Cloud Enterprise Network (CEN) instances, CEN connections, virtual border routers (VBRs), and IP addresses.</description></item>
        /// <item><description><b>2Tuple</b>: queries the rankings of hybrid cloud traffic data for the local and remote IP addresses.</description></item>
        /// <item><description><b>5Tuple</b>: queries the rankings of hybrid cloud traffic data for the local and remote IP addresses, local and remote ports, and protocols.</description></item>
        /// <item><description><b>CloudPort</b>: queries the rankings of hybrid cloud traffic data for the local ports.</description></item>
        /// <item><description><b>OtherPort</b>: queries the rankings of hybrid cloud traffic data for the remote ports.</description></item>
        /// <item><description><b>Protocol</b>: queries the rankings of hybrid cloud traffic data for the protocols.</description></item>
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
        /// <para>The metric for ranking hybrid cloud traffic data. Default value: Bytes. This value specifies that hybrid cloud traffic data is ranked by traffic volumes.</para>
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
        /// <remarks>
        /// <para> This parameter is required only if you set <b>GroupBy</b> to <b>OtherPort</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>40002</para>
        /// </summary>
        [NameInMap("OtherPort")]
        [Validation(Required=false)]
        public string OtherPort { get; set; }

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
        /// <para>The local region.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The order for ranking hybrid cloud traffic data. Valid values:</para>
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
        /// <para>Specifies top-N traffic data to display. Default value: <b>10</b>. This value specifies that top-10 traffic data is displayed by default. Maximum value: <b>100</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
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

        /// <summary>
        /// <para>The ID of the VBR that is associated with the Express Connect circuit.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vbr-k1atj46citwuek42j****</para>
        /// </summary>
        [NameInMap("VirtualBorderRouterId")]
        [Validation(Required=false)]
        public string VirtualBorderRouterId { get; set; }

    }

}
