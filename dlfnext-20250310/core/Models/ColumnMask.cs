// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DlfNext20250310.Models
{
    public class ColumnMask : TeaModel {
        /// <summary>
        /// <para>The column masking expression.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CONCAT(\&quot;<em><b>-</b>-</em>***\&quot;)</para>
        /// </summary>
        [NameInMap("expression")]
        [Validation(Required=false)]
        public string Expression { get; set; }

        /// <summary>
        /// <para>The column masking transform method.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;name&quot;:&quot;CONCAT&quot;,&quot;inputs&quot;:[&quot;***-&quot;,{&quot;index&quot;:1,&quot;name&quot;:&quot;phone&quot;,&quot;type&quot;:&quot;STRING&quot;}]}</para>
        /// </summary>
        [NameInMap("transform")]
        [Validation(Required=false)]
        public string Transform { get; set; }

    }

}
