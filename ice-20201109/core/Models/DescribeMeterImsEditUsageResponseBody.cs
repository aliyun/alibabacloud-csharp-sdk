// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class DescribeMeterImsEditUsageResponseBody : TeaModel {
        /// <summary>
        /// <para>The usage statistics of IMS on VOD editing.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeMeterImsEditUsageResponseBodyData> Data { get; set; }
        public class DescribeMeterImsEditUsageResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The usage duration, in minutes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.23</para>
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public long? Duration { get; set; }

            /// <summary>
            /// <para>The video profile.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1080P</para>
            /// </summary>
            [NameInMap("Profile")]
            [Validation(Required=false)]
            public string Profile { get; set; }

            /// <summary>
            /// <para>The beginning time of usage. The value is a 10-digit timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1656950400</para>
            /// </summary>
            [NameInMap("Time")]
            [Validation(Required=false)]
            public long? Time { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7F3AE2C6-5CC6-5712-BAC5-5A735A157687</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
