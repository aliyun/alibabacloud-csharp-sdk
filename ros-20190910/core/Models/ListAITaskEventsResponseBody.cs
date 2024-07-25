// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class ListAITaskEventsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Events")]
        [Validation(Required=false)]
        public List<ListAITaskEventsResponseBodyEvents> Events { get; set; }
        public class ListAITaskEventsResponseBodyEvents : TeaModel {
            [NameInMap("AgentType")]
            [Validation(Required=false)]
            public string AgentType { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("EstimatedProcessingTime")]
            [Validation(Required=false)]
            public string EstimatedProcessingTime { get; set; }

            [NameInMap("EventData")]
            [Validation(Required=false)]
            public string EventData { get; set; }

            [NameInMap("HandlerProcessStatus")]
            [Validation(Required=false)]
            public string HandlerProcessStatus { get; set; }

            [NameInMap("HandlerType")]
            [Validation(Required=false)]
            public string HandlerType { get; set; }

        }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        [NameInMap("TaskStatus")]
        [Validation(Required=false)]
        public string TaskStatus { get; set; }

        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

    }

}
