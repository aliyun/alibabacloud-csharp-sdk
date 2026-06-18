// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class CancelAiCallDetailsResponseBody : TeaModel {
        /// <summary>
        /// <para>The detailed reason why the access was denied.</para>
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
            /// <para>The number of calls that could not be canceled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>75</para>
            /// </summary>
            [NameInMap("FailedCount")]
            [Validation(Required=false)]
            public long? FailedCount { get; set; }

            /// <summary>
            /// <para>Details about the failed cancellations. This is a map where the key is the failed detail ID or phone number, and the value is the reason for the failure.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///   &quot;176********&quot;: &quot;明细记录当前状态不可取消&quot;
            /// }</para>
            /// </summary>
            [NameInMap("FailedDetails")]
            [Validation(Required=false)]
            public Dictionary<string, object> FailedDetails { get; set; }

            /// <summary>
            /// <para>The result code of the cancellation. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>ALL_FAILED: All cancellations failed.</para>
            /// </description></item>
            /// <item><description><para>ALL_SUCCEED: All cancellations succeeded.</para>
            /// </description></item>
            /// <item><description><para>PART_FAILED: Some cancellations failed.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PART_FAILED</para>
            /// </summary>
            [NameInMap("ResultCode")]
            [Validation(Required=false)]
            public string ResultCode { get; set; }

            /// <summary>
            /// <para>The number of calls that were successfully canceled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>81</para>
            /// </summary>
            [NameInMap("SucceedCount")]
            [Validation(Required=false)]
            public long? SucceedCount { get; set; }

            /// <summary>
            /// <para>The total number of items.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The message returned for the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>成功</para>
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
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: The request succeeded.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: The request failed.</para>
        /// </description></item>
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
