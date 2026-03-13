// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class QueryPredictiveValueResponseBody : TeaModel {
        [NameInMap("PredictiveValues")]
        [Validation(Required=false)]
        public QueryPredictiveValueResponseBodyPredictiveValues PredictiveValues { get; set; }
        public class QueryPredictiveValueResponseBodyPredictiveValues : TeaModel {
            [NameInMap("PredictiveValue")]
            [Validation(Required=false)]
            public List<QueryPredictiveValueResponseBodyPredictiveValuesPredictiveValue> PredictiveValue { get; set; }
            public class QueryPredictiveValueResponseBodyPredictiveValuesPredictiveValue : TeaModel {
                [NameInMap("Time")]
                [Validation(Required=false)]
                public string Time { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public int? Value { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FA5F448E-DC84-5EBC-B6D5-F659ADxxxx</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
