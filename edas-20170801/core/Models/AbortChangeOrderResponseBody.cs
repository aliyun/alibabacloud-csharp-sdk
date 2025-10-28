// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class AbortChangeOrderResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code that is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The change process.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public AbortChangeOrderResponseBodyData Data { get; set; }
        public class AbortChangeOrderResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The ID of the change process.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4f038ddf-b27b-<b><b>-</b></b>-88e44375****</para>
            /// </summary>
            [NameInMap("ChangeOrderId")]
            [Validation(Required=false)]
            public string ChangeOrderId { get; set; }

        }

        /// <summary>
        /// <para>The error code that is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The additional information that is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>57F146F6-3C94-<b><b>-</b></b>-A66EF4B9*****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the trace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0b59000b15947<b><b>55688656d</b></b></para>
        /// </summary>
        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
