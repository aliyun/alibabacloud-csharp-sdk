// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Nis20211216.Models
{
    public class GetInternetTupleShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of member accounts.</para>
        /// </summary>
        [NameInMap("AccountIds")]
        [Validation(Required=false)]
        public List<long?> AccountIds { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1684373600099</para>
        /// </summary>
        [NameInMap("BeginTime")]
        [Validation(Required=false)]
        public long? BeginTime { get; set; }

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
        /// <para>The local IP addresses for filtering.</para>
        /// </summary>
        [NameInMap("CloudIpList")]
        [Validation(Required=false)]
        public string CloudIpListShrink { get; set; }

        /// <summary>
        /// <para>The local Internet service provider (ISP).</para>
        /// <remarks>
        /// <para> In most cases, the value is Alibaba or Alibaba Cloud.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Alibaba</para>
        /// </summary>
        [NameInMap("CloudIsp")]
        [Validation(Required=false)]
        public string CloudIsp { get; set; }

        /// <summary>
        /// <para>The local port.</para>
        /// <remarks>
        /// <para> This parameter is required only if you set GroupBy to CloudPort.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>443</para>
        /// </summary>
        [NameInMap("CloudPort")]
        [Validation(Required=false)]
        public string CloudPort { get; set; }

        /// <summary>
        /// <para>The direction of the Internet traffic that you want to query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>in</b>: inbound</description></item>
        /// <item><description><b>out</b>: outbound</description></item>
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
        /// <para>The end of the time range to query. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1684373700099</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eip-sample*</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The instance IDs for filtering.</para>
        /// </summary>
        [NameInMap("InstanceList")]
        [Validation(Required=false)]
        public string InstanceListShrink { get; set; }

        /// <summary>
        /// <para>The metric for data ranking. Default value: <b>ByteCount</b>. This value indicates that Internet traffic data is ranked by traffic volume.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Rtt</description></item>
        /// <item><description>ByteCount</description></item>
        /// <item><description>PacketCount</description></item>
        /// <item><description>RetransmitRate</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ByteCount</para>
        /// </summary>
        [NameInMap("OrderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        /// <summary>
        /// <para>The remote city.</para>
        /// <remarks>
        /// <para> This parameter is required only if you set <b>TupleType</b> to <b>2</b> or <b>5</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Hangzhou</para>
        /// </summary>
        [NameInMap("OtherCity")]
        [Validation(Required=false)]
        public string OtherCity { get; set; }

        /// <summary>
        /// <para>The remote country.</para>
        /// <remarks>
        /// <para> This parameter is required only if you set <b>TupleType</b> to <b>2</b> or <b>5</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>China</para>
        /// </summary>
        [NameInMap("OtherCountry")]
        [Validation(Required=false)]
        public string OtherCountry { get; set; }

        /// <summary>
        /// <para>The remote IP address.</para>
        /// <remarks>
        /// <para>This parameter is required only when you set <b>TupleType</b> to <b>2</b> or <b>5</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>122.112.XX.XX</para>
        /// </summary>
        [NameInMap("OtherIp")]
        [Validation(Required=false)]
        public string OtherIp { get; set; }

        /// <summary>
        /// <para>The remote ISP.</para>
        /// <remarks>
        /// <para>This parameter is required if you want to view the information about the remote ISP.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>China Mobile</para>
        /// </summary>
        [NameInMap("OtherIsp")]
        [Validation(Required=false)]
        public string OtherIsp { get; set; }

        /// <summary>
        /// <para>The remote port.</para>
        /// <remarks>
        /// <para>This parameter is required only when you set <b>TupleType</b> to <b>5</b>.</para>
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
        /// <para>All protocols are supported. This parameter is required only when you set <b>TupleType</b> to <b>5</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("Protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

        /// <summary>
        /// <para>The ID of the region for which you want to query the Internet traffic.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The order in which instances are ranked by Internet traffic. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>desc</b>: the descending order</description></item>
        /// <item><description><b>asc</b>: the ascending order</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>desc</para>
        /// </summary>
        [NameInMap("Sort")]
        [Validation(Required=false)]
        public string Sort { get; set; }

        /// <summary>
        /// <para>Specifies top-N traffic data to display. Default value: <b>10</b>. This value specifies to display top-10 traffic data by default. Max value: <b>100</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TopN")]
        [Validation(Required=false)]
        public int? TopN { get; set; }

        /// <summary>
        /// <para>The type of the tuple. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: 1-tuple</description></item>
        /// <item><description><b>2</b>: 2-tuple</description></item>
        /// <item><description><b>5</b>: 5-tuple</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TupleType")]
        [Validation(Required=false)]
        public int? TupleType { get; set; }

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
