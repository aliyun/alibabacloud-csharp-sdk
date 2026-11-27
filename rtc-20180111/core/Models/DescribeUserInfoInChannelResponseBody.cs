// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class DescribeUserInfoInChannelResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether the channel exists. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The channel exists.</description></item>
        /// <item><description><b>false</b>: The channel does not exist.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsChannelExist")]
        [Validation(Required=false)]
        public bool? IsChannelExist { get; set; }

        /// <summary>
        /// <para>Indicates whether the user is currently in the channel. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The user is in the channel.</description></item>
        /// <item><description><b>false</b>: The user is not in the channel.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsInChannel")]
        [Validation(Required=false)]
        public bool? IsInChannel { get; set; }

        /// <summary>
        /// <para>The information of the user in the channel.</para>
        /// </summary>
        [NameInMap("Property")]
        [Validation(Required=false)]
        public List<DescribeUserInfoInChannelResponseBodyProperty> Property { get; set; }
        public class DescribeUserInfoInChannelResponseBodyProperty : TeaModel {
            /// <summary>
            /// <para>The time when the user joined the meeting (UTC time).</para>
            /// 
            /// <b>Example:</b>
            /// <para>1557909133</para>
            /// </summary>
            [NameInMap("Join")]
            [Validation(Required=false)]
            public int? Join { get; set; }

            /// <summary>
            /// <para>The role type in the meeting. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>0</b>: The user role in communication mode.</para>
            /// </description></item>
            /// <item><description><para><b>1</b>: The interactive role.</para>
            /// </description></item>
            /// <item><description><para><b>2</b>: The live (view only) role.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Role")]
            [Validation(Required=false)]
            public int? Role { get; set; }

            /// <summary>
            /// <para>The session ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xa744sxx8rtobgj****</para>
            /// </summary>
            [NameInMap("Session")]
            [Validation(Required=false)]
            public string Session { get; set; }

        }

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
        /// <para>The timestamp of the current moment (UTC time).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1557909133</para>
        /// </summary>
        [NameInMap("Timestamp")]
        [Validation(Required=false)]
        public int? Timestamp { get; set; }

    }

}
