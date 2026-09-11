// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class ListAliDingGroupMessagesRequest : TeaModel {
        /// <summary>
        /// <para>The session ID, typically used for JSSDK.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cid-example</para>
        /// </summary>
        [NameInMap("chatId")]
        [Validation(Required=false)]
        public string ChatId { get; set; }

        /// <summary>
        /// <para>The traffic direction. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>OutBound: outbound.</description></item>
        /// <item><description>InBound: inbound.</description></item>
        /// <item><description>Both: bidirectional.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>newer</para>
        /// </summary>
        [NameInMap("direction")]
        [Validation(Required=false)]
        public string Direction { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The tenant ID. This is a common parameter. Pass it explicitly through <c>--tenant-id</c> in winnexo-cli.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        /// <summary>
        /// <para>The relationship information.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-09-08T09:00:00+08:00</para>
        /// </summary>
        [NameInMap("time")]
        [Validation(Required=false)]
        public string Time { get; set; }

    }

}
