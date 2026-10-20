// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Bailian20231229.Models
{
    public class GetParseSettingsResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The business data returned when the request is successful.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetParseSettingsResponseBodyData> Data { get; set; }
        public class GetParseSettingsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The file type, specified as a file extension. Valid values include pdf, docx, and doc. All file types supported in the current category are listed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pdf</para>
            /// </summary>
            [NameInMap("FileType")]
            [Validation(Required=false)]
            public string FileType { get; set; }

            /// <summary>
            /// <para>The parser used to parse files of the current type under this category. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>DOCMIND: Intelligent Document Parsing.</description></item>
            /// <item><description>DOCMIND_DIGITAL: Electronic Document Parsing.</description></item>
            /// <item><description>DOCMIND_LLM_VERSION: LLM-based Document Parsing.</description></item>
            /// <item><description>DASH_QWEN_VL_PARSER: Qwen VL Parsing.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>DOCMIND</para>
            /// </summary>
            [NameInMap("Parser")]
            [Validation(Required=false)]
            public string Parser { get; set; }

            /// <summary>
            /// <para>The parser configuration. This parameter is returned only when the type is set to Qwen VL parsing.</para>
            /// </summary>
            [NameInMap("ParserConfig")]
            [Validation(Required=false)]
            public GetParseSettingsResponseBodyDataParserConfig ParserConfig { get; set; }
            public class GetParseSettingsResponseBodyDataParserConfig : TeaModel {
                /// <summary>
                /// <para>The model name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>qwen-vl-max</para>
                /// </summary>
                [NameInMap("ModelName")]
                [Validation(Required=false)]
                public string ModelName { get; set; }

                /// <summary>
                /// <para>The prompt used when calling Qwen VL parsing.</para>
                /// 
                /// <b>Example:</b>
                /// <h1>Role</h1>
                /// <para>You are a professional image content annotator who excels at identifying and describing the content in images.</para>
                /// <h1>Task Objective</h1>
                /// <para>Based on the input image, describe the content in the image in detail</para>
                /// </summary>
                [NameInMap("ModelPrompt")]
                [Validation(Required=false)]
                public string ModelPrompt { get; set; }

            }

            /// <summary>
            /// <para>The display name of the parsing method.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Electronic Document Parsing</para>
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
        /// <para>The status code returned by the operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Successful.</description></item>
        /// <item><description>false: Failed.</description></item>
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
