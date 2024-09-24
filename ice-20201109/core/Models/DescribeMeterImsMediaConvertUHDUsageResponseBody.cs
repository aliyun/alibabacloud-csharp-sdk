// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class DescribeMeterImsMediaConvertUHDUsageResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeMeterImsMediaConvertUHDUsageResponseBodyData> Data { get; set; }
        public class DescribeMeterImsMediaConvertUHDUsageResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>308028</para>
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public long? Duration { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>SuperResolution.Standard.1080P</para>
            /// </summary>
            [NameInMap("Specification")]
            [Validation(Required=false)]
            public string Specification { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1656950400</para>
            /// </summary>
            [NameInMap("Time")]
            [Validation(Required=false)]
            public long? Time { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>BEA98A0C-7870-15FE-B96F-8880BB600A2C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
