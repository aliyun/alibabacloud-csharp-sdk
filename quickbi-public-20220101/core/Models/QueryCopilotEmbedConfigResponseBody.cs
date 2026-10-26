// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class QueryCopilotEmbedConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1FC71085-D5FD-08E0-813A-4D4BD1031BC5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>List of embedded configurations.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<QueryCopilotEmbedConfigResponseBodyResult> Result { get; set; }
        public class QueryCopilotEmbedConfigResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>Robot\&quot;s nickname.</para>
            /// 
            /// <b>Example:</b>
            /// <para>little Q</para>
            /// </summary>
            [NameInMap("AgentName")]
            [Validation(Required=false)]
            public string AgentName { get; set; }

            /// <summary>
            /// <para>Embedding ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9c079710-ddbe-48b3-b495-7c83c8d57cc4</para>
            /// </summary>
            [NameInMap("CopilotId")]
            [Validation(Required=false)]
            public string CopilotId { get; set; }

            /// <summary>
            /// <para>ID of the creator.</para>
            /// 
            /// <b>Example:</b>
            /// <para>qweqw12312423521</para>
            /// </summary>
            [NameInMap("CreateUser")]
            [Validation(Required=false)]
            public string CreateUser { get; set; }

            /// <summary>
            /// <para>Nickname of the creator.</para>
            /// 
            /// <b>Example:</b>
            /// <para>zhangsan</para>
            /// </summary>
            [NameInMap("CreateUserName")]
            [Validation(Required=false)]
            public string CreateUserName { get; set; }

            /// <summary>
            /// <para>Data range (analysis themes and question resources).</para>
            /// </summary>
            [NameInMap("DataRange")]
            [Validation(Required=false)]
            public QueryCopilotEmbedConfigResponseBodyResultDataRange DataRange { get; set; }
            public class QueryCopilotEmbedConfigResponseBodyResultDataRange : TeaModel {
                /// <summary>
                /// <para>Whether all question resources are selected.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true/false</para>
                /// </summary>
                [NameInMap("AllCube")]
                [Validation(Required=false)]
                public bool? AllCube { get; set; }

                /// <summary>
                /// <para>Whether all analysis themes are selected.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true/false</para>
                /// </summary>
                [NameInMap("AllTheme")]
                [Validation(Required=false)]
                public bool? AllTheme { get; set; }

                /// <summary>
                /// <para>Collection of question resource IDs.</para>
                /// </summary>
                [NameInMap("LlmCubes")]
                [Validation(Required=false)]
                public List<string> LlmCubes { get; set; }

                /// <summary>
                /// <para>Collection of analysis theme IDs.</para>
                /// </summary>
                [NameInMap("Themes")]
                [Validation(Required=false)]
                public List<string> Themes { get; set; }

            }

            /// <summary>
            /// <para>ID of the modifier.</para>
            /// 
            /// <b>Example:</b>
            /// <para>asda1231231dfs</para>
            /// </summary>
            [NameInMap("ModifyUser")]
            [Validation(Required=false)]
            public string ModifyUser { get; set; }

            /// <summary>
            /// <para>Module name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>little Q</para>
            /// </summary>
            [NameInMap("ModuleName")]
            [Validation(Required=false)]
            public string ModuleName { get; set; }

            /// <summary>
            /// <para>Name of the embedded module.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0327</para>
            /// </summary>
            [NameInMap("ShowName")]
            [Validation(Required=false)]
            public string ShowName { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the request was successful. Possible values:</para>
        /// <list type="bullet">
        /// <item><description>true: The request was successful.</description></item>
        /// <item><description>false: The request failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
