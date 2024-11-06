// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnIpaUserDomainsRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to display domain names that are under review, failed the review, or failed to be configured. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("CheckDomainShow")]
        [Validation(Required=false)]
        public bool? CheckDomainShow { get; set; }

        /// <summary>
        /// <para>The domain name that is used as a keyword to filter domain names. Fuzzy match is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The search method. Default value: full_match. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>fuzzy_match</b>: fuzzy match</description></item>
        /// <item><description><b>pre_match</b>: prefix match</description></item>
        /// <item><description><b>suf_match</b>: suffix match</description></item>
        /// <item><description><b>full_match</b>: exact match</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>fuzzy_match</para>
        /// </summary>
        [NameInMap("DomainSearchType")]
        [Validation(Required=false)]
        public string DomainSearchType { get; set; }

        /// <summary>
        /// <para>The status of the domain name. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>online</b>: enabled</description></item>
        /// <item><description><b>offline</b>: disabled</description></item>
        /// <item><description><b>configuring</b>: configuring</description></item>
        /// <item><description><b>configure_failed</b>: configuration failed</description></item>
        /// <item><description><b>checking</b>: reviewing</description></item>
        /// <item><description><b>check_failed:</b> review failed</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>online</para>
        /// </summary>
        [NameInMap("DomainStatus")]
        [Validation(Required=false)]
        public string DomainStatus { get; set; }

        /// <summary>
        /// <para>The status of the feature.</para>
        /// <list type="bullet">
        /// <item><description>config: The feature is enabled.</description></item>
        /// <item><description>unconfig: The feature is not enabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>config</para>
        /// </summary>
        [NameInMap("FuncFilter")]
        [Validation(Required=false)]
        public string FuncFilter { get; set; }

        /// <summary>
        /// <para>The ID of the feature. For example, a value of 7 specifies the feature of configuring an expiration rule for a specific directory. For more information about feature IDs, see <a href="https://help.aliyun.com/document_detail/410622.html">Parameters for configuring features for domain names</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("FuncId")]
        [Validation(Required=false)]
        public string FuncId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The page number. Valid values: <b>1</b> to <b>100000</b>. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of domain names per page. Default value: <b>20</b>.**** Valid values: <b>1</b> to <b>500</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>abcd1234abcd****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The tags of the command.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeDcdnIpaUserDomainsRequestTag> Tag { get; set; }
        public class DescribeDcdnIpaUserDomainsRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key. Valid values of N: 1 to 20. You can call the TagDcdnResources operation to set a tag for a domain name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value. Valid values of N: 1 to 20.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
