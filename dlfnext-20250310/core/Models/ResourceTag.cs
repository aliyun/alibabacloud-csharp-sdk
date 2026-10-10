// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DlfNext20250310.Models
{
    public class ResourceTag : TeaModel {
        /// <summary>
        /// <para>The tag key, up to 128 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>team</para>
        /// </summary>
        [NameInMap("key")]
        [Validation(Required=false)]
        public string Key { get; set; }

        /// <summary>
        /// <para>The tag value, up to 256 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>recommendation</para>
        /// </summary>
        [NameInMap("value")]
        [Validation(Required=false)]
        public string Value { get; set; }

    }

}
