// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class IntlFlightOrderCancelResponseBody : TeaModel {
        [NameInMap("module")]
        [Validation(Required=false)]
        public IntlFlightOrderCancelResponseBodyModule Module { get; set; }
        public class IntlFlightOrderCancelResponseBodyModule : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2023-08-10 17:45:32</para>
            /// </summary>
            [NameInMap("cancel_time")]
            [Validation(Required=false)]
            public string CancelTime { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>A3F8DCAB-8301-5770-BD9F-71B0BF9E1A6E</para>
        /// </summary>
        [NameInMap("request_id")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("result_code")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("result_msg")]
        [Validation(Required=false)]
        public string ResultMsg { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>21041ce316577904808056433edbb2</para>
        /// </summary>
        [NameInMap("trace_id")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
