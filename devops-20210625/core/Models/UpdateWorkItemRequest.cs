// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class UpdateWorkItemRequest : TeaModel {
        /// <summary>
        /// 更新字段的类型，标题：subject/自定义字段：customField/状态：status/描述：document/基本字段：basic(包括负责人、迭代、参与人等)
        /// </summary>
        [NameInMap("fieldType")]
        [Validation(Required=false)]
        public string FieldType { get; set; }

        /// <summary>
        /// 工作项唯一标识id
        /// </summary>
        [NameInMap("identifier")]
        [Validation(Required=false)]
        public string Identifier { get; set; }

        /// <summary>
        /// 更新的字段名
        /// </summary>
        [NameInMap("propertyKey")]
        [Validation(Required=false)]
        public string PropertyKey { get; set; }

        /// <summary>
        /// 更新后的值
        /// </summary>
        [NameInMap("propertyValue")]
        [Validation(Required=false)]
        public string PropertyValue { get; set; }

    }

}
