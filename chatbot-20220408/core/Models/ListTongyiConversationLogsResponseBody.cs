// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class ListTongyiConversationLogsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>66</para>
        /// </summary>
        [NameInMap("CostTime")]
        [Validation(Required=false)]
        public string CostTime { get; set; }

        [NameInMap("Datas")]
        [Validation(Required=false)]
        public List<Dictionary<string, object>> Datas { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>28805A7C-D695-548C-A31B-67E52C2C274F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
