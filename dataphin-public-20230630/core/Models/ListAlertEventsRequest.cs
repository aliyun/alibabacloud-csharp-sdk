// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ListAlertEventsRequest : TeaModel {
        /// <summary>
        /// <para>The query request.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ListQuery")]
        [Validation(Required=false)]
        public ListAlertEventsRequestListQuery ListQuery { get; set; }
        public class ListAlertEventsRequestListQuery : TeaModel {
            /// <summary>
            /// <para>The alert end date.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-11-27 13:47:00</para>
            /// </summary>
            [NameInMap("AlertEndTime")]
            [Validation(Required=false)]
            public string AlertEndTime { get; set; }

            /// <summary>
            /// <para>The list of alert object types.</para>
            /// </summary>
            [NameInMap("AlertObjectTypeList")]
            [Validation(Required=false)]
            public List<string> AlertObjectTypeList { get; set; }

            /// <summary>
            /// <para>The list of alert causes.</para>
            /// </summary>
            [NameInMap("AlertReasonList")]
            [Validation(Required=false)]
            public List<string> AlertReasonList { get; set; }

            /// <summary>
            /// <para>The alert start date.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-11-16 00:00:00</para>
            /// </summary>
            [NameInMap("AlertStartTime")]
            [Validation(Required=false)]
            public string AlertStartTime { get; set; }

            /// <summary>
            /// <para>The list of business unit names.</para>
            /// </summary>
            [NameInMap("BizNameList")]
            [Validation(Required=false)]
            public List<string> BizNameList { get; set; }

            /// <summary>
            /// <para>The search keyword.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Keyword")]
            [Validation(Required=false)]
            public string Keyword { get; set; }

            /// <summary>
            /// <para>The list of monitored item IDs.</para>
            /// </summary>
            [NameInMap("MonitoredItemIdList")]
            [Validation(Required=false)]
            public List<string> MonitoredItemIdList { get; set; }

            /// <summary>
            /// <para>The page number.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Page")]
            [Validation(Required=false)]
            public int? Page { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The list of project names.</para>
            /// </summary>
            [NameInMap("ProjectNameList")]
            [Validation(Required=false)]
            public List<string> ProjectNameList { get; set; }

            /// <summary>
            /// <para>The source system. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>ALL: All.</description></item>
            /// <item><description>DQE: Data quality.</description></item>
            /// <item><description>OS: Data service.</description></item>
            /// <item><description>STREAM: Real-time computing.</description></item>
            /// <item><description>VDM_BATCH: Offline computing.</description></item>
            /// <item><description>SOP: O&amp;M platform.</description></item>
            /// <item><description>REAL_TIME_PIPELINE: Real-time integration.</description></item>
            /// <item><description>KGB: Baseline monitoring.</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ALL</para>
            /// </summary>
            [NameInMap("SourceSystem")]
            [Validation(Required=false)]
            public string SourceSystem { get; set; }

            /// <summary>
            /// <para>The list of alert statuses.</para>
            /// </summary>
            [NameInMap("StatusList")]
            [Validation(Required=false)]
            public List<string> StatusList { get; set; }

            /// <summary>
            /// <para>The list of alert contact IDs.</para>
            /// </summary>
            [NameInMap("UserIdList")]
            [Validation(Required=false)]
            public List<string> UserIdList { get; set; }

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
        /// <para>The ID of the operator.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

    }

}
