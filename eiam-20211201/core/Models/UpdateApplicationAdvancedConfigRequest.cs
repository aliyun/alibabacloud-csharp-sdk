// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class UpdateApplicationAdvancedConfigRequest : TeaModel {
        /// <summary>
        /// <para>The application ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>app_mkv7rgt4d7i4u7zqtzev2mxxxx</para>
        /// </summary>
        [NameInMap("ApplicationId")]
        [Validation(Required=false)]
        public string ApplicationId { get; set; }

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
        /// <para>The SCIM server advanced configuration.</para>
        /// </summary>
        [NameInMap("ScimServerAdvancedConfig")]
        [Validation(Required=false)]
        public UpdateApplicationAdvancedConfigRequestScimServerAdvancedConfig ScimServerAdvancedConfig { get; set; }
        public class UpdateApplicationAdvancedConfigRequestScimServerAdvancedConfig : TeaModel {
            /// <summary>
            /// <para>The list of supported user custom field IDs.</para>
            /// </summary>
            [NameInMap("SupportedUserCustomFieldIds")]
            [Validation(Required=false)]
            public List<string> SupportedUserCustomFieldIds { get; set; }

            /// <summary>
            /// <para>The namespace of user extended fields.</para>
            /// 
            /// <b>Example:</b>
            /// <para>urn:ietf:params:scim:schemas:extension:customfield:2.0:User</para>
            /// </summary>
            [NameInMap("UserCustomFieldNamespace")]
            [Validation(Required=false)]
            public string UserCustomFieldNamespace { get; set; }

        }

    }

}
