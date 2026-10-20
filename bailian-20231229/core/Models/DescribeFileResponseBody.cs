// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Bailian20231229.Models
{
    public class DescribeFileResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The business data field.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeFileResponseBodyData Data { get; set; }
        public class DescribeFileResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The ID of the category to which the file belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cate_cdd11b1b79a74e8bbd675c356a91ee3xxxxxxxx</para>
            /// </summary>
            [NameInMap("CategoryId")]
            [Validation(Required=false)]
            public string CategoryId { get; set; }

            /// <summary>
            /// <para>The timestamp when the file was added to Model Studio. Format: yyyy-MM-dd HH:mm:ss. Time zone: UTC+8.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-09-09 12:45:43</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The ID of the file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>file_9a65732555b54d5ea10796ca5742ba22_xxxxxxxx</para>
            /// </summary>
            [NameInMap("FileId")]
            [Validation(Required=false)]
            public string FileId { get; set; }

            /// <summary>
            /// <para>The name of the file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>XXX Product Introduction.pdf</para>
            /// </summary>
            [NameInMap("FileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            /// <summary>
            /// <para>The file type, which is the file extension. Valid values: pdf, docx, doc, txt, md, pptx, ppt, xlsx, xls, html, png, jpg, jpeg, bmp, and gif.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pdf</para>
            /// </summary>
            [NameInMap("FileType")]
            [Validation(Required=false)]
            public string FileType { get; set; }

            /// <summary>
            /// <para>The download URL of the source file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>https:xxxx.com/xxx.pdf?sign=xxxx&amp;expiredAt=xxxx</para>
            /// </summary>
            [NameInMap("OriginFileDownloadUrl")]
            [Validation(Required=false)]
            public string OriginFileDownloadUrl { get; set; }

            /// <summary>
            /// <para>The cause of the parsing failure.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Error Message</para>
            /// </summary>
            [NameInMap("ParseErrorMessage")]
            [Validation(Required=false)]
            public string ParseErrorMessage { get; set; }

            /// <summary>
            /// <para>The download URL of the file parsing result.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://example.com/parse-result">https://example.com/parse-result</a></para>
            /// </summary>
            [NameInMap("ParseResultDownloadUrl")]
            [Validation(Required=false)]
            public string ParseResultDownloadUrl { get; set; }

            /// <summary>
            /// <para>The type of the parser used to parse the file. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>DASHSCOPE_DOCMIND: the default document parser.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>DASHSCOPE_DOCMIND</para>
            /// </summary>
            [NameInMap("Parser")]
            [Validation(Required=false)]
            public string Parser { get; set; }

            /// <summary>
            /// <para>The size of the file, in bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234</para>
            /// </summary>
            [NameInMap("SizeInBytes")]
            [Validation(Required=false)]
            public long? SizeInBytes { get; set; }

            /// <summary>
            /// <para>&lt;props=&quot;china&quot;&gt;</para>
            /// <para>The status of a file used for a document knowledge base (type: UNSTRUCTURED). Valid values:</para>
            /// <para>&lt;props=&quot;intl&quot;&gt;</para>
            /// <para>The status of a file used for an unstructured knowledge base (type: UNSTRUCTURED). Valid values:</para>
            /// <list type="bullet">
            /// <item><description>INIT: to be parsed.</description></item>
            /// <item><description>IN_PARSE_QUEUE: queuing for parsing.</description></item>
            /// <item><description>PARSING: parsing.</description></item>
            /// <item><description>PARSE_SUCCESS: parsed.
            /// <note>You can import a document into a knowledge base only after its status changes to PARSE_SUCCESS.</note></description></item>
            /// <item><description>PARSE_FAILED: parsing failed.</description></item>
            /// </list>
            /// <para>&lt;props=&quot;china&quot;&gt;
            /// The status of a file used for <a href="https://www.alibabacloud.com/help/en/model-studio/user-guide/file-interaction">session interaction</a> in an agent application (type: SESSION_FILE). Valid values:</para>
            /// <list type="bullet">
            /// <item><description>INIT: to be parsed.</description></item>
            /// <item><description>IN_PARSE_QUEUE: queuing for parsing.</description></item>
            /// <item><description>PARSING: parsing.</description></item>
            /// <item><description>PARSE_SUCCESS: parsed.</description></item>
            /// <item><description>PARSE_FAILED: parsing failed.</description></item>
            /// <item><description>SAFE_CHECKING: undergoing security check.</description></item>
            /// <item><description>SAFE_CHECK_FAILED: security check failed.</description></item>
            /// <item><description>INDEX_BUILDING: building index.</description></item>
            /// <item><description>INDEX_BUILD_SUCCESS: index built.</description></item>
            /// <item><description>INDEX_BUILDING_FAILED: index building failed.</description></item>
            /// <item><description>INDEX_DELETED: file index deleted.</description></item>
            /// <item><description>FILE_IS_READY: file ready.
            /// <note>You can perform Q&amp;A only after the status changes to FILE_IS_READY.</note></description></item>
            /// <item><description>FILE_EXPIRED: file expired.
            /// <note>The file is valid only for the current session of the user. After the user closes the session, the file expires. The maximum validity period is 7 days. Long-term storage is not supported.</note></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PARSE_SUCCESS</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The list of tags associated with the file. A file can be associated with multiple tags.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<string> Tags { get; set; }

        }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Requests throttling triggered.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>17204B98-xxxx-4F9A-8464-2446A84821CA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The status code returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>Indicates whether the operation was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The operation was successful.</description></item>
        /// <item><description>false: The operation failed.</description></item>
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
