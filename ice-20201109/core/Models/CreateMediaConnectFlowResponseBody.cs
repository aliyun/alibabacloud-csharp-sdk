// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class CreateMediaConnectFlowResponseBody : TeaModel {
        /// <summary>
        /// <para>Response body</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public CreateMediaConnectFlowResponseBodyContent Content { get; set; }
        public class CreateMediaConnectFlowResponseBodyContent : TeaModel {
            /// <summary>
            /// <para>Flow instance ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>34900dc6-90ec-4968-af3c-fcd87f231a5f</para>
            /// </summary>
            [NameInMap("FlowId")]
            [Validation(Required=false)]
            public string FlowId { get; set; }

        }

        /// <summary>
        /// <para>Description information returned by the interface</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>86D92F9D-65E8-58A2-85D1-9DEEECC172E8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Returned error code, 0 indicates success</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("RetCode")]
        [Validation(Required=false)]
        public int? RetCode { get; set; }

    }

}
