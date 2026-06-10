// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class ListTongyiChatHistorysResponseBody : TeaModel {
        /// <summary>
        /// <para>The request duration, in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>116</para>
        /// </summary>
        [NameInMap("CostTime")]
        [Validation(Required=false)]
        public string CostTime { get; set; }

        /// <summary>
        /// <para>A list of chat history entries.</para>
        /// </summary>
        [NameInMap("Datas")]
        [Validation(Required=false)]
        public List<Dictionary<string, object>> Datas { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D0DDFC4C-D66D-4787-9AE4-4D757481EDEE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
