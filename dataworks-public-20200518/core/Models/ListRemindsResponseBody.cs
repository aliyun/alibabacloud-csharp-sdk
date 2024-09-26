// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListRemindsResponseBody : TeaModel {
        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListRemindsResponseBodyData Data { get; set; }
        public class ListRemindsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The page number of the returned page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries returned per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The list of custom alert rules.</para>
            /// </summary>
            [NameInMap("Reminds")]
            [Validation(Required=false)]
            public List<ListRemindsResponseBodyDataReminds> Reminds { get; set; }
            public class ListRemindsResponseBodyDataReminds : TeaModel {
                /// <summary>
                /// <para>The notification method. Valid values: MAIL, SMS, and PHONE. The value MAIL indicates that the notification is sent by email. Only DataWorks Professional Edition and more advanced editions support the PHONE notification method.</para>
                /// </summary>
                [NameInMap("AlertMethods")]
                [Validation(Required=false)]
                public List<string> AlertMethods { get; set; }

                /// <summary>
                /// <para>The IDs of the Alibaba Cloud accounts used by alert recipients.</para>
                /// </summary>
                [NameInMap("AlertTargets")]
                [Validation(Required=false)]
                public List<string> AlertTargets { get; set; }

                /// <summary>
                /// <para>The alert recipient. Valid values: OWNER and OTHER. The value OWNER indicates the node owner. The value OTHER indicates a specified user.</para>
                /// 
                /// <b>Example:</b>
                /// <para>OWNER</para>
                /// </summary>
                [NameInMap("AlertUnit")]
                [Validation(Required=false)]
                public string AlertUnit { get; set; }

                /// <summary>
                /// <para>The IDs of the baselines to which the custom alert rule is applied. This parameter is returned if the value of the RemindUnit parameter is BASELINE.</para>
                /// </summary>
                [NameInMap("BaselineIds")]
                [Validation(Required=false)]
                public List<long?> BaselineIds { get; set; }

                /// <summary>
                /// <para>The IDs of the workflows to which the custom alert rule is applied. This parameter is returned if the value of the RemindUnit parameter is BIZPROCESS.</para>
                /// </summary>
                [NameInMap("BizProcessIds")]
                [Validation(Required=false)]
                public List<long?> BizProcessIds { get; set; }

                /// <summary>
                /// <para>The end time of the quiet hours. The time is in the hh:mm format. Valid values of hh: [0,23]. Valid values of mm: [0,59].</para>
                /// 
                /// <b>Example:</b>
                /// <para>08:00</para>
                /// </summary>
                [NameInMap("DndEnd")]
                [Validation(Required=false)]
                public string DndEnd { get; set; }

                /// <summary>
                /// <para>The start time of the quiet hours. The time is in the hh:mm format. Valid values of hh: [0,23]. Valid values of mm: [0,59].</para>
                /// 
                /// <b>Example:</b>
                /// <para>00:00</para>
                /// </summary>
                [NameInMap("DndStart")]
                [Validation(Required=false)]
                public string DndStart { get; set; }

                /// <summary>
                /// <para>The ID of the Alibaba Cloud account used by the rule creator.</para>
                /// 
                /// <b>Example:</b>
                /// <para>952795****</para>
                /// </summary>
                [NameInMap("Founder")]
                [Validation(Required=false)]
                public string Founder { get; set; }

                /// <summary>
                /// <para>The IDs of the nodes to which the custom alert rule is applied. This parameter is returned if the value of the RemindUnit parameter is NODE.</para>
                /// </summary>
                [NameInMap("NodeIds")]
                [Validation(Required=false)]
                public List<long?> NodeIds { get; set; }

                /// <summary>
                /// <para>The IDs of the workspaces to which the custom alert rule is applied. This parameter is returned if the value of the RemindUnit parameter is PROJECT.</para>
                /// </summary>
                [NameInMap("ProjectIds")]
                [Validation(Required=false)]
                public List<long?> ProjectIds { get; set; }

                /// <summary>
                /// <para>The custom alert rule ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1234</para>
                /// </summary>
                [NameInMap("RemindId")]
                [Validation(Required=false)]
                public long? RemindId { get; set; }

                /// <summary>
                /// <para>The name of the custom alert rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Alert Rule</para>
                /// </summary>
                [NameInMap("RemindName")]
                [Validation(Required=false)]
                public string RemindName { get; set; }

                /// <summary>
                /// <para>The condition that triggers an alert. Valid values: FINISHED, UNFINISHED, ERROR, CYCLE_UNFINISHED, and TIMEOUT.</para>
                /// 
                /// <b>Example:</b>
                /// <para>FINISHED</para>
                /// </summary>
                [NameInMap("RemindType")]
                [Validation(Required=false)]
                public string RemindType { get; set; }

                /// <summary>
                /// <para>The type of the object to which the custom alert rule is applied. Valid values: NODE, BASELINE, PROJECT, and BIZPROCESS. The value NODE indicates a node. The value BASELINE indicates a baseline. The value PROJECT indicates a workspace. The value BIZPROCESS indicates a workflow.</para>
                /// 
                /// <b>Example:</b>
                /// <para>NODE</para>
                /// </summary>
                [NameInMap("RemindUnit")]
                [Validation(Required=false)]
                public string RemindUnit { get; set; }

                /// <summary>
                /// <para>Indicates whether the custom alert rule is enabled. Valid values: true and false.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Useflag")]
                [Validation(Required=false)]
                public bool? Useflag { get; set; }

            }

            /// <summary>
            /// <para>The total number of custom alert rules returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The error code returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1031203110005</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The specified parameters are invalid.</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The HTTP status code returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The ID of the request. You can use the ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0000-ABCD-EFG****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
