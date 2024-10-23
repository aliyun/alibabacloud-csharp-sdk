// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class GetAccessKeyLastUsedResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the time when the AccessKey pair was used for the last time.</para>
        /// </summary>
        [NameInMap("AccessKeyLastUsed")]
        [Validation(Required=false)]
        public GetAccessKeyLastUsedResponseBodyAccessKeyLastUsed AccessKeyLastUsed { get; set; }
        public class GetAccessKeyLastUsedResponseBodyAccessKeyLastUsed : TeaModel {
            /// <summary>
            /// <para>The time when the AccessKey pair was used for the last time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-10-16T01:37:37Z</para>
            /// </summary>
            [NameInMap("LastUsedDate")]
            [Validation(Required=false)]
            public string LastUsedDate { get; set; }

            /// <summary>
            /// <para>The Alibaba Cloud service that was last accessed by using the AccessKey pair.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Ram</para>
            /// </summary>
            [NameInMap("ServiceName")]
            [Validation(Required=false)]
            public string ServiceName { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B29C79F6-354B-4297-A994-1338CC22A2EC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
