// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribePdnsRequestStatisticRequest : TeaModel {
        /// <summary>
        /// <para>The primary domain name for which you want to query statistics.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The end date of the query in the <b>YYYY-MM-DD</b> format.</para>
        /// <para>The default value is the current day.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-07-01</para>
        /// </summary>
        [NameInMap("EndDate")]
        [Validation(Required=false)]
        public string EndDate { get; set; }

        /// <summary>
        /// <para>The language of the request and response. The default value is <b>zh</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>zh</b>: Chinese</para>
        /// </description></item>
        /// <item><description><para><b>en</b>: English</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The start date of the query in the <b>YYYY-MM-DD</b> format.</para>
        /// <para>You can query data from the last 90 days.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-06-14</para>
        /// </summary>
        [NameInMap("StartDate")]
        [Validation(Required=false)]
        public string StartDate { get; set; }

        /// <summary>
        /// <para>The subdomain for which you want to query statistics.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://www.example.com">www.example.com</a></para>
        /// </summary>
        [NameInMap("SubDomain")]
        [Validation(Required=false)]
        public string SubDomain { get; set; }

        /// <summary>
        /// <para>The dimension for statistics. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>ACCOUNT</b>: queries statistics by account.</para>
        /// </description></item>
        /// <item><description><para><b>DOMAIN</b>: queries statistics by domain name. The DomainName parameter is required.</para>
        /// </description></item>
        /// <item><description><para><b>SUB_DOMAIN</b>: queries statistics by subdomain. The DomainName and SubDomain parameters are required.</para>
        /// </description></item>
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
