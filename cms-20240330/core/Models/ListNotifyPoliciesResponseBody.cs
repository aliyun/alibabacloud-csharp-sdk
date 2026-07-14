// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class ListNotifyPoliciesResponseBody : TeaModel {
        /// <summary>
        /// <para>The maximum number of entries returned in this request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token for the next page. This parameter is empty if no more data is available.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eyJjdXJzb3IiOjEwfQ==</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The list of notify policies. Each entry is of the NotifyPolicySummary type (lightweight view).</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;uuid&quot;:&quot;np-12345678-1234-1234-1234-123456789012&quot;,&quot;name&quot;:&quot;prod-alert&quot;,&quot;description&quot;:&quot;生产环境告警策略&quot;,&quot;enabled&quot;:true,&quot;version&quot;:1,&quot;workspace&quot;:&quot;default-cms-xxxx-cn-hangzhou&quot;,&quot;userId&quot;:&quot;107640&quot;,&quot;createTime&quot;:&quot;1711792800000&quot;,&quot;updateTime&quot;:&quot;1711792800000&quot;}]</para>
        /// </summary>
        [NameInMap("notifyPolicyList")]
        [Validation(Required=false)]
        public List<NotifyPolicySummary> NotifyPolicyList { get; set; }

        /// <summary>
        /// <para>The request ID. You can use this ID for troubleshooting and ticket submission.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0B9377D9-C56B-5C2E-A8A4-A01D6CC3F4B8</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries. The actual total is returned on the first page. A fixed value of -1 is returned on subsequent pages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
