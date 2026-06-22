// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeDomainListRequest : TeaModel {
        /// <summary>
        /// <para>The page number of the page to return in a paged query. Default value: <b>1</b>, which indicates that the first page is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The type of the domain name to query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>root</b>: root domain name</description></item>
        /// <item><description><b>sub</b>: subdomain name.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>root</para>
        /// </summary>
        [NameInMap("DomainType")]
        [Validation(Required=false)]
        public string DomainType { get; set; }

        /// <summary>
        /// <para>The search keyword for the domain name to query. Fuzzy match is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sas</para>
        /// </summary>
        [NameInMap("FuzzyDomain")]
        [Validation(Required=false)]
        public string FuzzyDomain { get; set; }

        /// <summary>
        /// <para>The number of domain names to display on each page in a paged query. Default value: <b>10</b>, which indicates that 10 domain names are displayed on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The IP address of the access source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.122.XX.XX</para>
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

    }

}
