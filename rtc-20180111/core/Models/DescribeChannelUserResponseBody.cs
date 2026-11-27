// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class DescribeChannelUserResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether the channel exists. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The channel exists.</description></item>
        /// <item><description><b>false</b>: The channel does not exist.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("ChannelExist")]
        [Validation(Required=false)]
        public bool? ChannelExist { get; set; }

        /// <summary>
        /// <para>Indicates whether the user is currently in the channel. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The user is in the channel.</description></item>
        /// <item><description><b>false</b>: The user is not in the channel.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("InChannel")]
        [Validation(Required=false)]
        public bool? InChannel { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>16A96B9A-F203-4EC5-8E43-CB92E68F4CF8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of session information.</para>
        /// </summary>
        [NameInMap("Sessions")]
        [Validation(Required=false)]
        public List<DescribeChannelUserResponseBodySessions> Sessions { get; set; }
        public class DescribeChannelUserResponseBodySessions : TeaModel {
            /// <summary>
            /// <para>The UNIX timestamp in seconds when the user joined the channel. The time is in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1557909133</para>
            /// </summary>
            [NameInMap("Joined")]
            [Validation(Required=false)]
            public long? Joined { get; set; }

            /// <summary>
            /// <para>The session ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xa744sxx8rtobgj****</para>
            /// </summary>
            [NameInMap("SessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

            /// <summary>
            /// <para>The user ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1811****</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
