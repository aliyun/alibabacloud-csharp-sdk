// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveDomainTrafficDataRequest : TeaModel {
        /// <summary>
        /// <para>The streaming domain. You can specify a single domain name or multiple domain names. Separate multiple domain names with commas (,). If this parameter is left empty, the merged data of all live streaming domains is returned by default.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>When you specify DomainName, make sure that the specified domain names are live streaming domains and that you have the required permissions to operate on the specified domain names.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The end time. The end time must be later than the start time. Specify the time in the <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z format in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2017-12-10T15:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The time granularity for querying data. Unit: seconds. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>300</b> (default).</description></item>
        /// <item><description><b>3600</b>.</description></item>
        /// <item><description><b>86400</b>.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If you do not set this parameter or set it to an unsupported value, the default value <b>300</b> seconds is used.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>300</para>
        /// </summary>
        [NameInMap("Interval")]
        [Validation(Required=false)]
        public string Interval { get; set; }

        /// <summary>
        /// <para>The name of the Internet service provider (ISP) in English. You can call the <a href="https://help.aliyun.com/document_detail/91077.html">DescribeCdnRegionAndIsp</a> operation to obtain the ISP name. If you do not set this parameter, data of all ISPs is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alibaba</para>
        /// </summary>
        [NameInMap("IspNameEn")]
        [Validation(Required=false)]
        public string IspNameEn { get; set; }

        /// <summary>
        /// <para>The name of the region in English. You can call the <a href="https://help.aliyun.com/document_detail/91077.html">DescribeCdnRegionAndIsp</a> operation to obtain the region name. If you do not set this parameter, data of all regions is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tianjin</para>
        /// </summary>
        [NameInMap("LocationNameEn")]
        [Validation(Required=false)]
        public string LocationNameEn { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The start time. Specify the time in the <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z format in UTC.</para>
        /// <remarks>
        /// <para>You can query data from the past <b>90</b> days.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2017-12-10T14:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
