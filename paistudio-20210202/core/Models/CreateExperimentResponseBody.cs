// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20210202.Models
{
    public class CreateExperimentResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>draft-rbvg5wzljzjhc9ks92</para>
        /// </summary>
        [NameInMap("ExperimentId")]
        [Validation(Required=false)]
        public string ExperimentId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>42F23B58-3684-5443-848A-8DA81FF99712</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
