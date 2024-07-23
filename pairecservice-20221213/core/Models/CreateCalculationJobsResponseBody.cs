// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class CreateCalculationJobsResponseBody : TeaModel {
        [NameInMap("CalculationJobIds")]
        [Validation(Required=false)]
        public List<string> CalculationJobIds { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>8C27790E-CCA5-56BB-BA17-646295DEC0A2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
