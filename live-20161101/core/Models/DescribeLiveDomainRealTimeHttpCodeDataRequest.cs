// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveDomainRealTimeHttpCodeDataRequest : TeaModel {
        /// <summary>
        /// <para>The streaming domain.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>When you specify DomainName, make sure that the domain name is a live streaming domain and that the caller has the required permissions on the domain name.</description></item>
        /// <item><description>Separate multiple domain names with commas (,).</description></item>
        /// </list>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com,example.aliyundoc.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The end time. The end time must be later than the start time. Specify the time in the <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z format (UTC).</para>
        /// <remarks>
        /// <para>If both StartTime and EndTime are left empty, data within the last <b>1</b> hour from the current time is returned by default.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2015-11-30T05:40:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The name of the Internet service provider (ISP) in English.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/448109.html">DescribeCdnRegionAndIsp</a> operation to obtain the ISP name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alibaba</para>
        /// </summary>
        [NameInMap("IspNameEn")]
        [Validation(Required=false)]
        public string IspNameEn { get; set; }

        /// <summary>
        /// <para>The name of the region in English.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/448109.html">DescribeCdnRegionAndIsp</a> operation to obtain the region name.</para>
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
        /// <para>The start time. Specify the time in the <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z format (UTC).</para>
        /// <remarks>
        /// <para>If both StartTime and EndTime are left empty, data within the last <b>1</b> hour from the current time is returned by default.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2015-11-30T05:39:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
