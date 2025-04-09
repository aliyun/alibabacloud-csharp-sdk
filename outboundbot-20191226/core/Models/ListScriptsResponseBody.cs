// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class ListScriptsResponseBody : TeaModel {
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

        [NameInMap("Scripts")]
        [Validation(Required=false)]
        public ListScriptsResponseBodyScripts Scripts { get; set; }
        public class ListScriptsResponseBodyScripts : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<ListScriptsResponseBodyScriptsList> List { get; set; }
            public class ListScriptsResponseBodyScriptsList : TeaModel {
                [NameInMap("AgentKey")]
                [Validation(Required=false)]
                public string AgentKey { get; set; }

                [NameInMap("AgentLlm")]
                [Validation(Required=false)]
                public bool? AgentLlm { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>DRAFTED</para>
                /// </summary>
                [NameInMap("DebugStatus")]
                [Validation(Required=false)]
                public string DebugStatus { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("EmotionEnable")]
                [Validation(Required=false)]
                public bool? EmotionEnable { get; set; }

                [NameInMap("Industry")]
                [Validation(Required=false)]
                public string Industry { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("IsDebugDrafted")]
                [Validation(Required=false)]
                public bool? IsDebugDrafted { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("IsDrafted")]
                [Validation(Required=false)]
                public bool? IsDrafted { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("IsPreset")]
                [Validation(Required=false)]
                public bool? IsPreset { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("LongWaitEnable")]
                [Validation(Required=false)]
                public bool? LongWaitEnable { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("MiniPlaybackEnable")]
                [Validation(Required=false)]
                public bool? MiniPlaybackEnable { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("NewBargeInEnable")]
                [Validation(Required=false)]
                public bool? NewBargeInEnable { get; set; }

                [NameInMap("NluAccessType")]
                [Validation(Required=false)]
                public string NluAccessType { get; set; }

                [NameInMap("NluEngine")]
                [Validation(Required=false)]
                public string NluEngine { get; set; }

                [NameInMap("RejectReason")]
                [Validation(Required=false)]
                public string RejectReason { get; set; }

                [NameInMap("Scene")]
                [Validation(Required=false)]
                public string Scene { get; set; }

                [NameInMap("ScriptDescription")]
                [Validation(Required=false)]
                public string ScriptDescription { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>8d6a6e41-8093-49af-a9d1-0281878758ac</para>
                /// </summary>
                [NameInMap("ScriptId")]
                [Validation(Required=false)]
                public string ScriptId { get; set; }

                [NameInMap("ScriptName")]
                [Validation(Required=false)]
                public string ScriptName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>DRAFTED</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1578965079000</para>
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public long? UpdateTime { get; set; }

                [NameInMap("agentId")]
                [Validation(Required=false)]
                public long? AgentId { get; set; }

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
            /// <para>15</para>
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
