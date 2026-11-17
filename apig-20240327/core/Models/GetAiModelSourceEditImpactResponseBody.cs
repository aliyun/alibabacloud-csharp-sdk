// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class GetAiModelSourceEditImpactResponseBody : TeaModel {
        /// <summary>
        /// <para>The response status code. A value of Ok indicates success, and a specific business error code indicates failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Ok</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The business result returned by the model source operation.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetAiModelSourceEditImpactResponseBodyData Data { get; set; }
        public class GetAiModelSourceEditImpactResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The items to be cleaned up that are returned by the impact query, including model sources, models within the source, licenses, and billing projections.</para>
            /// </summary>
            [NameInMap("cleanup")]
            [Validation(Required=false)]
            public List<string> Cleanup { get; set; }

            /// <summary>
            /// <para>The actual references to the model source in the current saved and published configurations.</para>
            /// </summary>
            [NameInMap("references")]
            [Validation(Required=false)]
            public List<GetAiModelSourceEditImpactResponseBodyDataReferences> References { get; set; }
            public class GetAiModelSourceEditImpactResponseBodyDataReferences : TeaModel {
                /// <summary>
                /// <para>The ID of the API that references the model source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>api-d00000000000000000000</para>
                /// </summary>
                [NameInMap("apiId")]
                [Validation(Required=false)]
                public string ApiId { get; set; }

                /// <summary>
                /// <para>The logical model ID. Use the vm- identifier returned by the API operation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vm-d00000000000000000000</para>
                /// </summary>
                [NameInMap("logicalModelId")]
                [Validation(Required=false)]
                public string LogicalModelId { get; set; }

                /// <summary>
                /// <para>The model identifier. The source model card ID is used for regular models, and the vm- identifier is used for logical model entries.</para>
                /// 
                /// <b>Example:</b>
                /// <para>msc-d00000000000000000000</para>
                /// </summary>
                [NameInMap("modelCardId")]
                [Validation(Required=false)]
                public string ModelCardId { get; set; }

                /// <summary>
                /// <para>The identifier of the object that references the model source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>api-d00000000000000000000</para>
                /// </summary>
                [NameInMap("objectId")]
                [Validation(Required=false)]
                public string ObjectId { get; set; }

                /// <summary>
                /// <para>The LogicalModel reference location. This field is added for LogicalModel references and can be omitted for legacy API references.</para>
                /// 
                /// <b>Example:</b>
                /// <para>LogicalModel</para>
                /// </summary>
                [NameInMap("objectType")]
                [Validation(Required=false)]
                public string ObjectType { get; set; }

                /// <summary>
                /// <para>The purpose of the model source in the reference configuration, such as selected model, fallback model, or service binding.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SelectedModel</para>
                /// </summary>
                [NameInMap("role")]
                [Validation(Required=false)]
                public string Role { get; set; }

                /// <summary>
                /// <para>The ID of the route where the published reference resides.</para>
                /// 
                /// <b>Example:</b>
                /// <para>hr-d00000000000000000000</para>
                /// </summary>
                [NameInMap("routeId")]
                [Validation(Required=false)]
                public string RouteId { get; set; }

                /// <summary>
                /// <para>The ID of the actual AI service to which the model source is bound.</para>
                /// 
                /// <b>Example:</b>
                /// <para>svc-d00000000000000000000</para>
                /// </summary>
                [NameInMap("serviceId")]
                [Validation(Required=false)]
                public string ServiceId { get; set; }

                /// <summary>
                /// <para>Indicates whether the model source reference is from the saved configuration (Draft) or the published configuration (Published).</para>
                /// 
                /// <b>Example:</b>
                /// <para>Draft</para>
                /// </summary>
                [NameInMap("state")]
                [Validation(Required=false)]
                public string State { get; set; }

            }

            /// <summary>
            /// <para>The model source version read when the impact is queried.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("sourceVersion")]
            [Validation(Required=false)]
            public long? SourceVersion { get; set; }

        }

        /// <summary>
        /// <para>The response message that describes the result of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID generated by the system to trace the call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
