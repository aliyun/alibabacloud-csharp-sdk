// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class GetBotSessionDataResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>116</para>
        /// </summary>
        [NameInMap("CostTime")]
        [Validation(Required=false)]
        public string CostTime { get; set; }

        [NameInMap("Datas")]
        [Validation(Required=false)]
        public List<Dictionary<string, object>> Datas { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>15CD94CC-CBEB-4189-806C-A132D1F45D51</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
