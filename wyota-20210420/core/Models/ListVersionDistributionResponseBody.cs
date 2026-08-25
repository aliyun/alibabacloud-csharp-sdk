// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Wyota20210420.Models
{
    public class ListVersionDistributionResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code. A value of 200 is returned if the call is successful. An error code is returned if the call fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PARAMETER_MISSING</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The list of version distribution information.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListVersionDistributionResponseBodyData> Data { get; set; }
        public class ListVersionDistributionResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The number of terminals corresponding to this version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("DeviceCount")]
            [Validation(Required=false)]
            public long? DeviceCount { get; set; }

            /// <summary>
            /// <para>The version percentage. Valid values: 0 to 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.6</para>
            /// </summary>
            [NameInMap("Percentage")]
            [Validation(Required=false)]
            public double? Percentage { get; set; }

            /// <summary>
            /// <para>The version number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2.3.0</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>400</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The error message. This parameter is empty if the call is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>parameter missing</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C5DCE54A-B266-522E-A6ED-468AF45F5AAA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful.</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
