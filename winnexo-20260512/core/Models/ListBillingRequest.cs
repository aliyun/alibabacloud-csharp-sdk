// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class ListBillingRequest : TeaModel {
        /// <summary>
        /// <para>The unique business identifier. When bizType is LibraryChat, bizId refers to the document library ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>exampleBizId</para>
        /// </summary>
        [NameInMap("bizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        /// <summary>
        /// <para>The business type. Currently supported values: model Q&amp;A (LlmChat) and document library Q&amp;A (LibraryChat).</para>
        /// 
        /// <b>Example:</b>
        /// <para>string_value</para>
        /// </summary>
        [NameInMap("bizType")]
        [Validation(Required=false)]
        public string BizType { get; set; }

        /// <summary>
        /// <para>The actual end timestamp of the live stream, in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-10-01T12:00:00Z</para>
        /// </summary>
        [NameInMap("endTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>Specifies whether to filter out bills with zero credit consumption. Default value: true (filter out).</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ignoreZero")]
        [Validation(Required=false)]
        public bool? IgnoreZero { get; set; }

        /// <summary>
        /// <para>The operation type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>start: indicates task creation. This is the default value and does not need to be explicitly set in most cases.</description></item>
        /// <item><description>stop: stops a real-time meeting task. This corresponds to the creation of a real-time meeting. After the meeting ends, set this to stop to trigger the call. This is used in real-time meeting scenarios.</description></item>
        /// </list>
        /// <para>Note: When ending a real-time recording, you must set this parameter to stop.</para>
        /// 
        /// <b>Example:</b>
        /// <para>string_value</para>
        /// </summary>
        [NameInMap("operation")]
        [Validation(Required=false)]
        public string Operation { get; set; }

        /// <summary>
        /// <para>The current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("page")]
        [Validation(Required=false)]
        public long? Page { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 20. Minimum value: 1. Maximum value: 50.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The query start time. The value is a UNIX timestamp in seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-10-01T12:00:00Z</para>
        /// </summary>
        [NameInMap("startTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The task status. The status is returned as Running upon submission.</para>
        /// 
        /// <b>Example:</b>
        /// <para>READY</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The tenant ID. This is a common parameter. In winnexo-cli, pass it explicitly with --tenant-id.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        /// <summary>
        /// <para>The user ID (WINNEXO platform user ID, optional filter).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("wnUserId")]
        [Validation(Required=false)]
        public string WnUserId { get; set; }

    }

}
