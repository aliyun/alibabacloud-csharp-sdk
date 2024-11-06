// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class ModifyDcdnWafGroupRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the custom WAF rule group.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30000110</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>The name of the custom WAF rule group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The incremental modifications of the rules in the custom WAF rule group. The value is a JSON string.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;All\&quot;:false,\&quot;Op\&quot;:\&quot;del\&quot;,\&quot;List\&quot;:\&quot;900109\&quot;}</para>
        /// </summary>
        [NameInMap("Rules")]
        [Validation(Required=false)]
        public string Rules { get; set; }

    }

}
