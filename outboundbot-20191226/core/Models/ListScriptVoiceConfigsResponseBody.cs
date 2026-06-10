// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class ListScriptVoiceConfigsResponseBody : TeaModel {
        /// <summary>
        /// <para>The API status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

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
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>254EB995-DEDF-48A4-9101-9CA5B72FFBCC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The paginated list of script voice configurations.</para>
        /// </summary>
        [NameInMap("ScriptVoiceConfigs")]
        [Validation(Required=false)]
        public ListScriptVoiceConfigsResponseBodyScriptVoiceConfigs ScriptVoiceConfigs { get; set; }
        public class ListScriptVoiceConfigsResponseBodyScriptVoiceConfigs : TeaModel {
            /// <summary>
            /// <para>An array of script voice configuration objects.</para>
            /// </summary>
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<ListScriptVoiceConfigsResponseBodyScriptVoiceConfigsList> List { get; set; }
            public class ListScriptVoiceConfigsResponseBodyScriptVoiceConfigsList : TeaModel {
                /// <summary>
                /// <para>The instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>bdd49242-114c-4045-b1d1-25ccc1756c75</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The text content of the script.</para>
                /// 
                /// <b>Example:</b>
                /// <para>请问你是 @name 吗</para>
                /// </summary>
                [NameInMap("ScriptContent")]
                [Validation(Required=false)]
                public string ScriptContent { get; set; }

                /// <summary>
                /// <para>The script ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>a7441a05-43bb-4a2d-acb0-365f245d7a5b</para>
                /// </summary>
                [NameInMap("ScriptId")]
                [Validation(Required=false)]
                public string ScriptId { get; set; }

                /// <summary>
                /// <para>The ID of the voice configuration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2c8fa91f-9856-4145-90f2-08252f09bc18</para>
                /// </summary>
                [NameInMap("ScriptVoiceConfigId")]
                [Validation(Required=false)]
                public string ScriptVoiceConfigId { get; set; }

                /// <summary>
                /// <para>The relationship between the script and the audio file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;&quot;</para>
                /// </summary>
                [NameInMap("ScriptWaveformRelation")]
                [Validation(Required=false)]
                public string ScriptWaveformRelation { get; set; }

                /// <summary>
                /// <para>The source of the script.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DIALOGUE_FLOW</para>
                /// </summary>
                [NameInMap("Source")]
                [Validation(Required=false)]
                public string Source { get; set; }

                /// <summary>
                /// <para>The voice type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TTS</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the request succeeded.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
