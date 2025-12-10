// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20210202.Models
{
    public class GetAlgoTreeResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>[{}]</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public Dictionary<string, object> Data { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>8CAA642F-EFEB-5F87-8F2F-ACD58B15FA03</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
