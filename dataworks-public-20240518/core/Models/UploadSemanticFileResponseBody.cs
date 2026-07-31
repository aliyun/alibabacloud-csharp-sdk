// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class UploadSemanticFileResponseBody : TeaModel {
        /// <summary>
        /// <para>The attachment upload slot information. PUT the file to Data.UploadUrl before Data.ExpiresAt, and then use Data.FileId to create a single-file semantic job.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public UploadSemanticFileResponseBodyData Data { get; set; }
        public class UploadSemanticFileResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The expiration time of UploadUrl, expressed as a UNIX timestamp in milliseconds. After this time, call UploadSemanticFile again to request a new URL.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1700001800000</para>
            /// </summary>
            [NameInMap("ExpiresAt")]
            [Validation(Required=false)]
            public long? ExpiresAt { get; set; }

            /// <summary>
            /// <para>The unique identifier of the attachment. After the PUT upload to UploadUrl is complete, pass this value to the ReferenceFileIds parameter of CreateSemanticJob.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FID1</para>
            /// </summary>
            [NameInMap("FileId")]
            [Validation(Required=false)]
            public string FileId { get; set; }

            /// <summary>
            /// <para>The temporary OSS PUT upload URL. The URL is valid for 30 minutes and can only be used to upload the specified object. Use the ContentType specified in the request when you perform the PUT request. Do not log or distribute the full URL.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://example.com/temporary-upload-url">https://example.com/temporary-upload-url</a></para>
            /// </summary>
            [NameInMap("UploadUrl")]
            [Validation(Required=false)]
            public string UploadUrl { get; set; }

        }

        /// <summary>
        /// <para>The request ID. You can use this ID to locate logs and troubleshoot issues.</para>
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
