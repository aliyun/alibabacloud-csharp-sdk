// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20220101.Models
{
    public class GetDistributedTablesBufferSizeResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetDistributedTablesBufferSizeResponseBodyData Data { get; set; }
        public class GetDistributedTablesBufferSizeResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("BufferSizeGiB")]
            [Validation(Required=false)]
            public int? BufferSizeGiB { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>48CBEEBE-FA07-5A06-8BA4-567B92ADD6A0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
