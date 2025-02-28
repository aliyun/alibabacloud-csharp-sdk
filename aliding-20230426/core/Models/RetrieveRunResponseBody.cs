// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class RetrieveRunResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1642448000000</para>
        /// </summary>
        [NameInMap("cancelledAt")]
        [Validation(Required=false)]
        public long? CancelledAt { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1642448000000</para>
        /// </summary>
        [NameInMap("completedAt")]
        [Validation(Required=false)]
        public long? CompletedAt { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1642448000000</para>
        /// </summary>
        [NameInMap("createAt")]
        [Validation(Required=false)]
        public long? CreateAt { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1642448000000</para>
        /// </summary>
        [NameInMap("expiresAt")]
        [Validation(Required=false)]
        public long? ExpiresAt { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1642448000000</para>
        /// </summary>
        [NameInMap("failedAt")]
        [Validation(Required=false)]
        public long? FailedAt { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>runId123</para>
        /// </summary>
        [NameInMap("id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>errorMsg</para>
        /// </summary>
        [NameInMap("lastErrorMsg")]
        [Validation(Required=false)]
        public string LastErrorMsg { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("metadata")]
        [Validation(Required=false)]
        public Dictionary<string, object> Metadata { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>thread.run</para>
        /// </summary>
        [NameInMap("object")]
        [Validation(Required=false)]
        public string Object { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0FAAEC9C-C6C8-5C87-AF8E-1195889BBXXX</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1642448000000</para>
        /// </summary>
        [NameInMap("startedAt")]
        [Validation(Required=false)]
        public long? StartedAt { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>running</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>threadId123</para>
        /// </summary>
        [NameInMap("threadId")]
        [Validation(Required=false)]
        public string ThreadId { get; set; }

    }

}
