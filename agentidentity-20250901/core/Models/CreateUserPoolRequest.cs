// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentIdentity20250901.Models
{
    public class CreateUserPoolRequest : TeaModel {
        /// <summary>
        /// <para>The description of the user pool. The description must be 0 to 128 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Sample user pool</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The name of the user pool. The name must be unique within the same Alibaba Cloud account and must be 3 to 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-agent-userpool</para>
        /// </summary>
        [NameInMap("UserPoolName")]
        [Validation(Required=false)]
        public string UserPoolName { get; set; }

    }

}
