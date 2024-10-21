// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class ListServerLockRequest : TeaModel {
        /// <summary>
        /// <para>The start of the time range to query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-07-10 17:37:36</para>
        /// </summary>
        [NameInMap("BeginStartDate")]
        [Validation(Required=false)]
        public long? BeginStartDate { get; set; }

        /// <summary>
        /// <para>The domain name for which you want to query the enabled registry lock.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The end of the expiration time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-07-10 17:37:36</para>
        /// </summary>
        [NameInMap("EndExpireDate")]
        [Validation(Required=false)]
        public long? EndExpireDate { get; set; }

        /// <summary>
        /// <para>The end of the time range to query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-07-10 17:37:36</para>
        /// </summary>
        [NameInMap("EndStartDate")]
        [Validation(Required=false)]
        public long? EndStartDate { get; set; }

        /// <summary>
        /// <para>The language of the error message to return if the request fails. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>zh: Chinese</description></item>
        /// <item><description>en: English</description></item>
        /// </list>
        /// <para>Default value: en.</para>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The ID of the product to which the domain name with the registry lock enabled belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1807**</para>
        /// </summary>
        [NameInMap("LockProductId")]
        [Validation(Required=false)]
        public string LockProductId { get; set; }

        /// <summary>
        /// <para>The field that you use to sort the query results.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>EXPIRE_DATE</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>EXPIRE_DATE</para>
        /// </summary>
        [NameInMap("OrderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        /// <summary>
        /// <para>The order of the information based on which you want to sort the domain names, such as the registration date and expiration date. Valid values: ASC and DESC. The value ASC specifies the ascending order. The value DESC specifies the descending order. If this parameter is not configured, the default value DESC is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DESC</para>
        /// </summary>
        [NameInMap("OrderByType")]
        [Validation(Required=false)]
        public string OrderByType { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The status of the registry lock. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: The registry lock is not enabled.</description></item>
        /// <item><description>2: The registry lock is enabled.</description></item>
        /// <item><description>3: The registry lock is disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ServerLockStatus")]
        [Validation(Required=false)]
        public int? ServerLockStatus { get; set; }

        /// <summary>
        /// <para>The start of the expiration time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-07-10 17:37:36</para>
        /// </summary>
        [NameInMap("StartExpireDate")]
        [Validation(Required=false)]
        public long? StartExpireDate { get; set; }

        /// <summary>
        /// <para>The IP address of the client. For example, you can set the value to <b>127.0.0.1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>127.0.0.1</para>
        /// </summary>
        [NameInMap("UserClientIp")]
        [Validation(Required=false)]
        public string UserClientIp { get; set; }

    }

}
