// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AlikafkaKopilot20260414.Models
{
    public class KopilotListConversationChatMessagesRequest : TeaModel {
        /// <summary>
        /// <para>The cursor.</para>
        /// <remarks>
        /// <para>If this parameter is not specified, the last pageSize turn IDs are returned. If this parameter is specified, the turn IDs before the specified turn ID are returned.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2345</para>
        /// </summary>
        [NameInMap("BeforeTurnId")]
        [Validation(Required=false)]
        public int? BeforeTurnId { get; set; }

        /// <summary>
        /// <para>The page size.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

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
        /// <para>The session ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e356c91c-8220-425c-9d86-********</para>
        /// </summary>
        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// <para>The pagination cursor. Do not specify this parameter for the first query. For subsequent queries, pass in the value of Data.ScheduledTaskInfo.NextTaskCursor from the previous response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("TaskCursor")]
        [Validation(Required=false)]
        public string TaskCursor { get; set; }

        /// <summary>
        /// <para>The number of scheduled tasks per page. Default value: 20. Valid values: 1 to 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("TaskPageSize")]
        [Validation(Required=false)]
        public int? TaskPageSize { get; set; }

    }

}
