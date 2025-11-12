// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_controller20221215.Models
{
    public class ChangeNodeTypesResponseBody : TeaModel {
        [NameInMap("NodeResponse")]
        [Validation(Required=false)]
        public List<ChangeNodeTypesResponseBodyNodeResponse> NodeResponse { get; set; }
        public class ChangeNodeTypesResponseBodyNodeResponse : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>PASSED</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>success</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>e01-in-067da4ca9c2</para>
            /// </summary>
            [NameInMap("NodeId")]
            [Validation(Required=false)]
            public string NodeId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>887FA855-89F4-5DB3-B305-C5879EC480E6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>i158475611663639202234</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
