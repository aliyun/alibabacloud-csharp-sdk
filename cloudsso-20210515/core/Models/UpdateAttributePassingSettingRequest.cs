// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class UpdateAttributePassingSettingRequest : TeaModel {
        /// <summary>
        /// <para>The directory ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d-00fc2p61****</para>
        /// </summary>
        [NameInMap("DirectoryId")]
        [Validation(Required=false)]
        public string DirectoryId { get; set; }

        /// <summary>
        /// <para>The SourceIdentity pass-through mode. Three pass-through modes are supported. If this parameter is not specified, the existing configuration is not modified.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>IdP: Uses the SourceIdentity attribute value carried in the SAML assertion from the external identity provider (IdP). The attribute value must be 2 to 64 characters in length and can contain only letters, digits, and the following special characters: =,.@-_.</description></item>
        /// <item><description>UserName: Uses the CloudSSO username as the SourceIdentity. The system automatically adds a reserved prefix, resulting in the format acs:sso:<username>, with a total length of no more than 64 characters.</description></item>
        /// <item><description>Disabled: Does not pass through SourceIdentity.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Disabled</para>
        /// </summary>
        [NameInMap("SourceIdentityPassing")]
        [Validation(Required=false)]
        public string SourceIdentityPassing { get; set; }

    }

}
