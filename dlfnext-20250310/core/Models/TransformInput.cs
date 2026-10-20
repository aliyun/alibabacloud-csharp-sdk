// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DlfNext20250310.Models
{
    public class TransformInput : TeaModel {
        /// <summary>
        /// <para>The input content.</para>
        /// 
        /// <b>Example:</b>
        /// <para>INPUT</para>
        /// </summary>
        [NameInMap("input")]
        [Validation(Required=false)]
        public object Input { get; set; }

        /// <summary>
        /// <para>The input type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>LITERAL</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
