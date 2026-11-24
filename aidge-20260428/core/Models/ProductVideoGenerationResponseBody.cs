// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aidge20260428.Models
{
    public class ProductVideoGenerationResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The task acceptance result.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ProductVideoGenerationResponseBodyData Data { get; set; }
        public class ProductVideoGenerationResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The planning path written upon acceptance. Valid values: DIRECT (with script) and AUTO_PLAN (automatic planning).</para>
            /// 
            /// <b>Example:</b>
            /// <para>AUTO_PLAN</para>
            /// </summary>
            [NameInMap("route")]
            [Validation(Required=false)]
            public string Route { get; set; }

            /// <summary>
            /// <para>The current status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PENDING</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The task ID of this service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>task_778fa8bd21804828a5d147050e30edac</para>
            /// </summary>
            [NameInMap("task_id")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

        /// <summary>
        /// <para>The returned message or failure description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Task submitted</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>70CBEFDF-BB17-1EB3-8A21-569F3124738F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
