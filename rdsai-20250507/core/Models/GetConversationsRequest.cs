// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RdsAi20250507.Models
{
    public class GetConversationsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the flow.</para>
        /// 
        /// <b>Example:</b>
        /// <para>flow-c5007b4a03a2446cbe9d</para>
        /// </summary>
        [NameInMap("FlowId")]
        [Validation(Required=false)]
        public string FlowId { get; set; }

        /// <summary>
        /// <para>The ID of the last conversation record.</para>
        /// 
        /// <b>Example:</b>
        /// <para>77be60cd-237b-4ca9-9c46-48b663cb****</para>
        /// </summary>
        [NameInMap("LastId")]
        [Validation(Required=false)]
        public string LastId { get; set; }

        /// <summary>
        /// <para>The paging Settings for the number of entries per page in a paged query. Valid values: 1 to 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Limit")]
        [Validation(Required=false)]
        public string Limit { get; set; }

        /// <summary>
        /// <para>The pin mark for application favorites.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Pinned")]
        [Validation(Required=false)]
        public string Pinned { get; set; }

        /// <summary>
        /// <para>The sorting criterion.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CreatedAt</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// <para>The ID of the ContextDB workspace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>00000000-0000-4000-8000-000000000001</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
