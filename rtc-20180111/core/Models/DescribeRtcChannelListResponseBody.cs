// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class DescribeRtcChannelListResponseBody : TeaModel {
        [NameInMap("ChannelList")]
        [Validation(Required=false)]
        public DescribeRtcChannelListResponseBodyChannelList ChannelList { get; set; }
        public class DescribeRtcChannelListResponseBodyChannelList : TeaModel {
            [NameInMap("ChannelList")]
            [Validation(Required=false)]
            public List<DescribeRtcChannelListResponseBodyChannelListChannelList> ChannelList { get; set; }
            public class DescribeRtcChannelListResponseBodyChannelListChannelList : TeaModel {
                [NameInMap("CallArea")]
                [Validation(Required=false)]
                public DescribeRtcChannelListResponseBodyChannelListChannelListCallArea CallArea { get; set; }
                public class DescribeRtcChannelListResponseBodyChannelListChannelListCallArea : TeaModel {
                    [NameInMap("CallArea")]
                    [Validation(Required=false)]
                    public List<string> CallArea { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>testChannel</para>
                /// </summary>
                [NameInMap("ChannelId")]
                [Validation(Required=false)]
                public string ChannelId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2018-01-29T02:00:00Z</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2018-01-29T01:00:00Z</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("TotalUserCnt")]
                [Validation(Required=false)]
                public long? TotalUserCnt { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public long? PageNo { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>16A96B9A-F203-4EC5-8E43-CB92E68F4CD8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("TotalCnt")]
        [Validation(Required=false)]
        public long? TotalCnt { get; set; }

    }

}
