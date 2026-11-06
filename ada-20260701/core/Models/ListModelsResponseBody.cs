// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ada20260701.Models
{
    public class ListModelsResponseBody : TeaModel {
        /// <summary>
        /// <para>The maximum number of results used for the current pagination. If pagination is not used, this value is the total number of results. This value is not the actual number of entries returned on the current page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The array of model structures. For nested fields, refer to the supplementary description of response parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;Id&quot;:&quot;text-model-example&quot;,&quot;Object&quot;:&quot;model&quot;,&quot;Created&quot;:1793491200,&quot;OwnedBy&quot;:&quot;provider-example&quot;,&quot;DisplayName&quot;:&quot;示例文本模型&quot;,&quot;Capabilities&quot;:{&quot;InputModalities&quot;:[&quot;text&quot;]},&quot;CreditsCoefficient&quot;:&quot;2.5&quot;,&quot;ThinkingLevels&quot;:[&quot;off&quot;,&quot;low&quot;,&quot;medium&quot;,&quot;high&quot;],&quot;ThinkingLevel&quot;:&quot;off&quot;}]</para>
        /// </summary>
        [NameInMap("Models")]
        [Validation(Required=false)]
        public List<ListModelsResponseBodyModels> Models { get; set; }
        public class ListModelsResponseBodyModels : TeaModel {
            /// <summary>
            /// <para>The model capabilities structure.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;InputModalities&quot;:[&quot;text&quot;]}</para>
            /// </summary>
            [NameInMap("Capabilities")]
            [Validation(Required=false)]
            public ListModelsResponseBodyModelsCapabilities Capabilities { get; set; }
            public class ListModelsResponseBodyModelsCapabilities : TeaModel {
                /// <summary>
                /// <para>The supported input modalities. For text sessions, select a model that includes text.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[&quot;text&quot;]</para>
                /// </summary>
                [NameInMap("InputModalities")]
                [Validation(Required=false)]
                public List<string> InputModalities { get; set; }

            }

            /// <term><b>Obsolete</b></term>
            /// 
            /// <summary>
            /// <para>The deprecated compatibility field. This field is not returned. Do not rely on this field for integration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>32768</para>
            /// </summary>
            [NameInMap("ContextWindow")]
            [Validation(Required=false)]
            [Obsolete]
            public long? ContextWindow { get; set; }

            /// <summary>
            /// <para>The time when the model was created. The value is a UNIX timestamp in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1793491200</para>
            /// </summary>
            [NameInMap("Created")]
            [Validation(Required=false)]
            public long? Created { get; set; }

            /// <summary>
            /// <para>The credits coefficient of the model. The value is returned as a decimal string. This parameter is not returned if it is not configured.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2.5</para>
            /// </summary>
            [NameInMap("CreditsCoefficient")]
            [Validation(Required=false)]
            public string CreditsCoefficient { get; set; }

            /// <summary>
            /// <para>The display name of the model. Do not pass this value as the model identifier.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Sample text model</para>
            /// </summary>
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// <para>The model identifier. Used as Params.modelId for SetAgentSessionModel. Use the actual returned value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>text-model-example</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <term><b>Obsolete</b></term>
            /// 
            /// <summary>
            /// <para>The deprecated compatibility field. This field is not returned. Do not rely on this field for integration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>131072</para>
            /// </summary>
            [NameInMap("MaxContextWindow")]
            [Validation(Required=false)]
            [Obsolete]
            public long? MaxContextWindow { get; set; }

            /// <summary>
            /// <para>The object type. The value is fixed to model.</para>
            /// 
            /// <b>Example:</b>
            /// <para>model</para>
            /// </summary>
            [NameInMap("Object")]
            [Validation(Required=false)]
            public string Object { get; set; }

            /// <summary>
            /// <para>The identifier of the model provider.</para>
            /// 
            /// <b>Example:</b>
            /// <para>provider-example</para>
            /// </summary>
            [NameInMap("OwnedBy")]
            [Validation(Required=false)]
            public string OwnedBy { get; set; }

            /// <term><b>Obsolete</b></term>
            /// 
            /// <summary>
            /// <para>The deprecated compatibility field. This field is not returned. Use ThinkingLevels instead.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SupportsThinking")]
            [Validation(Required=false)]
            [Obsolete]
            public int? SupportsThinking { get; set; }

            /// <summary>
            /// <para>The default thinking level in the model catalog. This value does not represent the current value of the session. Query the current value by using GetAgentSessionModel.</para>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("ThinkingLevel")]
            [Validation(Required=false)]
            public string ThinkingLevel { get; set; }

            /// <summary>
            /// <para>The thinking levels supported by the model. An empty array does not indicate that all levels are supported. The target session still requires validation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[&quot;off&quot;,&quot;low&quot;,&quot;medium&quot;,&quot;high&quot;]</para>
            /// </summary>
            [NameInMap("ThinkingLevels")]
            [Validation(Required=false)]
            public List<string> ThinkingLevels { get; set; }

            /// <term><b>Obsolete</b></term>
            /// 
            /// <summary>
            /// <para>The deprecated compatibility field. This field is not returned. Use ThinkingLevel instead.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ThinkingMode")]
            [Validation(Required=false)]
            [Obsolete]
            public int? ThinkingMode { get; set; }

        }

        /// <summary>
        /// <para>The token for the next page. An empty value indicates that no more pages exist.</para>
        /// 
        /// <b>Example:</b>
        /// <para>next-token-example</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the request. You can use the ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0A1B2C3D-4E5F-6789-ABCD-EF0123456789</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of models that meet the filter conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
