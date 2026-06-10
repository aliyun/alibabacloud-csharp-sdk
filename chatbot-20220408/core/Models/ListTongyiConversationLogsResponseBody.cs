// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class ListTongyiConversationLogsResponseBody : TeaModel {
        /// <summary>
        /// <para>The request processing time, in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>66</para>
        /// </summary>
        [NameInMap("CostTime")]
        [Validation(Required=false)]
        public string CostTime { get; set; }

        /// <summary>
        /// <para>An array of conversation log entries.</para>
        /// </summary>
        [NameInMap("Datas")]
        [Validation(Required=false)]
        public List<Dictionary<string, object>> Datas { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>28805A7C-D695-548C-A31B-67E52C2C274F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The debug information for the session flow.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("SessionFlowDebugInfo")]
        [Validation(Required=false)]
        public ListTongyiConversationLogsResponseBodySessionFlowDebugInfo SessionFlowDebugInfo { get; set; }
        public class ListTongyiConversationLogsResponseBodySessionFlowDebugInfo : TeaModel {
            /// <summary>
            /// <para>The API parameters from the session flow.</para>
            /// </summary>
            [NameInMap("ApiParams")]
            [Validation(Required=false)]
            public Dictionary<string, object> ApiParams { get; set; }

            /// <summary>
            /// <para>The slot parameters from the session flow.</para>
            /// </summary>
            [NameInMap("SlotParams")]
            [Validation(Required=false)]
            public Dictionary<string, object> SlotParams { get; set; }

        }

    }

}
