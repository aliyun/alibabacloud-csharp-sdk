// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OnsMqtt20200420.Models
{
    public class UpdateCustomAuthIdentityRequest : TeaModel {
        /// <summary>
        /// The client ID if you set IdentityType to CLIENT.
        /// </summary>
        [NameInMap("ClientId")]
        [Validation(Required=false)]
        public string ClientId { get; set; }

        /// <summary>
        /// The identity type. Valid values:
        /// 
        /// *   USER
        /// *   CLIENT
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("IdentityType")]
        [Validation(Required=false)]
        public string IdentityType { get; set; }

        /// <summary>
        /// The ID of the ApsaraMQ for MQTT instance.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The AccessKey secret.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Secret")]
        [Validation(Required=false)]
        public string Secret { get; set; }

        /// <summary>
        /// The signature verification mode. ORIGIN: compares the password and AccessKey secret. SIGNED: uses the HMAC_SHA1 algorithm to sign the client ID to obtain a password and then compares the password.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("SignMode")]
        [Validation(Required=false)]
        public string SignMode { get; set; }

        /// <summary>
        /// The username.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Username")]
        [Validation(Required=false)]
        public string Username { get; set; }

    }

}
