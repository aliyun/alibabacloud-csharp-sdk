// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PAIElasticDatasetAccelerator20220801.Models
{
    public class Metric : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1655897743</para>
        /// </summary>
        [NameInMap("Timestamp")]
        [Validation(Required=false)]
        public string Timestamp { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>98.35</para>
        /// </summary>
        [NameInMap("Value")]
        [Validation(Required=false)]
        public double? Value { get; set; }

    }

}
