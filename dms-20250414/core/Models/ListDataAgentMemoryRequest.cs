// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class ListDataAgentMemoryRequest : TeaModel {
        /// <summary>
        /// <para>The content pattern used for fuzzy match search.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user preference</para>
        /// </summary>
        [NameInMap("ContentPattern")]
        [Validation(Required=false)]
        public string ContentPattern { get; set; }

        /// <summary>
        /// <para>The current Data Management unit.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("DMSUnit")]
        [Validation(Required=false)]
        public string DMSUnit { get; set; }

        /// <summary>
        /// <para>The source ID.</para>
        /// <list type="bullet">
        /// <item><description>If MemFrom is set to session, FromId indicates the session ID.</description></item>
        /// <item><description>If MemFrom is set to user, FromId indicates the RAM user ID.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>8zm3**********g3yxa1</para>
        /// </summary>
        [NameInMap("FromId")]
        [Validation(Required=false)]
        public string FromId { get; set; }

        /// <summary>
        /// <para>The memory source. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>session: Generated from a session.</description></item>
        /// <item><description>user: Edited by a user.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>session</para>
        /// </summary>
        [NameInMap("MemFrom")]
        [Validation(Required=false)]
        public string MemFrom { get; set; }

        /// <summary>
        /// <para>The sort order for the specified sort field. Default value: desc. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>asc: Ascending order.</description></item>
        /// <item><description>desc: Descending order.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>desc</para>
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// <para>The sort field. Default value: hitTimes. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>hitTimes: The number of hits.</description></item>
        /// <item><description>created: The creation time.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>hitTimes</para>
        /// </summary>
        [NameInMap("OrderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        /// <summary>
        /// <para>The page number. Minimum value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public long? PageNum { get; set; }

        /// <summary>
        /// <para>The maximum number of entries per page. Default value: 50.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>Specifies whether to query memories in all statuses. Default value: true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("QueryAll")]
        [Validation(Required=false)]
        public bool? QueryAll { get; set; }

    }

}
