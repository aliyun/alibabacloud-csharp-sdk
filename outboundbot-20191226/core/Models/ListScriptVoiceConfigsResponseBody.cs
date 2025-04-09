// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class ListScriptVoiceConfigsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>254EB995-DEDF-48A4-9101-9CA5B72FFBCC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ScriptVoiceConfigs")]
        [Validation(Required=false)]
        public ListScriptVoiceConfigsResponseBodyScriptVoiceConfigs ScriptVoiceConfigs { get; set; }
        public class ListScriptVoiceConfigsResponseBodyScriptVoiceConfigs : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<ListScriptVoiceConfigsResponseBodyScriptVoiceConfigsList> List { get; set; }
            public class ListScriptVoiceConfigsResponseBodyScriptVoiceConfigsList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>bdd49242-114c-4045-b1d1-25ccc1756c75</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("ScriptContent")]
                [Validation(Required=false)]
                public string ScriptContent { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>a7441a05-43bb-4a2d-acb0-365f245d7a5b</para>
                /// </summary>
                [NameInMap("ScriptId")]
                [Validation(Required=false)]
                public string ScriptId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2c8fa91f-9856-4145-90f2-08252f09bc18</para>
                /// </summary>
                [NameInMap("ScriptVoiceConfigId")]
                [Validation(Required=false)]
                public string ScriptVoiceConfigId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>&quot;&quot;</para>
                /// </summary>
                [NameInMap("ScriptWaveformRelation")]
                [Validation(Required=false)]
                public string ScriptWaveformRelation { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>DIALOGUE_FLOW</para>
                /// </summary>
                [NameInMap("Source")]
                [Validation(Required=false)]
                public string Source { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>TTS</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
