// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class NodeStatistics : TeaModel {
        /// <summary>
        /// <para>The total resources.</para>
        /// </summary>
        [NameInMap("ActualMinResources")]
        [Validation(Required=false)]
        public StatisticsResources ActualMinResources { get; set; }

        /// <summary>
        /// <para>The GPU idle statistics.</para>
        /// </summary>
        [NameInMap("GPUDetails")]
        [Validation(Required=false)]
        public List<NodeStatisticsGPUDetails> GPUDetails { get; set; }
        public class NodeStatisticsGPUDetails : TeaModel {
            /// <summary>
            /// <para>The count.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public long? Count { get; set; }

            /// <summary>
            /// <para>The idle count.</para>
            /// 
            /// <b>Example:</b>
            /// <para>16</para>
            /// </summary>
            [NameInMap("IdleNum")]
            [Validation(Required=false)]
            public long? IdleNum { get; set; }

        }

        /// <summary>
        /// <para>The hypernode idle statistics.</para>
        /// </summary>
        [NameInMap("HyperNodeDetails")]
        [Validation(Required=false)]
        public List<NodeStatisticsHyperNodeDetails> HyperNodeDetails { get; set; }
        public class NodeStatisticsHyperNodeDetails : TeaModel {
            /// <summary>
            /// <para>The count.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public long? Count { get; set; }

            /// <summary>
            /// <para>The idle count.</para>
            /// 
            /// <b>Example:</b>
            /// <para>18</para>
            /// </summary>
            [NameInMap("IdleNum")]
            [Validation(Required=false)]
            public long? IdleNum { get; set; }

        }

        /// <summary>
        /// <para>The idle resources.</para>
        /// </summary>
        [NameInMap("IdleResources")]
        [Validation(Required=false)]
        public StatisticsResources IdleResources { get; set; }

        /// <summary>
        /// <para>The amount of scheduling resources.</para>
        /// </summary>
        [NameInMap("SchedulableResources")]
        [Validation(Required=false)]
        public StatisticsResources SchedulableResources { get; set; }

        /// <summary>
        /// <para>The system reserved resources.</para>
        /// </summary>
        [NameInMap("SystemReservedResources")]
        [Validation(Required=false)]
        public StatisticsResources SystemReservedResources { get; set; }

    }

}
