// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribePdnsRequestStatisticRequest : TeaModel {
        /// <summary>
        /// <para>The primary domain name whose statistics you want to query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. Specify the time in the <b>YYYY-MM-DD</b> format.</para>
        /// <para>The default value is the day when you query the data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-7-1 00:00:00</para>
        /// </summary>
        [NameInMap("EndDate")]
        [Validation(Required=false)]
        public string EndDate { get; set; }

        /// <summary>
        /// <para>The language of the content within the request and response. Default value: <b>zh</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese</description></item>
        /// <item><description><b>en</b>: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. Specify the time in the <b>YYYY-MM-DD</b> format.</para>
        /// <para>You can query only records of the last 90 days.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-06-14 00:00:00</para>
        /// </summary>
        [NameInMap("StartDate")]
        [Validation(Required=false)]
        public string StartDate { get; set; }

        /// <summary>
        /// <para>The subdomain name whose statistics you want to query.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://www.example.com">www.example.com</a></para>
        /// </summary>
        [NameInMap("SubDomain")]
        [Validation(Required=false)]
        public string SubDomain { get; set; }

        /// <summary>
        /// <para>The type of the request statistics that you want to query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ACCOUNT</b>: queries the request statistics by account.</description></item>
        /// <item><description><b>DOMAIN</b>: queries the request statistics by domain name.</description></item>
        /// <item><description><b>SUB_DOMAIN</b>: queries the request statistics by subdomain name.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ACCOUNT</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
