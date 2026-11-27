// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class CancelAiCallDetailsResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the access denial.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CancelAiCallDetailsResponseBodyData Data { get; set; }
        public class CancelAiCallDetailsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The number of unsuccessful cancellations.</para>
            /// 
            /// <b>Example:</b>
            /// <para>75</para>
            /// </summary>
            [NameInMap("FailedCount")]
            [Validation(Required=false)]
            public long? FailedCount { get; set; }

            /// <summary>
            /// <para>The details of failed cancellations. This parameter is a map where the key is the ID or phone number of the failed detail record, and the value is the reason for the failure.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///   &quot;176********&quot;: &quot;The detail record cannot be canceled in its current state&quot;
            /// }</para>
            /// </summary>
            [NameInMap("FailedDetails")]
            [Validation(Required=false)]
            public Dictionary<string, object> FailedDetails { get; set; }

            /// <summary>
            /// <para>The cancellation result. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>ALL_FAILED: All cancellations failed.</description></item>
            /// <item><description>ALL_SUCCEED: All cancellations succeeded.</description></item>
            /// <item><description>PART_FAILED: Some cancellations failed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PART_FAILED</para>
            /// </summary>
            [NameInMap("ResultCode")]
            [Validation(Required=false)]
            public string ResultCode { get; set; }

            /// <summary>
            /// <para>The number of successful cancellations.</para>
            /// 
            /// <b>Example:</b>
            /// <para>81</para>
            /// </summary>
            [NameInMap("SucceedCount")]
            [Validation(Required=false)]
            public long? SucceedCount { get; set; }

            /// <summary>
            /// <para>The total count.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The description of the status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>46C98E28-9239-5D95-AC76-648B8FD4889A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the operation was called successfully. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The call was successful.</description></item>
        /// <item><description><b>false</b>: The call failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
