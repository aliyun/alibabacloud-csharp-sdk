// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class GetApplicationAdvancedConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The advanced configuration of the application.</para>
        /// </summary>
        [NameInMap("ApplicationAdvancedConfig")]
        [Validation(Required=false)]
        public GetApplicationAdvancedConfigResponseBodyApplicationAdvancedConfig ApplicationAdvancedConfig { get; set; }
        public class GetApplicationAdvancedConfigResponseBodyApplicationAdvancedConfig : TeaModel {
            /// <summary>
            /// <para>The application ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>app_mkv7rgt4d7i4u7zqtzev2mxxxx</para>
            /// </summary>
            [NameInMap("ApplicationId")]
            [Validation(Required=false)]
            public string ApplicationId { get; set; }

            /// <summary>
            /// <para>The ID of the IDaaS EIAM instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>idaas_ue2jvisn35ea5lmthk267xxxxx</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The advanced configuration of the SCIM server.</para>
            /// </summary>
            [NameInMap("ScimServerAdvancedConfig")]
            [Validation(Required=false)]
            public GetApplicationAdvancedConfigResponseBodyApplicationAdvancedConfigScimServerAdvancedConfig ScimServerAdvancedConfig { get; set; }
            public class GetApplicationAdvancedConfigResponseBodyApplicationAdvancedConfigScimServerAdvancedConfig : TeaModel {
                /// <summary>
                /// <para>A list of IDs of the supported custom user fields.</para>
                /// </summary>
                [NameInMap("SupportedUserCustomFieldIds")]
                [Validation(Required=false)]
                public List<string> SupportedUserCustomFieldIds { get; set; }

                /// <summary>
                /// <para>The namespace of the user extension fields.</para>
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
