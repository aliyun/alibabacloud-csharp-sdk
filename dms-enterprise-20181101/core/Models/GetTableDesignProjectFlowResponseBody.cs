// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetTableDesignProjectFlowResponseBody : TeaModel {
        /// <summary>
        /// The error code returned if the request failed.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The error message returned if the request failed.
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The information about the schema design process.
        /// </summary>
        [NameInMap("ProjectFlow")]
        [Validation(Required=false)]
        public GetTableDesignProjectFlowResponseBodyProjectFlow ProjectFlow { get; set; }
        public class GetTableDesignProjectFlowResponseBodyProjectFlow : TeaModel {
            /// <summary>
            /// The position of the current node in the process.
            /// </summary>
            [NameInMap("CurrentPosition")]
            [Validation(Required=false)]
            public int? CurrentPosition { get; set; }

            /// <summary>
            /// The nodes in the process.
            /// </summary>
            [NameInMap("FlowNodeArray")]
            [Validation(Required=false)]
            public List<GetTableDesignProjectFlowResponseBodyProjectFlowFlowNodeArray> FlowNodeArray { get; set; }
            public class GetTableDesignProjectFlowResponseBodyProjectFlowFlowNodeArray : TeaModel {
                /// <summary>
                /// Indicates whether the ticket can be returned to the schema design node. Valid values:
                /// 
                /// *   **1**: The ticket can be returned to the schema design node.
                /// *   **0**: The ticket cannot be returned to the schema design node. This value can be returned only for the PUBLISH node.
                /// </summary>
                [NameInMap("BackToDesign")]
                [Validation(Required=false)]
                public bool? BackToDesign { get; set; }

                /// <summary>
                /// Indicates whether the current node can be skipped. Valid values:
                /// 
                /// *   **1**: The current node can be skipped.
                /// *   **0**: The current node cannot be skipped. This value can be returned only for the PUBLISH node.
                /// </summary>
                [NameInMap("CanSkip")]
                [Validation(Required=false)]
                public bool? CanSkip { get; set; }

                /// <summary>
                /// The role of the node in the process.
                /// 
                /// *   START: The ticket was created.
                /// *   DESIGN: The schema is being created.
                /// *   PUBLISH: The schema is published.
                /// *   END: The ticket is complete.
                /// </summary>
                [NameInMap("NodeRole")]
                [Validation(Required=false)]
                public string NodeRole { get; set; }

                /// <summary>
                /// The title of the node.
                /// </summary>
                [NameInMap("NodeTitle")]
                [Validation(Required=false)]
                public string NodeTitle { get; set; }

                /// <summary>
                /// The position of the node in the process. The value starts from 1.
                /// </summary>
                [NameInMap("Position")]
                [Validation(Required=false)]
                public int? Position { get; set; }

                /// <summary>
                /// Indicates whether the node is the anchor node. A schema design process has only one anchor node, on which the schema is published. After the schema is published on the anchor node, a post-publish image is generated and the DDL metadata lock is released.
                /// </summary>
                [NameInMap("PublishAnchor")]
                [Validation(Required=false)]
                public bool? PublishAnchor { get; set; }

                /// <summary>
                /// The available publishing strategies.
                /// </summary>
                [NameInMap("PublishStrategies")]
                [Validation(Required=false)]
                public List<string> PublishStrategies { get; set; }

            }

            /// <summary>
            /// The description of the security rule set that is applied to the schema design ticket.
            /// </summary>
            [NameInMap("RuleComment")]
            [Validation(Required=false)]
            public string RuleComment { get; set; }

            /// <summary>
            /// The name of the security rule set that is applied to the schema design ticket.
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

        }

        /// <summary>
        /// The request ID. You can use the request ID to query logs and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
