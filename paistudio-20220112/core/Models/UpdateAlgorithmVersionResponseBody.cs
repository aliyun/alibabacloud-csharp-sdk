// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class UpdateAlgorithmVersionResponseBody : TeaModel {
        /// <summary>
        /// <para>The algorithm ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>algo-sidjc8134hv</para>
        /// </summary>
        [NameInMap("AlgorithmId")]
        [Validation(Required=false)]
        public string AlgorithmId { get; set; }

        /// <summary>
        /// <para>The algorithm version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v0.1.0</para>
        /// </summary>
        [NameInMap("AlgorithmVersion")]
        [Validation(Required=false)]
        public string AlgorithmVersion { get; set; }

    }

}
