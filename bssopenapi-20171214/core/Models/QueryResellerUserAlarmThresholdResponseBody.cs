// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class QueryResellerUserAlarmThresholdResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code of the request. If the call fails, an error code is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<QueryResellerUserAlarmThresholdResponseBodyData> Data { get; set; }
        public class QueryResellerUserAlarmThresholdResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The denominator of the alert percentage. This parameter is valid only when ThresholdType is set to 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Denominator")]
            [Validation(Required=false)]
            public int? Denominator { get; set; }

            /// <summary>
            /// <para>The numerator of the alert percentage. This parameter is valid only when ThresholdType is set to 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Numerator")]
            [Validation(Required=false)]
            public int? Numerator { get; set; }

            /// <summary>
            /// <para>The alert threshold in amount. This parameter is valid only when ThresholdType is set to 0.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("ThresholdAmount")]
            [Validation(Required=false)]
            public string ThresholdAmount { get; set; }

            /// <summary>
            /// <para>The type of the alert threshold. Valid values: 0 (amount) and 1 (percentage).</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ThresholdType")]
            [Validation(Required=false)]
            public int? ThresholdType { get; set; }

        }

        /// <summary>
        /// <para>The message returned. If the call fails, an error message is returned.</para>
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
        /// <para>EAE08A27-386C-579E-966D-8853EC3C5D0E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
