// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class ListAliDingMinutesRequest : TeaModel {
        /// <summary>
        /// <para>The cursor for the paged query. Set this parameter to 0 for the first request. For subsequent requests, set this parameter to the <b>nextCursor</b> value returned in the previous response. For more information about paging, see the response parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>opaque-next-cursor</para>
        /// </summary>
        [NameInMap("cursor")]
        [Validation(Required=false)]
        public string Cursor { get; set; }

        /// <summary>
        /// <para>The actual end timestamp of the live session, in milliseconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-09-08T23:59:59+08:00</para>
        /// </summary>
        [NameInMap("endTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The query start time. This value is a UNIX timestamp in seconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-09-01T00:00:00+08:00</para>
        /// </summary>
        [NameInMap("startTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The tenant ID. This is a common parameter. Pass it explicitly through the winnexo-cli --tenant-id option.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

    }

}
