// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class DescribeChannelParticipantsResponseBody : TeaModel {
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

        /// <summary>
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("TotalNum")]
        [Validation(Required=false)]
        public int? TotalNum { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalPage")]
        [Validation(Required=false)]
        public int? TotalPage { get; set; }

        [NameInMap("UserList")]
        [Validation(Required=false)]
        public DescribeChannelParticipantsResponseBodyUserList UserList { get; set; }
        public class DescribeChannelParticipantsResponseBodyUserList : TeaModel {
            [NameInMap("User")]
            [Validation(Required=false)]
            public List<string> User { get; set; }

        }

    }

}
