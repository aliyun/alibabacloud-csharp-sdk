// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class GetIdentityProviderAdvancedConfigurationResponseBody : TeaModel {
        /// <summary>
        /// <para>Advanced configuration information</para>
        /// </summary>
        [NameInMap("AdvancedConfiguration")]
        [Validation(Required=false)]
        public GetIdentityProviderAdvancedConfigurationResponseBodyAdvancedConfiguration AdvancedConfiguration { get; set; }
        public class GetIdentityProviderAdvancedConfigurationResponseBodyAdvancedConfiguration : TeaModel {
            /// <summary>
            /// <para>DingTalk advanced configuration</para>
            /// </summary>
            [NameInMap("DingtalkAdvancedConfig")]
            [Validation(Required=false)]
            public GetIdentityProviderAdvancedConfigurationResponseBodyAdvancedConfigurationDingtalkAdvancedConfig DingtalkAdvancedConfig { get; set; }
            public class GetIdentityProviderAdvancedConfigurationResponseBodyAdvancedConfigurationDingtalkAdvancedConfig : TeaModel {
                /// <summary>
                /// <para>AppKey of the DingTalk first-party application</para>
                /// 
                /// <b>Example:</b>
                /// <para>ding5xo9rg0csw3f6xxx</para>
                /// </summary>
                [NameInMap("AppKey")]
                [Validation(Required=false)]
                public string AppKey { get; set; }

                /// <summary>
                /// <para>App secret of the DingTalk first-party application</para>
                /// 
                /// <b>Example:</b>
                /// <hr>
                /// </summary>
                [NameInMap("AppSecret")]
                [Validation(Required=false)]
                public string AppSecret { get; set; }

            }

            /// <summary>
            /// <para>Identity provider ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>idp_na2rzpyc67zr7ixdfy35zgrxxx</para>
            /// </summary>
            [NameInMap("IdentityProviderId")]
            [Validation(Required=false)]
            public string IdentityProviderId { get; set; }

            /// <summary>
            /// <para>Instance ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>idaas_kpvmhktvun6u66dgpjh3l4wxxx</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

        }

        /// <summary>
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>0441BD79-92F3-53AA-8657-F8CE4A2B912A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
