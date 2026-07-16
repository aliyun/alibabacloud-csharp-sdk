// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Bailian20231229.Models
{
    public class AddFilesFromAuthorizedOssResponseBody : TeaModel {
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
        public AddFilesFromAuthorizedOssResponseBodyData Data { get; set; }
        public class AddFilesFromAuthorizedOssResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of file import results.</para>
            /// </summary>
            [NameInMap("AddFileResultList")]
            [Validation(Required=false)]
            public List<AddFilesFromAuthorizedOssResponseBodyDataAddFileResultList> AddFileResultList { get; set; }
            public class AddFilesFromAuthorizedOssResponseBodyDataAddFileResultList : TeaModel {
                /// <summary>
                /// <para>The file ID. Keep this value safe because it is required for all subsequent API operations related to this file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>file_809f469a59ac449586ec692576xxxxx_102248XXX</para>
                /// </summary>
                [NameInMap("FileId")]
                [Validation(Required=false)]
                public string FileId { get; set; }

                /// <summary>
                /// <para>The error message returned when the file import fails.</para>
                /// 
                /// <b>Example:</b>
                /// <para>size too large</para>
                /// </summary>
                [NameInMap("Msg")]
                [Validation(Required=false)]
                public string Msg { get; set; }

                /// <summary>
                /// <para>The key of the imported file in the OSS bucket.</para>
                /// 
                /// <b>Example:</b>
                /// <para>root/path/this_is_temp_xxxx.pdf</para>
                /// </summary>
                [NameInMap("OssKey")]
                [Validation(Required=false)]
                public string OssKey { get; set; }

                /// <summary>
                /// <para>The file import status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>SUCCESS: The import to application data is complete.</description></item>
                /// <item><description>FAILED: The import to application data failed.</description></item>
                /// </list>
                /// <remarks>
                /// <para>Only files with a SUCCESS status can be used to create or update a knowledge base.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>SUCCESS</para>
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
        /// <para>Cant find out category for category_id param.</para>
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
        public string Success { get; set; }

    }

}
