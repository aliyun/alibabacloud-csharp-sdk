// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeDomainRecordsRequest : TeaModel {
        /// <summary>
        /// <para>The order in which you want to sort the returned DNS records. Valid values: DESC and ASC. Default value: DESC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DESC</para>
        /// </summary>
        [NameInMap("Direction")]
        [Validation(Required=false)]
        public string Direction { get; set; }

        /// <summary>
        /// <para>The domain name. You can call the <a href="https://www.alibabacloud.com/help/zh/dns/api-alidns-2015-01-09-describedomains?spm=a2c63.p38356.help-menu-search-29697.d_0">DescribeDomains</a> operation to obtain the domain name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The ID of the domain name group.</para>
        /// <list type="bullet">
        /// <item><description>If you do not specify GroupId, all domain names are queried.</description></item>
        /// <item><description>If you set GroupId to 0, no value is returned.</description></item>
        /// <item><description>If you set GroupId to 1, the domain names in the default group are queried.</description></item>
        /// <item><description>If you set GroupId to -2, all domain names are queried.</description></item>
        /// <item><description>You can also specify GroupId based on the actual group ID.</description></item>
        /// </list>
        /// <para>You can call the <a href="https://www.alibabacloud.com/help/zh/dns/api-alidns-2015-01-09-describedomaingroups?spm=a2c63.p38356.help-menu-search-29697.d_0">DescribeDomainGroups </a>operation to obtain the ID of the domain name group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2223</para>
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
        /// <para>The language.</para>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The resolution line. Default value: <b>default</b>.</para>
        /// <para>For more information, see</para>
        /// <para><a href="https://www.alibabacloud.com/help/zh/doc-detail/29807.htm">DNS lines</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn_mobile_anhui</para>
        /// </summary>
        [NameInMap("Line")]
        [Validation(Required=false)]
        public string Line { get; set; }

        /// <summary>
        /// <para>The method that is used to sort the returned DNS records. By default, the DNS records are sorted in reverse chronological order based on the time when they were added.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("OrderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        /// <summary>
        /// <para>The page number. Pages start from page <b>1</b>. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values: <b>1 to 500</b>. Default value: <b>20</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The hostname keyword based on which the system queries DNS records. The system queries DNS records based on the value of this parameter in fuzzy match mode. The value is not case-sensitive.</para>
        /// 
        /// <b>Example:</b>
        /// <para>www</para>
        /// </summary>
        [NameInMap("RRKeyWord")]
        [Validation(Required=false)]
        public string RRKeyWord { get; set; }

        /// <summary>
        /// <para>The search mode. Valid values: <b>LIKE, EXACT, and ADVANCED</b>.</para>
        /// <list type="bullet">
        /// <item><description><para>If you set SearchMode to LIKE or EXACT, specify KeyWord. In this case, RRKeyWord, TypeKeyWord, ValueKeyWord, Type, Line, and Status are invalid.</para>
        /// </description></item>
        /// <item><description><para>If you set SearchMode to ADVANCED, specify RRKeyWord, TypeKeyWord, ValueKeyWord, Type, Line, and Status.</para>
        /// </description></item>
        /// <item><description><para>If you do not specify SearchMode, the system determines the search mode based on the following rules:</para>
        /// <list type="bullet">
        /// <item><description>If KeyWord is specified, the system uses the LIKE mode.</description></item>
        /// <item><description>If KeyWord is not specified, the system queries DNS records based on values of RRKeyWord and ValueKeyWord in fuzzy match mode, and based on the values of TypeKeyWord, Type, Line, and Status in exact match mode.</description></item>
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
        /// <para>The status of the DNS records to query. Valid values: <b>Enable and Disable</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Enable</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The type of the DNS records to query. For more information, see</para>
        /// <para><a href="https://www.alibabacloud.com/help/zh/doc-detail/29805.htm">DNS record types</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The type keyword based on which the system queries DNS records. The system queries DNS records based on the value of this parameter in exact match mode. The value is not case-sensitive.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MX</para>
        /// </summary>
        [NameInMap("TypeKeyWord")]
        [Validation(Required=false)]
        public string TypeKeyWord { get; set; }

        /// <summary>
        /// <para>The record value keyword based on which the system queries DNS records. The system queries DNS records based on the value of this parameter in fuzzy match mode. The value is not case-sensitive.</para>
        /// 
        /// <b>Example:</b>
        /// <para>com</para>
        /// </summary>
        [NameInMap("ValueKeyWord")]
        [Validation(Required=false)]
        public string ValueKeyWord { get; set; }

    }

}
