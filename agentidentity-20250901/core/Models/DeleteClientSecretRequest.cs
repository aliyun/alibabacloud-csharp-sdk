// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentIdentity20250901.Models
{
    public class DeleteClientSecretRequest : TeaModel {
        /// <summary>
        /// <para>The client ID. Specify either this parameter or ClientName. If both are specified, ClientId takes precedence.</para>
        /// 
        /// <b>Example:</b>
        /// <para>client-xxxxxxxxxxxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("ClientId")]
        [Validation(Required=false)]
        public string ClientId { get; set; }

        /// <summary>
        /// <para>The client name. Specify either this parameter or ClientId.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-web-app</para>
        /// </summary>
        [NameInMap("ClientName")]
        [Validation(Required=false)]
        public string ClientName { get; set; }

        /// <summary>
        /// <para>The key ID of the client secret to delete.</para>
        /// 
        /// <b>Example:</b>
        /// <para>secret-xxxxxxxxxxxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("ClientSecretId")]
        [Validation(Required=false)]
        public string ClientSecretId { get; set; }

        /// <summary>
        /// <para>The user pool name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-agent-userpool</para>
        /// </summary>
        [NameInMap("UserPoolName")]
        [Validation(Required=false)]
        public string UserPoolName { get; set; }

    }

}
