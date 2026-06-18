// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Bailian20231229.Models
{
    public class DeleteFilesResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DataCenter.FileTooLarge</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DeleteFilesResponseBodyData Data { get; set; }
        public class DeleteFilesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The deletion results.</para>
            /// </summary>
            [NameInMap("DeleteFileResultList")]
            [Validation(Required=false)]
            public List<DeleteFilesResponseBodyDataDeleteFileResultList> DeleteFileResultList { get; set; }
            public class DeleteFilesResponseBodyDataDeleteFileResultList : TeaModel {
                /// <summary>
                /// <para>The file ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>file_6b193b9b4b1546ef9eaa7340e69adfca_10052857</para>
                /// </summary>
                [NameInMap("FileId")]
                [Validation(Required=false)]
                public string FileId { get; set; }

                /// <summary>
                /// <para>The file deletion status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>DELETED: The file is deleted.</description></item>
                /// <item><description>FAILED: The file fails to be deleted.</description></item>
                /// <item><description>NOT_FOUND: The file is not found.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>DELETED</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Required parameter(%s) missing or invalid, please check the request parameters.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>17204B98-7734-4F9A-8464-2446A84821CA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The status code returned by the API.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>Indicates whether the API call is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The call is successful.</description></item>
        /// <item><description>false: The call fails.</description></item>
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
