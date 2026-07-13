// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeRecordResolveStatisticsSummaryRequest : TeaModel {
        /// <summary>
        /// <para>The sorting direction. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>DESC: descending order (default)</para>
        /// </description></item>
        /// <item><description><para>ASC: ascending order</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>DESC</para>
        /// </summary>
        [NameInMap("Direction")]
        [Validation(Required=false)]
        public string Direction { get; set; }

        /// <summary>
        /// <para>The domain name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The type of the domain name. This parameter is not case-sensitive. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>PUBLIC: an authoritative domain name (default)</para>
        /// </description></item>
        /// <item><description><para>CACHE: an authoritative proxy domain name</para>
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
        /// <para>The end date. Specify the date in the YYYY-MM-DD format. For example: 2023-03-13.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-03-29</para>
        /// </summary>
        [NameInMap("EndDate")]
        [Validation(Required=false)]
        public string EndDate { get; set; }

        /// <summary>
        /// <para>The keyword. This parameter is used with SearchMode.</para>
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
        /// <para>The page number. The value starts from 1. The default value is 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. The maximum value is 1000 and the minimum value is 1.</para>
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
        /// <item><description><para>LIKE: fuzzy search (default)</para>
        /// </description></item>
        /// <item><description><para>EXACT: exact match</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>LIKE</para>
        /// </summary>
        [NameInMap("SearchMode")]
        [Validation(Required=false)]
        public string SearchMode { get; set; }

        /// <summary>
        /// <para>The start date. Specify the date in the YYYY-MM-DD format. For example: 2023-03-01.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-03-29</para>
        /// </summary>
        [NameInMap("StartDate")]
        [Validation(Required=false)]
        public string StartDate { get; set; }

        /// <summary>
        /// <para>The resolution count threshold. This parameter lets you query subdomains based on their resolution counts.</para>
        /// <para>If you do not specify this parameter, data for subdomains with a resolution count greater than 0 is returned.</para>
        /// <para>If you specify a value less than 0, all data is returned.</para>
        /// <para>If you specify 0, data for subdomains with a resolution count of 0 is returned.</para>
        /// <para>If you specify a value greater than 0, data for subdomains with a resolution count less than or equal to the specified value is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-1</para>
        /// </summary>
        [NameInMap("Threshold")]
        [Validation(Required=false)]
        public long? Threshold { get; set; }

    }

}
