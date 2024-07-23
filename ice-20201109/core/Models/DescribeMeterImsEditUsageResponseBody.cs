// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class DescribeMeterImsEditUsageResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeMeterImsEditUsageResponseBodyData> Data { get; set; }
        public class DescribeMeterImsEditUsageResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1.23</para>
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public long? Duration { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1080P</para>
            /// </summary>
            [NameInMap("Profile")]
            [Validation(Required=false)]
            public string Profile { get; set; }

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
        /// <para>7F3AE2C6-5CC6-5712-BAC5-5A735A157687</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
