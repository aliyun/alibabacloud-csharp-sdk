// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class DescribeChannelUserResponseBody : TeaModel {
        [NameInMap("ChannelExist")]
        [Validation(Required=false)]
        public bool? ChannelExist { get; set; }

        [NameInMap("InChannel")]
        [Validation(Required=false)]
        public bool? InChannel { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>16A96B9A-F203-4EC5-8E43-CB92E68F4CF8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Sessions")]
        [Validation(Required=false)]
        public List<DescribeChannelUserResponseBodySessions> Sessions { get; set; }
        public class DescribeChannelUserResponseBodySessions : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1557909133</para>
            /// </summary>
            [NameInMap("Joined")]
            [Validation(Required=false)]
            public long? Joined { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xa744sxx8rtobgj****</para>
            /// </summary>
            [NameInMap("SessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1811****</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
