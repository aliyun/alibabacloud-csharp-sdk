// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Bailian20231229.Models
{
    public class DescribeFileResponseBody : TeaModel {
        /// <summary>
        /// <para>The error status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The data field of the operation.</para>
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
            /// <para>The file ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>file_9a65732555b54d5ea10796ca5742ba22_xxxxxxxx</para>
            /// </summary>
            [NameInMap("FileId")]
            [Validation(Required=false)]
            public string FileId { get; set; }

            /// <summary>
            /// <para>The file name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>XXX产品介绍.pdf</para>
            /// </summary>
            [NameInMap("FileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            /// <summary>
            /// <para>The file type (extension). Valid values: pdf, docx, doc, txt, md, pptx, ppt, xlsx, xls, html, png, jpg, jpeg, bmp, and gif.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pdf</para>
            /// </summary>
            [NameInMap("FileType")]
            [Validation(Required=false)]
            public string FileType { get; set; }

            [NameInMap("ParseErrorMessage")]
            [Validation(Required=false)]
            public string ParseErrorMessage { get; set; }

            [NameInMap("ParseResultDownloadUrl")]
            [Validation(Required=false)]
            public string ParseResultDownloadUrl { get; set; }

            /// <summary>
            /// <para>The parser type used to parse the file. Valid values:</para>
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
            /// <para>The file size, in bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234</para>
            /// </summary>
            [NameInMap("SizeInBytes")]
            [Validation(Required=false)]
            public long? SizeInBytes { get; set; }

            /// <summary>
            /// <para>&lt;props=&quot;china&quot;&gt;</para>
            /// <para>For files used in document-based knowledge bases (type: UNSTRUCTURED), valid values:</para>
            /// <para>&lt;props=&quot;intl&quot;&gt;</para>
            /// <para>For files used in unstructured knowledge bases (type: UNSTRUCTURED), valid values:</para>
            /// <list type="bullet">
            /// <item><description>INIT: pending parsing.</description></item>
            /// <item><description>IN_PARSE_QUEUE: queued for parsing.</description></item>
            /// <item><description>PARSING: being parsed.</description></item>
            /// <item><description>PARSE_SUCCESS: parsing completed.
            /// <note>The document can be imported into a knowledge base only after the status changes to PARSE_SUCCESS.</note></description></item>
            /// <item><description>PARSE_FAILED: parsing failed.</description></item>
            /// </list>
            /// <para>&lt;props=&quot;china&quot;&gt;
            /// For files used in agent application <a href="https://www.alibabacloud.com/help/en/model-studio/user-guide/file-interaction">session interaction</a> (type: SESSION_FILE), valid values:</para>
            /// <list type="bullet">
            /// <item><description>INIT: pending parsing.</description></item>
            /// <item><description>IN_PARSE_QUEUE: queued for parsing.</description></item>
            /// <item><description>PARSING: being parsed.</description></item>
            /// <item><description>PARSE_SUCCESS: parsing completed.</description></item>
            /// <item><description>PARSE_FAILED: parsing failed.</description></item>
            /// <item><description>SAFE_CHECKING: security check in progress.</description></item>
            /// <item><description>SAFE_CHECK_FAILED: security check failed.</description></item>
            /// <item><description>INDEX_BUILDING: index being built.</description></item>
            /// <item><description>INDEX_BUILD_SUCCESS: index built.</description></item>
            /// <item><description>INDEX_BUILDING_FAILED: index building failed.</description></item>
            /// <item><description>INDEX_DELETED: file index deleted.</description></item>
            /// <item><description>FILE_IS_READY: file is ready.
            /// <note>Q&amp;A can proceed only after the status changes to FILE_IS_READY.</note></description></item>
            /// <item><description>FILE_EXPIRED: file expired.
            /// <note>The file is valid only for the current user session. After the user closes the session, the file expires (maximum validity period: 7 days). Long-term retention is not supported.</note>
            /// .</description></item>
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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>17204B98-xxxx-4F9A-8464-2446A84821CA</para>
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
