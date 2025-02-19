// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RocketMQ20220801.Models
{
    public class ListInstanceAccountRequest : TeaModel {
        /// <summary>
        /// <para>The status of the account.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>DISABLE</description></item>
        /// <item><description>ENABLE</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ENABLE</para>
        /// </summary>
        [NameInMap("accountStatus")]
        [Validation(Required=false)]
        public string AccountStatus { get; set; }

        /// <summary>
        /// <para>The account type.</para>
        /// <list type="bullet">
        /// <item><description>CUSTOMER</description></item>
        /// <item><description>DEFAULT</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CUSTOMER</para>
        /// </summary>
        [NameInMap("accountType")]
        [Validation(Required=false)]
        public string AccountType { get; set; }

        /// <summary>
        /// <para>The page number. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The username of the account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("username")]
        [Validation(Required=false)]
        public string Username { get; set; }

    }

}
