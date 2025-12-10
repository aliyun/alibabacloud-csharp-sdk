// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20210202.Models
{
    public class GetAlgorithmDefsRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1709950208</para>
        /// </summary>
        [NameInMap("LatestTimestamp")]
        [Validation(Required=false)]
        public string LatestTimestamp { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("RangeEnd")]
        [Validation(Required=false)]
        public int? RangeEnd { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RangeStart")]
        [Validation(Required=false)]
        public int? RangeStart { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1709950208</para>
        /// </summary>
        [NameInMap("Timestamp")]
        [Validation(Required=false)]
        public string Timestamp { get; set; }

    }

}
