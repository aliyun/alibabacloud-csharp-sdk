// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class OperatorNode : TeaModel {
        /// <summary>
        /// <para>The child operator queue.</para>
        /// </summary>
        [NameInMap("children")]
        [Validation(Required=false)]
        public List<OperatorNode> Children { get; set; }

        /// <summary>
        /// <para>The operator ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("id")]
        [Validation(Required=false)]
        public int? Id { get; set; }

        /// <summary>
        /// <para>The total number of nodes at the tree level of the operator.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("levelWidth")]
        [Validation(Required=false)]
        public int? LevelWidth { get; set; }

        /// <summary>
        /// <para>The level of the operator in the tree.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("nodeDepth")]
        [Validation(Required=false)]
        public int? NodeDepth { get; set; }

        /// <summary>
        /// <para>The operator name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TableScan</para>
        /// </summary>
        [NameInMap("nodeName")]
        [Validation(Required=false)]
        public string NodeName { get; set; }

        /// <summary>
        /// <para>The left-to-right position of the node at the corresponding level.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("nodeWidth")]
        [Validation(Required=false)]
        public int? NodeWidth { get; set; }

        /// <summary>
        /// <para>The parent operator ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("parentId")]
        [Validation(Required=false)]
        public int? ParentId { get; set; }

        /// <summary>
        /// <para>The operator statistics information.</para>
        /// </summary>
        [NameInMap("stats")]
        [Validation(Required=false)]
        public OperatorNodeStats Stats { get; set; }
        public class OperatorNodeStats : TeaModel {
            /// <summary>
            /// <para>The data volume.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("bytes")]
            [Validation(Required=false)]
            public long? Bytes { get; set; }

            /// <summary>
            /// <para>The number of output rows.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("outputRows")]
            [Validation(Required=false)]
            public long? OutputRows { get; set; }

            /// <summary>
            /// <para>The operator parameters.</para>
            /// </summary>
            [NameInMap("parameters")]
            [Validation(Required=false)]
            public string Parameters { get; set; }

            /// <summary>
            /// <para>The maximum memory size consumed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("peakMemory")]
            [Validation(Required=false)]
            public long? PeakMemory { get; set; }

            /// <summary>
            /// <para>The execution time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("timeCost")]
            [Validation(Required=false)]
            public long? TimeCost { get; set; }

        }

    }

}
