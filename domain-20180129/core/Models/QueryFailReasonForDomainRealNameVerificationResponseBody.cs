// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class QueryFailReasonForDomainRealNameVerificationResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<QueryFailReasonForDomainRealNameVerificationResponseBodyData> Data { get; set; }
        public class QueryFailReasonForDomainRealNameVerificationResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2017-03-17 11:08:02</para>
            /// </summary>
            [NameInMap("Date")]
            [Validation(Required=false)]
            public string Date { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>SUCCEED</para>
            /// </summary>
            [NameInMap("DomainNameVerificationStatus")]
            [Validation(Required=false)]
            public string DomainNameVerificationStatus { get; set; }

            [NameInMap("FailReason")]
            [Validation(Required=false)]
            public string FailReason { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1F1BA893-AD33-4248-8CB8-1657E3733052</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
