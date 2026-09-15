// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class ListLumaKnowledgeBasesResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code. A value of Success indicates a successful call. Otherwise, a specific error code is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The list of knowledge bases bound to the agent. All results are returned at once without pagination.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListLumaKnowledgeBasesResponseBodyData Data { get; set; }
        public class ListLumaKnowledgeBasesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of knowledge bases bound to the agent.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;KnowledgeBaseName&quot;:&quot;my-knowledge-base&quot;}]</para>
            /// </summary>
            [NameInMap("KnowledgeBases")]
            [Validation(Required=false)]
            public List<KnowledgeBase> KnowledgeBases { get; set; }

        }

        /// <summary>
        /// <para>The message returned by the operation. The value is Operation success if the call succeeds, or a specific error description if the call fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Operation success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The unique identifier of the request, used for troubleshooting and ticket feedback.</para>
        /// 
        /// <b>Example:</b>
        /// <para>34AD682D-5B91-5773-8132-AA38C130****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful. A value of true indicates success.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
