// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ram20150501.Models
{
    public class GetAccessKeyLastUsedResponseBody : TeaModel {
        /// <summary>
        /// <para>Information about the last time the AccessKey pair was used.</para>
        /// </summary>
        [NameInMap("AccessKeyLastUsed")]
        [Validation(Required=false)]
        public GetAccessKeyLastUsedResponseBodyAccessKeyLastUsed AccessKeyLastUsed { get; set; }
        public class GetAccessKeyLastUsedResponseBodyAccessKeyLastUsed : TeaModel {
            /// <summary>
            /// <para>The last time the AccessKey pair was used.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-10-21T06:37:40Z</para>
            /// </summary>
            [NameInMap("LastUsedDate")]
            [Validation(Required=false)]
            public string LastUsedDate { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5CCE804C-6450-49A7-B1DB-2460F7A97416</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
