// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class DescribeChannelResponseBody : TeaModel {
        /// <summary>
        /// <para>channel</para>
        /// </summary>
        [NameInMap("Channel")]
        [Validation(Required=false)]
        public DescribeChannelResponseBodyChannel Channel { get; set; }
        public class DescribeChannelResponseBodyChannel : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>testid</para>
            /// </summary>
            [NameInMap("ChannelId")]
            [Validation(Required=false)]
            public string ChannelId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1557909133</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

        }

        [NameInMap("ChannelExist")]
        [Validation(Required=false)]
        public bool? ChannelExist { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>16A96B9A-F203-4EC5-8E43-CB92E68F4CF8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
