// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class SetWebAuthnConfigurationRequest : TeaModel {
        /// <summary>
        /// <para>List of AAGUIDs and their names.</para>
        /// </summary>
        [NameInMap("Aaguids")]
        [Validation(Required=false)]
        public List<SetWebAuthnConfigurationRequestAaguids> Aaguids { get; set; }
        public class SetWebAuthnConfigurationRequestAaguids : TeaModel {
            /// <summary>
            /// <para>AAGUID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>adce0002-35bc-c60a-648b-0b25f1f05503</para>
            /// </summary>
            [NameInMap("Aaguid")]
            [Validation(Required=false)]
            public string Aaguid { get; set; }

            /// <summary>
            /// <para>AAGUID name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Touch ID</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// <para>Enable AAGUID verification.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableAaguidVerification")]
        [Validation(Required=false)]
        public bool? EnableAaguidVerification { get; set; }

        /// <summary>
        /// <para>Enable WebAuthn authenticator MDS verification.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableMetadataServiceVerification")]
        [Validation(Required=false)]
        public bool? EnableMetadataServiceVerification { get; set; }

        /// <summary>
        /// <para>Allow user self-registration of WebAuthn authenticators.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableUserSelfRegistration")]
        [Validation(Required=false)]
        public bool? EnableUserSelfRegistration { get; set; }

        /// <summary>
        /// <para>Instance ID.</para>
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
