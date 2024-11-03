// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeUserDomainsRequest : TeaModel {
        /// <summary>
        /// <para>The type of workload accelerated by Alibaba Cloud CDN. Separate types with commas (,). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>web</b>: images and small files</description></item>
        /// <item><description><b>download</b>: large files</description></item>
        /// <item><description><b>video</b>: on-demand video and audio streaming</description></item>
        /// </list>
        /// <para>If you do not set this parameter, all service types are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>download,web,video</para>
        /// </summary>
        [NameInMap("CdnType")]
        [Validation(Required=false)]
        public string CdnType { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. Specify the time in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.</para>
        /// <remarks>
        /// <para>The end time must be later than the start time.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2019-10-10T12:14:58Z</para>
        /// </summary>
        [NameInMap("ChangeEndTime")]
        [Validation(Required=false)]
        public string ChangeEndTime { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. Specify the time in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-10-10T12:14:55Z</para>
        /// </summary>
        [NameInMap("ChangeStartTime")]
        [Validation(Required=false)]
        public string ChangeStartTime { get; set; }

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
        /// <para>The acceleration region. By default, all acceleration regions are queried. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>domestic</b>: Chinese mainland</description></item>
        /// <item><description><b>global</b>: global</description></item>
        /// <item><description><b>overseas</b>: outside the Chinese mainland</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>domestic</para>
        /// </summary>
        [NameInMap("Coverage")]
        [Validation(Required=false)]
        public string Coverage { get; set; }

        /// <summary>
        /// <para>The accelerated domain. If you do not set this parameter, all domain names that match the conditions are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The search mode. Valid values:</para>
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
        /// <item><description><b>online</b></description></item>
        /// <item><description><b>offline</b></description></item>
        /// <item><description><b>configuring</b></description></item>
        /// <item><description><b>configure_failed</b></description></item>
        /// <item><description><b>checking</b></description></item>
        /// <item><description><b>check_failed</b></description></item>
        /// <item><description><b>stopping</b></description></item>
        /// <item><description><b>deleting</b></description></item>
        /// </list>
        /// <para>If you do not set this parameter, domain names in all states are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>configure_failed</para>
        /// </summary>
        [NameInMap("DomainStatus")]
        [Validation(Required=false)]
        public string DomainStatus { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The page number. Valid values: <b>1</b> to <b>100000</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Valid values: <b>1 to 500</b>. Default value: <b>20</b>. Maximum value: <b>500</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the resource group. By default, all IDs are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>abcd1234abcd1234</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// <para>The information about the origin server.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.source.com</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <para>The list of tags. Maximum number of elements in the list: 20</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeUserDomainsRequestTag> Tag { get; set; }
        public class DescribeUserDomainsRequestTag : TeaModel {
            /// <summary>
            /// <para>The key of a tag.</para>
            /// <para>By default, all tag keys are queried.</para>
            /// 
            /// <b>Example:</b>
            /// <para>key</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the tag.</para>
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
