// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Bailian20231229.Models
{
    public class GetParseSettingsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetParseSettingsResponseBodyData> Data { get; set; }
        public class GetParseSettingsResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>pdf</para>
            /// </summary>
            [NameInMap("FileType")]
            [Validation(Required=false)]
            public string FileType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>DOCMIND</para>
            /// </summary>
            [NameInMap("Parser")]
            [Validation(Required=false)]
            public string Parser { get; set; }

            [NameInMap("ParserConfig")]
            [Validation(Required=false)]
            public GetParseSettingsResponseBodyDataParserConfig ParserConfig { get; set; }
            public class GetParseSettingsResponseBodyDataParserConfig : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <list type="bullet">
                /// <item><description>qwen-vl-max</description></item>
                /// <item><description>qwen-vl-plus</description></item>
                /// </list>
                /// </summary>
                [NameInMap("ModelName")]
                [Validation(Required=false)]
                public string ModelName { get; set; }

                [NameInMap("ModelPrompt")]
                [Validation(Required=false)]
                public string ModelPrompt { get; set; }

            }

            [NameInMap("ParserDisplayName")]
            [Validation(Required=false)]
            public string ParserDisplayName { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>workspace id is null or invalid.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>35A267BF-xxxx-54DB-8394-AA3B0742D833</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
