// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentIdentity20250901.Models
{
    public class CreateClientSecretRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the client. If you specify ClientId, you do not need to specify UserPoolName. Specify either ClientName or ClientId. If both are specified, ClientId takes precedence.</para>
        /// 
        /// <b>Example:</b>
        /// <para>client_xxxxxxxxxxxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("ClientId")]
        [Validation(Required=false)]
        public string ClientId { get; set; }

        /// <summary>
        /// <para>The name of the client. Specify either ClientName or ClientId.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-web-app</para>
        /// </summary>
        [NameInMap("ClientName")]
        [Validation(Required=false)]
        public string ClientName { get; set; }

        /// <summary>
        /// <para>The name of the user pool.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-agent-userpool</para>
        /// </summary>
        [NameInMap("UserPoolName")]
        [Validation(Required=false)]
        public string UserPoolName { get; set; }

    }

}
