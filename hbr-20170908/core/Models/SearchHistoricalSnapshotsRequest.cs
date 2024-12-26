// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class SearchHistoricalSnapshotsRequest : TeaModel {
        /// <summary>
        /// <para>The maximum number of rows that you want the current query to return. To query only the number of matched rows without the need to return specific data, you can set the Limit parameter to <c>0</c>. Then, the operation returns only the number of matched rows.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Limit")]
        [Validation(Required=false)]
        public int? Limit { get; set; }

        /// <summary>
        /// <para>The token that is required to obtain the next page of backup snapshots.</para>
        /// 
        /// <b>Example:</b>
        /// <para>caeba0bbb2be03f84eb48b699f0a****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ordering mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ASC (default): ascending order</description></item>
        /// <item><description>DESC: descending order</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ASC</para>
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// <para>The query conditions. Example:</para>
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
        /// <item><description><para>The following fields are supported:</para>
        /// <list type="bullet">
        /// <item><description>VaultId: specifies the ID of the backup vault. This field is required.</description></item>
        /// <item><description>InstanceId: specifies the ID of the Elastic Compute Service (ECS) instance. If the SourceType parameter is set to ECS_FILE, this field is required.</description></item>
        /// <item><description>Bucket: specifies the name of the Object Storage Service (OSS) bucket. If the SourceType parameter is set to OSS, this field is required.</description></item>
        /// <item><description>FileSystemId: specifies the ID of the File Storage NAS (NAS) file system. If the SourceType parameter is set to NAS, this field is required.</description></item>
        /// <item><description>CreateTime: specifies the time when the NAS file system was created. If the SourceType parameter is set to NAS, this field is required.</description></item>
        /// <item><description>CompleteTime: specifies the time when the backup snapshot was completed.</description></item>
        /// <item><description>PlanId: the ID of a backup plan.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>The following operations are supported:</para>
        /// <list type="bullet">
        /// <item><description>MATCH_TERM: exact match.</description></item>
        /// <item><description>GREATER_THAN: greater than.</description></item>
        /// <item><description>GREATER_THAN_OR_EQUAL: greater than or equal to.</description></item>
        /// <item><description>LESS_THAN: less than.</description></item>
        /// <item><description>LESS_THAN_OR_EQUAL: less than or equal to.</description></item>
        /// <item><description>BETWEEN: specifies a JSON array as a range. The results must fall within the range in the <c>[Minimum value,Maximum value]</c> format.</description></item>
        /// <item><description>IN: specifies an array as a collection. The results must fall within the collection.</description></item>
        /// <item><description>NOT_IN: specifies an array as a collection. The results cannot fall within the collection.</description></item>
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
        /// <para>The field that is used to sort data.</para>
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
        /// <item><description><b>ECS_FILE</b>: backup snapshots for Elastic Compute Service (ECS) files</description></item>
        /// <item><description><b>OSS</b>: backup snapshots for Object Storage Service (OSS) buckets</description></item>
        /// <item><description><b>NAS</b>: backup snapshots for Apsara File Storage NAS file systems</description></item>
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
