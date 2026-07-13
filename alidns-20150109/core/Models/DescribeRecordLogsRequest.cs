// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeRecordLogsRequest : TeaModel {
        /// <summary>
        /// <para>The domain name.&lt;props=&quot;china&quot;&gt;You can call the <a href="https://help.aliyun.com/document_detail/29751.html">DescribeDomains</a> operation to obtain the domain name.&lt;props=&quot;intl&quot;&gt;You can call the <a href="https://www.alibabacloud.com/help/en/dns/api-alidns-2015-01-09-describedomains">DescribeDomains</a> operation to obtain the domain name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The keyword. The system searches for the keyword in the &quot;%KeyWord%&quot; pattern. The search is not case-sensitive.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("KeyWord")]
        [Validation(Required=false)]
        public string KeyWord { get; set; }

        /// <summary>
        /// <para>The language of the request and response. Default value: <b>zh</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>zh</b>: Chinese</para>
        /// </description></item>
        /// <item><description><para><b>en</b>: English</para>
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
        /// <para>The page number. The value starts from <b>1</b>. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. The maximum value is <b>100</b>. Default value: <b>20</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The start of the time range to query. The format is <b>YYYY-MM-DD</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2015-12-12</para>
        /// </summary>
        [NameInMap("StartDate")]
        [Validation(Required=false)]
        public string StartDate { get; set; }

        /// <summary>
        /// <para>The client IP address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.0.2.1</para>
        /// </summary>
        [NameInMap("UserClientIp")]
        [Validation(Required=false)]
        public string UserClientIp { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. The format is <b>YYYY-MM-DD</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2015-12-12</para>
        /// </summary>
        [NameInMap("endDate")]
        [Validation(Required=false)]
        public string EndDate { get; set; }

    }

}
