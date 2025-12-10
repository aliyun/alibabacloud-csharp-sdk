// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20210202.Models
{
    public class CopyExperimentResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>draft-rbvg5wzljzjhc9ks92</para>
        /// </summary>
        [NameInMap("ExperimentId")]
        [Validation(Required=false)]
        public string ExperimentId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>6D161C28-9CB1-584E-8DD5-64441E32A5B3</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
