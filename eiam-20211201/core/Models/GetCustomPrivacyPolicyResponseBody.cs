// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class GetCustomPrivacyPolicyResponseBody : TeaModel {
        [NameInMap("CustomPrivacyPolicy")]
        [Validation(Required=false)]
        public GetCustomPrivacyPolicyResponseBodyCustomPrivacyPolicy CustomPrivacyPolicy { get; set; }
        public class GetCustomPrivacyPolicyResponseBodyCustomPrivacyPolicy : TeaModel {
            [NameInMap("CustomPrivacyPolicyContents")]
            [Validation(Required=false)]
            public List<GetCustomPrivacyPolicyResponseBodyCustomPrivacyPolicyCustomPrivacyPolicyContents> CustomPrivacyPolicyContents { get; set; }
            public class GetCustomPrivacyPolicyResponseBodyCustomPrivacyPolicyCustomPrivacyPolicyContents : TeaModel {
                [NameInMap("CustomPrivacyPolicyItems")]
                [Validation(Required=false)]
                public List<GetCustomPrivacyPolicyResponseBodyCustomPrivacyPolicyCustomPrivacyPolicyContentsCustomPrivacyPolicyItems> CustomPrivacyPolicyItems { get; set; }
                public class GetCustomPrivacyPolicyResponseBodyCustomPrivacyPolicyCustomPrivacyPolicyContentsCustomPrivacyPolicyItems : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>item name</para>
                    /// </summary>
                    [NameInMap("CustomPrivacyPolicyItemName")]
                    [Validation(Required=false)]
                    public string CustomPrivacyPolicyItemName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para><a href="https://example.com">https://example.com</a></para>
                    /// </summary>
                    [NameInMap("CustomPrivacyPolicyItemUrl")]
                    [Validation(Required=false)]
                    public string CustomPrivacyPolicyItemUrl { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Please read and agree：</para>
                /// </summary>
                [NameInMap("CustomPrivacyPolicyTip")]
                [Validation(Required=false)]
                public string CustomPrivacyPolicyTip { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>zh-Hans-CN</para>
                /// </summary>
                [NameInMap("LanguageCode")]
                [Validation(Required=false)]
                public string LanguageCode { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>pp_xxxxx</para>
            /// </summary>
            [NameInMap("CustomPrivacyPolicyId")]
            [Validation(Required=false)]
            public string CustomPrivacyPolicyId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Custom Privacy Policy Name</para>
            /// </summary>
            [NameInMap("CustomPrivacyPolicyName")]
            [Validation(Required=false)]
            public string CustomPrivacyPolicyName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>zh-Hans-CN</para>
            /// </summary>
            [NameInMap("DefaultLanguageCode")]
            [Validation(Required=false)]
            public string DefaultLanguageCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>idaas_ue2jvisn35ea5lmthk267xxxxx</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>enabled</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>implied_consent</para>
            /// </summary>
            [NameInMap("UserConsentType")]
            [Validation(Required=false)]
            public string UserConsentType { get; set; }

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
