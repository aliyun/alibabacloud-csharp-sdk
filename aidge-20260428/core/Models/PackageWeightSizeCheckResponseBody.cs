// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aidge20260428.Models
{
    public class PackageWeightSizeCheckResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code. A value of 200 indicates a successful call. For other response codes, refer to the error code information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The submit status result data, which contains the asynchronous task ID.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public PackageWeightSizeCheckResponseBodyData Data { get; set; }
        public class PackageWeightSizeCheckResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The asynchronous task ID, which is used to query the review result by calling QueryAsyncTaskResult.</para>
            /// 
            /// <b>Example:</b>
            /// <para>a8323ada-a196-9061-976f-90e38b27323a</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

        /// <summary>
        /// <para>The error message. &quot;Success&quot; is returned for a successful call. A specific error message is returned for a failed call.</para>
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
        /// <para>F93D82E4-D0B6-1043-AC58-282597BC3C10</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call is successful. A value of true indicates success. A value of false indicates failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
