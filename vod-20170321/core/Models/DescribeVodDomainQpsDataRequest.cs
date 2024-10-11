// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DescribeVodDomainQpsDataRequest : TeaModel {
        /// <summary>
        /// <para>You can specify multiple domain names and separate them with commas (,). You can specify a maximum of 500 domain names in each call.</para>
        /// <para>By default, this operation queries the number and proportions of HTTP status codes for all accelerated domain names that belong to your Alibaba Cloud account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. Specify the time in the ISO 8601 standard in the <em>yyyy-MM-dd**THH:mm:ssZ</em> format. The time must be in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-05-02T15:59:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The interval at which to return data. Unit: seconds. Valid values: <b>300</b>, <b>3600</b>, and <b>86400</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>300</para>
        /// </summary>
        [NameInMap("Interval")]
        [Validation(Required=false)]
        public string Interval { get; set; }

        /// <summary>
        /// <para>The name of the Internet service provider (ISP). If you leave this parameter empty, data of all ISPs is queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>unicom</para>
        /// </summary>
        [NameInMap("IspNameEn")]
        [Validation(Required=false)]
        public string IspNameEn { get; set; }

        /// <summary>
        /// <para>The name of the region. If you leave this parameter empty, data in all regions is queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>beijing</para>
        /// </summary>
        [NameInMap("LocationNameEn")]
        [Validation(Required=false)]
        public string LocationNameEn { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. Specify the time in the ISO 8601 standard in the <em>yyyy-MM-dd**THH:mm:ssZ</em> format. The time must be in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-05-02T15:50:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
