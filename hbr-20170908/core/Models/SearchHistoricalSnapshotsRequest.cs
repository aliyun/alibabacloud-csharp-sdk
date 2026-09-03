// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class SearchHistoricalSnapshotsRequest : TeaModel {
        /// <summary>
        /// <para>The edition type. Valid values: BASIC and STANDARD. Default value: STANDARD.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BASIC</para>
        /// </summary>
        [NameInMap("Edition")]
        [Validation(Required=false)]
        public string Edition { get; set; }

        /// <summary>
        /// <para>The maximum number of results to return for this query.
        /// If you only want to obtain the row count without actual data, set <c>limit=0</c> to return no rows.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Limit")]
        [Validation(Required=false)]
        public int? Limit { get; set; }

        /// <summary>
        /// <para>The token required to retrieve the next page of snapshots.</para>
        /// 
        /// <b>Example:</b>
        /// <para>caeba0bbb2be03f84eb48b699f0a****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The sort order. Default value: ASC.</para>
        /// <list type="bullet">
        /// <item><description>ASC: ascending order.</description></item>
        /// <item><description>DESC: descending order.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ASC</para>
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// <para>The query conditions. Example of Query:</para>
        /// <pre><c>[
        ///   {
        ///     &quot;field&quot;: &quot;VaultId&quot;,
        ///     &quot;value&quot;: &quot;v-0003rf9m*****qx5&quot;,
        ///     &quot;operation&quot;: &quot;MATCH_TERM&quot;
        ///   },
        ///   {
        ///     &quot;field&quot;: &quot;InstanceId&quot;,
        ///     &quot;value&quot;: &quot;i-bp1i20zq2*****e9368m&quot;,
        ///     &quot;operation&quot;: &quot;MATCH_TERM&quot;
        ///   },
        ///   {
        ///     &quot;field&quot;: &quot;PlanId&quot;,
        ///     &quot;value&quot;: &quot;plan-0005vk*****gkd1iu4f&quot;,
        ///     &quot;operation&quot;: &quot;MATCH_TERM&quot;
        ///   },
        ///   {
        ///     &quot;field&quot;: &quot;CompleteTime&quot;,
        ///     &quot;value&quot;: &quot;1626769913&quot;,
        ///     &quot;operation&quot;: &quot;GREATER_THAN_OR_EQUAL&quot;
        ///   }
        /// ]
        /// </c></pre>
        /// <list type="bullet">
        /// <item><description><para>Supported fields:</para>
        /// <list type="bullet">
        /// <item><description>VaultId: required. The vault ID.</description></item>
        /// <item><description>InstanceId: required only when SourceType=ECS_FILE. The ECS instance ID.</description></item>
        /// <item><description>Bucket: required only when SourceType=OSS. The OSS bucket name.</description></item>
        /// <item><description>FileSystemId: required only when SourceType=NAS. The NAS file system ID.</description></item>
        /// <item><description>CreateTime: required only when SourceType=NAS. The creation time of the NAS file system.</description></item>
        /// <item><description>CompleteTime: the time when the snapshot is completed.</description></item>
        /// <item><description>PlanId: the backup plan ID.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Supported operations:</para>
        /// <list type="bullet">
        /// <item><description>MATCH_TERM: exact match.</description></item>
        /// <item><description>GREATER_THAN: greater than.</description></item>
        /// <item><description>GREATER_THAN_OR_EQUAL: greater than or equal to.</description></item>
        /// <item><description>LESS_THAN: less than.</description></item>
        /// <item><description>LESS_THAN_OR_EQUAL: less than or equal to.</description></item>
        /// <item><description>BETWEEN: range. The value is a JSON array <c>[lower bound, upper bound]</c>.</description></item>
        /// <item><description>IN: in the set. The value is an array.</description></item>
        /// <item><description>NOT_IN: not in the set. The value is an array.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>[   {     &quot;field&quot;: &quot;VaultId&quot;,     &quot;value&quot;: &quot;v-0003rf9m17pap3ltpqx5&quot;,     &quot;operation&quot;: &quot;MATCH_TERM&quot;   },   {     &quot;field&quot;: &quot;InstanceId&quot;,     &quot;value&quot;: &quot;i-bp1i20zq2wuzdie9368m&quot;,     &quot;operation&quot;: &quot;MATCH_TERM&quot;   },   {     &quot;field&quot;: &quot;PlanId&quot;,     &quot;value&quot;: &quot;plan-0005vkqhpesqgkd1iu4f&quot;,     &quot;operation&quot;: &quot;MATCH_TERM&quot;   },   {     &quot;field&quot;: &quot;CompleteTime&quot;,     &quot;value&quot;: 1626769913,     &quot;operation&quot;: &quot;GREATER_THAN_OR_EQUAL&quot;   } ]</para>
        /// </summary>
        [NameInMap("Query")]
        [Validation(Required=false)]
        public List<object> Query { get; set; }

        /// <summary>
        /// <para>The field used for sorting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CreatedTime</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// <para>The type of the data source. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ECS_FILE</b>: backup snapshots of ECS files.</description></item>
        /// <item><description><b>OSS</b>: backup snapshots of Alibaba Cloud OSS.</description></item>
        /// <item><description><b>NAS</b>: backup snapshots of Alibaba Cloud NAS.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ECS_FILE</para>
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

    }

}
