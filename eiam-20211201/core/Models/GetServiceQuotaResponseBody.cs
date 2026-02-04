// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class GetServiceQuotaResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>0441BD79-92F3-53AA-8657-F8CE4A2B912A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ServiceQuota")]
        [Validation(Required=false)]
        public GetServiceQuotaResponseBodyServiceQuota ServiceQuota { get; set; }
        public class GetServiceQuotaResponseBodyServiceQuota : TeaModel {
            /// <summary>
            /// <para>Quota 配额的唯一标识。</para>
            /// 
            /// <b>Example:</b>
            /// <para>instanceTrialNumber</para>
            /// </summary>
            [NameInMap("QuotaType")]
            [Validation(Required=false)]
            public string QuotaType { get; set; }

            /// <summary>
            /// <para>Quota 配额的值。</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("QuotaValue")]
            [Validation(Required=false)]
            public long? QuotaValue { get; set; }

            /// <summary>
            /// <para>Quota 配额的当前用量。</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("UsedQuotaValue")]
            [Validation(Required=false)]
            public long? UsedQuotaValue { get; set; }

        }

    }

}
