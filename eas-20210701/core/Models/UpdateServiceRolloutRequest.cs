// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class UpdateServiceRolloutRequest : TeaModel {
        /// <summary>
        /// <para>The batch rollout configuration. This parameter is mutually exclusive with <c>Partition</c>.</para>
        /// <list type="bullet">
        /// <item><description><para>Type: object</para>
        /// </description></item>
        /// <item><description><para>Required: No</para>
        /// </description></item>
        /// <item><description><para>Description: The batch rollout configuration for adjusting batch policy parameters. This parameter is mutually exclusive with Partition.</para>
        /// </description></item>
        /// </list>
        /// </summary>
        [NameInMap("Batch")]
        [Validation(Required=false)]
        public UpdateServiceRolloutRequestBatch Batch { get; set; }
        public class UpdateServiceRolloutRequestBatch : TeaModel {
            /// <summary>
            /// <para>The number of replicas to update in each batch. This can be an integer or a percentage. The default is <c>&quot;25%&quot;</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>25%</para>
            /// </summary>
            [NameInMap("BatchSize")]
            [Validation(Required=false)]
            public string BatchSize { get; set; }

            /// <summary>
            /// <para>The interval to wait between batches. Supported units include <c>s</c> (seconds), <c>m</c> (minutes), and <c>h</c> (hours).</para>
            /// 
            /// <b>Example:</b>
            /// <para>60s</para>
            /// </summary>
            [NameInMap("Interval")]
            [Validation(Required=false)]
            public string Interval { get; set; }

        }

        /// <summary>
        /// <para>The partition rollout configuration. This parameter is mutually exclusive with <c>Batch</c>.</para>
        /// <list type="bullet">
        /// <item><description><para>Type: object</para>
        /// </description></item>
        /// <item><description><para>Required: No</para>
        /// </description></item>
        /// <item><description><para>Description: The partition rollout configuration. This parameter adjusts the parameters for the partition strategy. It is mutually exclusive with <c>Batch</c>.</para>
        /// </description></item>
        /// </list>
        /// </summary>
        [NameInMap("Partition")]
        [Validation(Required=false)]
        public UpdateServiceRolloutRequestPartition Partition { get; set; }
        public class UpdateServiceRolloutRequestPartition : TeaModel {
            /// <summary>
            /// <para><b>Partition value</b></para>
            /// <list type="bullet">
            /// <item><description><para>Type: string</para>
            /// </description></item>
            /// <item><description><para>Required: Yes</para>
            /// </description></item>
            /// <item><description><para>Description: The partition value. This parameter specifies the number or percentage of old-version replicas to retain. It supports two formats:</para>
            /// <ol>
            /// <item><description><para>An integer, such as &quot;5&quot;, for the number of replicas.</para>
            /// </description></item>
            /// <item><description><para>A percentage, such as &quot;50%&quot;, for the proportion of replicas.</para>
            /// </description></item>
            /// </ol>
            /// <para>Adjustment strategy:</para>
            /// <list type="bullet">
            /// <item><description><para>Increasing the value rolls back to the previous version by increasing the number of old-version replicas.</para>
            /// </description></item>
            /// <item><description><para>Decreasing the value continues the rollout by reducing the number of old-version replicas.</para>
            /// </description></item>
            /// <item><description><para>Setting the value to &quot;0&quot; or &quot;0%&quot; completes the rollout, replacing all old-version replicas.</para>
            /// </description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para>Example: 30%</para>
            /// </description></item>
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
        /// <para>Set to <c>true</c> to pause the rollout or <c>false</c> to resume it.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Paused")]
        [Validation(Required=false)]
        public bool? Paused { get; set; }

    }

}
