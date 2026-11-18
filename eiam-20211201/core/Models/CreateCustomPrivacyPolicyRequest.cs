// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class CreateCustomPrivacyPolicyRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the value, but you must ensure that it is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>client-token-example</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The details of the custom privacy policy content.</para>
        /// </summary>
        [NameInMap("CustomPrivacyPolicyContents")]
        [Validation(Required=false)]
        public List<CreateCustomPrivacyPolicyRequestCustomPrivacyPolicyContents> CustomPrivacyPolicyContents { get; set; }
        public class CreateCustomPrivacyPolicyRequestCustomPrivacyPolicyContents : TeaModel {
            /// <summary>
            /// <para>The custom privacy policy items.</para>
            /// </summary>
            [NameInMap("CustomPrivacyPolicyItems")]
            [Validation(Required=false)]
            public List<CreateCustomPrivacyPolicyRequestCustomPrivacyPolicyContentsCustomPrivacyPolicyItems> CustomPrivacyPolicyItems { get; set; }
            public class CreateCustomPrivacyPolicyRequestCustomPrivacyPolicyContentsCustomPrivacyPolicyItems : TeaModel {
                /// <summary>
                /// <para>The name of the custom privacy policy item.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Custom Privacy Policy Name</para>
                /// </summary>
                [NameInMap("CustomPrivacyPolicyItemName")]
                [Validation(Required=false)]
                public string CustomPrivacyPolicyItemName { get; set; }

                /// <summary>
                /// <para>The URL of the custom privacy policy item.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://www.xxxx.com">http://www.xxxx.com</a></para>
                /// </summary>
                [NameInMap("CustomPrivacyPolicyItemUrl")]
                [Validation(Required=false)]
                public string CustomPrivacyPolicyItemUrl { get; set; }

            }

            /// <summary>
            /// <para>The custom privacy policy tip.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Please read and agree：</para>
            /// </summary>
            [NameInMap("CustomPrivacyPolicyTip")]
            [Validation(Required=false)]
            public string CustomPrivacyPolicyTip { get; set; }

            /// <summary>
            /// <para>The language code of the custom privacy policy. The value is obtained from the LanguageCode parameter returned by the ListLanguages operation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>zh-Hans-CN</para>
            /// </summary>
            [NameInMap("LanguageCode")]
            [Validation(Required=false)]
            public string LanguageCode { get; set; }

        }

        /// <summary>
        /// <para>The name of the custom privacy policy.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Custom Privacy Policy Name</para>
        /// </summary>
        [NameInMap("CustomPrivacyPolicyName")]
        [Validation(Required=false)]
        public string CustomPrivacyPolicyName { get; set; }

        /// <summary>
        /// <para>The default language code of the custom privacy policy.</para>
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
        /// <para>The status of the custom privacy policy.</para>
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

}
