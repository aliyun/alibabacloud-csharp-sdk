// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aidge20260428.Models
{
    public class VisionFlowResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code. The value &quot;success&quot; is returned for a successful call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The submit status data of the asynchronous task, which contains the asynchronous task ID.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public VisionFlowResponseBodyData Data { get; set; }
        public class VisionFlowResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The asynchronous task ID. Use this ID to query the processing result through QueryAsyncTaskResult.</para>
            /// 
            /// <b>Example:</b>
            /// <para>e4c48e88-3c34-91e3-ab8a-08484dc4d402</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

        /// <summary>
        /// <para>The error message. The value &quot;Success&quot; is returned for a successful call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID, which uniquely identifies the API call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F3E65785-0180-1227-91B0-2F5F52F679FB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call is successful. Valid values: true and false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
