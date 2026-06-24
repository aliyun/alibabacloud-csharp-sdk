// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ListInstanceIndicesResponseBody : TeaModel {
        /// <summary>
        /// <para>The response headers.</para>
        /// </summary>
        [NameInMap("Headers")]
        [Validation(Required=false)]
        public ListInstanceIndicesResponseBodyHeaders Headers { get; set; }
        public class ListInstanceIndicesResponseBodyHeaders : TeaModel {
            /// <summary>
            /// <para>The total number of managed indexes in the cloud.</para>
            /// 
            /// <b>Example:</b>
            /// <para>15</para>
            /// </summary>
            [NameInMap("X-Managed-Count")]
            [Validation(Required=false)]
            public int? XManagedCount { get; set; }

            /// <summary>
            /// <para>The total size of managed indexes in the cloud. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>18093942932</para>
            /// </summary>
            [NameInMap("X-Managed-StorageSize")]
            [Validation(Required=false)]
            public long? XManagedStorageSize { get; set; }

            /// <summary>
            /// <para>The total number of OpenStore cold-phase indexes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("X-OSS-Count")]
            [Validation(Required=false)]
            public int? XOSSCount { get; set; }

            /// <summary>
            /// <para>The total size of OpenStore cold-phase indexes for the instance. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9093942932</para>
            /// </summary>
            [NameInMap("X-OSS-StorageSize")]
            [Validation(Required=false)]
            public long? XOSSStorageSize { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F99407AB-2FA9-489E-A259-40CF6DCC****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The index list details.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<ListInstanceIndicesResponseBodyResult> Result { get; set; }
        public class ListInstanceIndicesResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The time when the index list was queried.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-01-11T05:49:41.114Z</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The health status of the index. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>green: Healthy.</para>
            /// </description></item>
            /// <item><description><para>yellow: Warning.</para>
            /// </description></item>
            /// <item><description><para>red: Abnormal.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>green</para>
            /// </summary>
            [NameInMap("health")]
            [Validation(Required=false)]
            public string Health { get; set; }

            /// <summary>
            /// <para>The full lifecycle status of the index.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{    &quot;indices&quot;: {         &quot;.ds-console-2021.08.18-000002&quot;: {             &quot;index&quot;: &quot;.ds-console-2021.08.18-000002&quot;,             &quot;managed&quot;: true,             &quot;policy&quot;: &quot;console&quot;,             &quot;lifecycle_date_millis&quot;: 1629277498775,             &quot;age&quot;: &quot;2.64h&quot;,             &quot;phase&quot;: &quot;hot&quot;,             &quot;phase_time_millis&quot;: 1629277450334,             &quot;action&quot;: &quot;complete&quot;,             &quot;action_time_millis&quot;: 1629278605586,             &quot;step&quot;: &quot;complete&quot;,             &quot;step_time_millis&quot;: 1629278605586,             &quot;phase_execution&quot;: {                 &quot;policy&quot;: &quot;console&quot;,                 &quot;phase_definition&quot;: {                     &quot;min_age&quot;: &quot;0s&quot;,                     &quot;actions&quot;: {                         &quot;rollover&quot;: {                             &quot;max_size&quot;: &quot;1gb&quot;,                             &quot;max_age&quot;: &quot;1d&quot;,                             &quot;max_docs&quot;: 10000                         },                         &quot;set_priority&quot;: {                             &quot;priority&quot;: 1000                         }                     }                 },                 &quot;version&quot;: 1,                 &quot;modified_date_in_millis&quot;: 1629277370953             }         }     } }</para>
            /// </summary>
            [NameInMap("ilmExplain")]
            [Validation(Required=false)]
            public string IlmExplain { get; set; }

            /// <summary>
            /// <para>This parameter is deprecated and can be ignored.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("isManaged")]
            [Validation(Required=false)]
            public string IsManaged { get; set; }

            /// <summary>
            /// <para>The managed status of the index. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>following: Managed.</para>
            /// </description></item>
            /// <item><description><para>closing: Being unmanaged.</para>
            /// </description></item>
            /// <item><description><para>closed: Not managed.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>closing</para>
            /// </summary>
            [NameInMap("managedStatus")]
            [Validation(Required=false)]
            public string ManagedStatus { get; set; }

            /// <summary>
            /// <para>The index name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>.kibana_task_manager_1</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The current storage lifecycle phase. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>warm: Warm phase.</para>
            /// </description></item>
            /// <item><description><para>cold: Cold phase.</para>
            /// </description></item>
            /// <item><description><para>hot: Hot phase.</para>
            /// </description></item>
            /// <item><description><para>delete: Delete phase.</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>If this parameter is empty, the index is not managed by a lifecycle policy.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>warm</para>
            /// </summary>
            [NameInMap("phase")]
            [Validation(Required=false)]
            public string Phase { get; set; }

            /// <summary>
            /// <para>The total storage space occupied by the index. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>49298589</para>
            /// </summary>
            [NameInMap("size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

        }

    }

}
