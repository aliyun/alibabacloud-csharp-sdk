// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class DescribeUserOnlineClientsResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7108A98F-C47D-45F7-A4D8-C2E3022735DA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Users")]
        [Validation(Required=false)]
        public DescribeUserOnlineClientsResponseBodyUsers Users { get; set; }
        public class DescribeUserOnlineClientsResponseBodyUsers : TeaModel {
            [NameInMap("User")]
            [Validation(Required=false)]
            public List<DescribeUserOnlineClientsResponseBodyUsersUser> User { get; set; }
            public class DescribeUserOnlineClientsResponseBodyUsersUser : TeaModel {
                [NameInMap("ClientIp")]
                [Validation(Required=false)]
                public string ClientIp { get; set; }

                [NameInMap("OnlineTime")]
                [Validation(Required=false)]
                public string OnlineTime { get; set; }

            }

        }

    }

}
