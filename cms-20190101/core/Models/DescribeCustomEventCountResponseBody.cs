// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeCustomEventCountResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// <remarks>
        /// <para> The status code 200 indicates that the request was successful.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("CustomEventCounts")]
        [Validation(Required=false)]
        public DescribeCustomEventCountResponseBodyCustomEventCounts CustomEventCounts { get; set; }
        public class DescribeCustomEventCountResponseBodyCustomEventCounts : TeaModel {
            [NameInMap("CustomEventCount")]
            [Validation(Required=false)]
            public List<DescribeCustomEventCountResponseBodyCustomEventCountsCustomEventCount> CustomEventCount { get; set; }
            public class DescribeCustomEventCountResponseBodyCustomEventCountsCustomEventCount : TeaModel {
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Num")]
                [Validation(Required=false)]
                public int? Num { get; set; }

                [NameInMap("Time")]
                [Validation(Required=false)]
                public long? Time { get; set; }

            }

        }

        /// <summary>
        /// <para>The returned message. If the request was successful, a success message is returned. If the request failed, an error message is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60912C8D-B340-4253-ADE7-61ACDFD25CFC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values: true and false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
