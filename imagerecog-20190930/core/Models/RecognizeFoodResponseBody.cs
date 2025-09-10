// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imagerecog20190930.Models
{
    public class RecognizeFoodResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public RecognizeFoodResponseBodyData Data { get; set; }
        public class RecognizeFoodResponseBodyData : TeaModel {
            [NameInMap("TopFives")]
            [Validation(Required=false)]
            public List<RecognizeFoodResponseBodyDataTopFives> TopFives { get; set; }
            public class RecognizeFoodResponseBodyDataTopFives : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>208</para>
                /// </summary>
                [NameInMap("Calorie")]
                [Validation(Required=false)]
                public string Calorie { get; set; }

                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0.2083740234375</para>
                /// </summary>
                [NameInMap("Score")]
                [Validation(Required=false)]
                public float? Score { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>4C2369C5-54E0-4B9F-8ACB-80C4F50AD2DB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
