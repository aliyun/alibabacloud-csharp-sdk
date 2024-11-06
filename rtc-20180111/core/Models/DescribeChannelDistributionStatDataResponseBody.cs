// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class DescribeChannelDistributionStatDataResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>231470C1-ACFB-4C9F-844F-4CFE1E3804C5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("StatList")]
        [Validation(Required=false)]
        public List<DescribeChannelDistributionStatDataResponseBodyStatList> StatList { get; set; }
        public class DescribeChannelDistributionStatDataResponseBodyStatList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CallUserCount")]
            [Validation(Required=false)]
            public int? CallUserCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1.0000</para>
            /// </summary>
            [NameInMap("CallUserRatio")]
            [Validation(Required=false)]
            public string CallUserRatio { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>OS</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

    }

}
