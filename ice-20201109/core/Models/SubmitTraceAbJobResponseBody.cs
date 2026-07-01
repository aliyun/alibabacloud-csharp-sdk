// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SubmitTraceAbJobResponseBody : TeaModel {
        /// <summary>
        /// <para>Contains the IDs for the submitted job and the output media asset.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public SubmitTraceAbJobResponseBodyData Data { get; set; }
        public class SubmitTraceAbJobResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The job ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>bfb786c639894f4d80648792021e****</para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// <para>The ID of the media asset created for tracing.</para>
            /// 
            /// <b>Example:</b>
            /// <para>bf53333264f4d80648792021e****</para>
            /// </summary>
            [NameInMap("TraceMediaId")]
            [Validation(Required=false)]
            public string TraceMediaId { get; set; }

        }

        /// <summary>
        /// <para>The response message. A value of <c>ok</c> indicates a successful request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ok</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The unique identifier for the request. If you encounter an issue, provide this ID for technical support.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b><b>36-3C1E-4417-BDB2-1E034F</b></b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The HTTP status code. A value of <c>200</c> indicates success.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("StatusCode")]
        [Validation(Required=false)]
        public long? StatusCode { get; set; }

    }

}
