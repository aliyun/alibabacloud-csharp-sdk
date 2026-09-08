// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20260120.Models
{
    public class GetDataMaskingAccountCountResponseBody : TeaModel {
        [NameInMap("AccountCount")]
        [Validation(Required=false)]
        public GetDataMaskingAccountCountResponseBodyAccountCount AccountCount { get; set; }
        public class GetDataMaskingAccountCountResponseBodyAccountCount : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("FullAccessCount")]
            [Validation(Required=false)]
            public long? FullAccessCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("NoneAccessCount")]
            [Validation(Required=false)]
            public long? NoneAccessCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("RestrictedAccessCount")]
            [Validation(Required=false)]
            public long? RestrictedAccessCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>7C6D8E9F-1234-5678-ABCD-0123456789AB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
