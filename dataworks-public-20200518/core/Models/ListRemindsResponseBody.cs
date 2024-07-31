// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListRemindsResponseBody : TeaModel {
        /// <summary>
        /// The data returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListRemindsResponseBodyData Data { get; set; }
        public class ListRemindsResponseBodyData : TeaModel {
            /// <summary>
            /// The page number of the returned page.
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// The number of entries returned per page.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// The list of custom alert rules.
            /// </summary>
            [NameInMap("Reminds")]
            [Validation(Required=false)]
            public List<ListRemindsResponseBodyDataReminds> Reminds { get; set; }
            public class ListRemindsResponseBodyDataReminds : TeaModel {
                /// <summary>
                /// The notification method. Valid values: MAIL, SMS, and PHONE. The value MAIL indicates that the notification is sent by email. Only DataWorks Professional Edition and more advanced editions support the PHONE notification method.
                /// </summary>
                [NameInMap("AlertMethods")]
                [Validation(Required=false)]
                public List<string> AlertMethods { get; set; }

                /// <summary>
                /// The IDs of the Alibaba Cloud accounts used by alert recipients.
                /// </summary>
                [NameInMap("AlertTargets")]
                [Validation(Required=false)]
                public List<string> AlertTargets { get; set; }

                /// <summary>
                /// The alert recipient. Valid values: OWNER and OTHER. The value OWNER indicates the node owner. The value OTHER indicates a specified user.
                /// </summary>
                [NameInMap("AlertUnit")]
                [Validation(Required=false)]
                public string AlertUnit { get; set; }

                /// <summary>
                /// The IDs of the baselines to which the custom alert rule is applied. This parameter is returned if the value of the RemindUnit parameter is BASELINE.
                /// </summary>
                [NameInMap("BaselineIds")]
                [Validation(Required=false)]
                public List<long?> BaselineIds { get; set; }

                /// <summary>
                /// The IDs of the workflows to which the custom alert rule is applied. This parameter is returned if the value of the RemindUnit parameter is BIZPROCESS.
                /// </summary>
                [NameInMap("BizProcessIds")]
                [Validation(Required=false)]
                public List<long?> BizProcessIds { get; set; }

                /// <summary>
                /// The end time of the quiet hours. The time is in the hh:mm format. Valid values of hh: [0,23]. Valid values of mm: [0,59].
                /// </summary>
                [NameInMap("DndEnd")]
                [Validation(Required=false)]
                public string DndEnd { get; set; }

                /// <summary>
                /// The start time of the quiet hours. The time is in the hh:mm format. Valid values of hh: [0,23]. Valid values of mm: [0,59].
                /// </summary>
                [NameInMap("DndStart")]
                [Validation(Required=false)]
                public string DndStart { get; set; }

                /// <summary>
                /// The ID of the Alibaba Cloud account used by the rule creator.
                /// </summary>
                [NameInMap("Founder")]
                [Validation(Required=false)]
                public string Founder { get; set; }

                /// <summary>
                /// The IDs of the nodes to which the custom alert rule is applied. This parameter is returned if the value of the RemindUnit parameter is NODE.
                /// </summary>
                [NameInMap("NodeIds")]
                [Validation(Required=false)]
                public List<long?> NodeIds { get; set; }

                /// <summary>
                /// The IDs of the workspaces to which the custom alert rule is applied. This parameter is returned if the value of the RemindUnit parameter is PROJECT.
                /// </summary>
                [NameInMap("ProjectIds")]
                [Validation(Required=false)]
                public List<long?> ProjectIds { get; set; }

                /// <summary>
                /// The custom alert rule ID.
                /// </summary>
                [NameInMap("RemindId")]
                [Validation(Required=false)]
                public long? RemindId { get; set; }

                /// <summary>
                /// The name of the custom alert rule.
                /// </summary>
                [NameInMap("RemindName")]
                [Validation(Required=false)]
                public string RemindName { get; set; }

                /// <summary>
                /// The condition that triggers an alert. Valid values: FINISHED, UNFINISHED, ERROR, CYCLE_UNFINISHED, and TIMEOUT.
                /// </summary>
                [NameInMap("RemindType")]
                [Validation(Required=false)]
                public string RemindType { get; set; }

                /// <summary>
                /// The type of the object to which the custom alert rule is applied. Valid values: NODE, BASELINE, PROJECT, and BIZPROCESS. The value NODE indicates a node. The value BASELINE indicates a baseline. The value PROJECT indicates a workspace. The value BIZPROCESS indicates a workflow.
                /// </summary>
                [NameInMap("RemindUnit")]
                [Validation(Required=false)]
                public string RemindUnit { get; set; }

                /// <summary>
                /// Indicates whether the custom alert rule is enabled. Valid values: true and false.
                /// </summary>
                [NameInMap("Useflag")]
                [Validation(Required=false)]
                public bool? Useflag { get; set; }

            }

            /// <summary>
            /// The total number of custom alert rules returned.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// The error code returned.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The error message returned.
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The HTTP status code returned.
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// The ID of the request. You can use the ID to troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
