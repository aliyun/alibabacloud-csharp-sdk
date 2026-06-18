// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Bailian20231229.Models
{
    public class CreateMemoryNodeRequest : TeaModel {
        /// <summary>
        /// <para>The content of the memory node. The content must be 1 to 200 characters in length and can contain letters, digits, underscores (_), hyphens (-), periods (.), and colons (:).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>用户喜欢吃西红柿炒鸡蛋</para>
        /// </summary>
        [NameInMap("content")]
        [Validation(Required=false)]
        public string Content { get; set; }

    }

}
