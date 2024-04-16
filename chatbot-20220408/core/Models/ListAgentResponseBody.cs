// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class ListAgentResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListAgentResponseBodyData> Data { get; set; }
        public class ListAgentResponseBodyData : TeaModel {
            [NameInMap("AgentId")]
            [Validation(Required=false)]
            public long? AgentId { get; set; }

            [NameInMap("AgentKey")]
            [Validation(Required=false)]
            public string AgentKey { get; set; }

            [NameInMap("AgentName")]
            [Validation(Required=false)]
            public string AgentName { get; set; }

            [NameInMap("DefaultAgent")]
            [Validation(Required=false)]
            public bool? DefaultAgent { get; set; }

            [NameInMap("InstanceInfos")]
            [Validation(Required=false)]
            public Dictionary<string, object> InstanceInfos { get; set; }

        }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
