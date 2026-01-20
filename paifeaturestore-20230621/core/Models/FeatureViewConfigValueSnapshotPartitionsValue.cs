// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiFeatureStore20230621.Models
{
    public class FeatureViewConfigValueSnapshotPartitionsValue : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>20260101</para>
        /// </summary>
        [NameInMap("Value")]
        [Validation(Required=false)]
        public string Value { get; set; }

        [NameInMap("Values")]
        [Validation(Required=false)]
        public List<string> Values { get; set; }

        [NameInMap("StartValue")]
        [Validation(Required=false)]
        public string StartValue { get; set; }

        [NameInMap("EndValue")]
        [Validation(Required=false)]
        public string EndValue { get; set; }

    }

}
