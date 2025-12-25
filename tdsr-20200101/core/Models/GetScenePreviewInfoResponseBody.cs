// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tdsr20200101.Models
{
    public class GetScenePreviewInfoResponseBody : TeaModel {
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public GetScenePreviewInfoResponseBodyAccessDeniedDetail AccessDeniedDetail { get; set; }
        public class GetScenePreviewInfoResponseBodyAccessDeniedDetail : TeaModel {
            [NameInMap("AuthAction")]
            [Validation(Required=false)]
            public string AuthAction { get; set; }

            [NameInMap("AuthPrincipalDisplayName")]
            [Validation(Required=false)]
            public string AuthPrincipalDisplayName { get; set; }

            [NameInMap("AuthPrincipalOwnerId")]
            [Validation(Required=false)]
            public string AuthPrincipalOwnerId { get; set; }

            [NameInMap("AuthPrincipalType")]
            [Validation(Required=false)]
            public string AuthPrincipalType { get; set; }

            [NameInMap("EncodedDiagnosticMessage")]
            [Validation(Required=false)]
            public string EncodedDiagnosticMessage { get; set; }

            [NameInMap("NoPermissionType")]
            [Validation(Required=false)]
            public string NoPermissionType { get; set; }

            [NameInMap("PolicyType")]
            [Validation(Required=false)]
            public string PolicyType { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0：成功，其他：失败</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetScenePreviewInfoResponseBodyData Data { get; set; }
        public class GetScenePreviewInfoResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://www.aliyundoc.com/sgm/A.e.QRQRLWYEHIUEYLYW/A.e.QRQRLWYEHIUEYLYW****.sgm">https://www.aliyundoc.com/sgm/A.e.QRQRLWYEHIUEYLYW/A.e.QRQRLWYEHIUEYLYW****.sgm</a></para>
            /// </summary>
            [NameInMap("ModelPath")]
            [Validation(Required=false)]
            public string ModelPath { get; set; }

            [NameInMap("PanoList")]
            [Validation(Required=false)]
            public string PanoList { get; set; }

            [NameInMap("TextureModelPath")]
            [Validation(Required=false)]
            public string TextureModelPath { get; set; }

            [NameInMap("TexturePanoPath")]
            [Validation(Required=false)]
            public string TexturePanoPath { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xxxxx</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>4F882EA7-3A1D-0113-94E4-70162C4****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true/false</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
