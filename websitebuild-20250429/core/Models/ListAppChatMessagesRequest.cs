// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class ListAppChatMessagesRequest : TeaModel {
        /// <summary>
        /// <para>Chat ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>20833ba4-d189-4c50-9a44-a6bcbda2c93b</para>
        /// </summary>
        [NameInMap("ChatId")]
        [Validation(Required=false)]
        public string ChatId { get; set; }

        /// <summary>
        /// <para>Session ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>593fe1a2-d0b4-4fde-a2b0-78ad6a438d41</para>
        /// </summary>
        [NameInMap("ConversationId")]
        [Validation(Required=false)]
        public string ConversationId { get; set; }

        /// <summary>
        /// <para>Number of results per query.  </para>
        /// <para>Valid range: 10 to 100. Default Value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>Token indicating the start of the next query. This value is empty if there is no subsequent query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FFh3Xqm+JgZ/U9Jyb7wdVr9LWk80Tghn5UZjbcWEVEderBcbVF+Y6PS0i8PpCL4PQZ3e0C9oEH0Asd4tJEuGtkl2WuKdiWZpEwadNydQdJPFM=</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>Segment ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>169</para>
        /// </summary>
        [NameInMap("SectionId")]
        [Validation(Required=false)]
        public string SectionId { get; set; }

    }

}
