// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class DescribeMeterImsMediaConvertUsageResponseBody : TeaModel {
        /// <summary>
        /// <para>The usage statistics of IMS on VOD transcoding.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeMeterImsMediaConvertUsageResponseBodyData> Data { get; set; }
        public class DescribeMeterImsMediaConvertUsageResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The usage duration, in minutes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public long? Duration { get; set; }

            /// <summary>
            /// <para>The transcoding specifications.</para>
            /// 
            /// <b>Example:</b>
            /// <para>H264.HD</para>
            /// </summary>
            [NameInMap("Specification")]
            [Validation(Required=false)]
            public string Specification { get; set; }

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
        /// <para>FBBB5210-2B78-58FB-A6FE-9DD887BB2C61</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
