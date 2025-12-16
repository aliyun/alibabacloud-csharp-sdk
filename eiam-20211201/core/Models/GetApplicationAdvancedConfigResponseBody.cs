// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class GetApplicationAdvancedConfigResponseBody : TeaModel {
        [NameInMap("ApplicationAdvancedConfig")]
        [Validation(Required=false)]
        public GetApplicationAdvancedConfigResponseBodyApplicationAdvancedConfig ApplicationAdvancedConfig { get; set; }
        public class GetApplicationAdvancedConfigResponseBodyApplicationAdvancedConfig : TeaModel {
            /// <summary>
            /// <para>IDaaS EIAM 应用Id</para>
            /// 
            /// <b>Example:</b>
            /// <para>app_mkv7rgt4d7i4u7zqtzev2mxxxx</para>
            /// </summary>
            [NameInMap("ApplicationId")]
            [Validation(Required=false)]
            public string ApplicationId { get; set; }

            /// <summary>
            /// <para>IDaaS EIAM 实例Id</para>
            /// 
            /// <b>Example:</b>
            /// <para>idaas_ue2jvisn35ea5lmthk267xxxxx</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>Scim Server 高阶配置</para>
            /// </summary>
            [NameInMap("ScimServerAdvancedConfig")]
            [Validation(Required=false)]
            public GetApplicationAdvancedConfigResponseBodyApplicationAdvancedConfigScimServerAdvancedConfig ScimServerAdvancedConfig { get; set; }
            public class GetApplicationAdvancedConfigResponseBodyApplicationAdvancedConfigScimServerAdvancedConfig : TeaModel {
                /// <summary>
                /// <para>支持的用户自定义字段ID列表。</para>
                /// </summary>
                [NameInMap("SupportedUserCustomFieldIds")]
                [Validation(Required=false)]
                public List<string> SupportedUserCustomFieldIds { get; set; }

                /// <summary>
                /// <para>用户扩展字段的命名空间。</para>
                /// 
                /// <b>Example:</b>
                /// <para>urn:ietf:params:scim:schemas:extension:customfield:2.0:User</para>
                /// </summary>
                [NameInMap("UserCustomFieldNamespace")]
                [Validation(Required=false)]
                public string UserCustomFieldNamespace { get; set; }

            }

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
