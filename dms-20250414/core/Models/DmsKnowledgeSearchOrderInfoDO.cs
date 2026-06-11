// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class DmsKnowledgeSearchOrderInfoDO : TeaModel {
        /// <summary>
        /// <para>The UID of the Alibaba Cloud account.</para>
        /// </summary>
        [NameInMap("AliyunAccountUid")]
        [Validation(Required=false)]
        public string AliyunAccountUid { get; set; }

        /// <summary>
        /// <para>The API key used for authentication.</para>
        /// </summary>
        [NameInMap("ApiKey")]
        [Validation(Required=false)]
        public string ApiKey { get; set; }

        /// <summary>
        /// <para>The time when the entry was created.</para>
        /// </summary>
        [NameInMap("GmtCreate")]
        [Validation(Required=false)]
        public string GmtCreate { get; set; }

        /// <summary>
        /// <para>The time when the entry was last modified.</para>
        /// </summary>
        [NameInMap("GmtModified")]
        [Validation(Required=false)]
        public string GmtModified { get; set; }

        /// <summary>
        /// <para>The unique ID of the entry.</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>The unique ID of the order.</para>
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// <para>The endpoint URL for the web search API.</para>
        /// </summary>
        [NameInMap("WebSearchApiUrl")]
        [Validation(Required=false)]
        public string WebSearchApiUrl { get; set; }

    }

}
