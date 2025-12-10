// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20210202.Models
{
    public class GetAlgorithmDefResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>B4F16666-FD54-5D9D-A362-53A4C66692DF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("Spec")]
        [Validation(Required=false)]
        public Dictionary<string, object> Spec { get; set; }

    }

}
