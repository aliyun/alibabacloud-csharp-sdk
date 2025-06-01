// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class CreateWmExtractTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the watermark extraction task.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateWmExtractTaskResponseBodyData Data { get; set; }
        public class CreateWmExtractTaskResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The task ID. You can use task IDs to query task results.</para>
            /// 
            /// <b>Example:</b>
            /// <para>wmt-9648c22d2eb2cb57bb855dcae7898464********</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D6707286-A50E-57B1-B2CF-EFAC59E850D8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
