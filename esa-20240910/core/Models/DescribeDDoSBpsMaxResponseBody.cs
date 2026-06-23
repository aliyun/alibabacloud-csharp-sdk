// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class DescribeDDoSBpsMaxResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>2023-04-07T02:34:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10000000000</para>
        /// </summary>
        [NameInMap("MaxAtkBps")]
        [Validation(Required=false)]
        public long? MaxAtkBps { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100000000</para>
        /// </summary>
        [NameInMap("MaxAtkPps")]
        [Validation(Required=false)]
        public long? MaxAtkPps { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>A3790430-3A06-535F-A424-0998BD9A6C9F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2023-02-14T17:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
