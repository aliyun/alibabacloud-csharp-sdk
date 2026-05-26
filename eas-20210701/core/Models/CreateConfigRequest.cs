// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class CreateConfigRequest : TeaModel {
        /// <summary>
        /// <para>配置值</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;model&quot;: &quot;gpt-4&quot;}</para>
        /// </summary>
        [NameInMap("Value")]
        [Validation(Required=false)]
        public string Value { get; set; }

    }

}
