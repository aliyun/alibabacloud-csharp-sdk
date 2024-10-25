// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeEnsRegionIdResourceRequest : TeaModel {
        /// <summary>
        /// <para>The end time of the time range to query. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-06-16T06:33:15</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The Internet service provider (ISP). Valid values:</para>
        /// <list type="bullet">
        /// <item><description>cmcc: China Mobile</description></item>
        /// <item><description>telecom: China Telecom</description></item>
        /// <item><description>unicom: China Unicom</description></item>
        /// <item><description>multiCarrier: multi-line ISP</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cmcc</para>
        /// </summary>
        [NameInMap("Isp")]
        [Validation(Required=false)]
        public string Isp { get; set; }

        /// <summary>
        /// <para>The order in which the resources to return are sorted. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>InstanceCount: desc</description></item>
        /// <item><description>Area: asc</description></item>
        /// <item><description>InternetBandwidth: asc</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>InstanceCount: desc</para>
        /// </summary>
        [NameInMap("OrderByParams")]
        [Validation(Required=false)]
        public string OrderByParams { get; set; }

        /// <summary>
        /// <para>The page number. Pages start from page <b>1</b>. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Maximum value: <b>100</b>. Default value: <b>10</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-06-16T06:33:15Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
