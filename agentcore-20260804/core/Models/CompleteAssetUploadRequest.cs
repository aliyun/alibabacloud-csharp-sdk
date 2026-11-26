// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class CompleteAssetUploadRequest : TeaModel {
        /// <summary>
        /// <para>Specifies the upload session returned by BeginAssetUpload to prevent delayed confirmations from affecting subsequent uploads.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public CompleteAssetUploadRequestBody Body { get; set; }
        public class CompleteAssetUploadRequestBody : TeaModel {
            /// <summary>
            /// <para>The uploadId returned by BeginAssetUpload. It must match the current upload session and the current upload target generation of the asset.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>upload-001</para>
            /// </summary>
            [NameInMap("uploadId")]
            [Validation(Required=false)]
            public string UploadId { get; set; }

        }

    }

}
