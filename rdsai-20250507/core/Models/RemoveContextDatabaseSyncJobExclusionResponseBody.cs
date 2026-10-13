// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RdsAi20250507.Models
{
    public class RemoveContextDatabaseSyncJobExclusionResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Example value</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public RemoveContextDatabaseSyncJobExclusionResponseBodyData Data { get; set; }
        public class RemoveContextDatabaseSyncJobExclusionResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Indicates whether the data has changed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Changed")]
            [Validation(Required=false)]
            public bool? Changed { get; set; }

            /// <summary>
            /// <para>The configuration version number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("ConfigVersion")]
            [Validation(Required=false)]
            public int? ConfigVersion { get; set; }

            /// <summary>
            /// <para>The document ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>doc-as1llqmkol****</para>
            /// </summary>
            [NameInMap("DocumentId")]
            [Validation(Required=false)]
            public string DocumentId { get; set; }

            /// <summary>
            /// <para>Indicates whether the item is excluded.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Excluded")]
            [Validation(Required=false)]
            public bool? Excluded { get; set; }

            /// <summary>
            /// <para>The job ID, which is a system-generated UUID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>550e8400-e29b-41d4-a716-446655440000</para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public long? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Example value</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>id-001</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
