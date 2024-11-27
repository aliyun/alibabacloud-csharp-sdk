// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mssp20161228.Models
{
    public class GetVulPageSummaryResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetVulPageSummaryResponseBodyData Data { get; set; }
        public class GetVulPageSummaryResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1990</para>
            /// </summary>
            [NameInMap("CompletedCount")]
            [Validation(Required=false)]
            public long? CompletedCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>6</para>
            /// </summary>
            [NameInMap("HandingCount")]
            [Validation(Required=false)]
            public long? HandingCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>500</para>
            /// </summary>
            [NameInMap("HighCount")]
            [Validation(Required=false)]
            public long? HighCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("LowCount")]
            [Validation(Required=false)]
            public long? LowCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>500</para>
            /// </summary>
            [NameInMap("MediumCount")]
            [Validation(Required=false)]
            public long? MediumCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2000</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("WaitHandleCount")]
            [Validation(Required=false)]
            public long? WaitHandleCount { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>operation success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A3A575C8-80F9-5F04-AA24-CCAC246884A3</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
