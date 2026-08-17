// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Foasconsole20211028.Models
{
    public class GetFlinkAiServiceFreeQuotaResponseBody : TeaModel {
        /// <summary>
        /// <para>The Flink AI free quota data transfer object.</para>
        /// </summary>
        [NameInMap("FlinkAiFreeQuotaDTO")]
        [Validation(Required=false)]
        public GetFlinkAiServiceFreeQuotaResponseBodyFlinkAiFreeQuotaDTO FlinkAiFreeQuotaDTO { get; set; }
        public class GetFlinkAiServiceFreeQuotaResponseBodyFlinkAiFreeQuotaDTO : TeaModel {
            /// <summary>
            /// <para>The total free quota.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("FreeQuota")]
            [Validation(Required=false)]
            public double? FreeQuota { get; set; }

            /// <summary>
            /// <para>The list of used quota details for each usage type.</para>
            /// </summary>
            [NameInMap("UsedQuotaDetails")]
            [Validation(Required=false)]
            public List<GetFlinkAiServiceFreeQuotaResponseBodyFlinkAiFreeQuotaDTOUsedQuotaDetails> UsedQuotaDetails { get; set; }
            public class GetFlinkAiServiceFreeQuotaResponseBodyFlinkAiFreeQuotaDTOUsedQuotaDetails : TeaModel {
                /// <summary>
                /// <para>The used quota for this usage type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>35.5</para>
                /// </summary>
                [NameInMap("Amount")]
                [Validation(Required=false)]
                public double? Amount { get; set; }

                /// <summary>
                /// <para>The usage type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>AI_FUNCTION</para>
                /// </summary>
                [NameInMap("UsageType")]
                [Validation(Required=false)]
                public string UsageType { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C8DF2A5B-6FBA-5651-A3D4-960F3664****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
