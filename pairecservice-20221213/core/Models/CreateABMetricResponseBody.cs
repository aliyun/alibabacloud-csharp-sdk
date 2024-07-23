// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class CreateABMetricResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ABMetricId")]
        [Validation(Required=false)]
        public string ABMetricId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>F7AC05FF-EDE7-5C2B-B9AE-33D6DF4178BA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
