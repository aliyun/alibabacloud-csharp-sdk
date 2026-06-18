// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_controller20221215.Models
{
    public class ChangeNodeTypesResponseBody : TeaModel {
        /// <summary>
        /// <para>The responses for the nodes.</para>
        /// </summary>
        [NameInMap("NodeResponse")]
        [Validation(Required=false)]
        public List<ChangeNodeTypesResponseBodyNodeResponse> NodeResponse { get; set; }
        public class ChangeNodeTypesResponseBodyNodeResponse : TeaModel {
            /// <summary>
            /// <para>The response code for the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PASSED</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <para>The response message for the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>success</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The ID of the node included in the response.</para>
            /// 
            /// <b>Example:</b>
            /// <para>e01-in-067da4ca9c2</para>
            /// </summary>
            [NameInMap("NodeId")]
            [Validation(Required=false)]
            public string NodeId { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>887FA855-89F4-5DB3-B305-C5879EC480E6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The task ID. A task ID is returned only if all nodes pass the precheck. If an exception occurs, this parameter is empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i158475611663639202234</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
