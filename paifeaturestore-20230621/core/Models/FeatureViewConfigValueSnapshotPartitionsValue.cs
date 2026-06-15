// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiFeatureStore20230621.Models
{
    public class FeatureViewConfigValueSnapshotPartitionsValue : TeaModel {
        /// <summary>
        /// <para>The partition value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20260101</para>
        /// </summary>
        [NameInMap("Value")]
        [Validation(Required=false)]
        public string Value { get; set; }

        /// <summary>
        /// <para>An array of partition values.</para>
        /// </summary>
        [NameInMap("Values")]
        [Validation(Required=false)]
        public List<string> Values { get; set; }

        /// <summary>
        /// <para>The start value of the partition range.</para>
        /// </summary>
        [NameInMap("StartValue")]
        [Validation(Required=false)]
        public string StartValue { get; set; }

        /// <summary>
        /// <para>The end value of the partition range.</para>
        /// </summary>
        [NameInMap("EndValue")]
        [Validation(Required=false)]
        public string EndValue { get; set; }

    }

}
