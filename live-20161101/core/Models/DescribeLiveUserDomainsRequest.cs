// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveUserDomainsRequest : TeaModel {
        /// <summary>
        /// <para>The domain name that is used as a keyword to filter domain names. Fuzzy match is supported.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>If you set LiveDomainType to liveVideo and leave this parameter empty, the streaming domains are queried. - If you set LiveDomainType to liveEdge and leave this parameter empty, the ingest domains are queried.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>*.aliyundoc.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The search mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>fuzzy_match</b> (default): fuzzy match</description></item>
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
        /// <item><description><b>online</b></description></item>
        /// <item><description><b>offline</b></description></item>
        /// <item><description><b>configuring</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>online</para>
        /// </summary>
        [NameInMap("DomainStatus")]
        [Validation(Required=false)]
        public string DomainStatus { get; set; }

        /// <summary>
        /// <para>The type of the domain name. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>liveVideo</b>: streaming domain</description></item>
        /// <item><description><b>liveEdge</b>: ingest domain</description></item>
        /// </list>
        /// <remarks>
        /// <para> If you leave this parameter empty, all ingest domains and streaming domains within your Alibaba Cloud account are queried by default.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>liveVideo</para>
        /// </summary>
        [NameInMap("LiveDomainType")]
        [Validation(Required=false)]
        public string LiveDomainType { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The page number. Valid values: <b>1 to 100000</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: <b>20</b>. Maximum value: <b>50</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the region in which the domain name resides.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionName")]
        [Validation(Required=false)]
        public string RegionName { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aek2egyoep3jp7a</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// <para>The tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeLiveUserDomainsRequestTag> Tag { get; set; }
        public class DescribeLiveUserDomainsRequestTag : TeaModel {
            /// <summary>
            /// <para>The key of the tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
