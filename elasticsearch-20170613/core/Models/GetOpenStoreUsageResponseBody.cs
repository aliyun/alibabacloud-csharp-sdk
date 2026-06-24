// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class GetOpenStoreUsageResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E1DE2491-804F-4C86-BAB4-548DD70B****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The result of the current request.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public GetOpenStoreUsageResponseBodyResult Result { get; set; }
        public class GetOpenStoreUsageResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The current OpenStore storage usage, which is an estimated value based on actual indexes. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>204800</para>
            /// </summary>
            [NameInMap("currentUsage")]
            [Validation(Required=false)]
            public long? CurrentUsage { get; set; }

            /// <summary>
            /// <para>The OpenStore storage usage on the previous day. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>184320</para>
            /// </summary>
            [NameInMap("lastDayUsage")]
            [Validation(Required=false)]
            public long? LastDayUsage { get; set; }

        }

    }

}
