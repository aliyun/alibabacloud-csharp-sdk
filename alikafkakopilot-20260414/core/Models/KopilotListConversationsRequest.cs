// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AlikafkaKopilot20260414.Models
{
    public class KopilotListConversationsRequest : TeaModel {
        /// <summary>
        /// <para>The pagination cursor for notification channels. Do not specify this parameter for the first query. For subsequent queries, pass in the value of Data.AutomationOverview.Destinations.NextCursor from the previous response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("DestinationCursor")]
        [Validation(Required=false)]
        public string DestinationCursor { get; set; }

        /// <summary>
        /// <para>The number of entries per page for the notification channel list. Default value: 20. Valid values: 1 to 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("DestinationPageSize")]
        [Validation(Required=false)]
        public int? DestinationPageSize { get; set; }

        /// <summary>
        /// <para>Specifies whether to return the overview of scheduled tasks and notification channels for the account. A value of true indicates that the overview is returned. If this parameter is not specified, the overview is not returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IncludeAutomationOverview")]
        [Validation(Required=false)]
        public bool? IncludeAutomationOverview { get; set; }

        /// <summary>
        /// <para>The current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Page")]
        [Validation(Required=false)]
        public int? Page { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The page size.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Size")]
        [Validation(Required=false)]
        public int? Size { get; set; }

        /// <summary>
        /// <para>The pagination cursor. Do not specify this parameter for the first query. For subsequent queries, pass in the value of Data.AutomationOverview.Tasks.NextCursor from the previous response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("TaskCursor")]
        [Validation(Required=false)]
        public string TaskCursor { get; set; }

        /// <summary>
        /// <para>The number of entries per page for the scheduled task list. Default value: 20. Valid values: 1 to 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("TaskPageSize")]
        [Validation(Required=false)]
        public int? TaskPageSize { get; set; }

    }

}
