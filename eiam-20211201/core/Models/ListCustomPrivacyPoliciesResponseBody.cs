// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class ListCustomPrivacyPoliciesResponseBody : TeaModel {
        /// <summary>
        /// <para>A list of custom privacy policies.</para>
        /// </summary>
        [NameInMap("CustomPrivacyPolicies")]
        [Validation(Required=false)]
        public List<ListCustomPrivacyPoliciesResponseBodyCustomPrivacyPolicies> CustomPrivacyPolicies { get; set; }
        public class ListCustomPrivacyPoliciesResponseBodyCustomPrivacyPolicies : TeaModel {
            /// <summary>
            /// <para>The ID of the custom privacy policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pp_xxxxx</para>
            /// </summary>
            [NameInMap("CustomPrivacyPolicyId")]
            [Validation(Required=false)]
            public string CustomPrivacyPolicyId { get; set; }

            /// <summary>
            /// <para>The name of the custom privacy policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Custom Privacy Policy Name</para>
            /// </summary>
            [NameInMap("CustomPrivacyPolicyName")]
            [Validation(Required=false)]
            public string CustomPrivacyPolicyName { get; set; }

            /// <summary>
            /// <para>The default language of the policy. The value is the LanguageCode returned by the ListLanguages operation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>zh-Hans-CN</para>
            /// </summary>
            [NameInMap("DefaultLanguageCode")]
            [Validation(Required=false)]
            public string DefaultLanguageCode { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>idaas_ue2jvisn35ea5lmthk267xxxxx</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The status of the custom privacy policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>enabled</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The user consent type for the policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>implied_consent</para>
            /// </summary>
            [NameInMap("UserConsentType")]
            [Validation(Required=false)]
            public string UserConsentType { get; set; }

        }

        /// <summary>
        /// <para>The number of entries to return on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// <para>The token that is used to retrieve the next page of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NTxxxexample</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The token that is used to retrieve the previous page of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PTxxxexample</para>
        /// </summary>
        [NameInMap("PreviousToken")]
        [Validation(Required=false)]
        public string PreviousToken { get; set; }

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
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
