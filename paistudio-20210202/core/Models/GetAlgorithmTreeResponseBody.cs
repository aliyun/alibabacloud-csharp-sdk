// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20210202.Models
{
    public class GetAlgorithmTreeResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>46B59732-033F-5C96-9B15-1E05E7705548</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20210317101023</para>
        /// </summary>
        [NameInMap("Timestamp")]
        [Validation(Required=false)]
        public string Timestamp { get; set; }

        [NameInMap("Tree")]
        [Validation(Required=false)]
        public List<Dictionary<string, object>> Tree { get; set; }

    }

}
