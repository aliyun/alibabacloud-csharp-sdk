// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class AkSkIdentityConfig : TeaModel {
        /// <summary>
        /// <para>Access Key</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxx</para>
        /// </summary>
        [NameInMap("ak")]
        [Validation(Required=false)]
        public string Ak { get; set; }

        /// <summary>
        /// <para>Generation mode</para>
        /// 
        /// <b>Example:</b>
        /// <para>System</para>
        /// </summary>
        [NameInMap("generateMode")]
        [Validation(Required=false)]
        public string GenerateMode { get; set; }

        /// <summary>
        /// <para>Secret Key</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxx</para>
        /// </summary>
        [NameInMap("sk")]
        [Validation(Required=false)]
        public string Sk { get; set; }

        /// <summary>
        /// <para>Identity authentication type</para>
        /// 
        /// <b>Example:</b>
        /// <para>Jwt</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
