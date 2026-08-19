// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DescribeVodUserDomainsRequest : TeaModel {
        /// <summary>
        /// <para>The accelerated domain name for ApsaraVideo VOD. Fuzzy match filtering is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.aliyundoc.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The domain name query type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>fuzzy_match</b> (default): fuzzy match.</description></item>
        /// <item><description><b>pre_match</b>: prefix match.</description></item>
        /// <item><description><b>suf_match</b>: suffix match.</description></item>
        /// <item><description><b>full_match</b>: exact match.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>fuzzy_match</para>
        /// </summary>
        [NameInMap("DomainSearchType")]
        [Validation(Required=false)]
        public string DomainSearchType { get; set; }

        /// <summary>
        /// <para>The domain name status filter. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>online</b>: Enabled.</description></item>
        /// <item><description><b>offline</b>: Disabled.</description></item>
        /// <item><description><b>configuring</b>: Being configured.</description></item>
        /// <item><description><b>configure_failed</b>: Configuration failed.</description></item>
        /// <item><description><b>checking</b>: Being reviewed.</description></item>
        /// <item><description><b>check_failed</b>: Review failed.</description></item>
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
        /// <para>The number of the page to return.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: <b>20</b>. Maximum value: <b>50</b>. Valid values: any integer from <b>1</b> to <b>50</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// <para>The tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeVodUserDomainsRequestTag> Tag { get; set; }
        public class DescribeVodUserDomainsRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key. Valid values of N: <b>1</b> to <b>20</b>.</para>
            /// <para>By default, all tag keys are queried.</para>
            /// 
            /// <b>Example:</b>
            /// <para>key</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value. Valid values of N: <b>1</b> to <b>20</b>.</para>
            /// <para>By default, all tag values are queried.</para>
            /// 
            /// <b>Example:</b>
            /// <para>value</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
