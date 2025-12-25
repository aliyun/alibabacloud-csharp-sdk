// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tdsr20200101.Models
{
    public class GetScenePreviewResourceResponseBody : TeaModel {
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public GetScenePreviewResourceResponseBodyAccessDeniedDetail AccessDeniedDetail { get; set; }
        public class GetScenePreviewResourceResponseBodyAccessDeniedDetail : TeaModel {
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
        public GetScenePreviewResourceResponseBodyData Data { get; set; }
        public class GetScenePreviewResourceResponseBodyData : TeaModel {
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("ResourceDirectory")]
            [Validation(Required=false)]
            public GetScenePreviewResourceResponseBodyDataResourceDirectory ResourceDirectory { get; set; }
            public class GetScenePreviewResourceResponseBodyDataResourceDirectory : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>hotspotTag.json</para>
                /// </summary>
                [NameInMap("HotspotTagConfig")]
                [Validation(Required=false)]
                public string HotspotTagConfig { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>config.json</para>
                /// </summary>
                [NameInMap("ModelConfig")]
                [Validation(Required=false)]
                public string ModelConfig { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>orthomap/orthomap.json</para>
                /// </summary>
                [NameInMap("OrthomapConfig")]
                [Validation(Required=false)]
                public string OrthomapConfig { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>A.e.YKPYuuYuituy****</para>
                /// </summary>
                [NameInMap("RootPath")]
                [Validation(Required=false)]
                public string RootPath { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1.0</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

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
        /// <para>A8CD0AD9-8A92-455A-A984-A7E4B76*****</para>
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
