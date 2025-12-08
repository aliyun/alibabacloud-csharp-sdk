// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Facebody20191230.Models
{
    public class DetectBodyCountResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DetectBodyCountResponseBodyData Data { get; set; }
        public class DetectBodyCountResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>6</para>
            /// </summary>
            [NameInMap("PersonNumber")]
            [Validation(Required=false)]
            public int? PersonNumber { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1C709078-8886-4C91-AEDE-4E04EED0A689</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
