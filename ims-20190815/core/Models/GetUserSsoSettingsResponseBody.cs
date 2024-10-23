// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class GetUserSsoSettingsResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>69FC3E5E-D3D9-434B-90CA-BBA8E0551A47</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The configurations of user-based SSO.</para>
        /// </summary>
        [NameInMap("UserSsoSettings")]
        [Validation(Required=false)]
        public GetUserSsoSettingsResponseBodyUserSsoSettings UserSsoSettings { get; set; }
        public class GetUserSsoSettingsResponseBodyUserSsoSettings : TeaModel {
            /// <summary>
            /// <para>The auxiliary domain name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example.com</para>
            /// </summary>
            [NameInMap("AuxiliaryDomain")]
            [Validation(Required=false)]
            public string AuxiliaryDomain { get; set; }

            /// <summary>
            /// <para>The metadata file, which is Base64-encoded.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PD94bWwgdmVy****</para>
            /// </summary>
            [NameInMap("MetadataDocument")]
            [Validation(Required=false)]
            public string MetadataDocument { get; set; }

            /// <summary>
            /// <para>Indicates whether user-based SSO is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("SsoEnabled")]
            [Validation(Required=false)]
            public bool? SsoEnabled { get; set; }

        }

    }

}
