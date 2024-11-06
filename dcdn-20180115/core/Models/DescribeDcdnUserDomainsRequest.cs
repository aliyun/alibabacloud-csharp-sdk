// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnUserDomainsRequest : TeaModel {
        /// <summary>
        /// <para>The end of the time range to query. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC+0.</para>
        /// <remarks>
        /// <para>The end time must be later than the start time.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2018-05-10T14:00:00Z</para>
        /// </summary>
        [NameInMap("ChangeEndTime")]
        [Validation(Required=false)]
        public string ChangeEndTime { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC+0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2018-05-10T12:00:00Z</para>
        /// </summary>
        [NameInMap("ChangeStartTime")]
        [Validation(Required=false)]
        public string ChangeStartTime { get; set; }

        /// <summary>
        /// <para>Specifies whether to display domain names that are under review, failed the review, or failed to be configured. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: displays domain names.</description></item>
        /// <item><description>false: does not display detailed information.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("CheckDomainShow")]
        [Validation(Required=false)]
        public bool? CheckDomainShow { get; set; }

        /// <summary>
        /// <para>The acceleration region. By default, all acceleration regions are queried.</para>
        /// <list type="bullet">
        /// <item><description><b>domestic</b>: Chinese mainland</description></item>
        /// <item><description><b>overseas</b>: outside the Chinese mainland</description></item>
        /// <item><description><b>global</b>: global</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>domestic</para>
        /// </summary>
        [NameInMap("Coverage")]
        [Validation(Required=false)]
        public string Coverage { get; set; }

        /// <summary>
        /// <para>The accelerated domain names. If you do not set this parameter, configurations of all domain names that match the conditions are returned.</para>
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
        /// <item><description><b>full_match</b> (default): exact match</description></item>
        /// </list>
        /// <remarks>
        /// <para>If you specify the domain names to query but do not set the DomainSearchType parameter, the exact match mode is used.</para>
        /// </remarks>
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

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The number of returned pages. Valid values: <b>1</b> to <b>100000</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Default value: <b>20</b>. Valid values: <b>1</b> to <b>500</b>.</para>
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
        /// <para>rg-acfmv6jutt**</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// <para>The list of tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeDcdnUserDomainsRequestTag> Tag { get; set; }
        public class DescribeDcdnUserDomainsRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key. Valid values of N: <b>1</b> to <b>20</b>. You can call the TagDcdnResources operation to set a tag for a domain name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value. Valid values of N: <b>1</b> to <b>20</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The business type of the domain. Separate multiple values with commas (,). Default value: <b>dynamic</b>. To query common domains, keep the default value. To query domains of the computing business type, enter <b>computing_routine</b> or <b>computing_image</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>computing_routine</para>
        /// </summary>
        [NameInMap("WebSiteType")]
        [Validation(Required=false)]
        public string WebSiteType { get; set; }

    }

}
