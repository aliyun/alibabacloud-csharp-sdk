// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Bailian20231229.Models
{
    public class GetAvailableParserTypesResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DataCenter.Throttling</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The business data returned upon a successful request.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetAvailableParserTypesResponseBodyData Data { get; set; }
        public class GetAvailableParserTypesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The file type, which is the same as the FileType input parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pdf</para>
            /// </summary>
            [NameInMap("FileType")]
            [Validation(Required=false)]
            public string FileType { get; set; }

            /// <summary>
            /// <para>The list of parsers supported for the specified file type.</para>
            /// </summary>
            [NameInMap("ParserList")]
            [Validation(Required=false)]
            public List<GetAvailableParserTypesResponseBodyDataParserList> ParserList { get; set; }
            public class GetAvailableParserTypesResponseBodyDataParserList : TeaModel {
                /// <summary>
                /// <para>The display name of the parsing method.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Intelligent Document Parsing</para>
                /// </summary>
                [NameInMap("DisplayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                /// <summary>
                /// <para>The parser code. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>DOCMIND: Intelligent Document Parsing.</description></item>
                /// <item><description>DOCMIND_DIGITAL: Electronic Document Parsing.</description></item>
                /// <item><description>DOCMIND_LLM_VERSION: LLM-based Document Parsing.</description></item>
                /// <item><description>DASH_QWEN_VL_PARSER: Qwen-VL Parsing.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>DOCMIND</para>
                /// </summary>
                [NameInMap("Parser")]
                [Validation(Required=false)]
                public string Parser { get; set; }

            }

        }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>User not authorized to operate on the specified resource</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>17204B98-7734-4F9A-8464-2446XXXXXXX</para>
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
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
