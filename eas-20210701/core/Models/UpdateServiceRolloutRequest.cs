// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class UpdateServiceRolloutRequest : TeaModel {
        /// <summary>
        /// <para><b>Batch</b>  </para>
        /// <list type="bullet">
        /// <item><description>Type: object</description></item>
        /// <item><description>Required: no</description></item>
        /// <item><description>Description: The batch rollout configuration. Used to adjust batch policy parameters. Mutually exclusive with Partition.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("Batch")]
        [Validation(Required=false)]
        public UpdateServiceRolloutRequestBatch Batch { get; set; }
        public class UpdateServiceRolloutRequestBatch : TeaModel {
            /// <summary>
            /// <para>The batch size. The number of replicas to update in each batch. Integer or percentage formats are supported. Default value: <c>&quot;25%&quot;</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>25%</para>
            /// </summary>
            [NameInMap("BatchSize")]
            [Validation(Required=false)]
            public string BatchSize { get; set; }

            /// <summary>
            /// <para>The batch interval. The wait time between two rollouts. Supported units: <c>s</c> (seconds), <c>m</c> (minutes), and <c>h</c> (hours).</para>
            /// 
            /// <b>Example:</b>
            /// <para>60s</para>
            /// </summary>
            [NameInMap("Interval")]
            [Validation(Required=false)]
            public string Interval { get; set; }

        }

        /// <summary>
        /// <para><b>Partition</b>  </para>
        /// <list type="bullet">
        /// <item><description>Type: object</description></item>
        /// <item><description>Required: no</description></item>
        /// <item><description>Description: The partition rollout configuration. Used to adjust partition policy parameters. Mutually exclusive with Batch.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("Partition")]
        [Validation(Required=false)]
        public UpdateServiceRolloutRequestPartition Partition { get; set; }
        public class UpdateServiceRolloutRequestPartition : TeaModel {
            /// <summary>
            /// <para><b>Partition</b>  </para>
            /// <list type="bullet">
            /// <item><description>Type: string</description></item>
            /// <item><description>Required: yes</description></item>
            /// <item><description>Description: The partition value. Two formats are supported:<ol>
            /// <item><description>Integer format: such as &quot;5&quot;, which indicates that 5 old replicas are retained.</description></item>
            /// <item><description>Percentage format: such as &quot;50%&quot;, which indicates that 50% of the old replicas are retained.
            /// Adjustment strategies:</description></item>
            /// </ol>
            /// <list type="bullet">
            /// <item><description>Increase the value: Roll back to the old version and increase the proportion of old replicas.</description></item>
            /// <item><description>Decrease the value: Proceed to the new version and decrease the proportion of old replicas.</description></item>
            /// <item><description>Set to &quot;0%&quot;: Complete the full update and switch all replicas to the new version.</description></item>
            /// </list>
            /// </description></item>
            /// <item><description>Example: 30%</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>30%</para>
            /// </summary>
            [NameInMap("Partition")]
            [Validation(Required=false)]
            public string Partition { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether to pause the rollout. A value of <c>true</c> indicates that the rollout is paused. A value of <c>false</c> indicates that the rollout is resumed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Paused")]
        [Validation(Required=false)]
        public bool? Paused { get; set; }

    }

}
