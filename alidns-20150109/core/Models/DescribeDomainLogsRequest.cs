// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeDomainLogsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the domain name group. If you do not specify this parameter, all groups are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2****</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>The keyword for the query. A case-insensitive \<c>contains\\</c> search is performed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("KeyWord")]
        [Validation(Required=false)]
        public string KeyWord { get; set; }

        /// <summary>
        /// <para>The language of the request and response.</para>
        /// <list type="bullet">
        /// <item><description><para><b>zh</b>: Chinese</para>
        /// </description></item>
        /// <item><description><para><b>en</b>: English</para>
        /// </description></item>
        /// </list>
        /// <para>The default value is <b>zh</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The number of the page to return. The value starts from <b>1</b>. The default value is <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. The maximum value is <b>100</b>. The default value is <b>20</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The start date. The format is <b>YYYY-MM-DD</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-07-04</para>
        /// </summary>
        [NameInMap("StartDate")]
        [Validation(Required=false)]
        public string StartDate { get; set; }

        /// <summary>
        /// <para>The type of content to query.</para>
        /// <list type="bullet">
        /// <item><description><para>domain: domain name</para>
        /// </description></item>
        /// <item><description><para>slavedns: secondary DNS</para>
        /// </description></item>
        /// </list>
        /// <para>If you do not specify this parameter, all types are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>domain</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The end date. The format is <b>YYYY-MM-DD</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-07-04</para>
        /// </summary>
        [NameInMap("endDate")]
        [Validation(Required=false)]
        public string EndDate { get; set; }

    }

}
