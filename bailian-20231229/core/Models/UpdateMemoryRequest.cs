// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Bailian20231229.Models
{
    public class UpdateMemoryRequest : TeaModel {
        /// <summary>
        /// <para>The new description. The description must be 1 to 50 characters in length and can contain characters in the letter category of Unicode, which includes letters, Chinese characters, and digits. The description can also contain half-width colons (:), underscores (_), periods (.), or hyphens (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para>我的大模型应用$APP_ID关于B用户的长期记忆体</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

    }

}
