// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class SetWebAuthnConfigurationRequest : TeaModel {
        /// <summary>
        /// <para>The list of AAGUIDs and their names.</para>
        /// </summary>
        [NameInMap("Aaguids")]
        [Validation(Required=false)]
        public List<SetWebAuthnConfigurationRequestAaguids> Aaguids { get; set; }
        public class SetWebAuthnConfigurationRequestAaguids : TeaModel {
            /// <summary>
            /// <para>AAGUID</para>
            /// 
            /// <b>Example:</b>
            /// <para>adce0002-35bc-c60a-648b-0b25f1f05503</para>
            /// </summary>
            [NameInMap("Aaguid")]
            [Validation(Required=false)]
            public string Aaguid { get; set; }

            /// <summary>
            /// <para>The AAGUID name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Touch ID</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether AAGUID verification is enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableAaguidVerification")]
        [Validation(Required=false)]
        public bool? EnableAaguidVerification { get; set; }

        /// <summary>
        /// <para>Specifies whether MDS verification is enabled for WebAuthn authenticators.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableMetadataServiceVerification")]
        [Validation(Required=false)]
        public bool? EnableMetadataServiceVerification { get; set; }

        /// <summary>
        /// <para>Specifies whether users are allowed to self-register WebAuthn authenticators.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableUserSelfRegistration")]
        [Validation(Required=false)]
        public bool? EnableUserSelfRegistration { get; set; }

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

    }

}
