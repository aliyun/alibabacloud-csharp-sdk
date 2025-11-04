// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class GetDasAgentSSEResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>rm-xxxx</para>
        /// </summary>
        [NameInMap("Answer")]
        [Validation(Required=false)]
        public string Answer { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>summary</para>
        /// </summary>
        [NameInMap("Event")]
        [Validation(Required=false)]
        public string Event { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xxx-xxx-xxx</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        [NameInMap("Metadata")]
        [Validation(Required=false)]
        public GetDasAgentSSEResponseBodyMetadata Metadata { get; set; }
        public class GetDasAgentSSEResponseBodyMetadata : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1403</para>
            /// </summary>
            [NameInMap("CharCount")]
            [Validation(Required=false)]
            public long? CharCount { get; set; }

            [NameInMap("Code")]
            [Validation(Required=false)]
            public int? Code { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>04930480-9404-50CB-8252-Axxxxxxxx</para>
            /// </summary>
            [NameInMap("RequestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>SqlFilter</para>
            /// </summary>
            [NameInMap("ToolName")]
            [Validation(Required=false)]
            public string ToolName { get; set; }

            [NameInMap("ToolParams")]
            [Validation(Required=false)]
            public List<string> ToolParams { get; set; }

        }

    }

}
