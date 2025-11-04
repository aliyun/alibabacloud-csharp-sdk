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
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetAvailableParserTypesResponseBodyData Data { get; set; }
        public class GetAvailableParserTypesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The file type, which is the same as the FileType in the input parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pdf</para>
            /// </summary>
            [NameInMap("FileType")]
            [Validation(Required=false)]
            public string FileType { get; set; }

            /// <summary>
            /// <para>The list of supported parsers</para>
            /// </summary>
            [NameInMap("ParserList")]
            [Validation(Required=false)]
            public List<GetAvailableParserTypesResponseBodyDataParserList> ParserList { get; set; }
            public class GetAvailableParserTypesResponseBodyDataParserList : TeaModel {
                /// <summary>
                /// <para>The display name of the parsing method.</para>
                /// </summary>
                [NameInMap("DisplayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                /// <summary>
                /// <para>The parser code. Valid values:</para>
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

            }

        }

        /// <summary>
        /// <para>The error message that is returned if the request failed.</para>
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
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
