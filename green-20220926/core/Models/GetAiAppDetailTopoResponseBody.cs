// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220926.Models
{
    public class GetAiAppDetailTopoResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetAiAppDetailTopoResponseBodyData> Data { get; set; }
        public class GetAiAppDetailTopoResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The node category.</para>
            /// <list type="bullet">
            /// <item><description><para>LLM</para>
            /// </description></item>
            /// <item><description><para>Knowledge</para>
            /// </description></item>
            /// <item><description><para>Tools</para>
            /// </description></item>
            /// <item><description><para>Others</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>LLM</para>
            /// </summary>
            [NameInMap("NodeCategory")]
            [Validation(Required=false)]
            public string NodeCategory { get; set; }

            /// <summary>
            /// <para>The node ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>idxxx</para>
            /// </summary>
            [NameInMap("NodeId")]
            [Validation(Required=false)]
            public string NodeId { get; set; }

            /// <summary>
            /// <para>The node name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>namexxx</para>
            /// </summary>
            [NameInMap("NodeName")]
            [Validation(Required=false)]
            public string NodeName { get; set; }

            /// <summary>
            /// <para>The node type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>APP</b>: end-to-end agent.</description></item>
            /// <item><description><b>MODEL</b>: large language model.</description></item>
            /// <item><description><b>TOOL</b>: tool.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>TOOL</para>
            /// </summary>
            [NameInMap("NodeType")]
            [Validation(Required=false)]
            public string NodeType { get; set; }

            /// <summary>
            /// <para>The request count.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("RequestCount")]
            [Validation(Required=false)]
            public long? RequestCount { get; set; }

            /// <summary>
            /// <para>The risk level.</para>
            /// 
            /// <b>Example:</b>
            /// <para>high</para>
            /// </summary>
            [NameInMap("RiskLevel")]
            [Validation(Required=false)]
            public string RiskLevel { get; set; }

            /// <summary>
            /// <para>The alert count.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("WarningCount")]
            [Validation(Required=false)]
            public int? WarningCount { get; set; }

        }

        /// <summary>
        /// <para>The ID assigned by the backend to uniquely identify a request. You can use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAA-BBBB-CCCCC-DDDD-EEEEEEEE****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
