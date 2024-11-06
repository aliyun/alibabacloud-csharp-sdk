// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnUserDomainsByFuncRequest : TeaModel {
        /// <summary>
        /// <para>The accelerated domain name whose ICP filing status you want to update.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>Specifies whether the feature that is specified by the FuncId parameter is enabled.</para>
        /// <list type="bullet">
        /// <item><description><b>config</b>: enabled</description></item>
        /// <item><description><b>unconfig</b>: not enabled</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>config</para>
        /// </summary>
        [NameInMap("FuncFilter")]
        [Validation(Required=false)]
        public string FuncFilter { get; set; }

        /// <summary>
        /// <para>The ID of the feature. For more information about how to query feature IDs, see <a href="https://help.aliyun.com/document_detail/410622.html">Parameters for configuring features for domain names</a>. For example, the ID of the origin host feature (set_req_host_header) is 18.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("FuncId")]
        [Validation(Required=false)]
        public int? FuncId { get; set; }

        /// <summary>
        /// <para>The type of the search. Default value: exact_match. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>fuzzy_match: fuzzy search.</description></item>
        /// <item><description>exact_match: exact search.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>exact_match</para>
        /// </summary>
        [NameInMap("MatchType")]
        [Validation(Required=false)]
        public string MatchType { get; set; }

        /// <summary>
        /// <para>The number of the page to return. Default value: <b>1</b>. Valid values: <b>1 to 100000</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Default value: <b>20</b>. Valid values: <b>1 to 500</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmyuji4b6r4**</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

    }

}
