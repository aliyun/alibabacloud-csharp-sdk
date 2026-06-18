// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Bailian20231229.Models
{
    public class CreateMemoryRequest : TeaModel {
        /// <summary>
        /// <para>The description of the long-term memory. The description must be 1 to 50 characters in length and can contain letters, digits, and characters in the Unicode letter category (including Chinese characters). The description can also contain colons (:), underscores (_), periods (.), and hyphens (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para>我的大模型应用$APP_ID关于A用户的长期记忆体</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

    }

}
