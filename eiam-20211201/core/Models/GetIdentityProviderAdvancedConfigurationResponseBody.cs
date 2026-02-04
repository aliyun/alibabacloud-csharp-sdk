// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class GetIdentityProviderAdvancedConfigurationResponseBody : TeaModel {
        [NameInMap("AdvancedConfiguration")]
        [Validation(Required=false)]
        public GetIdentityProviderAdvancedConfigurationResponseBodyAdvancedConfiguration AdvancedConfiguration { get; set; }
        public class GetIdentityProviderAdvancedConfigurationResponseBodyAdvancedConfiguration : TeaModel {
            /// <summary>
            /// <para>钉钉高阶配置</para>
            /// </summary>
            [NameInMap("DingtalkAdvancedConfig")]
            [Validation(Required=false)]
            public GetIdentityProviderAdvancedConfigurationResponseBodyAdvancedConfigurationDingtalkAdvancedConfig DingtalkAdvancedConfig { get; set; }
            public class GetIdentityProviderAdvancedConfigurationResponseBodyAdvancedConfigurationDingtalkAdvancedConfig : TeaModel {
                /// <summary>
                /// <para>IDaaS EIAM 钉钉一方应用的AppKey</para>
                /// 
                /// <b>Example:</b>
                /// <para>ding5xo9rg0csw3f6xxx</para>
                /// </summary>
                [NameInMap("AppKey")]
                [Validation(Required=false)]
                public string AppKey { get; set; }

                /// <summary>
                /// <para>IDaaS EIAM 钉钉一方应用的AppSecret</para>
                /// 
                /// <b>Example:</b>
                /// <hr>
                /// </summary>
                [NameInMap("AppSecret")]
                [Validation(Required=false)]
                public string AppSecret { get; set; }

            }

            /// <summary>
            /// <para>IDaaS EIAM 身份提供方ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>idp_na2rzpyc67zr7ixdfy35zgrxxx</para>
            /// </summary>
            [NameInMap("IdentityProviderId")]
            [Validation(Required=false)]
            public string IdentityProviderId { get; set; }

            /// <summary>
            /// <para>IDaaS EIAM 实例Id</para>
            /// 
            /// <b>Example:</b>
            /// <para>idaas_kpvmhktvun6u66dgpjh3l4wxxx</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

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
