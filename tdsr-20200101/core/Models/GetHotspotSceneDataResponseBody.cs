// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tdsr20200101.Models
{
    public class GetHotspotSceneDataResponseBody : TeaModel {
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public GetHotspotSceneDataResponseBodyAccessDeniedDetail AccessDeniedDetail { get; set; }
        public class GetHotspotSceneDataResponseBodyAccessDeniedDetail : TeaModel {
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
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetHotspotSceneDataResponseBodyData Data { get; set; }
        public class GetHotspotSceneDataResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>A.e.QRQRLWYEHIUE****</para>
            /// </summary>
            [NameInMap("ModelToken")]
            [Validation(Required=false)]
            public string ModelToken { get; set; }

            [NameInMap("PreviewData")]
            [Validation(Required=false)]
            public string PreviewData { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>344794c32937474a9c59eb130936****</para>
            /// </summary>
            [NameInMap("PreviewToken")]
            [Validation(Required=false)]
            public string PreviewToken { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>MODEL_3D</para>
            /// </summary>
            [NameInMap("SceneType")]
            [Validation(Required=false)]
            public string SceneType { get; set; }

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
        /// <para>A8CD0AD9-8A92-455A-A984-A7E4B76****</para>
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
