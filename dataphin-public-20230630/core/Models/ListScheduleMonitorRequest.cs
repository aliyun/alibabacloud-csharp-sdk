// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ListScheduleMonitorRequest : TeaModel {
        /// <summary>
        /// <para>The query conditions for scheduling monitoring and alerting.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ListQuery")]
        [Validation(Required=false)]
        public ListScheduleMonitorRequestListQuery ListQuery { get; set; }
        public class ListScheduleMonitorRequestListQuery : TeaModel {
            /// <summary>
            /// <para>The list of alert cause types. Valid values: FAILED (the task execution failed), TIME_OUT (the task execution timed out), UNFINISHED (the task did not generate output), SUCCESS (the task execution succeeded), and DATA_DELAY (the data is delayed).</para>
            /// </summary>
            [NameInMap("AlertReasonList")]
            [Validation(Required=false)]
            public List<string> AlertReasonList { get; set; }

            /// <summary>
            /// <para>The keyword for search. Supports fuzzy matching for monitored task names. If this parameter is empty or not specified, no filtering is applied.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dwd_order_detail</para>
            /// </summary>
            [NameInMap("KeyWord")]
            [Validation(Required=false)]
            public string KeyWord { get; set; }

            /// <summary>
            /// <para>The list of logical field IDs.</para>
            /// </summary>
            [NameInMap("LogicFieldIdList")]
            [Validation(Required=false)]
            public List<long?> LogicFieldIdList { get; set; }

            /// <summary>
            /// <para>The list of logical table IDs.</para>
            /// </summary>
            [NameInMap("LogicalTableIdList")]
            [Validation(Required=false)]
            public List<long?> LogicalTableIdList { get; set; }

            /// <summary>
            /// <para>The list of on-call schedule IDs.</para>
            /// </summary>
            [NameInMap("OnCallTableList")]
            [Validation(Required=false)]
            public List<string> OnCallTableList { get; set; }

            /// <summary>
            /// <para>The list of user IDs of the creators of monitored objects.</para>
            /// </summary>
            [NameInMap("OwnerList")]
            [Validation(Required=false)]
            public List<string> OwnerList { get; set; }

            /// <summary>
            /// <para>The current page number. Pages start from 1. Default value: 1.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNo")]
            [Validation(Required=false)]
            public int? PageNo { get; set; }

            /// <summary>
            /// <para>The number of entries per page. Default value: 20.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The list of project IDs. If this parameter is empty, all projects that the current user has permissions on are automatically queried.</para>
            /// </summary>
            [NameInMap("ProjectIds")]
            [Validation(Required=false)]
            public List<long?> ProjectIds { get; set; }

            /// <summary>
            /// <para>The list of notification method types. Valid values: PHONE (phone call), MESSAGE (text message), EMAIL (email), DING_TALK (DingTalk), FEISHU (Lark), WECHAT (WeChat), and CUSTOM (custom channel).</para>
            /// </summary>
            [NameInMap("ReceivedWayTypeList")]
            [Validation(Required=false)]
            public List<string> ReceivedWayTypeList { get; set; }

            /// <summary>
            /// <para>The list of user IDs of the recipients.</para>
            /// </summary>
            [NameInMap("ReceiverList")]
            [Validation(Required=false)]
            public List<string> ReceiverList { get; set; }

            /// <summary>
            /// <para>The list of monitored object types. Valid values: LOGICAL_FIELD (logical field), OND_ID_NODE (logical table node), SCHEDULE_PHYSICAL_NODE (periodically scheduled physical task), MANUAL_PHYSICAL_NODE (manually scheduled physical task), ODM_NODE (source path task), LOGICAL_TABLE_NODE (logical table task), and PROJECT (project).</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("TypeList")]
            [Validation(Required=false)]
            public List<string> TypeList { get; set; }

        }

        /// <summary>
        /// <para>The tenant ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpTenantId")]
        [Validation(Required=false)]
        public long? OpTenantId { get; set; }

        /// <summary>
        /// <para>The user ID of the operator.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

    }

}
