// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Bailian20231229.Models
{
    public class DescribeFileResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data fields.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeFileResponseBodyData Data { get; set; }
        public class DescribeFileResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The ID of the category to which the document belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cate_cdd11b1b79a74e8bbd675c356a91ee3XXXXXXXX</para>
            /// </summary>
            [NameInMap("CategoryId")]
            [Validation(Required=false)]
            public string CategoryId { get; set; }

            /// <summary>
            /// <para>The timestamp when the document was uploaded to Model Studio. Format: yyyy-MM-dd HH:mm:ss. Time zone: UTC + 8.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-05-26 12:45:43</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The primary key ID of the document.</para>
            /// 
            /// <b>Example:</b>
            /// <para>file_9a65732555b54d5ea10796ca5742ba22_XXXXXXXX</para>
            /// </summary>
            [NameInMap("FileId")]
            [Validation(Required=false)]
            public string FileId { get; set; }

            /// <summary>
            /// <para>The name of the document.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test.pdf</para>
            /// </summary>
            [NameInMap("FileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            /// <summary>
            /// <para>The file type of the document. The value is an extension. Valid values: pdf, docx, doc, txt, md, pptx, and ppt.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pdf</para>
            /// </summary>
            [NameInMap("FileType")]
            [Validation(Required=false)]
            public string FileType { get; set; }

            [NameInMap("ParseResultDownloadUrl")]
            [Validation(Required=false)]
            public string ParseResultDownloadUrl { get; set; }

            /// <summary>
            /// <para>The parser that is used to parse the document. Valid value:</para>
            /// <list type="bullet">
            /// <item><description>DASHSCOPE_DOCMIND: The default document parser.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>DASHSCOPE_DOCMIND</para>
            /// </summary>
            [NameInMap("Parser")]
            [Validation(Required=false)]
            public string Parser { get; set; }

            /// <summary>
            /// <para>The size of the document. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234</para>
            /// </summary>
            [NameInMap("SizeInBytes")]
            [Validation(Required=false)]
            public long? SizeInBytes { get; set; }

            /// <summary>
            /// <para>The status of the document. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>INIT: pending parsing.</description></item>
            /// <item><description>PARSING</description></item>
            /// <item><description>PARSE_SUCCESS</description></item>
            /// <item><description>PARSE_FAILED</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PARSE_SUCCESS</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The tags that are associated with the document. A document can be associated with multiple tags.</para>
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
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>Indications whether the API call is successful. Valid values:</para>
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
