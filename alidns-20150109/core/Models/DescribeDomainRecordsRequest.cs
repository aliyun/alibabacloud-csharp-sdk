// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeDomainRecordsRequest : TeaModel {
        /// <summary>
        /// <para>The sorting direction. Valid values: DESC, ASC. Default value: DESC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DESC</para>
        /// </summary>
        [NameInMap("Direction")]
        [Validation(Required=false)]
        public string Direction { get; set; }

        /// <summary>
        /// <para>The domain name.&lt;props=&quot;china&quot;&gt; For more information, see <a href="https://help.aliyun.com/zh/dns/api-alidns-2015-01-09-describedomains?spm=a2c4g.11186623.help-menu-search-29697.d_0">DescribeDomains</a>.
        /// &lt;props=&quot;intl&quot;&gt;For more information, see <a href="https://www.alibabacloud.com/help/zh/dns/api-alidns-2015-01-09-describedomains?spm=a2c63.p38356.help-menu-search-29697.d_0">DescribeDomains</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The ID of the domain group.</para>
        /// <list type="bullet">
        /// <item><description><para>If you do not specify GroupId, the query is performed on all domain names.</para>
        /// </description></item>
        /// <item><description><para>If you set GroupId to 0, an empty result is returned.</para>
        /// </description></item>
        /// <item><description><para>If you set GroupId to -1, the query is performed on the default group. The default group includes domain names that are not assigned to a group.</para>
        /// </description></item>
        /// <item><description><para>If you set GroupId to -2, the query is performed on all domain names.</para>
        /// </description></item>
        /// <item><description><para>If you specify another value for GroupId, the query is performed on the specified group.
        /// &lt;props=&quot;china&quot;&gt;For more information, see <a href="https://help.aliyun.com/zh/dns/api-alidns-2015-01-09-describedomaingroups?spm=a2c4g.11186623.help-menu-search-29697.d_0">DescribeDomainGroups</a>.
        /// &lt;props=&quot;intl&quot;&gt;For more information, see <a href="https://www.alibabacloud.com/help/zh/dns/api-alidns-2015-01-09-describedomaingroups?spm=a2c63.p38356.help-menu-search-29697.d_0">DescribeDomainGroups</a>.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2****</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public long? GroupId { get; set; }

        /// <summary>
        /// <para>The keyword.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("KeyWord")]
        [Validation(Required=false)]
        public string KeyWord { get; set; }

        /// <summary>
        /// <para>The language of the request and response. Default value: <b>zh</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>zh</b>: Chinese</para>
        /// </description></item>
        /// <item><description><para><b>en</b>: English</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The DNS resolution line. Default value: <b>default</b>.</para>
        /// <para>For more information, see:
        /// &lt;props=&quot;china&quot;&gt;<a href="https://help.aliyun.com/document_detail/29807.html">Enumeration of DNS resolution lines</a>.</para>
        /// <para>&lt;props=&quot;intl&quot;&gt;</para>
        /// <para><a href="https://www.alibabacloud.com/help/zh/doc-detail/29807.htm">Enumeration of DNS resolution lines</a></para>
        /// 
        /// <b>Example:</b>
        /// <para>cn_mobile_anhui</para>
        /// </summary>
        [NameInMap("Line")]
        [Validation(Required=false)]
        public string Line { get; set; }

        /// <summary>
        /// <para>The sorting method. Records are sorted in descending order based on the time they were added.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("OrderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        /// <summary>
        /// <para>The page number. The value starts from <b>1</b>. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page for a paged query. Maximum value: <b>500</b>. Default value: <b>20</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The keyword for the host record. The search uses a fuzzy match pattern and is not case-sensitive.</para>
        /// 
        /// <b>Example:</b>
        /// <para>www</para>
        /// </summary>
        [NameInMap("RRKeyWord")]
        [Validation(Required=false)]
        public string RRKeyWord { get; set; }

        /// <summary>
        /// <para>The search mode. Valid values: LIKE, EXACT, ADVANCED, and <b>COMBINATION</b>.</para>
        /// <list type="bullet">
        /// <item><description><para>If you set this parameter to LIKE or EXACT, use the KeyWord parameter. The RRKeyWord, TypeKeyWord, ValueKeyWord, Type, Line, and Status parameters are invalid.</para>
        /// </description></item>
        /// <item><description><para>If you set this parameter to ADVANCED, use the RRKeyWord, TypeKeyWord, ValueKeyWord, Type, Line, and Status parameters. The RRKeyWord and ValueKeyWord parameters support fuzzy matching.</para>
        /// </description></item>
        /// <item><description><para>If you set this parameter to COMBINATION, use the RRKeyWord, TypeKeyWord, ValueKeyWord, Type, Line, and Status parameters. All these parameters support only exact matching.</para>
        /// </description></item>
        /// <item><description><para>If you do not specify this parameter:</para>
        /// <list type="bullet">
        /// <item><description><para>If you specify the keyWord parameter, the search mode is set to LIKE.</para>
        /// </description></item>
        /// <item><description><para>If you do not specify the keyWord parameter, RRKeyWord and ValueKeyWord support fuzzy matching, and TypeKeyWord, Type, Line, and Status support exact matching.</para>
        /// </description></item>
        /// </list>
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
        /// <para>The status of the DNS record. Valid values:</para>
        /// <para>Enable: The DNS record is enabled.</para>
        /// <para>Disable: The DNS record is paused.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Enable</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The type of the DNS record. For more information, see:</para>
        /// <para>&lt;props=&quot;china&quot;&gt;<a href="https://help.aliyun.com/document_detail/29805.html">DNS record types</a>
        /// &lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/zh/doc-detail/29805.htm">DNS record types</a></para>
        /// 
        /// <b>Example:</b>
        /// <para>A</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The keyword for the record type. The search uses an exact match and is not case-sensitive.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MX</para>
        /// </summary>
        [NameInMap("TypeKeyWord")]
        [Validation(Required=false)]
        public string TypeKeyWord { get; set; }

        /// <summary>
        /// <para>The keyword for the record value. The search uses a fuzzy match pattern and is not case-sensitive.</para>
        /// 
        /// <b>Example:</b>
        /// <para>com</para>
        /// </summary>
        [NameInMap("ValueKeyWord")]
        [Validation(Required=false)]
        public string ValueKeyWord { get; set; }

    }

}
