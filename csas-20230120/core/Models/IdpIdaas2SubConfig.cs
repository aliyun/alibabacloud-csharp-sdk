// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class IdpIdaas2SubConfig : TeaModel {
        /// <summary>
        /// <para>The unique identifier of the application within the IDaaS instance.</para>
        /// </summary>
        [NameInMap("ApplicationId")]
        [Validation(Required=false)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// <para>The client ID of the application registered with the identity provider.</para>
        /// </summary>
        [NameInMap("ClientId")]
        [Validation(Required=false)]
        public string ClientId { get; set; }

        /// <summary>
        /// <para>The client secret used to authenticate the application with the identity provider.</para>
        /// </summary>
        [NameInMap("ClientSecret")]
        [Validation(Required=false)]
        public string ClientSecret { get; set; }

        /// <summary>
        /// <para>The AES encryption key for securing event data.</para>
        /// </summary>
        [NameInMap("EventAesKey")]
        [Validation(Required=false)]
        public string EventAesKey { get; set; }

        /// <summary>
        /// <para>A label that identifies the event subscription.</para>
        /// </summary>
        [NameInMap("EventLabel")]
        [Validation(Required=false)]
        public string EventLabel { get; set; }

        /// <summary>
        /// <para>The unique identifier of the IDaaS instance.</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The URL of the endpoint providing the public key for token signature verification.</para>
        /// </summary>
        [NameInMap("PublicKeyEndpoint")]
        [Validation(Required=false)]
        public string PublicKeyEndpoint { get; set; }

        /// <summary>
        /// <para>The deployment region of the IDaaS instance.</para>
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// <para>The SAML metadata in XML format. It specifies the identity provider\&quot;s configuration, including endpoints and certificates.</para>
        /// </summary>
        [NameInMap("SamlMetadata")]
        [Validation(Required=false)]
        public string SamlMetadata { get; set; }

    }

}
