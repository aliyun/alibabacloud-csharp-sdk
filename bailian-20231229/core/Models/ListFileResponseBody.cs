// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Bailian20231229.Models
{
    public class ListFileResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListFileResponseBodyData Data { get; set; }
        public class ListFileResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of documents in the category.</para>
            /// </summary>
            [NameInMap("FileList")]
            [Validation(Required=false)]
            public List<ListFileResponseBodyDataFileList> FileList { get; set; }
            public class ListFileResponseBodyDataFileList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>cate_cdd11b1b79a74e8bbd675c356a91ee3510024405</para>
                /// </summary>
                [NameInMap("CategoryId")]
                [Validation(Required=false)]
                public string CategoryId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2023-08-18 11:03:35</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The document ID, which is the <c>FileId</c> parameter returned by the <a href="~~AddFile~~">AddFile</a> operation. To view the ID, click the icon next to the file name on the <a href="https://bailian.console.alibabacloud.com/#/data-center">Data Management</a> page.</para>
                /// 
                /// <b>Example:</b>
                /// <para>file_5ff599b3455a45db8c41b0054b361518_10098576</para>
                /// </summary>
                [NameInMap("FileId")]
                [Validation(Required=false)]
                public string FileId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>auto-test-1721096109278.pdf</para>
                /// </summary>
                [NameInMap("FileName")]
                [Validation(Required=false)]
                public string FileName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>docx</para>
                /// </summary>
                [NameInMap("FileType")]
                [Validation(Required=false)]
                public string FileType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>DASHSCOPE_DOCMIND</para>
                /// </summary>
                [NameInMap("Parser")]
                [Validation(Required=false)]
                public string Parser { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>512</para>
                /// </summary>
                [NameInMap("SizeInBytes")]
                [Validation(Required=false)]
                public long? SizeInBytes { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("Tags")]
                [Validation(Required=false)]
                public List<string> Tags { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("HasNext")]
            [Validation(Required=false)]
            public bool? HasNext { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("MaxResults")]
            [Validation(Required=false)]
            public int? MaxResults { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>4jzbJk9J6lNeuXD9hP0viA==</para>
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>48</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Requests throttling triggered.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>8F97A63B-55F1-527F-9D6E-467B6A7E8CF1</para>
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
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
