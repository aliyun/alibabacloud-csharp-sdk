// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class ListCustomPrivacyPoliciesForBrandResponseBody : TeaModel {
        [NameInMap("BrandCustomPrivacyPolicies")]
        [Validation(Required=false)]
        public List<ListCustomPrivacyPoliciesForBrandResponseBodyBrandCustomPrivacyPolicies> BrandCustomPrivacyPolicies { get; set; }
        public class ListCustomPrivacyPoliciesForBrandResponseBodyBrandCustomPrivacyPolicies : TeaModel {
            /// <summary>
            /// <para>条款ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>pp_xxxx</para>
            /// </summary>
            [NameInMap("CustomPrivacyPolicyId")]
            [Validation(Required=false)]
            public string CustomPrivacyPolicyId { get; set; }

        }

        /// <summary>
        /// <para>分页查询时每页行数。</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// <para>本次调用返回的查询凭证（Token）值，用于下一次翻页查询。</para>
        /// 
        /// <b>Example:</b>
        /// <para>NTxxxexample</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>本次调用返回的查询凭证（Token）值，用于上一次翻页查询。</para>
        /// 
        /// <b>Example:</b>
        /// <para>PTxxxexample</para>
        /// </summary>
        [NameInMap("PreviousToken")]
        [Validation(Required=false)]
        public string PreviousToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0441BD79-92F3-53AA-8657-F8CE4A2B912A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
