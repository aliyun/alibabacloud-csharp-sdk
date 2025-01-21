// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GetMediaConnectFlowResponseBody : TeaModel {
        [NameInMap("Content")]
        [Validation(Required=false)]
        public GetMediaConnectFlowResponseBodyContent Content { get; set; }
        public class GetMediaConnectFlowResponseBodyContent : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-07-18T01:29:24Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>34900dc6-90ec-4968-af3c-fcd87f231a5f</para>
            /// </summary>
            [NameInMap("FlowId")]
            [Validation(Required=false)]
            public string FlowId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>WorkTypeAfterRefresh</para>
            /// </summary>
            [NameInMap("FlowName")]
            [Validation(Required=false)]
            public string FlowName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Enabled</para>
            /// </summary>
            [NameInMap("FlowStatus")]
            [Validation(Required=false)]
            public string FlowStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2020-05-11T02:40Z</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ok</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>FB503AEF-118E-1516-89E2-7B227EA1AC20</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Retcode")]
        [Validation(Required=false)]
        public int? Retcode { get; set; }

    }

}
