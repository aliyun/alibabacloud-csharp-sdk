// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class CredentialConfigItem : TeaModel {
        /// <summary>
        /// <para>The configuration key.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Key")]
        [Validation(Required=false)]
        public string Key { get; set; }

        /// <summary>
        /// <para>The role configuration.</para>
        /// </summary>
        [NameInMap("Roles")]
        [Validation(Required=false)]
        public List<CredentialRole> Roles { get; set; }

        /// <summary>
        /// <para>The credential configuration type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Role</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
