// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeChannelParticipantsResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6159ba01-6687-4fb2-a831-f0cd8d188648</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The time elapsed until the result was returned. Unit: seconds. The value is a UNIX timestamp.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1557909133</para>
        /// </summary>
        [NameInMap("Times")]
        [Validation(Required=false)]
        public long? Times { get; set; }

        /// <summary>
        /// <para>The number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("TotalNum")]
        [Validation(Required=false)]
        public int? TotalNum { get; set; }

        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalPage")]
        [Validation(Required=false)]
        public int? TotalPage { get; set; }

        /// <summary>
        /// <para>The list of user IDs.</para>
        /// </summary>
        [NameInMap("UserList")]
        [Validation(Required=false)]
        public List<string> UserList { get; set; }

    }

}
