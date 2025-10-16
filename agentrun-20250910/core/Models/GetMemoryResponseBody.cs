// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class GetMemoryResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public GetMemoryResponseBodyData Data { get; set; }
        public class GetMemoryResponseBodyData : TeaModel {
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public int? CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>365</para>
            /// </summary>
            [NameInMap("longTtl")]
            [Validation(Required=false)]
            public int? LongTtl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test-memory</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("shortTtl")]
            [Validation(Required=false)]
            public int? ShortTtl { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>5A362ADD-51FC-5F4A-B858-D77F6EFAE2E6</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
