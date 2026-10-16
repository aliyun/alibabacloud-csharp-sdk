// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentIdentity20250901.Models
{
    public class RunUserPoolSyncJobRequest : TeaModel {
        /// <summary>
        /// <para>The identity provider type. Currently, only DingTalk is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DingTalk</para>
        /// </summary>
        [NameInMap("IdentityProviderType")]
        [Validation(Required=false)]
        public string IdentityProviderType { get; set; }

        /// <summary>
        /// <para>The maximum number of users to synchronize in a single task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("MaxSyncUsers")]
        [Validation(Required=false)]
        public string MaxSyncUsers { get; set; }

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
