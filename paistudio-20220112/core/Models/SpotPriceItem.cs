// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class SpotPriceItem : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>ml.gu8xf.8xlarge-gu108</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0.1</para>
        /// </summary>
        [NameInMap("SpotDiscount")]
        [Validation(Required=false)]
        public float? SpotDiscount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2024-01-17T06:00:00Z</para>
        /// </summary>
        [NameInMap("Timestamp")]
        [Validation(Required=false)]
        public string Timestamp { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-wulanchabu-a</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
