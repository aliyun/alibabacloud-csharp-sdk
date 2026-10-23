// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class SearchAliDingGroupChatsRequest : TeaModel {
        /// <summary>
        /// <para>The cursor for the paged query. Set this parameter to 0 for the first request. For subsequent paging requests, set this parameter to the value of <b>nextCursor</b> returned in the previous response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("cursor")]
        [Validation(Required=false)]
        public string Cursor { get; set; }

        /// <summary>
        /// <para>Specifies whether to exclude muted group chats.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("excludeMuted")]
        [Validation(Required=false)]
        public bool? ExcludeMuted { get; set; }

        /// <summary>
        /// <para>The keyword for search. The keyword always matches the name field. If the description field is defined in the schema, the keyword also matches the description field.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Customer project</para>
        /// </summary>
        [NameInMap("keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// <para>The page size.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The tenant ID. This is a common parameter. If this parameter is not specified, the default tenant of the caller is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

    }

}
