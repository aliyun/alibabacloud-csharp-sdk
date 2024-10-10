// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class MetricInfo : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1234.5</para>
        /// </summary>
        [NameInMap("Average")]
        [Validation(Required=false)]
        public float? Average { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1234.5</para>
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public float? Count { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1234.5</para>
        /// </summary>
        [NameInMap("Maximum")]
        [Validation(Required=false)]
        public float? Maximum { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1234.5</para>
        /// </summary>
        [NameInMap("Minimum")]
        [Validation(Required=false)]
        public float? Minimum { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1234.5</para>
        /// </summary>
        [NameInMap("Sum")]
        [Validation(Required=false)]
        public float? Sum { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1686568800000</para>
        /// </summary>
        [NameInMap("timestamp")]
        [Validation(Required=false)]
        public long? Timestamp { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1234.5</para>
        /// </summary>
        [NameInMap("value")]
        [Validation(Required=false)]
        public float? Value { get; set; }

    }

}
