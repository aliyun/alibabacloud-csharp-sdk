// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class GetMemoryResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>test_user_001</para>
        /// </summary>
        [NameInMap("agentId")]
        [Validation(Required=false)]
        public string AgentId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test_user_001</para>
        /// </summary>
        [NameInMap("appId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1751595283143</para>
        /// </summary>
        [NameInMap("createdAt")]
        [Validation(Required=false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1751595283143</para>
        /// </summary>
        [NameInMap("expirationDate")]
        [Validation(Required=false)]
        public string ExpirationDate { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>019ca1e5-7307-7d50-b943-5e628326a8ed</para>
        /// </summary>
        [NameInMap("id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("immutable")]
        [Validation(Required=false)]
        public string Immutable { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>My name is Zhang San and I live in Hangzhou.</para>
        /// </summary>
        [NameInMap("memory")]
        [Validation(Required=false)]
        public string Memory { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;sessionId&quot;:&quot;test_session_001&quot;}</para>
        /// </summary>
        [NameInMap("metadata")]
        [Validation(Required=false)]
        public string Metadata { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("organization")]
        [Validation(Required=false)]
        public string Organization { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("owner")]
        [Validation(Required=false)]
        public string Owner { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>8FDE2569-626B-5176-9844-28877A*****</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test_user_001</para>
        /// </summary>
        [NameInMap("runId")]
        [Validation(Required=false)]
        public string RunId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1744428159434</para>
        /// </summary>
        [NameInMap("updatedAt")]
        [Validation(Required=false)]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test_user_001</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
