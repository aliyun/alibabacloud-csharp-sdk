// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class CredentialConfigItem : TeaModel {
        /// <summary>
        /// <para>The identity key of the credential configuration item.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Key")]
        [Validation(Required=false)]
        public string Key { get; set; }

        /// <summary>
        /// <para>The list of associated roles.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("Roles")]
        [Validation(Required=false)]
        public List<CredentialRole> Roles { get; set; }

        /// <summary>
        /// <para>The credential type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RoleChain</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
