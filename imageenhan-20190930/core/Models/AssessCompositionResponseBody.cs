// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageenhan20190930.Models
{
    public class AssessCompositionResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public AssessCompositionResponseBodyData Data { get; set; }
        public class AssessCompositionResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>4.2551436</para>
            /// </summary>
            [NameInMap("Score")]
            [Validation(Required=false)]
            public float? Score { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CCAD9435-AEDB-49E4-BCCC-99B65ECC6693</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
