// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class QueryCopilotEmbedConfigResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1FC71085-D5FD-08E0-813A-4D4BD1031BC5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<QueryCopilotEmbedConfigResponseBodyResult> Result { get; set; }
        public class QueryCopilotEmbedConfigResponseBodyResult : TeaModel {
            [NameInMap("AgentName")]
            [Validation(Required=false)]
            public string AgentName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>9c079710-ddbe-48b3-b495-7c83c8d57cc4</para>
            /// </summary>
            [NameInMap("CopilotId")]
            [Validation(Required=false)]
            public string CopilotId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>qweqw12312423521</para>
            /// </summary>
            [NameInMap("CreateUser")]
            [Validation(Required=false)]
            public string CreateUser { get; set; }

            [NameInMap("CreateUserName")]
            [Validation(Required=false)]
            public string CreateUserName { get; set; }

            [NameInMap("DataRange")]
            [Validation(Required=false)]
            public QueryCopilotEmbedConfigResponseBodyResultDataRange DataRange { get; set; }
            public class QueryCopilotEmbedConfigResponseBodyResultDataRange : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>true/false</para>
                /// </summary>
                [NameInMap("AllCube")]
                [Validation(Required=false)]
                public bool? AllCube { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true/false</para>
                /// </summary>
                [NameInMap("AllTheme")]
                [Validation(Required=false)]
                public bool? AllTheme { get; set; }

                [NameInMap("LlmCubes")]
                [Validation(Required=false)]
                public List<string> LlmCubes { get; set; }

                [NameInMap("Themes")]
                [Validation(Required=false)]
                public List<string> Themes { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>asda1231231dfs</para>
            /// </summary>
            [NameInMap("ModifyUser")]
            [Validation(Required=false)]
            public string ModifyUser { get; set; }

            [NameInMap("ModuleName")]
            [Validation(Required=false)]
            public string ModuleName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0327</para>
            /// </summary>
            [NameInMap("ShowName")]
            [Validation(Required=false)]
            public string ShowName { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
