// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class QueryFailReasonForRegistrantProfileRealNameVerificationResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<QueryFailReasonForRegistrantProfileRealNameVerificationResponseBodyData> Data { get; set; }
        public class QueryFailReasonForRegistrantProfileRealNameVerificationResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2017-03-17 11:08:02</para>
            /// </summary>
            [NameInMap("Date")]
            [Validation(Required=false)]
            public string Date { get; set; }

            [NameInMap("FailReason")]
            [Validation(Required=false)]
            public string FailReason { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>548C407F-AEA2-4B5D-90DF-EC11EBB1D76F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
