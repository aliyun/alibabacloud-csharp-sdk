// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnWafDomainsRequest : TeaModel {
        /// <summary>
        /// <para>The number of the page to return. Valid values: <b>1</b> to <b>100000</b>.</para>
        /// <para>Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of domain names to return on each page. Valid values: an integer from <b>1</b> to <b>500</b>. Default value: <b>20</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The query conditions. You can filter domain names by name. Fuzzy match is supported <c>QueryArgs={&quot;DomainName&quot;:&quot;Accelerated domain name&quot;}</c></para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;DomainName&quot;:&quot;example.com&quot;}</para>
        /// </summary>
        [NameInMap("QueryArgs")]
        [Validation(Required=false)]
        public string QueryArgs { get; set; }

    }

}
