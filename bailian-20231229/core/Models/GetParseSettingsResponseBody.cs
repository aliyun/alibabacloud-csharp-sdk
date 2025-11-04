// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Bailian20231229.Models
{
    public class GetParseSettingsResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data fields.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetParseSettingsResponseBodyData> Data { get; set; }
        public class GetParseSettingsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The file type. Valid values are: pdf, docx, doc, etc. All supported file types in the category are listed here.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pdf</para>
            /// </summary>
            [NameInMap("FileType")]
            [Validation(Required=false)]
            public string FileType { get; set; }

            /// <summary>
            /// <para>The parser used for files of the current type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>DOCMIND (Intelligent parsing)</description></item>
            /// <item><description>DOCMIND_DIGITAL (Digital parsing)</description></item>
            /// <item><description>DOCMIND_LLM_VERSION (LLM parsing)</description></item>
            /// <item><description>DASH_QWEN_VL_PARSER (Qwen VL parsing)</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>DOCMIND</para>
            /// </summary>
            [NameInMap("Parser")]
            [Validation(Required=false)]
            public string Parser { get; set; }

            /// <summary>
            /// <para>The parser configuration. Currently, this is available only for Qwen VL parsing.</para>
            /// </summary>
            [NameInMap("ParserConfig")]
            [Validation(Required=false)]
            public GetParseSettingsResponseBodyDataParserConfig ParserConfig { get; set; }
            public class GetParseSettingsResponseBodyDataParserConfig : TeaModel {
                /// <summary>
                /// <para>The model name.</para>
                /// 
                /// <b>Example:</b>
                /// <list type="bullet">
                /// <item><description>qwen-vl-max</description></item>
                /// <item><description>qwen-vl-plus</description></item>
                /// </list>
                /// </summary>
                [NameInMap("ModelName")]
                [Validation(Required=false)]
                public string ModelName { get; set; }

                /// <summary>
                /// <para>The prompt used for parsing.</para>
                /// 
                /// <b>Example:</b>
                /// <h1>Role</h1>
                /// <para>You are a professional image content annotator, skilled in identifying and describing the contents of images.  </para>
                /// <h1>Task Objective</h1>
                /// <para>Based on the input image, provide a detailed description of its contents.</para>
                /// </summary>
                [NameInMap("ModelPrompt")]
                [Validation(Required=false)]
                public string ModelPrompt { get; set; }

            }

            /// <summary>
            /// <para>The display name of the parsing method.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Digital parsing</para>
            /// </summary>
            [NameInMap("ParserDisplayName")]
            [Validation(Required=false)]
            public string ParserDisplayName { get; set; }

        }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>workspace id is null or invalid.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>35A267BF-xxxx-54DB-8394-AA3B0742D833</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The HTTP status code returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>Indicates whether the call is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
