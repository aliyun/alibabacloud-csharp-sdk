// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class GetChatappPhoneNumberMetricResponseBody : TeaModel {
        /// <summary>
        /// <para>The details about the access denial.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NONE</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>The value OK indicates that the request was successful.</para>
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
        public List<GetChatappPhoneNumberMetricResponseBodyData> Data { get; set; }
        public class GetChatappPhoneNumberMetricResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The number of delivered messages.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("DeliveredCount")]
            [Validation(Required=false)]
            public int? DeliveredCount { get; set; }

            /// <summary>
            /// <para>The end of the time range that you queried.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1667196043904</para>
            /// </summary>
            [NameInMap("End")]
            [Validation(Required=false)]
            public long? End { get; set; }

            /// <summary>
            /// <para>The granularity of the metric.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>DAILY</description></item>
            /// <item><description>HALF_HOUR</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>DAILY</para>
            /// </summary>
            [NameInMap("Granularity")]
            [Validation(Required=false)]
            public string Granularity { get; set; }

            /// <summary>
            /// <para>The business phone number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>861380000</para>
            /// </summary>
            [NameInMap("PhoneNumber")]
            [Validation(Required=false)]
            public string PhoneNumber { get; set; }

            /// <summary>
            /// <para>The number of sent messages.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("SentCount")]
            [Validation(Required=false)]
            public int? SentCount { get; set; }

            /// <summary>
            /// <para>The beginning of the time range that you queried.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1669619491000</para>
            /// </summary>
            [NameInMap("Start")]
            [Validation(Required=false)]
            public long? Start { get; set; }

        }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1612C226-E271-4CFE-9F18-4066D******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
