// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_cnp20230828.Models
{
    public class ValidateResourceShrinkRequest : TeaModel {
        /// <summary>
        /// <para>Resource ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>ehpc-sh-ouypm5aucy</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>User Authorization Parameters</para>
        /// </summary>
        [NameInMap("UserAccessParam")]
        [Validation(Required=false)]
        public string UserAccessParamShrink { get; set; }

    }

}
