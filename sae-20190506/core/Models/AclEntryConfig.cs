// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class AclEntryConfig : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.2.3.4/32</para>
        /// </summary>
        [NameInMap("entry")]
        [Validation(Required=false)]
        public string Entry { get; set; }

    }

}
