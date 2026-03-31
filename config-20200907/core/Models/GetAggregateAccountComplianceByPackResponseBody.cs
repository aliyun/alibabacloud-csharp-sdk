// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class GetAggregateAccountComplianceByPackResponseBody : TeaModel {
        /// <summary>
        /// <para>The compliance evaluation results of member accounts for which the compliance package takes effect in an account group.</para>
        /// </summary>
        [NameInMap("AccountComplianceResult")]
        [Validation(Required=false)]
        public GetAggregateAccountComplianceByPackResponseBodyAccountComplianceResult AccountComplianceResult { get; set; }
        public class GetAggregateAccountComplianceByPackResponseBodyAccountComplianceResult : TeaModel {
            /// <summary>
            /// <para>The compliance evaluation result of member accounts.</para>
            /// </summary>
            [NameInMap("AccountCompliances")]
            [Validation(Required=false)]
            public List<GetAggregateAccountComplianceByPackResponseBodyAccountComplianceResultAccountCompliances> AccountCompliances { get; set; }
            public class GetAggregateAccountComplianceByPackResponseBodyAccountComplianceResultAccountCompliances : TeaModel {
                /// <summary>
                /// <para>The ID of the member account in the account group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100931896542****</para>
                /// </summary>
                [NameInMap("AccountId")]
                [Validation(Required=false)]
                public long? AccountId { get; set; }

                /// <summary>
                /// <para>The name of the member account in the account group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Alice</para>
                /// </summary>
                [NameInMap("AccountName")]
                [Validation(Required=false)]
                public string AccountName { get; set; }

                /// <summary>
                /// <para>The compliance evaluation result. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>COMPLIANT: The resource was evaluated as compliant.</description></item>
                /// <item><description>NON_COMPLIANT: The resource was evaluated as incompliant.</description></item>
                /// <item><description>NOT_APPLICABLE: The rule did not apply to your resource.</description></item>
                /// <item><description>INSUFFICIENT_DATA: No resource data was available.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>COMPLIANT</para>
                /// </summary>
                [NameInMap("ComplianceType")]
                [Validation(Required=false)]
                public string ComplianceType { get; set; }

            }

            /// <summary>
            /// <para>The ID of the compliance package.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cp-541e626622af0087****</para>
            /// </summary>
            [NameInMap("CompliancePackId")]
            [Validation(Required=false)]
            public string CompliancePackId { get; set; }

            /// <summary>
            /// <para>The number of non-compliant member accounts.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("NonCompliantCount")]
            [Validation(Required=false)]
            public int? NonCompliantCount { get; set; }

            /// <summary>
            /// <para>The total number of member accounts.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6EC7AED1-172F-42AE-9C12-295BC2ADB751</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
