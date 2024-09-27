// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeDomainResolveStatisticsSummaryRequest : TeaModel {
        /// <summary>
        /// <para>The order in which you want to sort the returned entries. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>DESC: the descending order</description></item>
        /// <item><description>ASC: the ascending order</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>DESC</para>
        /// </summary>
        [NameInMap("Direction")]
        [Validation(Required=false)]
        public string Direction { get; set; }

        /// <summary>
        /// <para>The end time in the yyyy-MM-dd format, for example, 2023-03-13.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-03-01</para>
        /// </summary>
        [NameInMap("EndDate")]
        [Validation(Required=false)]
        public string EndDate { get; set; }

        /// <summary>
        /// <para>The keyword. The Keyword parameter is used together with the SearchMode parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// <para>The language. Valid values: zh, en, and ja.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The number of the page to return. Pages start from page 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Valid values: 1 to 1000.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The search mode of the keyword. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>LIKE (default): fuzzy search</description></item>
        /// <item><description>EXACT: exact search</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>EXACT</para>
        /// </summary>
        [NameInMap("SearchMode")]
        [Validation(Required=false)]
        public string SearchMode { get; set; }

        /// <summary>
        /// <para>The start time in the yyyy-MM-dd format, for example, 2023-03-01.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-03-01</para>
        /// </summary>
        [NameInMap("StartDate")]
        [Validation(Required=false)]
        public string StartDate { get; set; }

        /// <summary>
        /// <para>The threshold for the number of Domain Name System (DNS) requests. You can query the domain names at the specified quantity level of DNS requests and query the number of DNS requests for each domain name.</para>
        /// <para>If you do not specify this parameter, the data about the domain names that have DNS requests is obtained.</para>
        /// <para>If you set this parameter to a value less than 0, the data about all domain names is obtained.</para>
        /// <para>If you set this parameter to 0, the data about the domain names that do not have DNS requests is obtained.</para>
        /// <para>If you set this parameter to a value greater than 0, the data about the domain names whose number of DNS requests is less than or equal to the value of this parameter is obtained.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-1</para>
        /// </summary>
        [NameInMap("Threshold")]
        [Validation(Required=false)]
        public long? Threshold { get; set; }

    }

}
