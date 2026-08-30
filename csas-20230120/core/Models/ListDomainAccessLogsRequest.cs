// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListDomainAccessLogsRequest : TeaModel {
        /// <summary>
        /// <para>The action taken upon a rule hit. Exact match is used. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Audit: Audit.</description></item>
        /// <item><description>Observe: Observe only.</description></item>
        /// <item><description>WhiteList: Allowed by whitelist.</description></item>
        /// <item><description>Block: Blocked.</description></item>
        /// <item><description>Redirect: Redirected to a prompt page.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Block</para>
        /// </summary>
        [NameInMap("BlockAction")]
        [Validation(Required=false)]
        public string BlockAction { get; set; }

        /// <summary>
        /// <para>The current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The department. Exact match is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>IT department</para>
        /// </summary>
        [NameInMap("Department")]
        [Validation(Required=false)]
        public string Department { get; set; }

        /// <summary>
        /// <para>The end time of the query. This value is a UNIX timestamp in seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1754956800</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The number of entries per page in paging. Valid values: 1 to 1000.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The policy type used to filter results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>la_domain_white</para>
        /// </summary>
        [NameInMap("PolicyType")]
        [Validation(Required=false)]
        public string PolicyType { get; set; }

        /// <summary>
        /// <para>The destination domain name accessed. Exact match is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://www.example.com">www.example.com</a></para>
        /// </summary>
        [NameInMap("RemoteHost")]
        [Validation(Required=false)]
        public string RemoteHost { get; set; }

        /// <summary>
        /// <para>The start time of the query. This value is a UNIX timestamp in seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1754870400</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// <para>The username. Exact match is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zhangsan</para>
        /// </summary>
        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

    }

}
