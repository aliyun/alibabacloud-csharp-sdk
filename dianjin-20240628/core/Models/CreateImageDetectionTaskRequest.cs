// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DianJin20240628.Models
{
    public class CreateImageDetectionTaskRequest : TeaModel {
        [NameInMap("fileInfo")]
        [Validation(Required=false)]
        public CreateImageDetectionTaskRequestFileInfo FileInfo { get; set; }
        public class CreateImageDetectionTaskRequestFileInfo : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>wanx-demo-1.png</para>
            /// </summary>
            [NameInMap("fileId")]
            [Validation(Required=false)]
            public string FileId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>wanx-demo-1.png</para>
            /// </summary>
            [NameInMap("fileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>fileTraceId</para>
            /// </summary>
            [NameInMap("fileTraceId")]
            [Validation(Required=false)]
            public string FileTraceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>wanx-demo-1.png</para>
            /// </summary>
            [NameInMap("ossKey")]
            [Validation(Required=false)]
            public string OssKey { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>fileUrl</para>
        /// </summary>
        [NameInMap("fileUrl")]
        [Validation(Required=false)]
        public string FileUrl { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sfkhwjf</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
