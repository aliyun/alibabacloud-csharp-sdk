// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class UpdateSessionRequest : TeaModel {
        /// <summary>
        /// <para>The session update configuration.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public UpdateSessionInput Body { get; set; }

        /// <summary>
        /// <para>The function alias or version associated with the session to be updated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aliasName1</para>
        /// </summary>
        [NameInMap("qualifier")]
        [Validation(Required=false)]
        public string Qualifier { get; set; }

    }

}
