// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class ListFileUploadResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of file objects.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListFileUploadResponseBodyData> Data { get; set; }
        public class ListFileUploadResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The ID of the Alibaba Cloud master account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>16738266********</para>
            /// </summary>
            [NameInMap("AliyunParentUid")]
            [Validation(Required=false)]
            public string AliyunParentUid { get; set; }

            /// <summary>
            /// <para>The Alibaba Cloud account ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20372822********</para>
            /// </summary>
            [NameInMap("AliyunUid")]
            [Validation(Required=false)]
            public string AliyunUid { get; set; }

            /// <summary>
            /// <para>The public download link.</para>
            /// </summary>
            [NameInMap("DownloadLink")]
            [Validation(Required=false)]
            public string DownloadLink { get; set; }

            /// <summary>
            /// <para>The file category.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TextReport</para>
            /// </summary>
            [NameInMap("FileCategory")]
            [Validation(Required=false)]
            public string FileCategory { get; set; }

            /// <summary>
            /// <para>The file source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Agent</para>
            /// </summary>
            [NameInMap("FileFrom")]
            [Validation(Required=false)]
            public string FileFrom { get; set; }

            /// <summary>
            /// <para>The file ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>f-8*******01m</para>
            /// </summary>
            [NameInMap("FileId")]
            [Validation(Required=false)]
            public string FileId { get; set; }

            /// <summary>
            /// <para>The file name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>samele_report.md</para>
            /// </summary>
            [NameInMap("FileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            /// <summary>
            /// <para>The file size, in bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7453</para>
            /// </summary>
            [NameInMap("FileSize")]
            [Validation(Required=false)]
            public long? FileSize { get; set; }

            /// <summary>
            /// <para>The file extension.</para>
            /// 
            /// <b>Example:</b>
            /// <para>md</para>
            /// </summary>
            [NameInMap("FileType")]
            [Validation(Required=false)]
            public string FileType { get; set; }

            /// <summary>
            /// <para>The time when the file was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-12-11T14:04:32.000+00:00</para>
            /// </summary>
            [NameInMap("GmtCreated")]
            [Validation(Required=false)]
            public string GmtCreated { get; set; }

            /// <summary>
            /// <para>The internal download link.</para>
            /// </summary>
            [NameInMap("IntranetDownloadLink")]
            [Validation(Required=false)]
            public string IntranetDownloadLink { get; set; }

            /// <summary>
            /// <para>The region.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// <para>The session ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>h8r********4fch</para>
            /// </summary>
            [NameInMap("SessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

            /// <summary>
            /// <para>The upload path.</para>
            /// </summary>
            [NameInMap("UploadLocation")]
            [Validation(Required=false)]
            public string UploadLocation { get; set; }

        }

        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message returned if the request fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Specified parameter Tid is not valid.</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>67E910F2-4B62-5B0C-ACA3-7547695C****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: The request was successful.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: The request failed.</para>
        /// </description></item>
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
