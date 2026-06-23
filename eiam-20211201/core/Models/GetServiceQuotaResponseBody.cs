// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class GetServiceQuotaResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0441BD79-92F3-53AA-8657-F8CE4A2B912A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The service quota.</para>
        /// </summary>
        [NameInMap("ServiceQuota")]
        [Validation(Required=false)]
        public GetServiceQuotaResponseBodyServiceQuota ServiceQuota { get; set; }
        public class GetServiceQuotaResponseBodyServiceQuota : TeaModel {
            /// <summary>
            /// <para>The unique identifier of the quota.</para>
            /// 
            /// <b>Example:</b>
            /// <para>instanceTrialNumber</para>
            /// </summary>
            [NameInMap("QuotaType")]
            [Validation(Required=false)]
            public string QuotaType { get; set; }

            /// <summary>
            /// <para>The value of the quota.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("QuotaValue")]
            [Validation(Required=false)]
            public long? QuotaValue { get; set; }

            /// <summary>
            /// <para>The current usage of the quota.</para>
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
