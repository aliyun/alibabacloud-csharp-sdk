// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class GetDasAgentSSEResponseBody : TeaModel {
        /// <summary>
        /// <para>The content of the response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-xxxx</para>
        /// </summary>
        [NameInMap("Answer")]
        [Validation(Required=false)]
        public string Answer { get; set; }

        /// <summary>
        /// <para>The type of the response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>summary</para>
        /// </summary>
        [NameInMap("Event")]
        [Validation(Required=false)]
        public string Event { get; set; }

        /// <summary>
        /// <para>The session ID. This is the same as the SessionId in the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-xxxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>The metadata.</para>
        /// </summary>
        [NameInMap("Metadata")]
        [Validation(Required=false)]
        public GetDasAgentSSEResponseBodyMetadata Metadata { get; set; }
        public class GetDasAgentSSEResponseBodyMetadata : TeaModel {
            /// <summary>
            /// <para>The number of characters in the response.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1403</para>
            /// </summary>
            [NameInMap("CharCount")]
            [Validation(Required=false)]
            public long? CharCount { get; set; }

            /// <summary>
            /// <para>The error code. This parameter is empty if no exception occurs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>-1810001</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public int? Code { get; set; }

            /// <summary>
            /// <para>The request ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>04930480-9404-50CB-8252-Axxxxxxxx</para>
            /// </summary>
            [NameInMap("RequestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

            /// <summary>
            /// <para>The name of the tool used.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SqlFilter</para>
            /// </summary>
            [NameInMap("ToolName")]
            [Validation(Required=false)]
            public string ToolName { get; set; }

            /// <summary>
            /// <para>The tool parameters.</para>
            /// </summary>
            [NameInMap("ToolParams")]
            [Validation(Required=false)]
            public List<string> ToolParams { get; set; }

        }

    }

}
