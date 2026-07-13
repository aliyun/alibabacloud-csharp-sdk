// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeRecordStatisticsRequest : TeaModel {
        /// <summary>
        /// <para>The primary domain name.
        /// &lt;props=&quot;china&quot;&gt;For more information, see <a href="https://help.aliyun.com/document_detail/29751.html">DescribeDomains</a>.
        /// &lt;props=&quot;intl&quot;&gt;For more information, see <a href="https://www.alibabacloud.com/help/en/dns/api-alidns-2015-01-09-describedomains">DescribeDomains</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>exmaple.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The type of the domain name. This parameter is not case-sensitive. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>PUBLIC (default): authoritative domain name</para>
        /// </description></item>
        /// <item><description><para>CACHE: authoritative proxy domain name</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PUBLIC</para>
        /// </summary>
        [NameInMap("DomainType")]
        [Validation(Required=false)]
        public string DomainType { get; set; }

        /// <summary>
        /// <para>The end date of the query. The format is <b>YYYY-MM-DD</b>.</para>
        /// <para>The default value is the current date.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-07-04</para>
        /// </summary>
        [NameInMap("EndDate")]
        [Validation(Required=false)]
        public string EndDate { get; set; }

        /// <summary>
        /// <para>The language of the return value. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>zh (default): Chinese</para>
        /// </description></item>
        /// <item><description><para>en: English</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The host record. For example, to resolve www\.example.com, set this parameter to www.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>www</para>
        /// </summary>
        [NameInMap("Rr")]
        [Validation(Required=false)]
        public string Rr { get; set; }

        /// <summary>
        /// <para>The start date of the query. The format is <b>YYYY-MM-DD</b>.</para>
        /// <para>The start date must be within the last 90 days.</para>
        /// <para>If the time range of the query is 7 days or less, data is returned by the hour.</para>
        /// <para>If the time range of the query is more than 7 days, data is returned by the day.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-07-04</para>
        /// </summary>
        [NameInMap("StartDate")]
        [Validation(Required=false)]
        public string StartDate { get; set; }

    }

}
