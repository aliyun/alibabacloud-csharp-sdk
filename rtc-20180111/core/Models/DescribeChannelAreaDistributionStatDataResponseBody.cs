// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class DescribeChannelAreaDistributionStatDataResponseBody : TeaModel {
        [NameInMap("AreaStatList")]
        [Validation(Required=false)]
        public List<DescribeChannelAreaDistributionStatDataResponseBodyAreaStatList> AreaStatList { get; set; }
        public class DescribeChannelAreaDistributionStatDataResponseBodyAreaStatList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>浙江省</para>
            /// </summary>
            [NameInMap("AreaName")]
            [Validation(Required=false)]
            public string AreaName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CallUserCount")]
            [Validation(Required=false)]
            public int? CallUserCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0.9999</para>
            /// </summary>
            [NameInMap("HighQualityTransmissionRate")]
            [Validation(Required=false)]
            public string HighQualityTransmissionRate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PubUserCount")]
            [Validation(Required=false)]
            public int? PubUserCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SubUserCount")]
            [Validation(Required=false)]
            public int? SubUserCount { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>231470C1-ACFB-4C9F-844F-4CFE1E3804C5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
