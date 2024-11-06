// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class DescribeRtcUserCntDataResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>16A96B9A-F203-4EC5-8E43-CB92E68F4CD8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("UserCntDataPerInterval")]
        [Validation(Required=false)]
        public DescribeRtcUserCntDataResponseBodyUserCntDataPerInterval UserCntDataPerInterval { get; set; }
        public class DescribeRtcUserCntDataResponseBodyUserCntDataPerInterval : TeaModel {
            [NameInMap("UserCntModule")]
            [Validation(Required=false)]
            public List<DescribeRtcUserCntDataResponseBodyUserCntDataPerIntervalUserCntModule> UserCntModule { get; set; }
            public class DescribeRtcUserCntDataResponseBodyUserCntDataPerIntervalUserCntModule : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("ActiveUserCnt")]
                [Validation(Required=false)]
                public long? ActiveUserCnt { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2018-01-29T00:00:00Z</para>
                /// </summary>
                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

            }

        }

    }

}
