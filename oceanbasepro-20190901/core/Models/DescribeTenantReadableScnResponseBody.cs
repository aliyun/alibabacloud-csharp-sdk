// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeTenantReadableScnResponseBody : TeaModel {
        /// <summary>
        /// <para>The data in the return result of the request.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeTenantReadableScnResponseBodyData Data { get; set; }
        public class DescribeTenantReadableScnResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The maximum readable timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1715329164977</para>
            /// </summary>
            [NameInMap("ReadableScn")]
            [Validation(Required=false)]
            public long? ReadableScn { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8442BB1E-3171-1192-B9DC-F6F4E53B2673</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
