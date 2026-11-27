// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class DescribeChannelUsersResponseBody : TeaModel {
        /// <summary>
        /// <para>The channel mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>1</b>: Communication (communication mode).</para>
        /// </description></item>
        /// <item><description><para><b>2</b>: Interactive_live (live streaming mode).</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ChannelProfile")]
        [Validation(Required=false)]
        public int? ChannelProfile { get; set; }

        /// <summary>
        /// <para>The total number of users in the channel in communication mode. If the channel is not in communication mode, this parameter is 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("CommTotalNum")]
        [Validation(Required=false)]
        public int? CommTotalNum { get; set; }

        /// <summary>
        /// <para>The list of interactive user IDs in the channel in live streaming mode. This parameter is empty if the channel is not in live streaming mode.</para>
        /// </summary>
        [NameInMap("InteractiveUserList")]
        [Validation(Required=false)]
        public List<string> InteractiveUserList { get; set; }

        /// <summary>
        /// <para>The total number of interactive users in the channel in live streaming mode. If the channel is not in live streaming mode, this parameter is 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("InteractiveUserNum")]
        [Validation(Required=false)]
        public int? InteractiveUserNum { get; set; }

        /// <summary>
        /// <para>Indicates whether the channel exists. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: The channel exists.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: The channel does not exist.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsChannelExist")]
        [Validation(Required=false)]
        public bool? IsChannelExist { get; set; }

        /// <summary>
        /// <para>The list of viewer IDs in the channel in live streaming mode. A maximum of 1,000 viewers are returned. This parameter is empty if the channel is not in live streaming mode.</para>
        /// </summary>
        [NameInMap("LiveUserList")]
        [Validation(Required=false)]
        public List<string> LiveUserList { get; set; }

        /// <summary>
        /// <para>The total number of viewers in the channel in live streaming mode. If the channel is not in live streaming mode, this parameter is 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("LiveUserNum")]
        [Validation(Required=false)]
        public int? LiveUserNum { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6159ba01-6687-4fb2-a831-f0cd8d188648</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The timestamp of the current time in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1557909133</para>
        /// </summary>
        [NameInMap("Timestamp")]
        [Validation(Required=false)]
        public int? Timestamp { get; set; }

        /// <summary>
        /// <para>The list of user IDs in the channel in communication mode. This parameter is empty if the channel is not in communication mode.</para>
        /// </summary>
        [NameInMap("UserList")]
        [Validation(Required=false)]
        public List<string> UserList { get; set; }

    }

}
