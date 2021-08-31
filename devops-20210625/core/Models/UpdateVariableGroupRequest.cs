// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class UpdateVariableGroupRequest : TeaModel {
        /// <summary>
        /// 变量组名称
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// 变量组描述
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// 变量信息json字符串 isEncrypted 是否加密 name 变量名称 value 变量值
        /// </summary>
        [NameInMap("variables")]
        [Validation(Required=false)]
        public string Variables { get; set; }

    }

}
