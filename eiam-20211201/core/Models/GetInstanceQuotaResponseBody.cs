// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class GetInstanceQuotaResponseBody : TeaModel {
        [NameInMap("Quota")]
        [Validation(Required=false)]
        public GetInstanceQuotaResponseBodyQuota Quota { get; set; }
        public class GetInstanceQuotaResponseBodyQuota : TeaModel {
            /// <summary>
            /// <para>Quota 配额的Key，同请求参数</para>
            /// 
            /// <b>Example:</b>
            /// <para>userMaxNumber</para>
            /// </summary>
            [NameInMap("QuotaKey")]
            [Validation(Required=false)]
            public string QuotaKey { get; set; }

            /// <summary>
            /// <para>Quota 配额的值。</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("QuotaValue")]
            [Validation(Required=false)]
            public int? QuotaValue { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0441BD79-92F3-53AA-8657-F8CE4A2B912A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
