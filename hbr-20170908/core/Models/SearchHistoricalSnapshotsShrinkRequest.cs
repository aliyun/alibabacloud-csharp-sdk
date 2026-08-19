// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class SearchHistoricalSnapshotsShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The edition. Valid values are BASIC and STANDARD. The default value is STANDARD.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BASIC</para>
        /// </summary>
        [NameInMap("Edition")]
        [Validation(Required=false)]
        public string Edition { get; set; }

        /// <summary>
        /// <para>The maximum number of results to return.
        /// To retrieve only the number of rows without any data, set Limit to <c>0</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Limit")]
        [Validation(Required=false)]
        public int? Limit { get; set; }

        /// <summary>
        /// <para>The token that is required to obtain the next page of snapshots.</para>
        /// 
        /// <b>Example:</b>
        /// <para>caeba0bbb2be03f84eb48b699f0a****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The sort order. The default value is ASC.</para>
        /// <list type="bullet">
        /// <item><description><para>ASC: ascending</para>
        /// </description></item>
        /// <item><description><para>DESC: descending</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ASC</para>
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// <para>The query conditions. For example:</para>
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
        /// <item><description><para>VaultId: This parameter is required. The ID of the backup vault.</para>
        /// </description></item>
        /// <item><description><para>InstanceId: This parameter is required only when SourceType is set to ECS_FILE. The ID of the ECS instance.</para>
        /// </description></item>
        /// <item><description><para>Bucket: This parameter is required only when SourceType is set to OSS. The name of the OSS bucket.</para>
        /// </description></item>
        /// <item><description><para>FileSystemId: This parameter is required only when SourceType is set to NAS. The ID of the NAS file system.</para>
        /// </description></item>
        /// <item><description><para>CreateTime: This parameter is required only when SourceType is set to NAS. The time when the NAS file system was created.</para>
        /// </description></item>
        /// <item><description><para>CompleteTime: The time when the snapshot was completed.</para>
        /// </description></item>
        /// <item><description><para>PlanId: The ID of the backup plan.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Supported operations:</para>
        /// <list type="bullet">
        /// <item><description><para>MATCH_TERM: exact match.</para>
        /// </description></item>
        /// <item><description><para>GREATER_THAN: greater than.</para>
        /// </description></item>
        /// <item><description><para>GREATER_THAN_OR_EQUAL: greater than or equal to.</para>
        /// </description></item>
        /// <item><description><para>LESS_THAN: less than.</para>
        /// </description></item>
        /// <item><description><para>LESS_THAN_OR_EQUAL: less than or equal to.</para>
        /// </description></item>
        /// <item><description><para>BETWEEN: a range. The value is a JSON array in the <c>[lower bound,upper bound]</c> format.</para>
        /// </description></item>
        /// <item><description><para>IN: in a collection. The value is an array.</para>
        /// </description></item>
        /// <item><description><para>NOT_IN: not in a collection. The value is an array.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>[   {     &quot;field&quot;: &quot;VaultId&quot;,     &quot;value&quot;: &quot;v-0003rf9m17pap3ltpqx5&quot;,     &quot;operation&quot;: &quot;MATCH_TERM&quot;   },   {     &quot;field&quot;: &quot;InstanceId&quot;,     &quot;value&quot;: &quot;i-bp1i20zq2wuzdie9368m&quot;,     &quot;operation&quot;: &quot;MATCH_TERM&quot;   },   {     &quot;field&quot;: &quot;PlanId&quot;,     &quot;value&quot;: &quot;plan-0005vkqhpesqgkd1iu4f&quot;,     &quot;operation&quot;: &quot;MATCH_TERM&quot;   },   {     &quot;field&quot;: &quot;CompleteTime&quot;,     &quot;value&quot;: 1626769913,     &quot;operation&quot;: &quot;GREATER_THAN_OR_EQUAL&quot;   } ]</para>
        /// </summary>
        [NameInMap("Query")]
        [Validation(Required=false)]
        public string QueryShrink { get; set; }

        /// <summary>
        /// <para>The field to sort by.</para>
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
        /// <item><description><para><b>ECS_FILE</b>: a backup snapshot of ECS files.</para>
        /// </description></item>
        /// <item><description><para><b>OSS</b>: a backup snapshot of Alibaba Cloud OSS.</para>
        /// </description></item>
        /// <item><description><para><b>NAS</b>: a backup snapshot of Alibaba Cloud NAS.</para>
        /// </description></item>
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
