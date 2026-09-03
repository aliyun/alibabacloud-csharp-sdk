// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class GetAttributePassingSettingResponseBody : TeaModel {
        /// <summary>
        /// <para>The attribute passing settings.</para>
        /// </summary>
        [NameInMap("AttributePassingSetting")]
        [Validation(Required=false)]
        public GetAttributePassingSettingResponseBodyAttributePassingSetting AttributePassingSetting { get; set; }
        public class GetAttributePassingSettingResponseBodyAttributePassingSetting : TeaModel {
            /// <summary>
            /// <para>The SourceIdentity pass-through mode. If not configured, Disabled is returned by default. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>IdP: Uses the SourceIdentity attribute value carried in the SAML assertion from the external identity provider (IdP). The attribute value must be 2 to 64 characters in length and can contain only letters, digits, and the following special characters: =,.@-_.</description></item>
            /// <item><description>UserName: Uses the CloudSSO username as the SourceIdentity. The system automatically adds a reserved prefix, resulting in the format acs:sso:<username>. The total length cannot exceed 64 characters.</description></item>
            /// <item><description>Disabled: Does not pass through the SourceIdentity.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Disabled</para>
            /// </summary>
            [NameInMap("SourceIdentityPassing")]
            [Validation(Required=false)]
            public string SourceIdentityPassing { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F6F90F3D-4502-5877-B80B-97476F6AE2CC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
