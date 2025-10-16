// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class RetrieveMemoryResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public RetrieveMemoryResponseBodyData Data { get; set; }
        public class RetrieveMemoryResponseBodyData : TeaModel {
            [NameInMap("events")]
            [Validation(Required=false)]
            public List<Dictionary<string, string>> Events { get; set; }

            [NameInMap("memories")]
            [Validation(Required=false)]
            public List<Dictionary<string, string>> Memories { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>BC65E49E-1F6A-55E0-8A0E-7255DBFAA8F9</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
