// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class ListDialogueFlowsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("DialogueFlows")]
        [Validation(Required=false)]
        public List<ListDialogueFlowsResponseBodyDialogueFlows> DialogueFlows { get; set; }
        public class ListDialogueFlowsResponseBodyDialogueFlows : TeaModel {
            [NameInMap("DialogueFlowDefinition")]
            [Validation(Required=false)]
            public string DialogueFlowDefinition { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>dae01529-3c3e-458e-b07a-97643d09ebb9</para>
            /// </summary>
            [NameInMap("DialogueFlowId")]
            [Validation(Required=false)]
            public string DialogueFlowId { get; set; }

            [NameInMap("DialogueFlowName")]
            [Validation(Required=false)]
            public string DialogueFlowName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>MainFlow</para>
            /// </summary>
            [NameInMap("DialogueFlowType")]
            [Validation(Required=false)]
            public string DialogueFlowType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2d5aa451-661f-4f08-b0c4-28eec78decc4</para>
            /// </summary>
            [NameInMap("ScriptId")]
            [Validation(Required=false)]
            public string ScriptId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1569220563549</para>
            /// </summary>
            [NameInMap("ScriptVersion")]
            [Validation(Required=false)]
            public string ScriptVersion { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>254EB995-DEDF-48A4-9101-9CA5B72FFBCC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
