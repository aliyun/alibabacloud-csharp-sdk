// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class GetAiModelSourceEditImpactResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>Ok</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public GetAiModelSourceEditImpactResponseBodyData Data { get; set; }
        public class GetAiModelSourceEditImpactResponseBodyData : TeaModel {
            [NameInMap("cleanup")]
            [Validation(Required=false)]
            public List<string> Cleanup { get; set; }

            [NameInMap("references")]
            [Validation(Required=false)]
            public List<GetAiModelSourceEditImpactResponseBodyDataReferences> References { get; set; }
            public class GetAiModelSourceEditImpactResponseBodyDataReferences : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>api-d00000000000000000000</para>
                /// </summary>
                [NameInMap("apiId")]
                [Validation(Required=false)]
                public string ApiId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>vm-d00000000000000000000</para>
                /// </summary>
                [NameInMap("logicalModelId")]
                [Validation(Required=false)]
                public string LogicalModelId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>msc-d00000000000000000000</para>
                /// </summary>
                [NameInMap("modelCardId")]
                [Validation(Required=false)]
                public string ModelCardId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>api-d00000000000000000000</para>
                /// </summary>
                [NameInMap("objectId")]
                [Validation(Required=false)]
                public string ObjectId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>LogicalModel</para>
                /// </summary>
                [NameInMap("objectType")]
                [Validation(Required=false)]
                public string ObjectType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>SelectedModel</para>
                /// </summary>
                [NameInMap("role")]
                [Validation(Required=false)]
                public string Role { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>hr-d00000000000000000000</para>
                /// </summary>
                [NameInMap("routeId")]
                [Validation(Required=false)]
                public string RouteId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>svc-d00000000000000000000</para>
                /// </summary>
                [NameInMap("serviceId")]
                [Validation(Required=false)]
                public string ServiceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Draft</para>
                /// </summary>
                [NameInMap("state")]
                [Validation(Required=false)]
                public string State { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("sourceVersion")]
            [Validation(Required=false)]
            public long? SourceVersion { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
