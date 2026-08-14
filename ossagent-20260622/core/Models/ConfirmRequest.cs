// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OssAgent20260622.Models
{
    public class ConfirmRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to approve the tool execution.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("confirmed")]
        [Validation(Required=false)]
        public bool? Confirmed { get; set; }

        /// <summary>
        /// <para>The current execution phase.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PARAM_INPUT</para>
        /// </summary>
        [NameInMap("phase")]
        [Validation(Required=false)]
        public string Phase { get; set; }

        /// <summary>
        /// <para>The reason for whether to call the tool.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("reason")]
        [Validation(Required=false)]
        public string Reason { get; set; }

        /// <summary>
        /// <para>The Q&amp;A session ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UUID</para>
        /// </summary>
        [NameInMap("sessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// <para>The tool invocations.</para>
        /// </summary>
        [NameInMap("toolCalls")]
        [Validation(Required=false)]
        public List<ConfirmRequestToolCalls> ToolCalls { get; set; }
        public class ConfirmRequestToolCalls : TeaModel {
            /// <summary>
            /// <para>The tool ID, returned by the Chat operation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>call_662cc029b3444d8d923a7ea6</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The command to execute for the tool calling operation, returned by the Chat operation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///     &quot;command&quot;: &quot;api put-bucket-acl --bucket xxx --acl private&quot;,
            ///     &quot;region&quot;: &quot;cn-hangzhou&quot;
            /// }</para>
            /// </summary>
            [NameInMap("modifiedInput")]
            [Validation(Required=false)]
            public Dictionary<string, object> ModifiedInput { get; set; }

            /// <summary>
            /// <para>The consumer name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ossutil_safe</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

    }

}
