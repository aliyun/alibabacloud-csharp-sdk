// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeCustomEventCountResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code.</para>
        /// <remarks>
        /// <para> The status code 200 indicates that the call was successful.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The details of the custom event.</para>
        /// </summary>
        [NameInMap("CustomEventCounts")]
        [Validation(Required=false)]
        public DescribeCustomEventCountResponseBodyCustomEventCounts CustomEventCounts { get; set; }
        public class DescribeCustomEventCountResponseBodyCustomEventCounts : TeaModel {
            [NameInMap("CustomEventCount")]
            [Validation(Required=false)]
            public List<DescribeCustomEventCountResponseBodyCustomEventCountsCustomEventCount> CustomEventCount { get; set; }
            public class DescribeCustomEventCountResponseBodyCustomEventCountsCustomEventCount : TeaModel {
                /// <summary>
                /// <para>The name of the custom event.</para>
                /// 
                /// <b>Example:</b>
                /// <para>BABEL_BUY</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The number of times that the custom event occurred in the specified time period.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("Num")]
                [Validation(Required=false)]
                public int? Num { get; set; }

                /// <summary>
                /// <para>The time when the custom event occurred.</para>
                /// <para>This value is a UNIX timestamp representing the number of milliseconds that have elapsed since the epoch time January 1, 1970, 00:00:00 UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1552267615000</para>
                /// </summary>
                [NameInMap("Time")]
                [Validation(Required=false)]
                public long? Time { get; set; }

            }

        }

        /// <summary>
        /// <para>The returned message. If the call was successful, the value success is returned. If the call failed, an error message is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60912C8D-B340-4253-ADE7-61ACDFD25CFC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful. The value true indicates a success. The value false indicates a failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
