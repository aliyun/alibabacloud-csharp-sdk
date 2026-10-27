// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.VoiceNavigator20251111.Models
{
    public class ListScriptProfileTemplatesResponseBody : TeaModel {
        /// <summary>
        /// <para>The internal error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The list of scenario templates.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListScriptProfileTemplatesResponseBodyData> Data { get; set; }
        public class ListScriptProfileTemplatesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1752829090000</para>
            /// </summary>
            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public long? CreatedTime { get; set; }

            /// <summary>
            /// <para>The description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Build professional conversational prompt engineering from a blank document</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The template name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>General scenario</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The template definition.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///   &quot;name&quot;: &quot;General&quot;,
            ///   &quot;properties&quot;: {
            ///     &quot;prompts&quot;: {
            ///       &quot;displayName&quot;: &quot;Instruction information&quot;,
            ///       &quot;dataType&quot;: &quot;TEXT&quot;,
            ///       &quot;name&quot;: &quot;prompts&quot;,
            ///       &quot;displayOrder&quot;: 1,
            ///       &quot;defaultValue&quot;: &quot;You are a friendly and approachable chat assistant, focusing on natural Chinese conversations. Stay positive and patient, provide helpful responses, and avoid sensitive content. Honestly admit when you do not know the answer to create a relaxed and pleasant communication experience.&quot;,
            ///       &quot;attributes&quot;: {
            ///         &quot;placeholder&quot;: &quot;You are a friendly and approachable chat assistant, focusing on natural Chinese conversations. Stay positive and patient, provide helpful responses, and avoid sensitive content. Honestly admit when you do not know the answer to create a relaxed and pleasant communication experience.&quot;,
            ///         &quot;rows&quot;: 20
            ///       },
            ///       &quot;editorType&quot;: &quot;MENTIONS_TEXTAREA&quot;,
            ///       &quot;maxLength&quot;: 2000,
            ///       &quot;required&quot;: true,
            ///       &quot;group&quot;: &quot;Business description&quot;
            ///     }
            ///   }
            /// }</para>
            /// </summary>
            [NameInMap("Schema")]
            [Validation(Required=false)]
            public string Schema { get; set; }

            /// <summary>
            /// <para>The template ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CCC_PROMPTS_DEFAULT</para>
            /// </summary>
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

            /// <summary>
            /// <para>The update time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1752829090000</para>
            /// </summary>
            [NameInMap("UpdatedTime")]
            [Validation(Required=false)]
            public long? UpdatedTime { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Instance af81a389-91f0-4157-8d82-720edd02b66a
        ///  does not exist.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The list of error parameters.</para>
        /// </summary>
        [NameInMap("Params")]
        [Validation(Required=false)]
        public List<string> Params { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E6E61E1A-D2DC-5ACF-AED4-A115B6691F98</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
