// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ListAlertNotificationsRequest : TeaModel {
        /// <summary>
        /// <para>The query conditions.</para>
        /// </summary>
        [NameInMap("ListQuery")]
        [Validation(Required=false)]
        public ListAlertNotificationsRequestListQuery ListQuery { get; set; }
        public class ListAlertNotificationsRequestListQuery : TeaModel {
            /// <summary>
            /// <para>The list of alert reasons.</para>
            /// </summary>
            [NameInMap("AlertReasonList")]
            [Validation(Required=false)]
            public List<string> AlertReasonList { get; set; }

            /// <summary>
            /// <para>The list of push channel types.</para>
            /// </summary>
            [NameInMap("ChannelTypeList")]
            [Validation(Required=false)]
            public List<string> ChannelTypeList { get; set; }

            /// <summary>
            /// <para>The list of custom message channel IDs.</para>
            /// </summary>
            [NameInMap("CustomChannelIdList")]
            [Validation(Required=false)]
            public List<string> CustomChannelIdList { get; set; }

            /// <summary>
            /// <para>The keyword for the query.</para>
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
            /// <para>The end time of the push.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-11-27 13:47:00</para>
            /// </summary>
            [NameInMap("NotifyEndTime")]
            [Validation(Required=false)]
            public string NotifyEndTime { get; set; }

            /// <summary>
            /// <para>The start time of the push.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-11-16 00:00:00</para>
            /// </summary>
            [NameInMap("NotifyStartTime")]
            [Validation(Required=false)]
            public string NotifyStartTime { get; set; }

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
            /// <para>The number of records per page.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The source system. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>ALL: all.</description></item>
            /// <item><description>DQE: data quality.</description></item>
            /// <item><description>OS: data service.</description></item>
            /// <item><description>STREAM: real-time computing.</description></item>
            /// <item><description>VDM_BATCH: offline computing.</description></item>
            /// <item><description>SOP: O&amp;M platform.</description></item>
            /// <item><description>REAL_TIME_PIPELINE: real-time integration.</description></item>
            /// <item><description>KGB: baseline monitoring.</description></item>
            /// </list>
            /// <para>And more.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ALL</para>
            /// </summary>
            [NameInMap("SourceSystem")]
            [Validation(Required=false)]
            public string SourceSystem { get; set; }

            /// <summary>
            /// <para>The list of push statuses.</para>
            /// </summary>
            [NameInMap("StatusList")]
            [Validation(Required=false)]
            public List<string> StatusList { get; set; }

            /// <summary>
            /// <para>The list of push recipient IDs.</para>
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

    }

}
