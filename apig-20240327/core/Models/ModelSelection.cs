// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class ModelSelection : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable convenience aliases. When enabled, all selected model names must be unique.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("convenienceAliasEnabled")]
        [Validation(Required=false)]
        public bool? ConvenienceAliasEnabled { get; set; }

        /// <summary>
        /// <para>The collection of explicitly selected built-in endpoint (route) names. This parameter is required and cannot be empty.</para>
        /// </summary>
        [NameInMap("endpoints")]
        [Validation(Required=false)]
        public List<string> Endpoints { get; set; }

        /// <summary>
        /// <para>The ordered fallback chains configured by endpoint and initial model.</para>
        /// </summary>
        [NameInMap("fallbackChains")]
        [Validation(Required=false)]
        public List<ModelSelectionFallbackChains> FallbackChains { get; set; }
        public class ModelSelectionFallbackChains : TeaModel {
            /// <summary>
            /// <para>The endpoint name to which the chain belongs. It must be one of the currently selected endpoints.</para>
            /// 
            /// <b>Example:</b>
            /// <para>create-chat-completion</para>
            /// </summary>
            [NameInMap("endpoint")]
            [Validation(Required=false)]
            public string Endpoint { get; set; }

            /// <summary>
            /// <para>The ordered collection of fallback model card IDs.</para>
            /// </summary>
            [NameInMap("fallbackModelCardIds")]
            [Validation(Required=false)]
            public List<string> FallbackModelCardIds { get; set; }

            /// <summary>
            /// <para>The source model card ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>msc-d00000000000000000000</para>
            /// </summary>
            [NameInMap("sourceModelCardId")]
            [Validation(Required=false)]
            public string SourceModelCardId { get; set; }

        }

        /// <summary>
        /// <para>The selected model group IDs within the instance. Group identity is retained, the union of current members and single-selected models is calculated, and empty groups can be saved as drafts.</para>
        /// </summary>
        [NameInMap("modelGroupIds")]
        [Validation(Required=false)]
        public List<string> ModelGroupIds { get; set; }

        /// <summary>
        /// <para>The selected model collection.</para>
        /// </summary>
        [NameInMap("models")]
        [Validation(Required=false)]
        public List<ModelSelectionModels> Models { get; set; }
        public class ModelSelectionModels : TeaModel {
            /// <summary>
            /// <para>The model card ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>msc-d00000000000000000000</para>
            /// </summary>
            [NameInMap("modelCardId")]
            [Validation(Required=false)]
            public string ModelCardId { get; set; }

            /// <summary>
            /// <para>The explicit execution target AI service ID for the model. This parameter is optional and takes precedence over the provider default.</para>
            /// 
            /// <b>Example:</b>
            /// <para>svc-d00000000000000000000</para>
            /// </summary>
            [NameInMap("serviceId")]
            [Validation(Required=false)]
            public string ServiceId { get; set; }

        }

    }

}
