// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class GetStorageSummaryComparedResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetStorageSummaryComparedResponseBodyData Data { get; set; }
        public class GetStorageSummaryComparedResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>20250601</para>
            /// </summary>
            [NameInMap("beginDate")]
            [Validation(Required=false)]
            public string BeginDate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>20250604</para>
            /// </summary>
            [NameInMap("endDate")]
            [Validation(Required=false)]
            public string EndDate { get; set; }

            [NameInMap("rate")]
            [Validation(Required=false)]
            public Dictionary<string, double?> Rate { get; set; }

            [NameInMap("unit")]
            [Validation(Required=false)]
            public Dictionary<string, string> Unit { get; set; }

            [NameInMap("value")]
            [Validation(Required=false)]
            public Dictionary<string, double?> Value { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>plan \&quot;***\&quot; does not exist</para>
        /// </summary>
        [NameInMap("errorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpCode")]
        [Validation(Required=false)]
        public int? HttpCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0bc3b4b016674434996033675e71ee</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
