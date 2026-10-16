// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentIdentity20250901.Models
{
    public class CreateRoleRequest : TeaModel {
        /// <summary>
        /// <para>The description of the role. The description must be 0 to 128 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Data analyst role</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The name of the role. The name must be unique within the user pool and must be 3 to 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Analyst</para>
        /// </summary>
        [NameInMap("RoleName")]
        [Validation(Required=false)]
        public string RoleName { get; set; }

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
