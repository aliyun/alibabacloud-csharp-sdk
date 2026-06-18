// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Bailian20231229.Models
{
    public class ListFileResponseBody : TeaModel {
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
        /// <para>The data field returned by the operation.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListFileResponseBodyData Data { get; set; }
        public class ListFileResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of files in the category.</para>
            /// </summary>
            [NameInMap("FileList")]
            [Validation(Required=false)]
            public List<ListFileResponseBodyDataFileList> FileList { get; set; }
            public class ListFileResponseBodyDataFileList : TeaModel {
                /// <summary>
                /// <para>The ID of the category to which the file belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cate_cdd11b1b79a74e8bbd675c356a91ee35xxxxxxxx</para>
                /// </summary>
                [NameInMap("CategoryId")]
                [Validation(Required=false)]
                public string CategoryId { get; set; }

                /// <summary>
                /// <para>The timestamp when the file was added to Alibaba Cloud Model Studio. Format: yyyy-MM-dd HH:mm:ss. Time zone: UTC+8.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-09-09 11:03:35</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The file ID, which is the <c>FileId</c> returned by the <b>AddFile</b> operation. You can also obtain it on the &lt;props=&quot;china&quot;&gt;<a href="https://bailian.console.aliyun.com/?tab=app#/data-center">Application Data</a>&lt;props=&quot;intl&quot;&gt;<a href="https://modelstudio.console.alibabacloud.com/?tab=app#/data-center">Application Data</a> page by clicking the icon next to the file name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>file_5ff599b3455a45db8c41b0054b361518_xxxxxxxx</para>
                /// </summary>
                [NameInMap("FileId")]
                [Validation(Required=false)]
                public string FileId { get; set; }

                /// <summary>
                /// <para>The file name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>product-overview.pdf</para>
                /// </summary>
                [NameInMap("FileName")]
                [Validation(Required=false)]
                public string FileName { get; set; }

                /// <summary>
                /// <para>The file format type. Valid values: pdf, docx, doc, txt, md, pptx, ppt, xlsx, xls, html, png, jpg, jpeg, bmp, and gif.</para>
                /// 
                /// <b>Example:</b>
                /// <para>docx</para>
                /// </summary>
                [NameInMap("FileType")]
                [Validation(Required=false)]
                public string FileType { get; set; }

                [NameInMap("ParseErrorMessage")]
                [Validation(Required=false)]
                public string ParseErrorMessage { get; set; }

                /// <summary>
                /// <para>The document parser. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>DASHSCOPE_DOCMIND: Alibaba Cloud intelligent document parsing.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>DASHSCOPE_DOCMIND</para>
                /// </summary>
                [NameInMap("Parser")]
                [Validation(Required=false)]
                public string Parser { get; set; }

                /// <summary>
                /// <para>The file size in bytes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>512</para>
                /// </summary>
                [NameInMap("SizeInBytes")]
                [Validation(Required=false)]
                public long? SizeInBytes { get; set; }

                /// <summary>
                /// <para>The file parsing status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>INIT: Initialization state, waiting to be scheduled.</description></item>
                /// <item><description>PARSING: Parsing in progress.</description></item>
                /// <item><description>PARSE_SUCCESS: Parsing completed.</description></item>
                /// <item><description>PARSE_FAILED: Parsing failed.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>PARSE_SUCCESS</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The list of tags associated with the file. A document can be associated with multiple tags.</para>
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public List<string> Tags { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether there is a next page of category data that matches the query conditions. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Yes.</description></item>
            /// <item><description>false: No.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("HasNext")]
            [Validation(Required=false)]
            public bool? HasNext { get; set; }

            /// <summary>
            /// <para>The number of entries per page for paging.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("MaxResults")]
            [Validation(Required=false)]
            public int? MaxResults { get; set; }

            /// <summary>
            /// <para>The pagination token returned by this call.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4jzbJk9J6lNeuXD9hP0viA==</para>
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            /// <summary>
            /// <para>The total number of entries in the returned results.</para>
            /// 
            /// <b>Example:</b>
            /// <para>48</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

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
        /// <para>8F97A63B-xxxx-527F-9D6E-467B6A7E8CF1</para>
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
        /// <para>Indicates whether the operation was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Successful. </description></item>
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
