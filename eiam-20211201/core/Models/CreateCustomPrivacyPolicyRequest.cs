// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class CreateCustomPrivacyPolicyRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>client-token-example</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>自定义条款内容详情</para>
        /// </summary>
        [NameInMap("CustomPrivacyPolicyContents")]
        [Validation(Required=false)]
        public List<CreateCustomPrivacyPolicyRequestCustomPrivacyPolicyContents> CustomPrivacyPolicyContents { get; set; }
        public class CreateCustomPrivacyPolicyRequestCustomPrivacyPolicyContents : TeaModel {
            /// <summary>
            /// <para>自定义条款项</para>
            /// </summary>
            [NameInMap("CustomPrivacyPolicyItems")]
            [Validation(Required=false)]
            public List<CreateCustomPrivacyPolicyRequestCustomPrivacyPolicyContentsCustomPrivacyPolicyItems> CustomPrivacyPolicyItems { get; set; }
            public class CreateCustomPrivacyPolicyRequestCustomPrivacyPolicyContentsCustomPrivacyPolicyItems : TeaModel {
                /// <summary>
                /// <para>自定义条款名称</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxxx隐私政策条款</para>
                /// </summary>
                [NameInMap("CustomPrivacyPolicyItemName")]
                [Validation(Required=false)]
                public string CustomPrivacyPolicyItemName { get; set; }

                /// <summary>
                /// <para>自定义条款访问地址</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://www.xxxx.com">http://www.xxxx.com</a></para>
                /// </summary>
                [NameInMap("CustomPrivacyPolicyItemUrl")]
                [Validation(Required=false)]
                public string CustomPrivacyPolicyItemUrl { get; set; }

            }

            /// <summary>
            /// <para>自定义条款提示</para>
            /// 
            /// <b>Example:</b>
            /// <para>登录视为同意此条款</para>
            /// </summary>
            [NameInMap("CustomPrivacyPolicyTip")]
            [Validation(Required=false)]
            public string CustomPrivacyPolicyTip { get; set; }

            /// <summary>
            /// <para>自定义条款所属语言</para>
            /// 
            /// <b>Example:</b>
            /// <para>zh-Hans-CN</para>
            /// </summary>
            [NameInMap("LanguageCode")]
            [Validation(Required=false)]
            public string LanguageCode { get; set; }

        }

        /// <summary>
        /// <para>自定义条款名称</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Custom Privacy Policy Name</para>
        /// </summary>
        [NameInMap("CustomPrivacyPolicyName")]
        [Validation(Required=false)]
        public string CustomPrivacyPolicyName { get; set; }

        /// <summary>
        /// <para>默认条款语言，若其他语言未配置条款，则使用默认的</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh-Hans-CN</para>
        /// </summary>
        [NameInMap("DefaultLanguageCode")]
        [Validation(Required=false)]
        public string DefaultLanguageCode { get; set; }

        /// <summary>
        /// <para>IDaaS EIAM实例的ID。</para>
        /// <para>This parameter is required.</para>
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
        /// <para>手动勾选同意，还是默认同意</para>
        /// 
        /// <b>Example:</b>
        /// <para>implied_consent</para>
        /// </summary>
        [NameInMap("UserConsentType")]
        [Validation(Required=false)]
        public string UserConsentType { get; set; }

    }

}
