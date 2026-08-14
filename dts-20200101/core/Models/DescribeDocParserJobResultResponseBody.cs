// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class DescribeDocParserJobResultResponseBody : TeaModel {
        /// <summary>
        /// <para>The complete text parsing content.</para>
        /// <remarks>
        /// <para>If the task type is content, ContentList splits the original document by page. Each page has a separate Markdown text entry.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("ContentList")]
        [Validation(Required=false)]
        public List<DescribeDocParserJobResultResponseBodyContentList> ContentList { get; set; }
        public class DescribeDocParserJobResultResponseBodyContentList : TeaModel {
            /// <summary>
            /// <para>The text content of the corresponding page, which is the complete Markdown text after parsing.</para>
            /// 
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description>Demo * ** Demo title **</description></item>
            /// </list>
            /// </summary>
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

        }

        /// <summary>
        /// <para>The dynamic error code. This parameter will be deprecated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>403</para>
        /// </summary>
        [NameInMap("DynamicCode")]
        [Validation(Required=false)]
        public string DynamicCode { get; set; }

        /// <summary>
        /// <para>The dynamic error message used to replace the <b>%s</b> variable in the <b>ErrMessage</b> response parameter.</para>
        /// <remarks>
        /// <para>If <b>ErrMessage</b> returns <b>The Value of Input Parameter %s is not valid</b> and <b>DynamicMessage</b> returns <b>DtsJobId</b>, the request parameter <b>DtsJobId</b> is invalid.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>DtsJobId</para>
        /// </summary>
        [NameInMap("DynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

        /// <summary>
        /// <para>The error code returned when the call fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InternalError</para>
        /// </summary>
        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <para>The error message returned when the call fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The request processing has failed due to some unknown error.</para>
        /// </summary>
        [NameInMap("ErrMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        /// <summary>
        /// <para>The OSS download URL of the file.</para>
        /// <remarks>
        /// <para>If the task type is zip, this field returns the download URL of the zip package. The URL is valid for 30 minutes.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://oss-cn-hangzhou.aliyuncs.com/806a_209584525031252870_078f1180f27b4c069c0f271758aa">https://oss-cn-hangzhou.aliyuncs.com/806a_209584525031252870_078f1180f27b4c069c0f271758aa</a>****</para>
        /// </summary>
        [NameInMap("FileUrl")]
        [Validation(Required=false)]
        public string FileUrl { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The public OSS download URL of the file.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://oss-cn-hangzhou.aliyuncs.com/806a_209584525031252870_078f1180f27b4c069c0f271758aa">https://oss-cn-hangzhou.aliyuncs.com/806a_209584525031252870_078f1180f27b4c069c0f271758aa</a>****</para>
        /// </summary>
        [NameInMap("OuterFileUrl")]
        [Validation(Required=false)]
        public string OuterFileUrl { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C166D79D-436B-45F0-B5A5-25E1959F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
