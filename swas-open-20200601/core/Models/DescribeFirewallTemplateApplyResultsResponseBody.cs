// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SWAS_OPEN20200601.Models
{
    public class DescribeFirewallTemplateApplyResultsResponseBody : TeaModel {
        /// <summary>
        /// The page number.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page. Default value: 20.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

        /// <summary>
        /// The returned results.
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<DescribeFirewallTemplateApplyResultsResponseBodyData> Data { get; set; }
        public class DescribeFirewallTemplateApplyResultsResponseBodyData : TeaModel {
            /// <summary>
            /// The time when the firewall template was applied to the simple application servers.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// The total number of simple application servers to which the firewall template fails to apply.
            /// </summary>
            [NameInMap("FailedCount")]
            [Validation(Required=false)]
            public string FailedCount { get; set; }

            /// <summary>
            /// The ID of the firewall template.
            /// </summary>
            [NameInMap("FirewallTemplateId")]
            [Validation(Required=false)]
            public string FirewallTemplateId { get; set; }

            /// <summary>
            /// The result of applying the firewall template to the simple application servers.
            /// </summary>
            [NameInMap("InstanceApplyResults")]
            [Validation(Required=false)]
            public List<DescribeFirewallTemplateApplyResultsResponseBodyDataInstanceApplyResults> InstanceApplyResults { get; set; }
            public class DescribeFirewallTemplateApplyResultsResponseBodyDataInstanceApplyResults : TeaModel {
                /// <summary>
                /// The ID of the simple application server.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// The status of applying the firewall template to the simple application servers. Valid values:
                /// 
                /// *   Running: The firewall template is being applied to the simple application servers.
                /// *   Failed: The firewall template is applied to none of the simple application servers.
                /// *   Success: The firewall template is applied to all the simple application servers.
                /// *   PartFailed: The firewall template fails to be applied to some simple application servers.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// The status of applying the template to all simple application servers. Valid values:
            /// 
            /// *   Running: The firewall template is being applied to simple application servers.
            /// *   Failed: The firewall template is applied to none of simple application servers.
            /// *   Success: The firewall template is applied to all simple application servers.
            /// *   PartFailed: The firewall template fails to be applied to some simple application servers.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The ID of the execution to apply the template.
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// The total number of entries returned.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public string TotalCount { get; set; }

        }

    }

}
