// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180208.Models
{
    public class AcceptDemandResponseBody : TeaModel {
        [NameInMap("BindUrl")]
        [Validation(Required=false)]
        public string BindUrl { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>497F7522-82B0-4BD4-84FE-AE8749E4C2F9</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
