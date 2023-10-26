// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Fnf20190315.Models
{
    public class ListFlowsResponseBody : TeaModel {
        /// <summary>
        /// The details of flows.
        /// </summary>
        [NameInMap("Flows")]
        [Validation(Required=false)]
        public List<ListFlowsResponseBodyFlows> Flows { get; set; }
        public class ListFlowsResponseBodyFlows : TeaModel {
            /// <summary>
            /// The time when the flow was created.
            /// </summary>
            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public string CreatedTime { get; set; }

            /// <summary>
            /// The definition of the flow. The definition must comply with the Flow Definition Language (FDL) syntax.
            /// </summary>
            [NameInMap("Definition")]
            [Validation(Required=false)]
            public string Definition { get; set; }

            /// <summary>
            /// The description of the flow.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The execution mode or the enumeration type. Valid values: Express and Standard. The value Standard indicates an empty string.
            /// </summary>
            [NameInMap("ExecutionMode")]
            [Validation(Required=false)]
            public string ExecutionMode { get; set; }

            /// <summary>
            /// The unique ID of the flow.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// The time when the flow was last modified.
            /// </summary>
            [NameInMap("LastModifiedTime")]
            [Validation(Required=false)]
            public string LastModifiedTime { get; set; }

            /// <summary>
            /// The name of the flow.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The Alibaba Cloud Resource Name (ARN) of the Resource Access Management (RAM) role.
            /// </summary>
            [NameInMap("RoleArn")]
            [Validation(Required=false)]
            public string RoleArn { get; set; }

            /// <summary>
            /// The type of the flow.
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// The start key for the next query. This parameter is not returned if all results have been returned.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
