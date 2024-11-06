// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class DescribeChannelUsersResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ChannelProfile")]
        [Validation(Required=false)]
        public int? ChannelProfile { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("CommTotalNum")]
        [Validation(Required=false)]
        public int? CommTotalNum { get; set; }

        [NameInMap("InteractiveUserList")]
        [Validation(Required=false)]
        public List<string> InteractiveUserList { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("InteractiveUserNum")]
        [Validation(Required=false)]
        public int? InteractiveUserNum { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsChannelExist")]
        [Validation(Required=false)]
        public bool? IsChannelExist { get; set; }

        [NameInMap("LiveUserList")]
        [Validation(Required=false)]
        public List<string> LiveUserList { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("LiveUserNum")]
        [Validation(Required=false)]
        public int? LiveUserNum { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>6159ba01-6687-4fb2-a831-f0cd8d188648</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1557909133</para>
        /// </summary>
        [NameInMap("Timestamp")]
        [Validation(Required=false)]
        public int? Timestamp { get; set; }

        [NameInMap("UserList")]
        [Validation(Required=false)]
        public List<string> UserList { get; set; }

    }

}
