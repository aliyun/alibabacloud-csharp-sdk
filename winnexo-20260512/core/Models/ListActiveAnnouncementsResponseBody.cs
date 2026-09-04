// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class ListActiveAnnouncementsResponseBody : TeaModel {
        /// <summary>
        /// <para>The business status code. A value of 200 indicates success. A failure returns a backend error code (ERR.* / InvalidParameter.*).</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The list of MCP cards.</para>
        /// </summary>
        [NameInMap("items")]
        [Validation(Required=false)]
        public List<ListActiveAnnouncementsResponseBodyItems> Items { get; set; }
        public class ListActiveAnnouncementsResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The business ID of the announcement.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1001</para>
            /// </summary>
            [NameInMap("announcementId")]
            [Validation(Required=false)]
            public long? AnnouncementId { get; set; }

            /// <summary>
            /// <para>The returned content.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The system will undergo maintenance tonight</para>
            /// </summary>
            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <para>The user ID of the project creator.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10001</para>
            /// </summary>
            [NameInMap("createdBy")]
            [Validation(Required=false)]
            public long? CreatedBy { get; set; }

            /// <summary>
            /// <para>The display page. Valid values: ALL, FRONTEND, BACKEND.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ALL</para>
            /// </summary>
            [NameInMap("displayPage")]
            [Validation(Required=false)]
            public string DisplayPage { get; set; }

            /// <summary>
            /// <para>The display type and group label.</para>
            /// 
            /// <b>Example:</b>
            /// <para>LIST</para>
            /// </summary>
            [NameInMap("displayType")]
            [Validation(Required=false)]
            public string DisplayType { get; set; }

            /// <summary>
            /// <para>The custom effective end time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-08-21T14:00:00+08:00</para>
            /// </summary>
            [NameInMap("effectiveEnd")]
            [Validation(Required=false)]
            public string EffectiveEnd { get; set; }

            /// <summary>
            /// <para>The effective start time in ISO 8601 format with time zone. If not specified, the announcement takes effect immediately.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-08-20T14:00:00+08:00</para>
            /// </summary>
            [NameInMap("effectiveStart")]
            [Validation(Required=false)]
            public string EffectiveStart { get; set; }

            /// <summary>
            /// <para>The priority of the free task.</para>
            /// <list type="bullet">
            /// <item><description><para>Uses the default priority of the project, as shown in the following figure. The default priorities are as follows:</para>
            /// <list type="bullet">
            /// <item><description><para><b>-10</b>: Low. This is the default value.</para>
            /// </description></item>
            /// <item><description><para><b>0</b>: Normal.</para>
            /// </description></item>
            /// <item><description><para><b>1</b>: Urgent.</para>
            /// </description></item>
            /// <item><description><para><b>2</b>: Very urgent.</para>
            /// </description></item>
            /// </list>
            /// </description></item>
            /// </list>
            /// <para><img src="https://img.alicdn.com/imgextra/i1/O1CN01hNuSPz25juCzgxhmW_!!6000000007563-2-tps-2682-1304.png" alt=""></para>
            /// <list type="bullet">
            /// <item><description>Custom priority, as shown in the following figure, with an additional &quot;Moderately urgent&quot; level.</description></item>
            /// </list>
            /// <para>The value of this parameter is subject to the actual response of the API. A higher priority corresponds to a larger value.</para>
            /// <para><img src="https://img.alicdn.com/imgextra/i1/O1CN01V67b3i1mkNvJiW8D1_!!6000000004992-2-tps-2128-1126.png" alt=""></para>
            /// 
            /// <b>Example:</b>
            /// <para>GENERAL</para>
            /// </summary>
            [NameInMap("priority")]
            [Validation(Required=false)]
            public string Priority { get; set; }

            /// <summary>
            /// <para>The publish time in ISO 8601 format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-08-20T14:00:00+08:00</para>
            /// </summary>
            [NameInMap("publishedAt")]
            [Validation(Required=false)]
            public string PublishedAt { get; set; }

            /// <summary>
            /// <para>The task status. Running is returned upon submission.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PUBLISHED</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The title of the scheduled meeting.</para>
            /// 
            /// <b>Example:</b>
            /// <para>System Maintenance Notice</para>
            /// </summary>
            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        /// <summary>
        /// <para>The description of the status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The page number, starting from 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The page size.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>019FF406-1B10-0065-A97D-2D1920C2A03D</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
