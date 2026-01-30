// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class QueryPredictiveValueResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of predicted instances in the scaling group.</para>
        /// </summary>
        [NameInMap("PredictiveValues")]
        [Validation(Required=false)]
        public QueryPredictiveValueResponseBodyPredictiveValues PredictiveValues { get; set; }
        public class QueryPredictiveValueResponseBodyPredictiveValues : TeaModel {
            [NameInMap("PredictiveValue")]
            [Validation(Required=false)]
            public List<QueryPredictiveValueResponseBodyPredictiveValuesPredictiveValue> PredictiveValue { get; set; }
            public class QueryPredictiveValueResponseBodyPredictiveValuesPredictiveValue : TeaModel {
                /// <summary>
                /// <para>The point in time, in the ISO 8601 standard, in the yyyy-MM-ddTHH:mmZ format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-12-17T10:00Z</para>
                /// </summary>
                [NameInMap("Time")]
                [Validation(Required=false)]
                public string Time { get; set; }

                /// <summary>
                /// <para>The number of instances.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
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
