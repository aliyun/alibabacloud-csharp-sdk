// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class ListCustomPrivacyPoliciesResponseBody : TeaModel {
        [NameInMap("CustomPrivacyPolicies")]
        [Validation(Required=false)]
        public List<ListCustomPrivacyPoliciesResponseBodyCustomPrivacyPolicies> CustomPrivacyPolicies { get; set; }
        public class ListCustomPrivacyPoliciesResponseBodyCustomPrivacyPolicies : TeaModel {
            /// <summary>
            /// <para>自定义条款Id</para>
            /// 
            /// <b>Example:</b>
            /// <para>pp_xxxxx</para>
            /// </summary>
            [NameInMap("CustomPrivacyPolicyId")]
            [Validation(Required=false)]
            public string CustomPrivacyPolicyId { get; set; }

            /// <summary>
            /// <para>自定义条款名称</para>
            /// 
            /// <b>Example:</b>
            /// <para>Custom Privacy Policy Name</para>
            /// </summary>
            [NameInMap("CustomPrivacyPolicyName")]
            [Validation(Required=false)]
            public string CustomPrivacyPolicyName { get; set; }

            /// <summary>
            /// <para>若显示语言未配置时，门户侧展示默认语言展示条款。</para>
            /// 
            /// <b>Example:</b>
            /// <para>zh-Hans-CN</para>
            /// </summary>
            [NameInMap("DefaultLanguageCode")]
            [Validation(Required=false)]
            public string DefaultLanguageCode { get; set; }

            /// <summary>
            /// <para>实例id</para>
            /// 
            /// <b>Example:</b>
            /// <para>idaas_ue2jvisn35ea5lmthk267xxxxx</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>自定义条款状态</para>
            /// 
            /// <b>Example:</b>
            /// <para>enabled</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>自定义条款同意类型，是默认同意，还是用户勾选同意</para>
            /// 
            /// <b>Example:</b>
            /// <para>implied_consent</para>
            /// </summary>
            [NameInMap("UserConsentType")]
            [Validation(Required=false)]
            public string UserConsentType { get; set; }

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
