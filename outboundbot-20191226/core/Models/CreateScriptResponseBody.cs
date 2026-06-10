// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class CreateScriptResponseBody : TeaModel {
        /// <summary>
        /// <para>Response code</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>HTTP status code</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>API message</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>254EB995-DEDF-48A4-9101-9CA5B72FFBCC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Script information</para>
        /// </summary>
        [NameInMap("Script")]
        [Validation(Required=false)]
        public CreateScriptResponseBodyScript Script { get; set; }
        public class CreateScriptResponseBodyScript : TeaModel {
            /// <summary>
            /// <para>Script debug status</para>
            /// 
            /// <b>Example:</b>
            /// <para>DRAFTED</para>
            /// </summary>
            [NameInMap("DebugStatus")]
            [Validation(Required=false)]
            public string DebugStatus { get; set; }

            /// <summary>
            /// <para>Industry</para>
            /// 
            /// <b>Example:</b>
            /// <para>教育</para>
            /// </summary>
            [NameInMap("Industry")]
            [Validation(Required=false)]
            public string Industry { get; set; }

            /// <summary>
            /// <para>Is debug draft</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsDebugDrafted")]
            [Validation(Required=false)]
            public bool? IsDebugDrafted { get; set; }

            /// <summary>
            /// <para>Is draft</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsDrafted")]
            [Validation(Required=false)]
            public bool? IsDrafted { get; set; }

            /// <summary>
            /// <para>NLU access method (applicable only to Large Language Model (LLM) scenarios). Enumeration: Managed - Access using an Alibaba public account. This field is empty for non-LLM scenarios.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Managed</para>
            /// </summary>
            [NameInMap("NluAccessType")]
            [Validation(Required=false)]
            public string NluAccessType { get; set; }

            /// <summary>
            /// <para>NLU engine (applicable only to Large Language Model (LLM) scenarios). Enumeration: Prompts - Large Language Model (LLM) scenario. This field is empty for non-LLM scenarios.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Prompts</para>
            /// </summary>
            [NameInMap("NluEngine")]
            [Validation(Required=false)]
            public string NluEngine { get; set; }

            /// <summary>
            /// <para>Scenario</para>
            /// 
            /// <b>Example:</b>
            /// <para>回访</para>
            /// </summary>
            [NameInMap("Scene")]
            [Validation(Required=false)]
            public string Scene { get; set; }

            /// <summary>
            /// <para>Script description</para>
            /// 
            /// <b>Example:</b>
            /// <para>课程满意度回访</para>
            /// </summary>
            [NameInMap("ScriptDescription")]
            [Validation(Required=false)]
            public string ScriptDescription { get; set; }

            /// <summary>
            /// <para>Script ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>8c58d3e0-bf27-4685-a5a5-65872ec5abc4</para>
            /// </summary>
            [NameInMap("ScriptId")]
            [Validation(Required=false)]
            public string ScriptId { get; set; }

            /// <summary>
            /// <para>Script name</para>
            /// 
            /// <b>Example:</b>
            /// <para>课程满意度回访</para>
            /// </summary>
            [NameInMap("ScriptName")]
            [Validation(Required=false)]
            public string ScriptName { get; set; }

            /// <summary>
            /// <para>Job status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>DRAFTED</b>: Draft.</para>
            /// </description></item>
            /// <item><description><para><b>INITIALIZE_IN_PROGRESS</b>: Initializing.</para>
            /// </description></item>
            /// <item><description><para><b>PUBLISHED</b>: Published.</para>
            /// </description></item>
            /// <item><description><para><b>PUBLISH_IN_PROGRESS</b>: Publishing.</para>
            /// </description></item>
            /// <item><description><para><b>ROLLBACK_IN_PROGRESS</b>: Rolling back.</para>
            /// </description></item>
            /// <item><description><para><b>EXAMINE_IN_PROGRESS</b>: Pending review.</para>
            /// </description></item>
            /// <item><description><para><b>PUBLISHED_AND_EXAMINE_IN_PROGRESS</b>: Published and pending review.</para>
            /// </description></item>
            /// <item><description><para><b>PUBLISH_FAILED</b>: Publish failed.</para>
            /// </description></item>
            /// <item><description><para><b>ROLLBACK_FAILED</b>: Rollback failed.</para>
            /// </description></item>
            /// <item><description><para><b>IMPORT_IN_PROGRESS</b>: Importing.</para>
            /// </description></item>
            /// <item><description><para><b>IMPORT_FAILED</b>: Import failed.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>DRAFTED</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>Script update time (unit: milliseconds)</para>
            /// 
            /// <b>Example:</b>
            /// <para>1578474045152</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the operation was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
