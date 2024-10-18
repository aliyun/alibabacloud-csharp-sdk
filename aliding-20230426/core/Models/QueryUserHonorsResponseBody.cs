// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class QueryUserHonorsResponseBody : TeaModel {
        [NameInMap("honors")]
        [Validation(Required=false)]
        public List<QueryUserHonorsResponseBodyHonors> Honors { get; set; }
        public class QueryUserHonorsResponseBodyHonors : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("expirationTime")]
            [Validation(Required=false)]
            public long? ExpirationTime { get; set; }

            [NameInMap("grantHistory")]
            [Validation(Required=false)]
            public List<QueryUserHonorsResponseBodyHonorsGrantHistory> GrantHistory { get; set; }
            public class QueryUserHonorsResponseBodyHonorsGrantHistory : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>12312312312312312</para>
                /// </summary>
                [NameInMap("grantTime")]
                [Validation(Required=false)]
                public long? GrantTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>363784</para>
                /// </summary>
                [NameInMap("senderUserid")]
                [Validation(Required=false)]
                public string SenderUserid { get; set; }

            }

            [NameInMap("honorDesc")]
            [Validation(Required=false)]
            public string HonorDesc { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>21659398</para>
            /// </summary>
            [NameInMap("honorId")]
            [Validation(Required=false)]
            public string HonorId { get; set; }

            [NameInMap("honorName")]
            [Validation(Required=false)]
            public string HonorName { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>http-trigger-nodejs10.luoni-old.1431999136518149.cn-hangzhou.fc.devsapp.net</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>requestId</para>
        /// 
        /// <b>Example:</b>
        /// <para>0FAAEC9C-C6C8-5C87-AF8E-1195889BBXXX</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
