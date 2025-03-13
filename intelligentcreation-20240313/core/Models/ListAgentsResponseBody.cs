// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IntelligentCreation20240313.Models
{
    public class ListAgentsResponseBody : TeaModel {
        [NameInMap("list")]
        [Validation(Required=false)]
        public List<ListAgentsResponseBodyList> List { get; set; }
        public class ListAgentsResponseBodyList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>840016700254633984</para>
            /// </summary>
            [NameInMap("agentId")]
            [Validation(Required=false)]
            public string AgentId { get; set; }

            [NameInMap("agentName")]
            [Validation(Required=false)]
            public string AgentName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>text</para>
            /// </summary>
            [NameInMap("agentScene")]
            [Validation(Required=false)]
            public string AgentScene { get; set; }

            [NameInMap("charactersDescription")]
            [Validation(Required=false)]
            public string CharactersDescription { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("enableInteraction")]
            [Validation(Required=false)]
            public int? EnableInteraction { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Car</para>
            /// </summary>
            [NameInMap("industry")]
            [Validation(Required=false)]
            public string Industry { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("onlineSearch")]
            [Validation(Required=false)]
            public bool? OnlineSearch { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>SYSTEM</para>
            /// </summary>
            [NameInMap("owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>http
            /// ;//<a href="http://www.abc.com/111.mp4">www.abc.com/111.mp4</a></para>
            /// </summary>
            [NameInMap("referenceUrl")]
            [Validation(Required=false)]
            public string ReferenceUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>RED_BOOK</para>
            /// </summary>
            [NameInMap("textStyle")]
            [Validation(Required=false)]
            public string TextStyle { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Seller</para>
            /// </summary>
            [NameInMap("viewer")]
            [Validation(Required=false)]
            public string Viewer { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>86A90C40-D1AB-50DA-A4B1-0D545F80F2FE</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
