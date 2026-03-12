// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20160511.Models
{
    public class QueryDomainListRequest : TeaModel {
        /// <summary>
        /// <para>The end of the time range to query based on the time when domain names expire.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1696435200000</para>
        /// </summary>
        [NameInMap("DeadEndDate")]
        [Validation(Required=false)]
        public long? DeadEndDate { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query based on the time when domain names expire.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1694016000000</para>
        /// </summary>
        [NameInMap("DeadStartDate")]
        [Validation(Required=false)]
        public long? DeadStartDate { get; set; }

        /// <summary>
        /// <para>The domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test003.cn</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The type of the domain name. Valid values:</para>
        /// <para>GUOJI, TONGYONG, GUONEI, NAME, and WEIBO.</para>
        /// 
        /// <b>Example:</b>
        /// <para>GUONEI</para>
        /// </summary>
        [NameInMap("DomainType")]
        [Validation(Required=false)]
        public string DomainType { get; set; }

        /// <summary>
        /// <para>The end of the time range to query based on the time when domain names expire.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-01-11 00:00:00</para>
        /// </summary>
        [NameInMap("EndDate")]
        [Validation(Required=false)]
        public string EndDate { get; set; }

        /// <summary>
        /// <para>The group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>The language of the error message to return if the request fails. Valid values:</para>
        /// <para>zh: Chinese. en: English.</para>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The order in which you want to sort the queried domain names. Valid values:</para>
        /// <para>ASC: ascending order. DESC: descending order.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DESC</para>
        /// </summary>
        [NameInMap("OrderByType")]
        [Validation(Required=false)]
        public string OrderByType { get; set; }

        /// <summary>
        /// <para>The field by which domain names to be queried are sorted. Valid values:</para>
        /// <para>REGDATE: registration time. DEADDATE: expiration time. CREATEDATE: creation time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>REGDATE</para>
        /// </summary>
        [NameInMap("OrderKeyType")]
        [Validation(Required=false)]
        public string OrderKeyType { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The product type of the domain name. Valid values:</para>
        /// <para>New gTLD, gTLD, ccTLD, and other.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ccTLD</para>
        /// </summary>
        [NameInMap("ProductDomainType")]
        [Validation(Required=false)]
        public string ProductDomainType { get; set; }

        /// <summary>
        /// <para>The type of the query. Valid values:</para>
        /// <para>1: renewal. 2: redemption. 4: transfer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("QueryType")]
        [Validation(Required=false)]
        public string QueryType { get; set; }

        /// <summary>
        /// <para>The end of the time range to query based on the time when domain names were registered.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1696435200000</para>
        /// </summary>
        [NameInMap("RegEndDate")]
        [Validation(Required=false)]
        public long? RegEndDate { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query based on the time when domain names were registered.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1694016000000</para>
        /// </summary>
        [NameInMap("RegStartDate")]
        [Validation(Required=false)]
        public long? RegStartDate { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query based on the time when domain names expire.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-01-01 00:00:00</para>
        /// </summary>
        [NameInMap("StartDate")]
        [Validation(Required=false)]
        public string StartDate { get; set; }

        /// <summary>
        /// <para>The IP address of the client. Set the value to 127.0.0.1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>127.0.0.1</para>
        /// </summary>
        [NameInMap("UserClientIp")]
        [Validation(Required=false)]
        public string UserClientIp { get; set; }

    }

}
