// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SysOM20231230.Models
{
    public class ListInstanceHealthResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>SysomOpenAPI.ServerError</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public List<ListInstanceHealthResponseBodyData> Data { get; set; }
        public class ListInstanceHealthResponseBodyData : TeaModel {
            [NameInMap("images")]
            [Validation(Required=false)]
            public List<string> Images { get; set; }

            [NameInMap("instance")]
            [Validation(Required=false)]
            public string Instance { get; set; }

            [NameInMap("namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            [NameInMap("pod")]
            [Validation(Required=false)]
            public string Pod { get; set; }

            [NameInMap("region_id")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("score")]
            [Validation(Required=false)]
            public float? Score { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Query no data</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>35F91AAB-5FDF-5A22-B211-C7C6B00817D0</para>
        /// </summary>
        [NameInMap("request_id")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>42</para>
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
