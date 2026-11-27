// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class DescribeChannelAllUsersResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether the channel exists. Valid values:  </para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The channel exists.  </description></item>
        /// <item><description><b>false</b>: The channel does not exist.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("ChannelExist")]
        [Validation(Required=false)]
        public bool? ChannelExist { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>16A96B9A-F203-4EC5-8E43-CB92E68F4CF8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>List of online users in the channel.</para>
        /// </summary>
        [NameInMap("Users")]
        [Validation(Required=false)]
        public List<DescribeChannelAllUsersResponseBodyUsers> Users { get; set; }
        public class DescribeChannelAllUsersResponseBodyUsers : TeaModel {
            /// <summary>
            /// <para>User ID.</para>
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
