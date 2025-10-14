// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AirticketOpen20230117.Models
{
    public class ChangeConfirmResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>51593418-8C73-5E47-8BA8-3F1D4A00CC0B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public ChangeConfirmResponseBodyData Data { get; set; }
        public class ChangeConfirmResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("pay_amount")]
            [Validation(Required=false)]
            public double? PayAmount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1756797933000</para>
            /// </summary>
            [NameInMap("pay_time")]
            [Validation(Required=false)]
            public long? PayTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>hkduendkd-2023-dj0</para>
            /// </summary>
            [NameInMap("transaction_no")]
            [Validation(Required=false)]
            public string TransactionNo { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("error_code")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("error_data")]
        [Validation(Required=false)]
        public object ErrorData { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("error_msg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
