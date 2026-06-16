// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class UpdateCustomPrivacyPolicyRequest : TeaModel {
        /// <summary>
        /// <para>The details of the custom privacy policy content.</para>
        /// </summary>
        [NameInMap("CustomPrivacyPolicyContents")]
        [Validation(Required=false)]
        public List<UpdateCustomPrivacyPolicyRequestCustomPrivacyPolicyContents> CustomPrivacyPolicyContents { get; set; }
        public class UpdateCustomPrivacyPolicyRequestCustomPrivacyPolicyContents : TeaModel {
            /// <summary>
            /// <para>The items of the custom privacy policy.</para>
            /// </summary>
            [NameInMap("CustomPrivacyPolicyItems")]
            [Validation(Required=false)]
            public List<UpdateCustomPrivacyPolicyRequestCustomPrivacyPolicyContentsCustomPrivacyPolicyItems> CustomPrivacyPolicyItems { get; set; }
            public class UpdateCustomPrivacyPolicyRequestCustomPrivacyPolicyContentsCustomPrivacyPolicyItems : TeaModel {
                /// <summary>
                /// <para>The name of the custom privacy policy item.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Item Name</para>
                /// </summary>
                [NameInMap("CustomPrivacyPolicyItemName")]
                [Validation(Required=false)]
                public string CustomPrivacyPolicyItemName { get; set; }

                /// <summary>
                /// <para>The endpoint of the custom privacy policy item. The value must start with https\://.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://example.com">https://example.com</a></para>
                /// </summary>
                [NameInMap("CustomPrivacyPolicyItemUrl")]
                [Validation(Required=false)]
                public string CustomPrivacyPolicyItemUrl { get; set; }

            }

            /// <summary>
            /// <para>The prompt for the custom privacy policy content.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Please read and agree：</para>
            /// </summary>
            [NameInMap("CustomPrivacyPolicyTip")]
            [Validation(Required=false)]
            public string CustomPrivacyPolicyTip { get; set; }

            /// <summary>
            /// <para>The language of the custom privacy policy. The value is the LanguageCode returned by the ListLanguages operation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>zh-Hans-CN</para>
            /// </summary>
            [NameInMap("LanguageCode")]
            [Validation(Required=false)]
            public string LanguageCode { get; set; }

        }

        /// <summary>
        /// <para>The ID of the custom privacy policy.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pp_neagxpoznsjdtxxxxx</para>
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
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>idaas_ue2jvisn35ea5lmthk267xxxxx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The consent type for the custom privacy policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>implied_consent</para>
        /// </summary>
        [NameInMap("UserConsentType")]
        [Validation(Required=false)]
        public string UserConsentType { get; set; }

    }

}
