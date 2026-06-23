// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class GetCustomPrivacyPolicyResponseBody : TeaModel {
        /// <summary>
        /// <para>The custom privacy policy.</para>
        /// </summary>
        [NameInMap("CustomPrivacyPolicy")]
        [Validation(Required=false)]
        public GetCustomPrivacyPolicyResponseBodyCustomPrivacyPolicy CustomPrivacyPolicy { get; set; }
        public class GetCustomPrivacyPolicyResponseBodyCustomPrivacyPolicy : TeaModel {
            /// <summary>
            /// <para>The content details of the custom privacy policy.</para>
            /// </summary>
            [NameInMap("CustomPrivacyPolicyContents")]
            [Validation(Required=false)]
            public List<GetCustomPrivacyPolicyResponseBodyCustomPrivacyPolicyCustomPrivacyPolicyContents> CustomPrivacyPolicyContents { get; set; }
            public class GetCustomPrivacyPolicyResponseBodyCustomPrivacyPolicyCustomPrivacyPolicyContents : TeaModel {
                /// <summary>
                /// <para>The custom privacy policy items.</para>
                /// </summary>
                [NameInMap("CustomPrivacyPolicyItems")]
                [Validation(Required=false)]
                public List<GetCustomPrivacyPolicyResponseBodyCustomPrivacyPolicyCustomPrivacyPolicyContentsCustomPrivacyPolicyItems> CustomPrivacyPolicyItems { get; set; }
                public class GetCustomPrivacyPolicyResponseBodyCustomPrivacyPolicyCustomPrivacyPolicyContentsCustomPrivacyPolicyItems : TeaModel {
                    /// <summary>
                    /// <para>The name of the custom privacy policy item.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>item name</para>
                    /// </summary>
                    [NameInMap("CustomPrivacyPolicyItemName")]
                    [Validation(Required=false)]
                    public string CustomPrivacyPolicyItemName { get; set; }

                    /// <summary>
                    /// <para>The URL of the custom privacy policy item. The URL must start with https://.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="https://example.com">https://example.com</a></para>
                    /// </summary>
                    [NameInMap("CustomPrivacyPolicyItemUrl")]
                    [Validation(Required=false)]
                    public string CustomPrivacyPolicyItemUrl { get; set; }

                }

                /// <summary>
                /// <para>The tip for the custom privacy policy content.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Please read and agree：</para>
                /// </summary>
                [NameInMap("CustomPrivacyPolicyTip")]
                [Validation(Required=false)]
                public string CustomPrivacyPolicyTip { get; set; }

                /// <summary>
                /// <para>The language of the custom privacy policy. The value is obtained from the LanguageCode parameter returned by the ListLanguages operation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>zh-Hans-CN</para>
                /// </summary>
                [NameInMap("LanguageCode")]
                [Validation(Required=false)]
                public string LanguageCode { get; set; }

            }

            /// <summary>
            /// <para>The custom privacy policy ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pp_xxxxx</para>
            /// </summary>
            [NameInMap("CustomPrivacyPolicyId")]
            [Validation(Required=false)]
            public string CustomPrivacyPolicyId { get; set; }

            /// <summary>
            /// <para>The custom privacy policy name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Custom Privacy Policy Name</para>
            /// </summary>
            [NameInMap("CustomPrivacyPolicyName")]
            [Validation(Required=false)]
            public string CustomPrivacyPolicyName { get; set; }

            /// <summary>
            /// <para>The language of the custom privacy policy. The value is obtained from the LanguageCode parameter returned by the ListLanguages operation.</para>
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
            /// <para>The status of the custom privacy policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>enabled: Enabled.</description></item>
            /// <item><description>disabled: Disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>enabled</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The user consent type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>implied_consent</para>
            /// </summary>
            [NameInMap("UserConsentType")]
            [Validation(Required=false)]
            public string UserConsentType { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0441BD79-92F3-53AA-8657-F8CE4A2B912A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
