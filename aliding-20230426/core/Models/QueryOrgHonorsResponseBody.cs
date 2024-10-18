// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class QueryOrgHonorsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("openHonors")]
        [Validation(Required=false)]
        public List<QueryOrgHonorsResponseBodyOpenHonors> OpenHonors { get; set; }
        public class QueryOrgHonorsResponseBodyOpenHonors : TeaModel {
            [NameInMap("honorDesc")]
            [Validation(Required=false)]
            public string HonorDesc { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>21658579</para>
            /// </summary>
            [NameInMap("honorId")]
            [Validation(Required=false)]
            public long? HonorId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://xxxx.ali-cdn.com/jfejfi.jpg">https://xxxx.ali-cdn.com/jfejfi.jpg</a></para>
            /// </summary>
            [NameInMap("honorImgUrl")]
            [Validation(Required=false)]
            public string HonorImgUrl { get; set; }

            [NameInMap("honorName")]
            [Validation(Required=false)]
            public string HonorName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://xxxx.ali-cdn.com/jfejfi.jpg">https://xxxx.ali-cdn.com/jfejfi.jpg</a></para>
            /// </summary>
            [NameInMap("honorPendantImgUrl")]
            [Validation(Required=false)]
            public string HonorPendantImgUrl { get; set; }

        }

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
