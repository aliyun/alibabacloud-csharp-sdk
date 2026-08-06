// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class UploadSemanticFileResponseBody : TeaModel {
        /// <summary>
        /// <para>The attachment upload slot information. PUT the file to Data.UploadUrl before Data.ExpiresAt, then use Data.FileId to create a single-file semantic task.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public UploadSemanticFileResponseBodyData Data { get; set; }
        public class UploadSemanticFileResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The expiration time of UploadUrl, expressed as a Unix timestamp in milliseconds. After this time, call UploadSemanticFile again to request a new URL.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1700001800000</para>
            /// </summary>
            [NameInMap("ExpiresAt")]
            [Validation(Required=false)]
            public long? ExpiresAt { get; set; }

            /// <summary>
            /// <para>The unique identifier of the attachment. After completing the PUT upload to UploadUrl, pass this value to the ReferenceFileIds parameter of CreateSemanticJob.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FID1</para>
            /// </summary>
            [NameInMap("FileId")]
            [Validation(Required=false)]
            public string FileId { get; set; }

            /// <summary>
            /// <para>The temporary OSS PUT upload URL. Valid for 30 minutes. Only the specified object can be uploaded. Use the ContentType from the request when performing the PUT request. Do not log or distribute the full URL.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://example.com/temporary-upload-url">https://example.com/temporary-upload-url</a></para>
            /// </summary>
            [NameInMap("UploadUrl")]
            [Validation(Required=false)]
            public string UploadUrl { get; set; }

        }

        /// <summary>
        /// <para>The request ID. Used for locating logs and troubleshooting issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>676271D6-53B4-57BE-89FA-72F7AE1418DF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
