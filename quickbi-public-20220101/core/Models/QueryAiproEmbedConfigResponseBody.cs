// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class QueryAiproEmbedConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D8749***C180FF3B4</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The array of AIPro configurations.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<QueryAiproEmbedConfigResponseBodyResult> Result { get; set; }
        public class QueryAiproEmbedConfigResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The agent nickname.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Xiao Q</para>
            /// </summary>
            [NameInMap("AgentName")]
            [Validation(Required=false)]
            public string AgentName { get; set; }

            /// <summary>
            /// <para>The embed configuration ID, which is used for CreateTicket4AiPro.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123124</para>
            /// </summary>
            [NameInMap("AiProId")]
            [Validation(Required=false)]
            public string AiProId { get; set; }

            /// <summary>
            /// <para>Indicates whether chat history is displayed. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>1: Displayed.</description></item>
            /// <item><description>0: Not displayed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ChatHistoryStatus")]
            [Validation(Required=false)]
            public int? ChatHistoryStatus { get; set; }

            /// <summary>
            /// <para>The JSON string of the embed appearance configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Config")]
            [Validation(Required=false)]
            public string Config { get; set; }

            /// <summary>
            /// <para>Specifies whether memory is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>1: Enabled.</description></item>
            /// <item><description>0: Disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("MemoryEnabled")]
            [Validation(Required=false)]
            public int? MemoryEnabled { get; set; }

            /// <summary>
            /// <para>The configuration name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0327</para>
            /// </summary>
            [NameInMap("ShowName")]
            [Validation(Required=false)]
            public string ShowName { get; set; }

            /// <summary>
            /// <para>The status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>1: Enabled.</description></item>
            /// <item><description>0: Disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>Specifies whether file upload is allowed. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>1: Allowed.</description></item>
            /// <item><description>0: Not allowed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("UploadEnabled")]
            [Validation(Required=false)]
            public int? UploadEnabled { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the request is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The request is successful.</description></item>
        /// <item><description>false: The request failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
