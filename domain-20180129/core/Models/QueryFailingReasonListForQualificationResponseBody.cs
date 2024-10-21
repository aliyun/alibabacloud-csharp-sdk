// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class QueryFailingReasonListForQualificationResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<QueryFailingReasonListForQualificationResponseBodyData> Data { get; set; }
        public class QueryFailingReasonListForQualificationResponseBodyData : TeaModel {
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
        /// <para>9DFCF6F8-243C-****-8035-4B12FEFD7D48</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
