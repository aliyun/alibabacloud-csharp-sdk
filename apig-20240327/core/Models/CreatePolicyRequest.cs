// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class CreatePolicyRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Timeout</para>
        /// </summary>
        [NameInMap("className")]
        [Validation(Required=false)]
        public string ClassName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;unitNum&quot;:1,&quot;timeUnit&quot;:&quot;s&quot;,&quot;enable&quot;:true}</para>
        /// </summary>
        [NameInMap("config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-policy</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
